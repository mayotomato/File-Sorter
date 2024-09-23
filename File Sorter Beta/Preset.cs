using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Sorter_Beta
{
    internal class Preset
    {
        //Backing fields
        private string name;
        private List<Folder> folders;
        private static List<Preset> presets;

        //Getters and setters
        private string Name
        {
            get => name;
            set => name = value;
        }

        private List<Folder> Folders
        {
            get => folders;
            set => folders = value;
        }

        private static List<Preset> Presets
        {
            get => presets;
            set => presets = value;
        }

        //Constructors
        Preset(string aName, List<Folder> aFolders,)
        {
            this.
        }
    }
}
