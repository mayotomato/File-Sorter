using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace File_Sorter_Beta
{
    internal class Folder
    {
        private string name;
        //public string path;
        private bool isSorting;
        private List<Extension> extensions;
        private List<string> extensionFormats;
        private static List<Folder> folders = new List<Folder>();

        //Constructors
        public Folder(string aName)
        {
            this.Name = aName;
            this.IsSorting = false;
            this.Extensions = new List<Extension>();

            folders.Add(this);
        }

        public Folder(string aName, List<Extension> aExtensions)
        {
            this.Name = aName;
            this.IsSorting = false;
            this.Extensions = aExtensions;


            folders.Add(this);
        }

        public Folder(string aName, List<Extension> aExtensions, bool Sorting)
        {
            this.Name = aName;
            this.IsSorting = Sorting;
            this.Extensions = aExtensions;


            folders.Add(this);
        }

        public Folder(string aName, List<Extension> aExtensions, bool Sorting, string[] aExtensionFormats)
        {
            this.Name = aName;
            this.IsSorting = Sorting;
            this.Extensions = aExtensions;
            this.extensionFormats = aExtensionFormats.ToList();


            folders.Add(this);
        }

        //Getters and setters
        public string Name
        {
            get { return name; }
            set 
            {
                if (IsValidName(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot contain special characters");
                }
            }
        }

        public bool IsSorting
        {
            get => isSorting;
            set
            {
                this.isSorting = value;
            }
        }

        public List<Extension> Extensions
        {
            get => extensions;
            set 
            {
                this.extensions = value;
            }
        }

        public static List<Folder> Folders
        {
            get { return folders; }
            set => folders = value;
        }

        public List<string> ExtensionFormats 
        {
            get 
            {
                return this.extensionFormats.Where(extension => this.isSorting).ToList();
            }
        }


        //Functions

        private bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"[a-zA-Z0-9\s]+$");
        }

        public static Folder[] getFolders()
        {
            return folders.ToArray();
        }

        public Extension[] getExtensions()
        {
            return this.extensions.ToArray();
        }

        //Default folders extensions
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
