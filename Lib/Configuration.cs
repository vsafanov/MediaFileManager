namespace MediaFileManager
{
    public class Configuration
    {
        private long minFileSizeToCopy;
        public string SourceFolder { get; set; } //= @"C:\Users\vsafanov\Pictures\SourcePhotos\";
        public string TargetFolder { get; set; } //= @"C:\temp\TargetPhotos";

        public string MediaFileExtensions { get; set; }
        //public string VideoFileExtensions { get; set; }

        public long MinFileSizeToCopy
        {
            get => minFileSizeToCopy;
            set => minFileSizeToCopy = value * 1024;
        }

        public CreationTemplate CreationTemplate { get; set; }

        public bool OverwriteFiles { get; set; }

    }
}