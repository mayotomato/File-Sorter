using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace File_Sorter_Beta
{
    internal class Preset
    {
        //Backing fields
        public string name;
        public List<Folder> folders;
        public static List<Preset> presets = new List<Preset>();

        //Getters and setters
        public string Name
        {
            get => name;
            set => name = value;
        }

        public List<Folder> Folders
        {
            get => folders;
            set => folders = value;
        }

        public static List<Preset> Presets
        {
            get => presets;
        }

        //Constructors
        public Preset(string aName)
        {
            this.Name = aName;
            this.Folders = new List<Folder>();

            presets.Add(this);
        }

        public Preset(string aName, List<Folder> aFolders)
        {
            this.Name = aName;
            this.Folders = aFolders;

            presets.Add(this);
        }

        //Functions
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

        public override string ToString()
        {
            return Name;
        }
    }
}
