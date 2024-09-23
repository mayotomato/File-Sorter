namespace File_Sorter_Beta
{
    partial class NewPreset
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
            this.lbl_PresetName = new System.Windows.Forms.Label();
            this.txtbox_PresetName = new System.Windows.Forms.TextBox();
            this.btn_SavePreset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_PresetName
            // 
            this.lbl_PresetName.AutoSize = true;
            this.lbl_PresetName.Location = new System.Drawing.Point(4, 29);
            this.lbl_PresetName.Name = "lbl_PresetName";
            this.lbl_PresetName.Size = new System.Drawing.Size(35, 13);
            this.lbl_PresetName.TabIndex = 21;
            this.lbl_PresetName.Text = "Name";
            // 
            // txtbox_PresetName
            // 
            this.txtbox_PresetName.Location = new System.Drawing.Point(47, 26);
            this.txtbox_PresetName.Name = "txtbox_PresetName";
            this.txtbox_PresetName.Size = new System.Drawing.Size(179, 20);
            this.txtbox_PresetName.TabIndex = 20;
            // 
            // btn_SavePreset
            // 
            this.btn_SavePreset.Location = new System.Drawing.Point(134, 72);
            this.btn_SavePreset.Name = "btn_SavePreset";
            this.btn_SavePreset.Size = new System.Drawing.Size(90, 32);
            this.btn_SavePreset.TabIndex = 19;
            this.btn_SavePreset.Text = "Confirm";
            this.btn_SavePreset.UseVisualStyleBackColor = true;
            this.btn_SavePreset.Click += new System.EventHandler(this.btn_SavePreset_Click);
            // 
            // NewPreset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 112);
            this.Controls.Add(this.lbl_PresetName);
            this.Controls.Add(this.txtbox_PresetName);
            this.Controls.Add(this.btn_SavePreset);
            this.Name = "NewPreset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Choose New Preset Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PresetName;
        private System.Windows.Forms.TextBox txtbox_PresetName;
        private System.Windows.Forms.Button btn_SavePreset;
    }
}