

namespace MediaFileManager
{
    public  class TargetFolderStructure
    {


        public CreationTemplate? GetExistingTemplate(string path)
        {

            var yearFolder = Directory.GetDirectories(path).FirstOrDefault();
            if (yearFolder == null)
            {
                return null;
            }

            if (!IsDateFolder(yearFolder,"yyyy"))
            {
                return null;
            }
            var yearSubFolder = Directory.GetDirectories(yearFolder).FirstOrDefault();

            //if subfolder is month
            if (IsDateFolder(yearSubFolder, "MMMM"))
            {
                //get subfolders with Mix Media or Pics and Videos
                if (IsPicVideoFolder(yearSubFolder))
                {
                    return CreationTemplate.YearMonthPicturesAndVideos;
                }
                //no subfolders just mixed media files
                return CreationTemplate.YearMonthMixedMedia;
            }

            //subfolder is Pictures and videos
            if (IsPicVideoFolder(yearSubFolder))
            {
                return CreationTemplate.YearPicturesAndVideos;
            }
            //no subfolders just mixed media files
            return CreationTemplate.YearMixedMedia;
        }

        private bool IsDateFolder(string folder, string format)
        {
            try
            {
                DateTime.ParseExact(folder.Substring(folder.LastIndexOf("\\", StringComparison.OrdinalIgnoreCase) + 1), format, System.Globalization.CultureInfo.InvariantCulture);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool IsPicVideoFolder(string folder)
        {
            try
            {

                var subFolder = Directory.GetDirectories(folder).FirstOrDefault();
                var subFolderName = subFolder?.Substring(subFolder.LastIndexOf("\\", StringComparison.OrdinalIgnoreCase) + 1).ToLower();
                return subFolderName == "pictures" || subFolderName == "video";
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
