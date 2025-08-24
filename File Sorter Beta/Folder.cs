using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace File_Sorter_Beta
{
    internal class Folder
    {
        private string name;
        private bool isSorting;
        private List<Extension> extensions;
        private List<string> extensionFormats;

        private static List<Folder> folders = new List<Folder>();

        // Properties
        public string Name
        {
            get => name;
            set
            {
                if (IsValidName(value))
                    name = value;
                else
                    throw new ArgumentException("Name cannot contain special characters");
            }
        }

        public bool IsSorting
        {
            get => isSorting;
            set => isSorting = value;
        }

        public List<Extension> Extensions
        {
            get => extensions;
            set => extensions = value ?? new List<Extension>();
        }

        public static List<Folder> Folders
        {
            get => folders;
            set => folders = value ?? new List<Folder>();
        }

        public List<string> ExtensionFormats
        {
            get => (extensionFormats ?? new List<string>())
                   .Where(_ => isSorting)
                   .ToList();
            set => extensionFormats = value ?? new List<string>();
        }

        // Parameterless constructor for JSON.NET
        public Folder() { }

        public Folder(string aName)
        {
            Name = aName;
            IsSorting = false;
            Extensions = new List<Extension>();
            folders.Add(this);
        }

        public Folder(string aName, List<Extension> aExtensions)
        {
            Name = aName;
            IsSorting = false;
            Extensions = aExtensions ?? new List<Extension>();
            folders.Add(this);
        }

        public Folder(string aName, List<Extension> aExtensions, bool sorting)
        {
            Name = aName;
            IsSorting = sorting;
            Extensions = aExtensions ?? new List<Extension>();
            folders.Add(this);
        }

        public Folder(string aName, List<Extension> aExtensions, bool sorting, string[] aExtensionFormats)
        {
            Name = aName;
            IsSorting = sorting;
            Extensions = aExtensions ?? new List<Extension>();
            extensionFormats = aExtensionFormats?.ToList() ?? new List<string>();
            folders.Add(this);
        }

        public override string ToString() => Name;

        private bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z0-9\s]+$");
        }

        public static Folder[] GetFolders() => folders.ToArray();

        public Extension[] GetExtensions() => extensions.ToArray();

        public static Dictionary<string, string[]> GetDefaultExtensions()
        {
            string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "defaultExtensions.json");

            if (File.Exists(jsonPath))
            {
                try
                {
                    string json = File.ReadAllText(jsonPath);
                    var dict = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(json);
                    return dict ?? new Dictionary<string, string[]>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to load default extensions: {ex.Message}");
                }
            }

            // Fallback hard‑coded defaults
            return new Dictionary<string, string[]>
            {
                { "Images", new[] { ".jpg", ".jpeg", ".png", ".gif" } },
                { "Documents", new[] { ".pdf", ".docx", ".txt" } }
            };
        }
    }
}