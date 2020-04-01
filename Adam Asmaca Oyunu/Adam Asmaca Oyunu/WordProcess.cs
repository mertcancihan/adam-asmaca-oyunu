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
    public partial class WordProcess : Form
    {
        public static WordProcess obj;
        bool wordDelete = false;
        public WordProcess()
        {
            InitializeComponent();
        }

        private void Score_Load(object sender, EventArgs e)
        {
            Database.obj.showToWord(listWord);
            createObj();
        }
        private void createObj()
        {
            if(obj == null)
            {
                obj = this;
            }
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            Database.obj.clearTextFile("words.txt");
            Database.obj.saveToWords(listWord, wordDelete);
            Database.obj.showToWord(listWord);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listWord.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Silinecek Kelimeyi Seçiniz!");
            }
            else
            {
                wordDelete = true;
                Database.obj.deleteToWord(listWord);
                Database.obj.clearTextFile("words.txt");
                Database.obj.saveToWords(listWord, wordDelete);
                Database.obj.showToWord(listWord);
                wordDelete = false;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register.obj.Show();
        }
    }
}
