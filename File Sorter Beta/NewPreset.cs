using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Sorter_Beta
{
    public partial class NewPreset : Form
    {
        private string presetName;
        Preset preset;

        public NewPreset()
        {
            InitializeComponent();
        }

        private void btn_SavePreset_Click(object sender, EventArgs e)
        {
            presetName = txtbox_PresetName.Text;
            preset = new Preset(presetName);

            if (presetName == null || presetName == "")
            {
                txtbox_PresetName.Clear();
                MessageBox.Show("Please enter a valid name");
            }
            else { Close(); }
        }

        internal Preset getNewPreset => preset;
    }
}
