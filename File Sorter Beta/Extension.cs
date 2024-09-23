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
            this.Format = aFormat;
            this.IsSorting = false;

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
            this.Format = aFormat;
            this.IsSorting = Sorting;

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

    }
}
