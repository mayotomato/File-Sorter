using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace File_Sorter_Beta
{
    internal class Preset
    {
        // Backing fields (private to avoid JSON duplication)
        private string name;
        private List<Folder> folders;

        // Static list of all presets
        private static List<Preset> presets = new List<Preset>();

        // Properties
        public string Name
        {
            get => name;
            set => name = value;
        }

        public List<Folder> Folders
        {
            get => folders;
            set => folders = value ?? new List<Folder>();
        }

        public static List<Preset> Presets => presets;

        // Parameterless constructor for JSON.NET
        public Preset() { }

        public Preset(string aName)
        {
            Name = aName;
            Folders = new List<Folder>();
            presets.Add(this);
        }

        public Preset(string aName, List<Folder> aFolders)
        {
            Name = aName;
            Folders = aFolders ?? new List<Folder>();
            presets.Add(this);
        }

        public override string ToString() => Name;

        // Default folder set
        public static Dictionary<string, bool> GetDefaultFolders()
        {
            return new Dictionary<string, bool>
            {
                { "Compressed", true },
                { "Database", false },
                { "Documents", true },
                { "Ebook", false },
                { "Font", false },
                { "Images", true },
                { "Music", true },
                { "Programs", true },
                { "Video", true },
                { "Web", false }
            };
        }

        // Save to JSON
        public static void SavePresets()
        {
            string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "userPresets.json");
            string json = JsonConvert.SerializeObject(presets, Formatting.Indented);
            File.WriteAllText(jsonPath, json);
        }

        // Load from JSON or defaults
        public static void LoadOrCreatePresets()
        {
            string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "userPresets.json");

            if (File.Exists(jsonPath))
            {
                try
                {
                    string json = File.ReadAllText(jsonPath);
                    var loaded = JsonConvert.DeserializeObject<List<Preset>>(json);

                    if (loaded != null && loaded.Count > 0)
                    {
                        presets.Clear();
                        presets.AddRange(loaded);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to load presets: {ex.Message}");
                }
            }

            // Fallback to defaults
            presets.Clear();
            var defaultFolders = GetDefaultFolders();
            var defaultPreset = new Preset("Default");

            foreach (var kvp in defaultFolders)
            {
                defaultPreset.Folders.Add(new Folder(kvp.Key, new List<Extension>(), kvp.Value));
            }

            SavePresets();
        }
    }
}