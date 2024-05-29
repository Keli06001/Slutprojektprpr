using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slutprojekt
{
    public partial class SettingsForm : Form
    {
        private int hemlisTryck = 0;
        public bool TranslateEnglishToSwedish { get; private set; }
        public SettingsForm(bool currentSetting)
        {
            InitializeComponent();
            TranslateEnglishToSwedish = currentSetting;

            if (TranslateEnglishToSwedish)
            {
                radioButtonEnglishToSwedish.Checked = true;
            }
            else
            {
                radioButtonSwedishToEnglish.Checked = true;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            TranslateEnglishToSwedish = radioButtonEnglishToSwedish.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Du hittade en av mina hemligheter!");
            MessageBox.Show("Det finns totalt tre gömda hemligheter i mitt spel");
            MessageBox.Show("Hittar du alla tre kommer en liten överaskning");
            if (hemlisTryck == 0)
            {
                Hemlis.Secret++;
                if (Hemlis.Secret >= 3)
                {
                    this.BackColor = Color.White;
                }
            }
            hemlisTryck++;
        }
    }
    public static class Settings
    {
        public static bool TranslateEnglishToSwedish { get; set; } = true; // Default inställning
    }
}
