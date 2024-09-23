using File_Sorter_Beta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Sorter_Beta
{
    public partial class Sorter : Form
    {



        //Tracking current state of things
        private Folder selectedFolder;
        private Extension selectedExtension;
        private string selectedPath;
        private bool pathContainsAllDirectories;
        private Dictionary<string, string> recentFilesSorted;

        //Calculation or UI Related
        private int selectedFolderIndex;
        private int selectedExtensionIndex;
        private bool allExtensionsSelected;
        private int sortedCount;



        public Sorter()
        {
            InitializeComponent();
            chcklistbox_Extensions.Items.Clear();
            chcklistbox_Folders.Items.Clear();
            addDefaultFoldersAndExtensions();
        }


        //-------------------Folders-------------------
        private void chcklistbox_Folders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chcklistbox_Folders != null)
            {
                selectedFolderIndex = chcklistbox_Folders.SelectedIndex;
                if (selectedFolderIndex != -1) 
                {
                    selectedFolder = Folder.getFolders()[selectedFolderIndex];
                    chckbox_allExtensions.Checked = false;
                    chcklistbox_Extensions_Reload();
                    chcklistbox_Extensions.Enabled = selectedFolder.IsSorting;
                    chckbox_allExtensions_Reload();
                }
                
            }
        }

        private void chcklistbox_Folders_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            selectedFolder.IsSorting = !selectedFolder.IsSorting;
            chcklistbox_Extensions.Enabled = selectedFolder.IsSorting;
        }

        private void chcklistbox_Folders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (selectedFolderIndex != 1)
            {
                chcklistbox_Extensions.Enabled = selectedFolder.IsSorting;
            }
        }

        private void chcklistbox_Folders_Reload()
        {
            chcklistbox_Folders.Items.Clear();
            chcklistbox_Folders.ClearSelected();
            Folder[] folders = Folder.getFolders();
            foreach (Folder folder in folders)
            {
                int index = chcklistbox_Folders.Items.Add(folder.Name);
                chcklistbox_Folders.SetItemChecked(index, folder.IsSorting);
            }
        }

        private void addNewFolder()
        {
            string folder_name = txtbox_Name.Text;
            Folder folder = new Folder(folder_name);
            chcklistbox_Folders_Reload();
        }

        private void removeFolder()
        {
            Folder.Folders.Remove(selectedFolder);
            chcklistbox_Folders_Reload();
        }


        //-------------------Extensions-------------------

        private void chcklistbox_Extensions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            selectedExtensionIndex = e.Index;
            if (selectedExtensionIndex >= 0 && selectedExtensionIndex < chcklistbox_Extensions.Items.Count)
            {
                selectedExtension = selectedFolder.getExtensions()[selectedExtensionIndex];
                bool selectedItemisChecked = !chcklistbox_Extensions.CheckedItems.Contains(chcklistbox_Extensions.Items[selectedExtensionIndex]);
                selectedExtension.IsSorting = !selectedExtension.IsSorting;
                selectedExtension.IsSorting = selectedItemisChecked;

                lbl_testing.Text = $"{selectedExtension.Format} {selectedExtension.IsSorting.ToString()} {allExtensionsSelected}";

                
            }
            
        }

        private void chcklistbox_Extensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            allExtensionsSelected = (chcklistbox_Extensions.Items.Count == chcklistbox_Extensions.CheckedItems.Count);
            chckbox_allExtensions_Reload();
        }

        private void addNewExtension()
        {
            string extension_format = txtbox_Name.Text;
            Extension extension = new Extension(extension_format);
            selectedFolder.Extensions.Add(extension);
            chcklistbox_Extensions_Reload();
        }

        private void removeExtension()
        {
            Extension.Extensions.Remove(selectedExtension);
            chcklistbox_Extensions_Reload();
        }

        private void chcklistbox_Extensions_Reload()
        {
            /*Reloading all extension objects from selected folder and displaying it on
            chcklistbox_Extensions*/

            chcklistbox_Extensions.Items.Clear();
            Extension[] extensions = selectedFolder.getExtensions();
            int allSortedChecker = 1;
            foreach (Extension extension in extensions)
            {
                int index = chcklistbox_Extensions.Items.Add(extension.Format);
                chcklistbox_Extensions.SetItemChecked(index, extension.IsSorting);
                allSortedChecker *= extension.IsSorting ? 1 : 0;
            }
            //Checking if all items in the check list box are selected
            allExtensionsSelected = (allSortedChecker == 1);
        }

        private void chcklistbox_Extensions_SelectAll()
        {
            foreach (Extension extension in selectedFolder.getExtensions())
            {
                extension.IsSorting = true;
            }
            allExtensionsSelected = true;
            chcklistbox_Extensions_Reload();
        }

        private void chcklistbox_Extensions_DeselectAll()
        {
            foreach (Extension extension in selectedFolder.getExtensions())
            {
                extension.IsSorting = false;
            }
            allExtensionsSelected = false;
            chcklistbox_Extensions_Reload();
        }


        //-------------------Select All Button-------------------
        //IloveMahin

        private void chckbox_allExtensions_Reload()
        {
            chckbox_allExtensions.Checked = allExtensionsSelected;

        }

        private void chckbox_allExtensions_MouseClick(object sender, MouseEventArgs e)
        {
            if (chckbox_allExtensions.Checked)
            {
                chcklistbox_Extensions_SelectAll();
            }
            else
            {
                chcklistbox_Extensions_DeselectAll();
            }
        }


        //-------------------File Sorting-------------------
        private void create_directories()
        {
            List<Folder> directories = Folder.Folders.Where(folder => folder.IsSorting).ToList();
            string[] foldersInPath = Directory.GetDirectories(selectedPath);

            foreach (Folder folder in directories)
            {
                string folderPath = $@"{selectedPath}\{folder.Name}";
                if (!foldersInPath.Contains(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
            }
            pathContainsAllDirectories = true;
        }

        private int sortinto_directories()
        {
            List<Folder> directories = Folder.Folders.Where(folder => folder.IsSorting).ToList();
            string[] filePaths = Directory.GetFiles(selectedPath);
            recentFilesSorted = new Dictionary<string, string>();
            int sortedCount = 0;

            Parallel.ForEach(directories, (folder) => 
            {
                foreach (string filePath in filePaths)
                {
                    string fileName = Path.GetFileName(filePath);
                    string fileExtension = Path.GetExtension(filePath);
                    if (folder.ExtensionFormats.Contains(fileExtension)) 
                    {
                        string destinationPath = $@"{selectedPath}\{folder.Name}\{fileName}";
                        File.Move(filePath, destinationPath);
                        recentFilesSorted.Add(destinationPath, filePath);
                        sortedCount++;
                        Console.WriteLine(recentFilesSorted);
                        Console.ReadLine();
                    }
                }
            });

            return sortedCount;
        }

        //Undo last sorting
        private void undo_sortinto_directories()
        {
            List<string> directories = Folder.Folders
                .Where(folder => folder.IsSorting)
                .Select(folder => folder.Name)
                .ToList();

            //Move each file back
            foreach (var recentFileSorted in recentFilesSorted)
            {
                File.Move(recentFileSorted.Key, recentFileSorted.Value);
            }

            //Delete the new directories
            foreach (string directory in directories)
            {
                string path = $@"{selectedPath}\{directory}";
                Directory.Delete(path);
            }
            
        }


        //-------------------General-------------------

        //Adding new folder button
        private void btn_AddFolder_Click(object sender, EventArgs e)
        {
            addNewFolder();
        }

        //Adding new extension button
        private void btn_AddExtension_Click(object sender, EventArgs e)
        {
            addNewExtension();
        }

        //Method to add the hardcoded default folders and extensions in their respective classes
        private void addDefaultFoldersAndExtensions()
        {
            Dictionary<string, bool> defaultFolders = Folder.getDefaultFolders();
            Dictionary<string, string[]> defaultFoldersToExtensions = Extension.getDefaultExtensions();

            foreach (var defaultFolder in defaultFolders)
            {
                string[] extensionFormats = defaultFoldersToExtensions[defaultFolder.Key];
                List<Extension> extensions = new List<Extension>();

                foreach (string format in extensionFormats)
                {
                    Extension extension = new Extension(format, defaultFolder.Value);
                    extensions.Add(extension);
                }

                Folder folder = new Folder(defaultFolder.Key, extensions, defaultFolder.Value, extensionFormats);
            }

            selectedFolder = Folder.getFolders()[0];
            selectedExtension = Extension.getExtensions()[0];

            chcklistbox_Folders_Reload();
        }

        //Selecting folder with use of FileBrowserDialog
        private void btn_selectFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select a main folder to sort files in.";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    selectedPath = fbd.SelectedPath;
                    pathContainsAllDirectories = false;
                    btn_sort.Enabled = true;
                }
            }
        }

        //Sorting button executing sorting methods
        private void btn_sort_Click(object sender, EventArgs e)
        {
            sortedCount = 0;
            if (pathContainsAllDirectories)
            {
                sortedCount = sortinto_directories();
            }
            else
            {
                create_directories();
                sortedCount = sortinto_directories();
            }
            btn_UndoSort.Enabled = true;

            MessageBox.Show($"Sort Successful\nMoved {sortedCount} files");
        }

        //Button to trigger undo sort method
        private void btn_UndoSort_Click(object sender, EventArgs e)
        {
            undo_sortinto_directories();

            MessageBox.Show($"Undo Successful\nMoved {sortedCount} files");
        }
    }
}
