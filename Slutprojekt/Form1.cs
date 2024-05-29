using System.Security.Cryptography.X509Certificates;
namespace slutprojekt
{
    public partial class Form1 : Form
    {
        int record;
        private int hemlisTryck = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hej och v�lkommen till mitt program!");
            MessageBox.Show("F�r att starta s� klickar du p� START i huvudmenyn");
            MessageBox.Show("Du kommer f� ett ord p� engelska som du sedan ska skriva p� svenska");
            MessageBox.Show("Om du vill ha ett ord p� svenska som du ska skriva p� engelska s� kan du �ndra det i inst�llningarna");
            MessageBox.Show("Kan du inte ordet s� kan du klicka p� Ledtr�d f�r att se de tv� f�rsta bokst�verna i ordet, detta kan du bara g�ra tre g�nger");
            MessageBox.Show("F�r att kolla om ditt ord �r korrekt eller inte s� kan du antingen klicka p� CHECK eller s� klickar du Enter p� tangentbordet");
            MessageBox.Show("F�r varje r�tt du f�r s� f�r du en po�ng, men gissar du fel s� g�r du tillbaka till 0");
            MessageBox.Show("Du kan sedan se ditt rekord i huvumenyn");
            MessageBox.Show("Lycka till!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 gameForm = new Form2(record);
            gameForm.GameOver += GameForm_GameOver;
            gameForm.Show();
        }
        private void GameForm_GameOver(object sender, int newRecord)
        {
            if (newRecord > record)
            {
                record = newRecord;
            }
            if (record >= 100)
            {
                this.ALabel.Visible = true;
                this.APicture.Visible = true;
            }
        }

        private void recordButton_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Ditt rekord �r " + record);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(Settings.TranslateEnglishToSwedish);
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                Settings.TranslateEnglishToSwedish = settingsForm.TranslateEnglishToSwedish;
                MessageBox.Show("Inst�llningara Sparades");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Du hittade en av mina hemligheter!");
            MessageBox.Show("Det finns totalt tre g�mda hemligheter i mitt spel");
            MessageBox.Show("Hittar du alla tre kommer en liten �veraskning");
            if (hemlisTryck == 0)
            {
                Hemlis.Secret++;
            }
            if (Hemlis.Secret >= 3)
            {
                this.BackColor = Color.White;
            }
            hemlisTryck++;
        }
    }
    public static class Hemlis
    {
        public static int Secret { get; set; } = 0;
    }

}