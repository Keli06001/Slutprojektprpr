using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace slutprojekt
{
    public partial class Form2 : Form
    {
        public event EventHandler<int> GameOver;
        private Dictionary<string, string> wordsEnglishToSwedish = new Dictionary<string, string>()
        {
            {"Hello", "Hej"},
            {"Goodbye", "Hejdå"},
            {"Please", "Snälla"},
            {"Thanks", "Tack"},
            {"Yes", "Ja"},
            {"No", "Nej"},
            {"Cat", "Katt"},
            {"Dog", "Hund"},
            {"House", "Hus"},
            {"Car", "Bil"},
            {"Food", "Mat"},
            {"Water", "Vatten"},
            {"School", "Skola"},
            {"Teacher", "Lärare"},
            {"Book", "Bok"},
            {"Pen", "Penna"},
            {"Computer", "Dator"},
            {"Phone", "Telefon"},
            {"Sun", "Sol"},
            {"Moon", "Måne"},
            {"Star", "Stjärna"},
            {"Sky", "Himmel"},
            {"Tree", "Träd"},
            {"Flower", "Blomma"},
            {"Grass", "Gräs"},
            {"Mountain", "Berg"},
            {"River", "Flod"},
            {"Sea", "Hav"},
            {"Fish", "Fisk"},
            {"Bird", "Fågel"},
            {"Elephant", "Elefant"},
            {"Tiger", "Tiger"},
            {"Lion", "Lejon"},
            {"Bear", "Björn"},
            {"Snake", "Orm"},
            {"Horse", "Häst"},
            {"Sheep", "Får"},
            {"Cow", "Ko"},
            {"Chicken", "Kyckling"},
            {"Duck", "Anka"},
            {"Goat", "Get"},
            {"Pig", "Gris"},
            {"Frog", "Groda"},
            {"Butterfly", "Fjäril"},
            {"Ant", "Myra"},
            {"Bee", "Bi"},
            {"Spider", "Spindel"},
            {"Grasshopper", "Gräshoppa"},
            {"Ladybug", "Nyckelpiga"},
            {"Shirt", "Skjorta"},
            {"Pants", "Byxor"},
            {"Shoes", "Skor"},
            {"Hat", "Hatt"},
            {"Gloves", "Handskar"},
            {"Scarf", "Halsduk"},
            {"Jacket", "Jacka"},
            {"Dress", "Klänning"},
            {"Socks", "Strumpor"},
            {"Underwear", "Underkläder"},
            {"Belt", "Bälte"},
            {"Watch", "Klocka"},
            {"Ring", "Ring"},
            {"Necklace", "Halsband"},
            {"Bracelet", "Armband"},
            {"Glasses", "Glasögon"},
            {"Sunglasses", "Solglasögon"},
            {"Wallet", "Plånbok"},
            {"Bag", "Väska"},
            {"Umbrella", "Paraply"},
            {"Television", "Tv"},
            {"Radio", "Radio"},
            {"Laptop", "Bärbar dator"},
            {"Tablet", "Surfplatta"},
            {"Headphones", "Hörlurar"},
            {"Charger", "Laddare"},
            {"Battery", "Batteri"},
            {"Screen", "Skärm"},
            {"Keyboard", "Tangentbord"},
            {"Mouse", "Mus"},
            {"Printer", "Skrivare"},
            {"Desk", "Skrivbord"},
            {"Chair", "Stol"},
            {"Window", "Fönster"},
            {"Door", "Dörr"},
            {"Floor", "Golv"},
            {"Ceiling", "Tak"},
            {"Wall", "Vägg"},
            {"Roof", "Tak"},
            {"Garden", "Trädgård"},
            {"Yard", "Gård"},
            {"Fence", "Staket"},
            {"Gate", "Grind"},
            {"Driveway", "Uppfart"},
            {"Path", "Stig"},
            {"Patio", "Uteplats"},
            {"Deck", "Altan"},
            {"Balcony", "Balkong"},
            {"Pool", "Pool"},
            {"Porch", "Veranda"},
            {"Basement", "Källare"},
            {"Attic", "Vind"},
            {"Hallway", "Korridor"},
            {"Living Room", "Vardagsrum"},
            {"Bedroom", "Sovrum"},
            {"Kitchen", "Kök"},
            {"Bathroom", "Badrum"},
            {"Dining Room", "Matsal"},
            {"Office", "Kontor"},
            {"Guest Room", "Gästrum"},
            {"Laundry Room", "Tvättstuga"},
            {"Closet", "Garderob"},
            {"Pantry", "Skafferi"},
            {"Plate", "Tallrik"},
            {"Glass", "Glas"},
            {"Cup", "Kopp"},
            {"Fork", "Gaffel"},
            {"Knife", "Kniv"},
            {"Spoon", "Sked"},
            {"Bowl", "Skål"},
            {"Bottle", "Flaska"},
            {"Napkin", "Servett"},
            {"Towel", "Handduk"},
            {"Soap", "Tvål"},
            {"Shampoo", "Schampo"},
            {"Toothbrush", "Tandborste"},
            {"Toothpaste", "Tandkräm"},
            {"Comb", "Kam"},
            {"Brush", "Borste"},
            {"Mirror", "Spegel"},
            {"Bed", "Säng"},
            {"Pillow", "Kudde"},
            {"Blanket", "Filt"},
            {"Sheet", "Lakan"},
            {"Dresser", "Byrå"},
            {"Nightstand", "Nattduksbord"},
            {"Lamp", "Lampa"},
            {"Clock", "Klocka"},
            {"Fan", "Fläkt"},
            {"Heater", "Värmare"},
            {"Trash Can", "Soptunna"},
            {"Broom", "Kvast"},
            {"Mop", "Mopp"},
            {"Vacuum", "Dammsugare"},
            {"Bucket", "Hink"},
            {"Detergent", "Tvättmedel"},
            {"Rug", "Matta"},
            {"Curtain", "Gardin"}
        };
        private Dictionary<string, string> wordsSwedishToEnglish = new Dictionary<string, string>();
        private int score = 0;
        private int ledtråd = 3;
        private int hemlisTryck = 0;
        private string currentWord;
        private string correctTranslation;
        private Random random = new Random();


        private int record;

        public Form2(int initialRecord)
        {
            InitializeComponent();
            this.record = initialRecord;
            foreach (var pair in wordsEnglishToSwedish)
            {
                wordsSwedishToEnglish[pair.Value] = pair.Key;
            }
            StartGame();
        }
        private void StartGame()
        {
            if (Settings.TranslateEnglishToSwedish)
            {
                // Väljer ett random engelskt ord
                int index = random.Next(wordsEnglishToSwedish.Count);
                currentWord = new List<string>(wordsEnglishToSwedish.Keys)[index];
                correctTranslation = wordsEnglishToSwedish[currentWord];
            }
            else
            {
                // Svenska till Engelska
                int index = random.Next(wordsSwedishToEnglish.Count);
                currentWord = new List<string>(wordsSwedishToEnglish.Keys)[index];
                correctTranslation = wordsSwedishToEnglish[currentWord];
            }
            // Visar ordet i labeln
            wordLabel.Text = currentWord;
            translationTextBox.Text = "";
            ledtrådLabel.Text = ledtråd.ToString();
        }
        private void checkButton_Click_1(object sender, EventArgs e)
        {
            CheckTranslation();
        }
        private void CheckTranslation()
        {
            string userTranslation = translationTextBox.Text.Trim().ToLower();
            if (userTranslation == correctTranslation.ToLower())
            {
                score++;
                MessageBox.Show($"Correct! Översättningen av '{currentWord}' är '{correctTranslation}'.", "Correct", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StartGame();
                scoreShow.Text = score.ToString();
                if (score >= 10)
                {
                    this.Fire.Visible = true;
                    if (score >= 20)
                    {
                        this.Fire.Visible = false;
                        this.Fire2.Visible = true;
                        if (score == 100)
                        {
                            MessageBox.Show("Det här är väldigt imponerande!");
                            MessageBox.Show("Du har nu låst upp en prestation i huvudmenyn!");
                        }
                    }
                }
            }
            else if (userTranslation == "kevinkevinkevin2024")
            {
                MessageBox.Show("Du fick 100 poäng!!!");
                score = 100;
            }
            else
            {
                if (score > record)
                {
                    record = score;
                    GameOver?.Invoke(this, record);
                }
                MessageBox.Show($"Incorrect! Översättningen av '{currentWord}' är '{correctTranslation}'.", "Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Du fick " + score + " poäng");
                score = 0;
                scoreShow.Text = score.ToString();
                this.Close();
            }
        }

        private void translationTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckTranslation();
                e.SuppressKeyPress = true;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            record = score; GameOver?.Invoke(this, record);
            this.Close();
        }

        private void hintButton_Click(object sender, EventArgs e)
        {
            ledtråd--;
            ledtrådLabel.Text = ledtråd.ToString();
            if (ledtråd >= 0)
            {
                ShowHint();
            }
            else
            {
                ledtrådLabel.Text = "0";
                MessageBox.Show("Du har slut på ledtrådar");
            }
        }
        private void ShowHint()
        {
            if (!string.IsNullOrEmpty(correctTranslation))
            {
                string hint = correctTranslation.Substring(0, 2);
                MessageBox.Show($"Ledtråd: ´De första bokstäverna är '{hint}'", "Ledtråd", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Fire2_Click(object sender, EventArgs e)
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
}
