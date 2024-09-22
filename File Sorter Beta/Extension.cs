using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace File_Sorter_Beta
{
    internal class Extension
    {
        //Backing fields
        private string format;
        private bool isSorting;
        private static List<Extension> extensions = new List<Extension>();
        //private string isSortedInto;

        //Constructors
        public Extension(string aFormat)
        {
            this.format = aFormat;
            this.isSorting = false;

            extensions.Add(this);
        }

        //public Extension(string aFormat, string folderName)
        //{
        //    this.format = aFormat;
        //    this.isSorting = false;
        //    this.isSortedInto = folderName;

        //    extensions.Add(this);
        //}

        public Extension(string aFormat, bool Sorting)
        {
            this.format = aFormat;
            this.isSorting = Sorting;

            extensions.Add(this);
        }

        //Getters and setters
        public string Format
        {
            get => format;
            set
            {
                if (IsValidFormat(value))
                {
                    format = value;
                }
                else { throw new ArgumentException("Format must be in the correct format e.g: .mp3, .png, .pdf"); }
            }
        }

        public bool IsSorting
        {
            get => isSorting;
            set => isSorting = value;
        }

        public static List<Extension> Extensions
        {
            get => extensions;
            set => extensions = value;
        }


        //Functions

        private bool IsValidFormat(string format)
        {
            return Regex.IsMatch(format, @"\.[a-zA-z0-9]{2,4}");
        }

        public static Extension[] getExtensions()
        {
            return extensions.ToArray();
        }

        public static Dictionary<string, string[]> getDefaultExtensions()
        {
            Dictionary<string, string[]> defaultExtensions = new Dictionary<string, string[]>();
            defaultExtensions.Add("Compressed", 
                new string[]
                {
                    ".zip", ".rar", ".tar", ".gz", ".bz2", ".xz",
                    ".7z", ".zipx", ".dmg", ".cab", ".lz"
                });

            defaultExtensions.Add("Database", 
                new string[]
                {
                    ".sql", ".db", ".sqlite", ".mdb", ".accdb", ".mdf", ".ldf"
                });

            defaultExtensions.Add("Documents",
                new string[]
                {
                    ".doc", ".docx", ".pdf", ".txt", ".rtf", ".odt", ".xls",
                    ".xlsx", ".ppt", ".pptx", ".csv", ".json"
                });

            defaultExtensions.Add("Ebook", 
                new string[] 
                {
                    ".epub", ".mobi", ".azw"
                });

            defaultExtensions.Add("Font",
                new string[]
                {
                    ".ttf", ".otf", ".woff", ".woff2", ".eot", ".fon"
                });

            defaultExtensions.Add("Images",
                new string[]
                {
                    ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".webp", ".svg", ".ico", ".heif"
                });

            defaultExtensions.Add("Music",
                new string[]
                {
                    ".mp3", ".wav", ".flac", ".aac", ".ogg", ".wma", ".m4a", ".alac", ".aiff", ".dsd"
                });

            defaultExtensions.Add("Programs",
                new string[]
                {
                    ".exe", ".dll", ".bat", ".sh", ".bin", ".app", ".jar", ".msi", ".iso", ".pkg"
                });

            defaultExtensions.Add("Video",
                new string[]
                {
                    ".mp4", ".avi", ".mkv", ".mov", ".wmv", ".flv", ".webm", ".mpeg", ".mpg", ".ts"
                });

            defaultExtensions.Add("Web",
                new string[]
                {
                    ".html", ".htm", ".css", ".js", ".xml"
                });

            return defaultExtensions;
        }

    }
}
