using File_Sorter_Beta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Sorter_Beta
{
    public partial class Sorter : Form
    {
        //-----------------------------------------------Backing Fields-----------------------------------------------

        //Tracking current state of things
        private Preset selectedPreset;
        private Folder selectedFolder;
        private Extension selectedExtension;

        //Sorting and undoing related
        private string selectedPath;
        private Dictionary<string, string> recentFilesSorted;

        //Calculation or UI Related
        private int selectedFolderIndex;
        private int selectedExtensionIndex;

        //Select all button
        private bool pathContainsAllDirectories;

        //Tracking number of files sorted during sort
        private int sortedCount;


        //-----------------------------------------------Constructor & Loading-----------------------------------------------
        public Sorter()
        {
            InitializeComponent();
            chcklistbox_Extensions.Items.Clear();
            chcklistbox_Folders.Items.Clear();
            create_default_preset();
            chckbox_allExtensions_Reload();
        }

        private void Sorter_Load(object sender, EventArgs e)
        {
            cmbobox_Preset.Items.Add("Add Item");
        }


        //-----------------------------------------------Creating Default Preset-----------------------------------------------
        private void create_default_preset()
        {
            Dictionary<string, bool> defaultFolders = Preset.getDefaultFolders();
            Dictionary<string, string[]> defaultFoldersToExtensions = Folder.getDefaultExtensions();
            List<Folder> folders = new List<Folder>();

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
                folders.Add(folder);
            }

            Preset defaultPreset = new Preset("Default", folders);

            //Setting up the selected preset, folder, and extension
            selectedPreset = defaultPreset;
            selectedFolder = selectedPreset.Folders[0];
            selectedExtension = Extension.getExtensions()[0];

            //Forms stuff
            cmbobox_Preset.Items.Insert(0, selectedPreset.ToString());
            cmbobox_Preset.SelectedIndex = 0;
            chcklistbox_Folders_Reload();
        }


        //-----------------------------------------------Presets-----------------------------------------------
        private void detect_changes()
        {
            
        }

        private void cmbobox_Preset_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cmbobox_Preset.SelectedItem as string;
            if (selectedItem != null && selectedItem == "Add Item")
            {
                NewPreset menu = new NewPreset();
                menu.ShowDialog();

                Preset newPreset = menu.getNewPreset;
                int newIndex = cmbobox_Preset.Items.Count - 1;

                cmbobox_Preset.Items.Insert(newIndex, newPreset.ToString());
                cmbobox_Preset.SelectedIndex = newIndex;

                selectedPreset = newPreset;

                chcklistbox_Folders_Reload();
                chcklistbox_Extensions.Items.Clear();

                return;
            }

            selectedPreset = Preset.Presets.FirstOrDefault(p => p.Name == selectedItem);
            chcklistbox_Folders_Reload();
            chcklistbox_Extensions_Reload();
            chckbox_allExtensions_Reload();

            //Selecting the first folder directory name when the preset is changed
            if (chcklistbox_Folders.Items.Count != 0)
            {
                chcklistbox_Folders.SelectedIndex = 0;
            }
        }


        //-----------------------------------------------Folders-----------------------------------------------
        private void chcklistbox_Folders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chcklistbox_Folders != null)
            {
                selectedFolderIndex = chcklistbox_Folders.SelectedIndex;
                if (selectedFolderIndex != -1 && selectedPreset.Folders.Count != 0) 
                {
                    //MessageBox.Show(selectedFolderIndex.ToString());
                    selectedFolder = selectedPreset.Folders[selectedFolderIndex];
                    chckbox_allExtensions.Checked = false;
                    chcklistbox_Extensions_Reload();
                    chcklistbox_Extensions.Enabled = selectedFolder.IsSorting;
                    chckbox_allExtensions_Reload();

                    return;
                }
                chckbox_allExtensions_Reload();
                return;
            }
        }

        private void chcklistbox_Folders_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            selectedFolder.IsSorting = !selectedFolder.IsSorting;
            chcklistbox_Extensions.Enabled = selectedFolder.IsSorting;
        }

        private void chcklistbox_Folders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //selected folder index is set when selected index is changed so no need to check it here
            if (selectedFolderIndex != -1)
            {
                chcklistbox_Extensions.Enabled = selectedFolder.IsSorting;
            }
        }

        private void chcklistbox_Folders_Reload()
        {
            //selectedFolderIndex is not chosen if the the check list box is empty
            if (chcklistbox_Folders.Items.Count != 0) 
            {
                chcklistbox_Folders.SelectedIndex = selectedFolderIndex;
            }
            chcklistbox_Folders.Items.Clear();
            chcklistbox_Folders.ClearSelected();
            Folder[] folders = selectedPreset.Folders.ToArray();

            foreach (Folder folder in folders)
            {
                int index = chcklistbox_Folders.Items.Add(folder.Name);
                chcklistbox_Folders.SetItemChecked(index, folder.IsSorting);
                //MessageBox.Show($"{folder.Name} {folder.IsSorting.ToString()}");
            }
        }

        //Adding new folder
        private void addNewFolder()
        {
            string folder_name = txtbox_Name.Text;
            folder_name = folder_name.Trim();
            if (string.IsNullOrEmpty(folder_name) || (Regex.IsMatch(folder_name, @" +$")))
            {
                return;
            }

            Folder folder = new Folder(folder_name);
            selectedPreset.Folders.Add(folder);
            selectedFolder = folder;

            chcklistbox_Folders.Items.Add(folder_name);
            chcklistbox_Folders.SelectedItem = folder_name;

        }

        //Removing a folder
        private void removeFolder()
        {
            int tempIndex = selectedFolderIndex;
            Folder.Folders.Remove(selectedFolder);
            selectedPreset.Folders.Remove(selectedFolder);

            chcklistbox_Folders.Items.Remove(selectedFolder.Name);
            chcklistbox_Folders.SelectedIndex = tempIndex-1;

            if (chcklistbox_Folders.Items.Count == 0)
            {
                chcklistbox_Extensions.Items.Clear();
                chckbox_allExtensions.Checked = false;
            }
        }


        //-----------------------------------------------Extensions-----------------------------------------------

        //On item check event
        private void chcklistbox_Extensions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            selectedExtensionIndex = chcklistbox_Extensions.SelectedIndex;
            if (selectedExtensionIndex >= 0 && selectedExtensionIndex < chcklistbox_Extensions.Items.Count)
            {
                selectedExtension = selectedFolder.getExtensions()[selectedExtensionIndex];
                bool selectedItemisChecked = !chcklistbox_Extensions.CheckedItems.Contains(chcklistbox_Extensions.Items[selectedExtensionIndex]);
                selectedExtension.IsSorting = !selectedExtension.IsSorting;
                selectedExtension.IsSorting = selectedItemisChecked;

                lbl_testing.Text = $"{selectedExtension.Format} {selectedExtension.IsSorting.ToString()}";
            }
            
        }

        //On selected item change
        private void chcklistbox_Extensions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chcklistbox_Extensions.SelectedIndex != -1)
            {
                selectedExtensionIndex = chcklistbox_Extensions.SelectedIndex;
                selectedExtension = selectedFolder.getExtensions()[selectedExtensionIndex];

                chckbox_allExtensions_Reload();
                lbl_testing.Text = $"{selectedExtension.Format} {selectedExtension.IsSorting.ToString()}";

            }
        }

        //Double click handling
        private void chcklistbox_Extensions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            chckbox_allExtensions_Reload();
            lbl_testing.Text = $"{selectedExtension.Format} {selectedExtension.IsSorting.ToString()}";
        }

        //Reloading extensions check list box
        private void chcklistbox_Extensions_Reload()
        {
            /*Reloading all extension objects from selected folder and displaying it on
            chcklistbox_Extensions*/
            if (selectedFolder == null) { chcklistbox_Extensions.Items.Clear(); chcklistbox_Extensions.Enabled = false; return; }

            Folder[] folders = selectedPreset.Folders.ToArray();

            if (folders.Length == 0)
            {
                chcklistbox_Extensions.Items.Clear();
                return;
            }
            else
            {
                chcklistbox_Extensions.Items.Clear();
                Extension[] extensions = selectedFolder.getExtensions();
                if (extensions.Length == 0)
                {
                    return;
                }
                foreach (Extension extension in extensions)
                {
                    int index = chcklistbox_Extensions.Items.Add(extension.Format);
                    chcklistbox_Extensions.SetItemChecked(index, extension.IsSorting);
                }

                //Checking if all items in the check list box are selected
                chckbox_allExtensions_Reload();
            }


        }

        //Adding new extension
        private void addNewExtension()
        {
            string extension_format = txtbox_Name.Text;
            extension_format = extension_format.Trim();

            Extension extension = new Extension(extension_format);
            selectedFolder.Extensions.Add(extension);

            chcklistbox_Extensions.Items.Add(extension_format);
            chckbox_allExtensions_Reload();
        }

        //Removing extension
        private void removeExtension()
        {
            int tempIndex = selectedExtensionIndex;

            Extension.Extensions.Remove(selectedExtension);
            selectedFolder.Extensions.Remove(selectedExtension);

            chcklistbox_Extensions.Items.Remove(selectedExtension.Format);
            chcklistbox_Extensions.SelectedIndex = tempIndex - 1;

            if (tempIndex <= 0)
            {
                chckbox_allExtensions.Checked = false;
            }
            chckbox_allExtensions_Reload();
        }

        //-----------------------------------------------Select All Extensions Button-----------------------------------------------
        //IloveMahin

        //Selecting all extensions
        private void chcklistbox_Extensions_SelectAll()
        {
            foreach (Extension extension in selectedFolder.getExtensions())
            {
                extension.IsSorting = true;
            }
            chcklistbox_Extensions_Reload();
        }

        //Deselecting all extensions
        private void chcklistbox_Extensions_DeselectAll()
        {
            foreach (Extension extension in selectedFolder.getExtensions())
            {
                extension.IsSorting = false;
            }
            chcklistbox_Extensions_Reload();
        }

        //Reloading the button in the UI
        private void chckbox_allExtensions_Reload()
        {
            if (chcklistbox_Extensions.Items.Count == 0 ||
                chcklistbox_Extensions.Items.Count != chcklistbox_Extensions.CheckedItems.Count)
            {
                chckbox_allExtensions.Checked = false;
                return;
            }
            else
            {
                chckbox_allExtensions.Checked = true;
                return;
            }

        }

        //Handling both item check and unchecking
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


        //-----------------------------------------------File Sorting-----------------------------------------------
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


        //-----------------------------------------------General-----------------------------------------------

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
            btn_UndoSort.Visible = true;

            MessageBox.Show($"Sort Successful\nMoved {sortedCount} files");
        }

        //Button to trigger undo sort method
        private void btn_UndoSort_Click(object sender, EventArgs e)
        {
            undo_sortinto_directories();

            MessageBox.Show($"Undo Successful\nMoved {sortedCount} files");
        }

        //Button triggering remove folder
        private void btn_RemoveFolder_Click(object sender, EventArgs e)
        {
            removeFolder();
        }

        //Button triggering remove extension
        private void btn_RemoveExtension_Click(object sender, EventArgs e)
        {
            removeExtension();
        }


    }
}
