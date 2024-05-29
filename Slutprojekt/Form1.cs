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
            MessageBox.Show("Hej och välkommen till mitt program!");
            MessageBox.Show("För att starta så klickar du på START i huvudmenyn");
            MessageBox.Show("Du kommer få ett ord på engelska som du sedan ska skriva på svenska");
            MessageBox.Show("Om du vill ha ett ord på svenska som du ska skriva på engelska så kan du ändra det i inställningarna");
            MessageBox.Show("Kan du inte ordet så kan du klicka på Ledtråd för att se de två första bokstäverna i ordet, detta kan du bara göra tre gånger");
            MessageBox.Show("För att kolla om ditt ord är korrekt eller inte så kan du antingen klicka på CHECK eller så klickar du Enter på tangentbordet");
            MessageBox.Show("För varje rätt du får så får du en poäng, men gissar du fel så går du tillbaka till 0");
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
            MessageBox.Show("Ditt rekord är " + record);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(Settings.TranslateEnglishToSwedish);
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                Settings.TranslateEnglishToSwedish = settingsForm.TranslateEnglishToSwedish;
                MessageBox.Show("Inställningara Sparades");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Du hittade en av mina hemligheter!");
            MessageBox.Show("Det finns totalt tre gömda hemligheter i mitt spel");
            MessageBox.Show("Hittar du alla tre kommer en liten överaskning");
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