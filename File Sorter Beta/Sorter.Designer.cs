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
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_selectFolder = new System.Windows.Forms.Button();
            this.btn_AddFolder = new System.Windows.Forms.Button();
            this.btn_AddExtension = new System.Windows.Forms.Button();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_testing = new System.Windows.Forms.Label();
            this.chckbox_allExtensions = new System.Windows.Forms.CheckBox();
            this.btn_UndoSort = new System.Windows.Forms.Button();
            this.btn_RemoveFolder = new System.Windows.Forms.Button();
            this.btn_RemoveExtension = new System.Windows.Forms.Button();
            this.cmbobox_Preset = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chcklistbox_Folders
            // 
            this.chcklistbox_Folders.FormattingEnabled = true;
            this.chcklistbox_Folders.Location = new System.Drawing.Point(12, 27);
            this.chcklistbox_Folders.Name = "chcklistbox_Folders";
            this.chcklistbox_Folders.Size = new System.Drawing.Size(246, 259);
            this.chcklistbox_Folders.TabIndex = 0;
            this.chcklistbox_Folders.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chcklistbox_Folders_ItemCheck);
            this.chcklistbox_Folders.SelectedIndexChanged += new System.EventHandler(this.chcklistbox_Folders_SelectedIndexChanged);
            this.chcklistbox_Folders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.chcklistbox_Folders_MouseDoubleClick);
            // 
            // chcklistbox_Extensions
            // 
            this.chcklistbox_Extensions.CheckOnClick = true;
            this.chcklistbox_Extensions.FormattingEnabled = true;
            this.chcklistbox_Extensions.Location = new System.Drawing.Point(276, 27);
            this.chcklistbox_Extensions.Name = "chcklistbox_Extensions";
            this.chcklistbox_Extensions.Size = new System.Drawing.Size(246, 259);
            this.chcklistbox_Extensions.TabIndex = 1;
            this.chcklistbox_Extensions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chcklistbox_Extensions_ItemCheck);
            this.chcklistbox_Extensions.SelectedIndexChanged += new System.EventHandler(this.chcklistbox_Extensions_SelectedIndexChanged);
            this.chcklistbox_Extensions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.chcklistbox_Extensions_MouseDoubleClick);
            // 
            // btn_sort
            // 
            this.btn_sort.Enabled = false;
            this.btn_sort.Location = new System.Drawing.Point(432, 517);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(90, 32);
            this.btn_sort.TabIndex = 2;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_selectFolder
            // 
            this.btn_selectFolder.Location = new System.Drawing.Point(336, 517);
            this.btn_selectFolder.Name = "btn_selectFolder";
            this.btn_selectFolder.Size = new System.Drawing.Size(90, 32);
            this.btn_selectFolder.TabIndex = 3;
            this.btn_selectFolder.Text = "Select Folder";
            this.btn_selectFolder.UseVisualStyleBackColor = true;
            this.btn_selectFolder.Click += new System.EventHandler(this.btn_selectFolder_Click);
            // 
            // btn_AddFolder
            // 
            this.btn_AddFolder.Location = new System.Drawing.Point(148, 292);
            this.btn_AddFolder.Name = "btn_AddFolder";
            this.btn_AddFolder.Size = new System.Drawing.Size(110, 32);
            this.btn_AddFolder.TabIndex = 4;
            this.btn_AddFolder.Text = "Add Folder";
            this.btn_AddFolder.UseVisualStyleBackColor = true;
            this.btn_AddFolder.Click += new System.EventHandler(this.btn_AddFolder_Click);
            // 
            // btn_AddExtension
            // 
            this.btn_AddExtension.Location = new System.Drawing.Point(410, 292);
            this.btn_AddExtension.Name = "btn_AddExtension";
            this.btn_AddExtension.Size = new System.Drawing.Size(112, 32);
            this.btn_AddExtension.TabIndex = 5;
            this.btn_AddExtension.Text = "Add Extension";
            this.btn_AddExtension.UseVisualStyleBackColor = true;
            this.btn_AddExtension.Click += new System.EventHandler(this.btn_AddExtension_Click);
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Location = new System.Drawing.Point(278, 409);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(228, 20);
            this.txtbox_Name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // lbl_testing
            // 
            this.lbl_testing.AutoSize = true;
            this.lbl_testing.Location = new System.Drawing.Point(273, 452);
            this.lbl_testing.Name = "lbl_testing";
            this.lbl_testing.Size = new System.Drawing.Size(35, 13);
            this.lbl_testing.TabIndex = 8;
            this.lbl_testing.Text = "label2";
            // 
            // chckbox_allExtensions
            // 
            this.chckbox_allExtensions.AutoSize = true;
            this.chckbox_allExtensions.Location = new System.Drawing.Point(278, 292);
            this.chckbox_allExtensions.Name = "chckbox_allExtensions";
            this.chckbox_allExtensions.Size = new System.Drawing.Size(70, 17);
            this.chckbox_allExtensions.TabIndex = 9;
            this.chckbox_allExtensions.Text = "Select All";
            this.chckbox_allExtensions.UseVisualStyleBackColor = true;
            this.chckbox_allExtensions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chckbox_allExtensions_MouseClick);
            // 
            // btn_UndoSort
            // 
            this.btn_UndoSort.Location = new System.Drawing.Point(432, 479);
            this.btn_UndoSort.Name = "btn_UndoSort";
            this.btn_UndoSort.Size = new System.Drawing.Size(90, 32);
            this.btn_UndoSort.TabIndex = 10;
            this.btn_UndoSort.Text = "Undo";
            this.btn_UndoSort.UseVisualStyleBackColor = true;
            this.btn_UndoSort.Visible = false;
            this.btn_UndoSort.Click += new System.EventHandler(this.btn_UndoSort_Click);
            // 
            // btn_RemoveFolder
            // 
            this.btn_RemoveFolder.Location = new System.Drawing.Point(148, 330);
            this.btn_RemoveFolder.Name = "btn_RemoveFolder";
            this.btn_RemoveFolder.Size = new System.Drawing.Size(110, 32);
            this.btn_RemoveFolder.TabIndex = 11;
            this.btn_RemoveFolder.Text = "Remove Folder";
            this.btn_RemoveFolder.UseVisualStyleBackColor = true;
            this.btn_RemoveFolder.Click += new System.EventHandler(this.btn_RemoveFolder_Click);
            // 
            // btn_RemoveExtension
            // 
            this.btn_RemoveExtension.Location = new System.Drawing.Point(410, 330);
            this.btn_RemoveExtension.Name = "btn_RemoveExtension";
            this.btn_RemoveExtension.Size = new System.Drawing.Size(112, 32);
            this.btn_RemoveExtension.TabIndex = 12;
            this.btn_RemoveExtension.Text = "Remove Extension";
            this.btn_RemoveExtension.UseVisualStyleBackColor = true;
            this.btn_RemoveExtension.Click += new System.EventHandler(this.btn_RemoveExtension_Click);
            // 
            // cmbobox_Preset
            // 
            this.cmbobox_Preset.FormattingEnabled = true;
            this.cmbobox_Preset.Location = new System.Drawing.Point(49, 22);
            this.cmbobox_Preset.Name = "cmbobox_Preset";
            this.cmbobox_Preset.Size = new System.Drawing.Size(149, 21);
            this.cmbobox_Preset.TabIndex = 13;
            this.cmbobox_Preset.SelectedIndexChanged += new System.EventHandler(this.cmbobox_Preset_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Preset";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbobox_Preset);
            this.groupBox1.Location = new System.Drawing.Point(12, 386);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 167);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // Sorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_RemoveExtension);
            this.Controls.Add(this.btn_RemoveFolder);
            this.Controls.Add(this.btn_UndoSort);
            this.Controls.Add(this.chckbox_allExtensions);
            this.Controls.Add(this.lbl_testing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_Name);
            this.Controls.Add(this.btn_AddExtension);
            this.Controls.Add(this.btn_AddFolder);
            this.Controls.Add(this.btn_selectFolder);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.chcklistbox_Extensions);
            this.Controls.Add(this.chcklistbox_Folders);
            this.MaximizeBox = false;
            this.Name = "Sorter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beta";
            this.Load += new System.EventHandler(this.Sorter_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chcklistbox_Folders;
        private System.Windows.Forms.CheckedListBox chcklistbox_Extensions;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_selectFolder;
        private System.Windows.Forms.Button btn_AddFolder;
        private System.Windows.Forms.Button btn_AddExtension;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_testing;
        private System.Windows.Forms.CheckBox chckbox_allExtensions;
        private System.Windows.Forms.Button btn_UndoSort;
        private System.Windows.Forms.Button btn_RemoveFolder;
        private System.Windows.Forms.Button btn_RemoveExtension;
        private System.Windows.Forms.ComboBox cmbobox_Preset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

