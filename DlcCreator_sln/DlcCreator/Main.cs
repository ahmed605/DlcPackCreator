using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DlcCreator.Utils;
using System.Windows.Forms;
using System.IO;

namespace DlcCreator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            DlcTypeComboBox.SelectedIndex = 0;
        }

        string dlcType;
        string dlcName;
        string dlcListItem;

        private void CreateDlcPackButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.Description = "Choose Location To Save DLC Pack!";

            dlcType = DlcTypeComboBox.Text;
            dlcName = DlcNameTextBox.Text.ToLower();
            dlcListItem = "<Item>dlcpacks:\\" + dlcName + "\\</Item>";
            if (dlcType == "Vehicle")
            {
                MessageBox.Show("Vehicle Dlc Packs Coming Soon!", "Cancelled");
                return;
            }
            if(dlcName == "" || dlcName.Contains(" "))
            {
                MessageBox.Show("Please enter a dlc name or remove the spaces in the name!", "Error");
                return;
            }

            if(fd.ShowDialog() == DialogResult.OK)
            {
                string savePath = Path.Combine(fd.SelectedPath + "\\" + dlcName);
                
                if (dlcType == "Map")
                {
                    CreateDlcPack(savePath);
                }
                if(dlcType == "Vehicle")
                {
                    CreateDlcPack(savePath);
                }

                DlcListItemTextBox.Text = dlcListItem;
            }
        }

        private void CreateDlcPack(string savePath)
        {
            Dlc.Create(dlcType, dlcName, savePath);
        }
    }
}
