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

        public static Dictionary<string, bool> getDefaultFolders() 
        {
            Dictionary<string, bool> defaultFolders = new Dictionary<string, bool>();
            defaultFolders.Add("Compressed", true);
            defaultFolders.Add("Database", false);
            defaultFolders.Add("Documents", true);
            defaultFolders.Add("Ebook", false);
            defaultFolders.Add("Font", false);
            defaultFolders.Add("Images", true);
            defaultFolders.Add("Music", true);
            defaultFolders.Add("Programs", true);
            defaultFolders.Add("Video", true);
            defaultFolders.Add("Web", false);

            return defaultFolders;
        }

    }
}
