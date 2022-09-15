namespace MediaFileManager
{
    public class Response
    {
        public int TotalFiles { get; set; }
        public int FilesCopied { get; set; }

        public int FilesNotCopied { get; set; }
        public List<MediaFile> ListOfFilesCopied { get; set; }

        public List<MediaFile> ListOfFilesNotCopied { get; set; }
        public Dictionary<string, List<MediaFile>> ListOfDuplicatedFiles { get; set; }

        public TimeSpan OperationDuration { get; set; }

        public List<string> ExceptionList { get; set; }

        public List<string> CorruptedFilesList { get; set; }
        public List<MediaFile> ListOfNewFiles { get; set; }

    }
}
