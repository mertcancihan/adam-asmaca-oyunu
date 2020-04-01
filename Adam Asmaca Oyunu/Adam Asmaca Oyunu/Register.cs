using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Asmaca_Oyunu
{
    public partial class Register : Form
    {
        public static Register obj;

        private static int chosenLet = 0;
        public String name = null;

        public Register()
        {
            InitializeComponent();
        }

        void createObj()
        {
            if (obj == null)
            {
                obj = this;
            }
        }
        private void Register_Load(object sender, EventArgs e)
        {
            createObj();
            Database.obj.ReadToword();
            Database.obj.spareToWords();
        }
        private void oyunaBaslaBtn_Click(object sender, EventArgs e)
        {
            if (((harfSec.Enabled == false && harfNum.SelectedItem != null) || (rastHarfSec.Enabled == false)) && string.IsNullOrWhiteSpace(nameTxt.Text) == false)
            {
                name = nameTxt.Text;
                Game game = new Game();
                game.Show();
                this.Hide();
            }
            else
            {
                LetNumLbl.Text = "Lütfen Harf Sayısı ve İsim Giriniz";
                LetNumLbl.Visible = true;
                rastHarfSec.Enabled = true;
                harfSec.Enabled = true;
            }
        }
        public int getChosenLet() {
            int chosenLetter = chosenLet;
            return chosenLetter;
        }
        public void setChosenLet(int chosenNum) 
        {
            chosenLet = chosenNum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int chosenLetter = rnd.Next(4,12);
            LetNumLbl.Text = "Rastgele Seçilen Harf Sayısı : "+ chosenLetter.ToString();
            LetNumLbl.Visible = true;
            rastHarfSec.Enabled = false;
            harfSec.Enabled = false;

            setChosenLet(chosenLetter);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (harfNum.SelectedItem == null)
            {
                LetNumLbl.Text = "Lütfen Harf Sayısı Seçin";
                LetNumLbl.Visible = true;
            }
            else 
            {
                int chosenLetter = Int32.Parse(harfNum.SelectedItem.ToString());
                LetNumLbl.Text = "Seçilen Harf Sayısı : " + chosenLetter.ToString();
                LetNumLbl.Visible = true;
                rastHarfSec.Enabled = false;
                harfSec.Enabled = false;
                setChosenLet(chosenLetter);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WordProcess score = new WordProcess();
            score.Show();
            this.Hide();
        }
    }
}
