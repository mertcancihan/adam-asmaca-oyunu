using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Asmaca_Oyunu
{
    public partial class Game : Form
    {
        public static Game obj;
        int LetNum, wrong_Right, picCont = 14,gameCont = 0;
        bool picControl = false; 
        public static int score = 0;
        String chosenWord;
        Register register = new Register();
        static char[] spareWord;
        Label[] letArray;
        Image[] image = new Image[15];

        public Game()
        {
            InitializeComponent();
        }

        void createObj()
        {
            if (obj == null)
                obj = this;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            createObj();
            letLabelVisible();
            wrongRight();
            wordToLetter();
            gettingPicture();
        }
        public int getScore()
        {
            int scoreNumber = score;
            return scoreNumber;
        }
        public void setScore(int scoreNum)
        {
            score = scoreNum;
        }
        private void gettingPicture()
        {
            for (int i = 1; i < 15; i++)
            {
                image[i] = Image.FromFile(@"picture/"+i+".png");
            }
            pictureBox.Image = image[14];
        }
        private void letLabelVisible() 
        {
            LetNum = register.getChosenLet();
            letArray = new Label[] { Let1, Let2, Let3, Let4, Let5, Let6, Let7, Let8, Let9, Let10, Let11 };
            for (int i = 0; i < LetNum; i++)
            {
                letArray[i].Visible = true;
            }
            chosenWord = Database.obj.chosenNumOfWord();
        }
        private void wrongRight() 
        {
            wrong_Right = Register.obj.getChosenLet() + 2;
            yanlisHak.Text = wrong_Right.ToString();
        }
        private void wordToLetter()
        {
            String word = Database.obj.chosenNumOfWord();
            spareWord = word.ToCharArray();
        }
        private void pictureControl()
        {
            if (Register.obj.getChosenLet() == 11)
            {
                pictureBox.Image = image[picCont];
                picCont--;
            }
            else if(Register.obj.getChosenLet() == 10)
            {
                if(picControl == false)
                {
                    picControl = true;
                    picCont-=1;
                }
                pictureBox.Image = image[picCont];
                picCont--;
            }
            else if (Register.obj.getChosenLet() == 9)
            {
                if (picControl == false)
                {
                    picControl = true;
                    picCont -= 2;
                }
                pictureBox.Image = image[picCont];
                picCont--;
            }
            else if (Register.obj.getChosenLet() == 8)
            {
                if (picControl == false)
                {
                    picControl = true;
                    picCont -= 3;
                }
                pictureBox.Image = image[picCont];
                picCont--;
            }
            else if (Register.obj.getChosenLet() == 7)
            {
                if (picControl == false)
                {
                    picControl = true;
                    picCont -= 4;
                }
                pictureBox.Image = image[picCont];
                picCont--;
            }
            else if (Register.obj.getChosenLet() == 6)
            {
                if (picControl == false)
                {
                    picControl = true;
                    picCont -= 5;
                }
                pictureBox.Image = image[picCont];
                picCont--;
            }
            else if (Register.obj.getChosenLet() == 5)
            {
                if (picControl == false)
                {
                    picControl = true;
                    picCont -= 6;
                }
                pictureBox.Image = image[picCont];
                picCont--;
            }
            else if (Register.obj.getChosenLet() == 4)
            {
                if (picControl == false)
                {
                    picControl = true;
                    picCont -= 7;
                }
                pictureBox.Image = image[picCont];
                picCont--;
            }
        }
        private void btnEnabled()
        {
            if(wrong_Right == -1)
            {
                btn_A.Enabled = false;
                btn_B.Enabled = false;
                btn_C.Enabled = false;
                btn_CC.Enabled = false;
                btn_D.Enabled = false;
                btn_E.Enabled = false;
                btn_F.Enabled = false;
                btn_G.Enabled = false;
                btn_GG.Enabled = false;
                btn_H.Enabled = false;
                btn_I.Enabled = false;
                btn_II.Enabled = false;
                btn_J.Enabled = false;
                btn_K.Enabled = false;
                btn_L.Enabled = false;
                btn_M.Enabled = false;
                btn_N.Enabled = false;
                btn_O.Enabled = false;
                btn_OO.Enabled = false;
                btn_P.Enabled = false;
                btn_R.Enabled = false;
                btn_S.Enabled = false;
                btn_SS.Enabled = false;
                btn_T.Enabled = false;
                btn_U.Enabled = false;
                btn_UU.Enabled = false;
                btn_V.Enabled = false;
                btn_Y.Enabled = false;
                btn_Z.Enabled = false;
            }
        }
        private void gameOver() 
        {
            if(gameCont == LetNum)
            {
                Score.obj.hideToList();
                MessageBox.Show("Tebrikler!", "Oyun Bitti");
                Score.obj.Show();
                this.Hide();
            }
            else if (wrong_Right == -1)
            {
                
                DialogResult secenek = MessageBox.Show("Yanlış hakkınız bitti! Oyunu tamamlayamadınız.", "Oyun Bitti", MessageBoxButtons.RetryCancel,MessageBoxIcon.Information); ;

                if (secenek == DialogResult.Retry)
                {
                    restartGame();
                }
                else if (secenek == DialogResult.Cancel)
                {
                    Score.obj.hideToList();
                    Score.obj.Show();
                    this.Hide();
                }
                else
                    restartGame();
                yanlisHak.Text = "Hakkınız kalmadı.";
            }
        }
        public void restartGame()
        {
            setScore(0);
            Register.obj.rastHarfSec.Enabled = true;
            Register.obj.harfSec.Enabled = true;
            Register.obj.LetNumLbl.Text = "Lütfen Harf Sayısı ve İsim Giriniz";
            Register.obj.Show();
            this.Close();
        }
        private void findToLetter(Button button, char upperCase, char lowerCase)
        {
            int i = 0, scoreControl = 0;
            while (i != LetNum)
            {
                if (spareWord[i] == upperCase || spareWord[i] == lowerCase)
                {
                    scoreControl = 1;
                    letArray[i].Text = upperCase.ToString();
                    letArray[i].Visible = true;
                    button.BackColor = Color.Green;                   
                    score += 10;
                    setScore(score);
                    scoreLbl.Text = score.ToString();
                    gameCont += 1;
                }
                else if (button.BackColor != Color.Green)
                {
                    button.BackColor = Color.Red;
                    if (scoreControl == 0)
                        scoreControl = 2;
                }
                if(i == (LetNum-1))
                    if(scoreControl == 2)
                    {
                        wrong_Right -= 1;
                        score -= 3;
                        setScore(score);
                        yanlisHak.Text = wrong_Right.ToString();
                        scoreLbl.Text = score.ToString();
                        pictureControl();
                        btnEnabled();
                        gameOver();
                    }
                i++;
            }
            if(gameCont == LetNum)
                gameOver();
            button.Enabled = false;
        }
        private void btn_restartGame_Click(object sender, EventArgs e)
        {
            restartGame();
        }
        private void btn_A_Click(object sender, EventArgs e)
        {
            findToLetter(btn_A, 'A', 'a');
        }
        private void btn_B_Click(object sender, EventArgs e)
        {
            findToLetter(btn_B, 'B', 'b');
        }
        private void btn_C_Click(object sender, EventArgs e)
        {
            findToLetter(btn_C, 'C', 'c');
        }
        private void btn_CC_Click(object sender, EventArgs e)
        {
            findToLetter(btn_CC, 'Ç', 'ç');
        }
        private void btn_D_Click(object sender, EventArgs e)
        {
            findToLetter(btn_D, 'D', 'd');
        }
        private void btn_E_Click(object sender, EventArgs e)
        {
            findToLetter(btn_E, 'E', 'e');
        }
        private void btn_F_Click(object sender, EventArgs e)
        {
            findToLetter(btn_F, 'F', 'f');
        }
        private void btn_G_Click(object sender, EventArgs e)
        {
            findToLetter(btn_G, 'G', 'g');
        }
        private void btn_GG_Click(object sender, EventArgs e)
        {
            findToLetter(btn_GG, 'Ğ', 'ğ');
        }
        private void btn_H_Click(object sender, EventArgs e)
        {
            findToLetter(btn_H, 'H', 'h');
        }
        private void btn_I_Click(object sender, EventArgs e)
        {
            findToLetter(btn_I, 'I', 'ı');
        }
        private void btn_II_Click(object sender, EventArgs e)
        {
            findToLetter(btn_II, 'İ', 'i');
        }
        private void btn_J_Click(object sender, EventArgs e)
        {
            findToLetter(btn_J, 'J', 'j');
        }
        private void btn_K_Click(object sender, EventArgs e)
        {
            findToLetter(btn_K, 'K', 'k');
        }
        private void btn_L_Click(object sender, EventArgs e)
        {
            findToLetter(btn_L, 'L', 'l');
        }
        private void btn_M_Click(object sender, EventArgs e)
        {
            findToLetter(btn_M, 'M', 'm');
        }
        private void btn_N_Click(object sender, EventArgs e)
        {
            findToLetter(btn_N, 'N', 'n');
        }
        private void btn_O_Click(object sender, EventArgs e)
        {
            findToLetter(btn_O, 'O', 'O');
        }
        private void btn_OO_Click(object sender, EventArgs e)
        {
            findToLetter(btn_OO, 'Ö', 'ö');
        }
        private void btn_P_Click(object sender, EventArgs e)
        {
            findToLetter(btn_P, 'P', 'p');
        }
        private void btn_R_Click(object sender, EventArgs e)
        {
            findToLetter(btn_R, 'R', 'r');
        }
        private void btn_S_Click(object sender, EventArgs e)
        {
            findToLetter(btn_S, 'S', 's');
        }
        private void btn_SS_Click(object sender, EventArgs e)
        {
            findToLetter(btn_SS, 'Ş', 'ş');
        }
        private void btn_T_Click(object sender, EventArgs e)
        {
            findToLetter(btn_T, 'T', 't');
        }
        private void btn_U_Click(object sender, EventArgs e)
        {
            findToLetter(btn_U, 'U', 'u');
        }
        private void btn_UU_Click(object sender, EventArgs e)
        {
            findToLetter(btn_UU, 'Ü', 'ü');
        }
        private void btn_V_Click(object sender, EventArgs e)
        {
            findToLetter(btn_V, 'V', 'v');
        }
        private void btn_Y_Click(object sender, EventArgs e)
        {
            findToLetter(btn_Y, 'Y', 'y');
        }
        private void btn_Z_Click(object sender, EventArgs e)
        {
            findToLetter(btn_Z, 'Z', 'z');
        }
    }
}
