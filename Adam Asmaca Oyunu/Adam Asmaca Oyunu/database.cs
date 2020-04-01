using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Asmaca_Oyunu
{
    public class Database
    {
        public static Database obj = new Database();
        public FileStream fs,fs2,fs3,fs4;
        public StreamReader sr;
        private String sendWord;
        private static int numWord4 = 0, numWord4_counter,
                numWord5 = 0, numWord5_counter,
                numWord6 = 0, numWord6_counter,
                numWord7 = 0, numWord7_counter,
                numWord8 = 0, numWord8_counter,
                numWord9 = 0, numWord9_counter,
                numWord10 = 0, numWord10_counter,
                numWord11 = 0, numWord11_counter;
        private static String[] word, word_4, word_5,
                               word_6, word_7, word_8,
                               word_9, word_10, word_11;
        

        public void ReadToword()
        {
            fs = new FileStream(@"words.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));

            word = new String[150];
            int a = 0;

            while (a != word.Length)
            {
                word[a] = "bos";
                a++;
            }
            int i = 0;

            while (sr.EndOfStream != true)
            {
                word[i] = sr.ReadLine();
                i++;
            }
            sr.Close();
        }
        private void newArray()
        {
            word_4 = new String[15];
            word_5 = new String[15];
            word_6 = new String[15];
            word_7 = new String[15];
            word_8 = new String[15];
            word_9 = new String[15];
            word_10 = new String[15];
            word_11 = new String[15];
        }
        public void spareToWords()
        {
            newArray();
            int k = 0;

            while (k != word.Length)
            {
                if (word[k].Length == 4)
                {
                    numWord4_counter = numWord4;
                    word_4[numWord4] = word[k];

                    while (numWord4_counter != word_4.Length)
                    {
                        word_4[numWord4_counter] = word[k];
                        numWord4_counter++;
                    }
                    numWord4++;
                }
                else if (word[k].Length == 5)
                {
                    numWord5_counter = numWord5;
                    word_5[numWord5] = word[k];

                    while (numWord5_counter != word_5.Length)
                    {
                        word_5[numWord5_counter] = word[k];
                        numWord5_counter++;
                    }
                    numWord5++;
                }
                else if (word[k].Length == 6)
                {
                    numWord6_counter = numWord6;
                    word_6[numWord5] = word[k];

                    while (numWord6_counter != word_6.Length)
                    {
                        word_6[numWord6_counter] = word[k];
                        numWord6_counter++;
                    }
                    numWord6++;
                }
                else if (word[k].Length == 7)
                {
                    numWord7_counter = numWord7;
                    word_7[numWord7] = word[k];

                    while (numWord7_counter != word_7.Length)
                    {
                        word_7[numWord7_counter] = word[k];
                        numWord7_counter++;
                    }
                    numWord7++;
                }
                else if (word[k].Length == 8)
                {
                    numWord8_counter = numWord8;
                    word_8[numWord8] = word[k];

                    while (numWord8_counter != word_8.Length)
                    {
                        word_8[numWord8_counter] = word[k];
                        numWord8_counter++;
                    }
                    numWord8++;
                }
                else if (word[k].Length == 9)
                {
                    numWord9_counter = numWord9;
                    word_9[numWord9] = word[k];

                    while (numWord9_counter != word_9.Length)
                    {
                        word_9[numWord9_counter] = word[k];
                        numWord9_counter++;
                    }
                    numWord9++;
                }
                else if (word[k].Length == 10)
                {
                    numWord10_counter = numWord10;
                    word_10[numWord10] = word[k];

                    while (numWord10_counter != word_10.Length)
                    {
                        word_10[numWord10_counter] = word[k];
                        numWord10_counter++;
                    }
                    numWord10++;
                }
                else if (word[k].Length == 11)
                {
                    numWord11_counter = numWord11;
                    word_11[numWord11] = word[k];

                    while (numWord11_counter != word_11.Length)
                    {
                        word_10[numWord11_counter] = word[k];
                        numWord11_counter++;
                    }
                    numWord11++;
                }
                k++;
            }
        }
        public String chosenNumOfWord()
        {
            Random rand = new Random();
            int chosenNum = Register.obj.getChosenLet(), chosenWord;

            if (chosenNum == 4)
            {
                chosenWord = rand.Next(0, numWord4 + 1);
                sendWord = word_4[chosenWord];
            }
            else if (chosenNum == 5)
            {
                chosenWord = rand.Next(0, numWord5 + 1);
                sendWord = word_5[chosenWord];
            }
            else if (chosenNum == 6)
            {
                chosenWord = rand.Next(0, numWord6 + 1);
                sendWord = word_6[chosenWord];
            }
            else if (chosenNum == 7)
            {
                chosenWord = rand.Next(0, numWord7 + 1);
                sendWord = word_7[chosenWord];
            }
            else if (chosenNum == 8)
            {
                chosenWord = rand.Next(0, numWord8 + 1);
                sendWord = word_8[chosenWord];
            }
            else if (chosenNum == 9)
            {
                chosenWord = rand.Next(0, numWord9 + 1);
                sendWord = word_9[chosenWord];
            }
            else if (chosenNum == 10)
            {
                chosenWord = rand.Next(0, numWord10 + 1);
                sendWord = word_10[chosenWord];
            }
            else if (chosenNum == 11)
            {
                chosenWord = rand.Next(0, numWord11 + 1);
                sendWord = word_11[chosenWord];
            }

            return sendWord;
        }
        public void showToWord(ListBox listbox)
        {
            listbox.Items.Clear();
            fs = new FileStream(@"words.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("windows-1254"));
            string word = sr.ReadLine();
            while (word != null)
            {
                listbox.Items.Add(word);
                word = sr.ReadLine();
            }
            sr.Close();
        }
        public void deleteToWord(ListBox listbox)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listbox);
            selectedItems = listbox.SelectedItems;

            if (listbox.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    listbox.Items.Remove(selectedItems[i]);
            }
        }
        public void saveToWords(ListBox listbox, bool wordDelete)
        {
            fs2 = new FileStream(@"words.txt", FileMode.OpenOrCreate, FileAccess.Write);
            if(wordDelete == false)
                listbox.Items.Add(WordProcess.obj.textBox1.Text);
            StreamWriter SaveFile = new StreamWriter(fs2, Encoding.GetEncoding("windows-1254"));
            foreach (var item in listbox.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.Close();
        }
        public void clearTextFile(String filePath)
        {
            File.Delete(@filePath);
        }
        public void showScoreList(ListBox listScore)
        {
            listScore.Items.Clear();
            fs3 = new FileStream(@"scoreList.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs3, Encoding.GetEncoding("windows-1254"));
            string name = sr.ReadLine();
            while (name != null)
            {
                listScore.Items.Add(name);
                name = sr.ReadLine();
            }
            sr.Close();
        }
        public void saveToScore(ListBox listScore)
        {
            fs4 = new FileStream(@"scoreList.txt", FileMode.OpenOrCreate, FileAccess.Write);
            listScore.Items.Add("  "+Game.obj.getScore() +" --- "+ Register.obj.name);
            StreamWriter SaveFile = new StreamWriter(fs4, Encoding.GetEncoding("windows-1254"));
            foreach (var item in listScore.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.Close();
        }
    }
}
