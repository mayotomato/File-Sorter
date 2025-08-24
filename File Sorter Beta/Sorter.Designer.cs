namespace File_Sorter_Beta
{
    partial class Sorter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chcklistbox_Folders = new System.Windows.Forms.CheckedListBox();
            this.chcklistbox_Extensions = new System.Windows.Forms.CheckedListBox();
            this.btn_selectFolder = new System.Windows.Forms.Button();
            this.btn_AddFolder = new System.Windows.Forms.Button();
            this.btn_AddExtension = new System.Windows.Forms.Button();
            this.lbl_testing = new System.Windows.Forms.Label();
            this.chckbox_allExtensions = new System.Windows.Forms.CheckBox();
            this.btn_UndoSort = new System.Windows.Forms.Button();
            this.btn_RemoveFolder = new System.Windows.Forms.Button();
            this.btn_RemoveExtension = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbobox_Preset = new System.Windows.Forms.ComboBox();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sort = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_path = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbox_extension = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chcklistbox_Folders
            // 
            this.chcklistbox_Folders.FormattingEnabled = true;
            this.chcklistbox_Folders.Location = new System.Drawing.Point(12, 58);
            this.chcklistbox_Folders.Name = "chcklistbox_Folders";
            this.chcklistbox_Folders.Size = new System.Drawing.Size(246, 229);
            this.chcklistbox_Folders.TabIndex = 0;
            this.chcklistbox_Folders.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chcklistbox_Folders_ItemCheck);
            this.chcklistbox_Folders.SelectedIndexChanged += new System.EventHandler(this.chcklistbox_Folders_SelectedIndexChanged);
            this.chcklistbox_Folders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.chcklistbox_Folders_MouseDoubleClick);
            // 
            // chcklistbox_Extensions
            // 
            this.chcklistbox_Extensions.CheckOnClick = true;
            this.chcklistbox_Extensions.FormattingEnabled = true;
            this.chcklistbox_Extensions.Location = new System.Drawing.Point(276, 58);
            this.chcklistbox_Extensions.Name = "chcklistbox_Extensions";
            this.chcklistbox_Extensions.Size = new System.Drawing.Size(246, 229);
            this.chcklistbox_Extensions.TabIndex = 1;
            this.chcklistbox_Extensions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chcklistbox_Extensions_ItemCheck);
            this.chcklistbox_Extensions.SelectedIndexChanged += new System.EventHandler(this.chcklistbox_Extensions_SelectedIndexChanged);
            this.chcklistbox_Extensions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.chcklistbox_Extensions_MouseDoubleClick);
            // 
            // btn_selectFolder
            // 
            this.btn_selectFolder.Location = new System.Drawing.Point(296, 471);
            this.btn_selectFolder.Name = "btn_selectFolder";
            this.btn_selectFolder.Size = new System.Drawing.Size(108, 32);
            this.btn_selectFolder.TabIndex = 3;
            this.btn_selectFolder.Text = "Select Path";
            this.btn_selectFolder.UseVisualStyleBackColor = true;
            this.btn_selectFolder.Click += new System.EventHandler(this.btn_selectFolder_Click);
            // 
            // btn_AddFolder
            // 
            this.btn_AddFolder.Location = new System.Drawing.Point(148, 323);
            this.btn_AddFolder.Name = "btn_AddFolder";
            this.btn_AddFolder.Size = new System.Drawing.Size(110, 32);
            this.btn_AddFolder.TabIndex = 4;
            this.btn_AddFolder.Text = "Add Folder";
            this.btn_AddFolder.UseVisualStyleBackColor = true;
            this.btn_AddFolder.Click += new System.EventHandler(this.btn_AddFolder_Click);
            // 
            // btn_AddExtension
            // 
            this.btn_AddExtension.Location = new System.Drawing.Point(410, 323);
            this.btn_AddExtension.Name = "btn_AddExtension";
            this.btn_AddExtension.Size = new System.Drawing.Size(112, 32);
            this.btn_AddExtension.TabIndex = 5;
            this.btn_AddExtension.Text = "Add Extension";
            this.btn_AddExtension.UseVisualStyleBackColor = true;
            this.btn_AddExtension.Click += new System.EventHandler(this.btn_AddExtension_Click);
            // 
            // lbl_testing
            // 
            this.lbl_testing.AutoSize = true;
            this.lbl_testing.Location = new System.Drawing.Point(273, 452);
            this.lbl_testing.Name = "lbl_testing";
            this.lbl_testing.Size = new System.Drawing.Size(0, 13);
            this.lbl_testing.TabIndex = 8;
            // 
            // chckbox_allExtensions
            // 
            this.chckbox_allExtensions.AutoSize = true;
            this.chckbox_allExtensions.Location = new System.Drawing.Point(450, 293);
            this.chckbox_allExtensions.Name = "chckbox_allExtensions";
            this.chckbox_allExtensions.Size = new System.Drawing.Size(70, 17);
            this.chckbox_allExtensions.TabIndex = 9;
            this.chckbox_allExtensions.Text = "Select All";
            this.chckbox_allExtensions.UseVisualStyleBackColor = true;
            this.chckbox_allExtensions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chckbox_allExtensions_MouseClick);
            // 
            // btn_UndoSort
            // 
            this.btn_UndoSort.Location = new System.Drawing.Point(410, 433);
            this.btn_UndoSort.Name = "btn_UndoSort";
            this.btn_UndoSort.Size = new System.Drawing.Size(112, 32);
            this.btn_UndoSort.TabIndex = 10;
            this.btn_UndoSort.Text = "Undo";
            this.btn_UndoSort.UseVisualStyleBackColor = true;
            this.btn_UndoSort.Visible = false;
            this.btn_UndoSort.Click += new System.EventHandler(this.btn_UndoSort_Click);
            // 
            // btn_RemoveFolder
            // 
            this.btn_RemoveFolder.Location = new System.Drawing.Point(148, 361);
            this.btn_RemoveFolder.Name = "btn_RemoveFolder";
            this.btn_RemoveFolder.Size = new System.Drawing.Size(110, 32);
            this.btn_RemoveFolder.TabIndex = 11;
            this.btn_RemoveFolder.Text = "Remove Folder";
            this.btn_RemoveFolder.UseVisualStyleBackColor = true;
            this.btn_RemoveFolder.Click += new System.EventHandler(this.btn_RemoveFolder_Click);
            // 
            // btn_RemoveExtension
            // 
            this.btn_RemoveExtension.Location = new System.Drawing.Point(410, 361);
            this.btn_RemoveExtension.Name = "btn_RemoveExtension";
            this.btn_RemoveExtension.Size = new System.Drawing.Size(112, 32);
            this.btn_RemoveExtension.TabIndex = 12;
            this.btn_RemoveExtension.Text = "Remove Extension";
            this.btn_RemoveExtension.UseVisualStyleBackColor = true;
            this.btn_RemoveExtension.Click += new System.EventHandler(this.btn_RemoveExtension_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 17;
            // 
            // cmbobox_Preset
            // 
            this.cmbobox_Preset.FormattingEnabled = true;
            this.cmbobox_Preset.ItemHeight = 13;
            this.cmbobox_Preset.Location = new System.Drawing.Point(52, 19);
            this.cmbobox_Preset.Name = "cmbobox_Preset";
            this.cmbobox_Preset.Size = new System.Drawing.Size(149, 21);
            this.cmbobox_Preset.TabIndex = 13;
            this.cmbobox_Preset.SelectedIndexChanged += new System.EventHandler(this.cmbobox_Preset_SelectedIndexChanged);
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Location = new System.Drawing.Point(14, 332);
            this.txtbox_Name.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(124, 20);
            this.txtbox_Name.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Preset";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Folder Name";
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(410, 471);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(112, 32);
            this.btn_sort.TabIndex = 21;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_path);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 106);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Path";
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(74, 53);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(35, 13);
            this.lbl_path.TabIndex = 23;
            this.lbl_path.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::File_Sorter_Beta.Properties.Resources.folder_svgrepo_com;
            this.pictureBox1.Location = new System.Drawing.Point(23, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtbox_extension
            // 
            this.txtbox_extension.Location = new System.Drawing.Point(274, 335);
            this.txtbox_extension.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_extension.Name = "txtbox_extension";
            this.txtbox_extension.Size = new System.Drawing.Size(124, 20);
            this.txtbox_extension.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Extension";
            // 
            // Sorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 517);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbox_extension);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbobox_Preset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_RemoveExtension);
            this.Controls.Add(this.btn_RemoveFolder);
            this.Controls.Add(this.btn_UndoSort);
            this.Controls.Add(this.chckbox_allExtensions);
            this.Controls.Add(this.lbl_testing);
            this.Controls.Add(this.btn_AddExtension);
            this.Controls.Add(this.btn_AddFolder);
            this.Controls.Add(this.btn_selectFolder);
            this.Controls.Add(this.chcklistbox_Extensions);
            this.Controls.Add(this.chcklistbox_Folders);
            this.MaximizeBox = false;
            this.Name = "Sorter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Sorter";
            this.Load += new System.EventHandler(this.Sorter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chcklistbox_Folders;
        private System.Windows.Forms.CheckedListBox chcklistbox_Extensions;
        private System.Windows.Forms.Button btn_selectFolder;
        private System.Windows.Forms.Button btn_AddFolder;
        private System.Windows.Forms.Button btn_AddExtension;
        private System.Windows.Forms.Label lbl_testing;
        private System.Windows.Forms.CheckBox chckbox_allExtensions;
        private System.Windows.Forms.Button btn_UndoSort;
        private System.Windows.Forms.Button btn_RemoveFolder;
        private System.Windows.Forms.Button btn_RemoveExtension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbobox_Preset;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.TextBox txtbox_extension;
        private System.Windows.Forms.Label label5;
    }
}

