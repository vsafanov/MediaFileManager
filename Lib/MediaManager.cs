using MetadataExtractor;
using Serilog;
using System.Globalization;

// using Microsoft.Extensions.Logging;
using Directory = System.IO.Directory;

namespace MediaFileManager
{
    public class MediaManager
    {
        // private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);
        private readonly ILogger _logger;

        private List<MediaFile> mediaFiles = new();
        private readonly List<string> exceptions = new();
        private readonly List<string> corruptedFiles = new();
        private readonly DateTime startTime;
        private readonly Configuration settings;
        private readonly Progress frmProgress = new();

        public MediaManager(ILogger logger, Configuration settings)
        {
            _logger = logger;
            _logger.Information("MediaManager started");
            startTime = DateTime.Now;
            this.settings = settings;
            GetAllMediaFiles();
        }

        private void AddVideoFileToList(string file)
        {
            FileInfo info = new FileInfo(file);

            mediaFiles.Add(new MediaFile
            {
                FilePath = file,
                TimeStamp = info.LastWriteTime,
                FileSize = info.Length,
                FileType = MediaFileType.Video,
                FileName = info.Name
            });
        }

        private void AddImageFileToList(string file)
        {
            IReadOnlyList<MetadataExtractor.Directory> directories;
            try
            {
                directories = ImageMetadataReader.ReadMetadata(file);
            }
            catch (Exception ex)
            {
                _logger.Warning(ex.Message + " : " + file);
                corruptedFiles.Add(file);
                Print("File is corrupted or not an image:" + file, ConsoleColor.Red);
                return;
            }

            try
            {
                var dateTaken = directories.SelectMany(dir => dir.Tags).FirstOrDefault(t => t.Name == "Date/Time")?.Description;
                var dateModified = directories.SelectMany(dir => dir.Tags).FirstOrDefault(t => t.Name == "File Modified Date")?.Description;
                var fileSize = directories.SelectMany(dir => dir.Tags).FirstOrDefault(t => t.Name == "File Size")?.Description;
                var fileName = directories.SelectMany(dir => dir.Tags).FirstOrDefault(t => t.Name == "File Name")?.Description;

                //foreach (var directory in directories)
                //{
                //    foreach (var tag in directory.Tags)
                //    {
                //       //Console.WriteLine($"{directory.Name} - {tag.Name} = {tag.Description}");
                //        if (tag.Name == "Date/Time")
                //        {
                //            //dateTaken = tag.Description;
                //            Console.WriteLine(tag.Name + " = " + tag.Description);
                //        }
                //        if (tag.Name == "File Modified Date")
                //        {
                //            //dateModified = tag.Description;
                //            Console.WriteLine(tag.Name + " = " + tag.Description);
                //        }
                //    }
                //}

                var finalDate = dateTaken;
                var format = "yyyy:MM:dd HH:mm:ss";

                if (string.IsNullOrEmpty(dateTaken) || dateTaken == "0000:00:00 00:00:00")
                {
                    finalDate = dateModified;
                    format = "ddd MMM dd HH:mm:ss zzz yyyy";
                }

                var d = DateTime.ParseExact(finalDate ?? string.Empty, format, CultureInfo.InvariantCulture);
                var size = long.Parse(fileSize?.Replace("bytes", "") ?? "0".Trim());
                if (size < settings.MinFileSizeToCopy)
                {
                    //Print("File " + file + " is less than " + FormatBytes(settings.MinFileSizeToCopy),ConsoleColor.Red);
                    //Log.Info("File " + file + " is less than " + FormatBytes(settings.MinFileSizeToCopy));
                    return;
                }
                mediaFiles.Add(new MediaFile
                {
                    FilePath = file,
                    TimeStamp = d,
                    FileSize = size,
                    FileType = MediaFileType.Image,
                    FileName = fileName
                });
            }
            catch (Exception ex)
            {
                exceptions.Add(ex.Message);

                _logger.Warning(ex.Message + " : " + file);
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void GetAllMediaFiles()
        {
            //combine Pictures and Video extensions
            var filters = settings.MediaFileExtensions.Split(',').Select(t => "." + t.Trim().ToLower());

            var allMediaFiles = Directory.GetFiles(settings.SourceFolder, "*.*", SearchOption.AllDirectories).Where(f => filters.Any(f.ToLower().EndsWith)).ToList();

            Parallel.ForEach(allMediaFiles, new ParallelOptions { MaxDegreeOfParallelism = 8 }, file =>
                {
                    var mimeType = MimeMapping.MimeUtility.GetMimeMapping(file);
                    switch (mimeType.Substring(0, mimeType.IndexOf("/", StringComparison.OrdinalIgnoreCase)))
                    {
                        case "image":
                            AddImageFileToList(file);
                            break;

                        case "video":
                        case "audio":
                        case "model": //video type model/vnd.mts
                        case "application": //video type application/octet-stream
                            AddVideoFileToList(file);
                            break;

                        default:
                            exceptions.Add($"File format [{mimeType}] is not media type:{file}");
                            Print($"File format is [{mimeType}] is not media type:{file}", ConsoleColor.Red);
                            break;
                    }
                }
            );

            //remove all files that less in size than the settings(in bytes)
            mediaFiles = mediaFiles.Where(f => f.FileSize > settings.MinFileSizeToCopy).ToList();
        }

        /// <summary>
        /// Copy files from Source to Target directory
        /// </summary>
        /// <returns>Response object</returns>
        public Response CopyFiles()
        {
            var filesCopied = 0;
            var filesNotCopied = 0;
            var listOfFilesCopied = new List<MediaFile>();
            var listOfFilesNotCopied = new List<MediaFile>();
            frmProgress.Show();
            frmProgress.TotalFiles(mediaFiles.Count);

            foreach (var mediaFile in mediaFiles)
            {
                //update progress bar
                frmProgress.UpdateProgress();

                var folder = CreateFolderPath(mediaFile);

                var destFilePath = folder + mediaFile.FileName;

                if (!CopyFile(mediaFile, destFilePath))
                {
                    filesNotCopied++;
                    listOfFilesNotCopied.Add(mediaFile);
                    continue;
                }

                frmProgress.AddLine(mediaFile.FilePath);
                Application.DoEvents();
                listOfFilesCopied.Add(mediaFile);
                filesCopied++;
            }

            if (filesCopied == 0)
            {
                frmProgress.Close();
            }
            else
            {
                frmProgress.AddLine("Files Copied: " + filesCopied);
                frmProgress.AddLine("Done!");
            }

            var timeEnd = DateTime.Now;

            return new Response
            {
                ExceptionList = exceptions,
                FilesCopied = filesCopied,
                ListOfFilesCopied = listOfFilesCopied,
                ListOfFilesNotCopied = listOfFilesNotCopied,
                OperationDuration = timeEnd.Subtract(startTime),
                TotalFiles = mediaFiles.Count,
                FilesNotCopied = filesNotCopied,
                CorruptedFilesList = corruptedFiles
            };
        }

        /// <summary>
        /// Gets a collection of corrupted files
        /// </summary>
        /// <returns>Response object</returns>
        public Response FindCorruptedFiles()
        {
            return new Response
            {
                CorruptedFilesList = corruptedFiles,
                OperationDuration = DateTime.Now.Subtract(startTime)
            };
        }

        private bool CopyFile(MediaFile mediaFile, string destFilePath)
        {
            var destFileInfo = new FileInfo(destFilePath);
            try
            {
                var date = mediaFile.TimeStamp.ToString("yy-MM-dd");
                var newFileName = destFilePath.Replace(".", $"_{date}.");

                //overwrite file is true logic
                if (settings.OverwriteFiles)
                {
                    //if files identical overwrite it
                    if (destFileInfo.Exists && destFileInfo.Length != mediaFile.FileSize)
                    {
                        destFilePath = newFileName;
                    }
                    File.Copy(mediaFile.FilePath, destFilePath, true);
                    return true;
                }

                //overwrite file is false logic

                if (destFileInfo.Exists)
                {
                    if (destFileInfo.Length == mediaFile.FileSize)
                    {
                        return false;
                    }
                    //if files had been renamed before and already exist with Date format extension, skip copying it
                    if (File.Exists(newFileName))
                    {
                        return false;
                    }

                    //if files have identical names and different size and does not exist, replace the name with "_{Date}"
                    File.Copy(mediaFile.FilePath, newFileName);
                    return true;
                }
                File.Copy(mediaFile.FilePath, destFilePath);
                return true;
            }
            catch (Exception ex)
            {
                exceptions.Add(ex.Message);
                return false;
            }
        }

        private string CreateFolderPath(MediaFile mediaFile)
        {
            //create year directory
            var yearFolder = $@"{settings.TargetFolder}\{mediaFile.TimeStamp.Year}";
            CreateDirectory(yearFolder);

            switch (settings.CreationTemplate)
            {
                case CreationTemplate.YearMixedMedia:
                    return $@"{yearFolder}\";

                case CreationTemplate.YearMonthMixedMedia:
                    //create month directory
                    var f1 = $@"{yearFolder}\{mediaFile.TimeStamp:MMMM}\";
                    CreateDirectory(f1);
                    return f1;

                case CreationTemplate.YearPicturesAndVideos:
                    var f2 = $@"{yearFolder}\Pictures\";
                    if (mediaFile.FileType == MediaFileType.Video)
                    {
                        f2 = $@"{yearFolder}\Video\";
                    }
                    CreateDirectory(f2);
                    return f2;

                //case CreationTemplate.YearMonthPicturesAndVideos:
                default:
                    //create month directory
                    var f3 = $@"{yearFolder}\{mediaFile.TimeStamp:MMMM}";
                    CreateDirectory(f3);

                    var f4 = $@"{f3}\Pictures\";
                    if (mediaFile.FileType == MediaFileType.Video)
                    {
                        f4 = $@"{f3}\Video\";
                    }
                    CreateDirectory(f4);

                    return f4;
            }
        }

        /// <summary>
        /// Returns Dictionary with Key/GroupOfDuplicates media files
        /// </summary>
        /// <returns></returns>
        public Response FindDuplicatedFiles()
        {
            var duplicates = mediaFiles.GroupBy(f => new { f.FileName, f.FileSize }).Where(e => e.Count() > 1).ToList();
            //var allDups = duplicates.SelectMany(f => f.ToList());

            var groupList = duplicates.Select(f => new { Key = f.Key, Group = f.ToList() });

            var result = groupList.ToDictionary(item => item.Key.FileName + " (" + FormatBytes(item.Key.FileSize) + ")", item => item.Group);

            return new Response
            {
                ListOfDuplicatedFiles = result,
                OperationDuration = DateTime.Now.Subtract(startTime)
            };
        }

        private void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                if (path != null) Directory.CreateDirectory(path);
            }
        }

        private string FormatBytes(long bytes)
        {
            string[] suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }
            return $"{dblSByte:0.##} {suffix[i]}";
        }

        /// <summary>
        /// Returns Dictionary with Key/GroupOfDuplicates media files
        /// </summary>
        /// <returns></returns>
        public Response FindNewFiles()
        {
            //combine Pictures and Video extensions
            var filters = settings.MediaFileExtensions.Split(',').Select(t => "." + t.Trim().ToLower());

            //var sourceMediaFiles = Directory.GetFiles(settings.SourceFolder, "*.*", SearchOption.AllDirectories).Where(f => filters.Any(f.ToLower().EndsWith)).ToList();
            var targetMediaFiles = Directory.GetFiles(settings.TargetFolder, "*.*", SearchOption.AllDirectories).Where(f => filters.Any(f.ToLower().EndsWith)).Select(f => f.Substring(f.LastIndexOf("\\") + 1)).ToList();
            var newFiles = mediaFiles.Where(f => !targetMediaFiles.Contains(f.FileName) && f.FileSize > settings.MinFileSizeToCopy).ToList();

            return new Response
            {
                ListOfNewFiles = newFiles,
                OperationDuration = DateTime.Now.Subtract(startTime)
            };
        }

        private void Print(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}