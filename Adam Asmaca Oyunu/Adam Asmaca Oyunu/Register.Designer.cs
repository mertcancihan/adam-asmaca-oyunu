namespace Adam_Asmaca_Oyunu
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.oyunaBaslaBtn = new System.Windows.Forms.Button();
            this.rastHarfSec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.harfNum = new System.Windows.Forms.ComboBox();
            this.LetNumLbl = new System.Windows.Forms.Label();
            this.harfSec = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsminizi Giriniz :";
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTxt.Location = new System.Drawing.Point(266, 57);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(186, 26);
            this.nameTxt.TabIndex = 1;
            // 
            // oyunaBaslaBtn
            // 
            this.oyunaBaslaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyunaBaslaBtn.Location = new System.Drawing.Point(229, 244);
            this.oyunaBaslaBtn.Name = "oyunaBaslaBtn";
            this.oyunaBaslaBtn.Size = new System.Drawing.Size(75, 58);
            this.oyunaBaslaBtn.TabIndex = 2;
            this.oyunaBaslaBtn.Text = "Oyuna Başla";
            this.oyunaBaslaBtn.UseVisualStyleBackColor = true;
            this.oyunaBaslaBtn.Click += new System.EventHandler(this.oyunaBaslaBtn_Click);
            // 
            // rastHarfSec
            // 
            this.rastHarfSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rastHarfSec.Location = new System.Drawing.Point(266, 137);
            this.rastHarfSec.Name = "rastHarfSec";
            this.rastHarfSec.Size = new System.Drawing.Size(75, 30);
            this.rastHarfSec.TabIndex = 10;
            this.rastHarfSec.Text = "Rastgele";
            this.rastHarfSec.UseVisualStyleBackColor = true;
            this.rastHarfSec.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rastgele Harf Sayısı Seç :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(70, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Harf Sayısı Seç :";
            // 
            // harfNum
            // 
            this.harfNum.FormattingEnabled = true;
            this.harfNum.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.harfNum.Location = new System.Drawing.Point(266, 100);
            this.harfNum.Name = "harfNum";
            this.harfNum.Size = new System.Drawing.Size(38, 21);
            this.harfNum.TabIndex = 7;
            // 
            // LetNumLbl
            // 
            this.LetNumLbl.AutoSize = true;
            this.LetNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LetNumLbl.Location = new System.Drawing.Point(154, 196);
            this.LetNumLbl.Name = "LetNumLbl";
            this.LetNumLbl.Size = new System.Drawing.Size(236, 20);
            this.LetNumLbl.TabIndex = 8;
            this.LetNumLbl.Text = "Lütfen Harf Sayısı ve İsim Giriniz";
            this.LetNumLbl.Visible = false;
            // 
            // harfSec
            // 
            this.harfSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.harfSec.Location = new System.Drawing.Point(310, 94);
            this.harfSec.Name = "harfSec";
            this.harfSec.Size = new System.Drawing.Size(50, 30);
            this.harfSec.TabIndex = 12;
            this.harfSec.Text = "Seç";
            this.harfSec.UseVisualStyleBackColor = true;
            this.harfSec.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(435, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Kelime Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.harfSec);
            this.Controls.Add(this.rastHarfSec);
            this.Controls.Add(this.LetNumLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.harfNum);
            this.Controls.Add(this.oyunaBaslaBtn);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button oyunaBaslaBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox harfNum;
        public System.Windows.Forms.Button rastHarfSec;
        public System.Windows.Forms.Label LetNumLbl;
        public System.Windows.Forms.Button harfSec;
        private System.Windows.Forms.Button button1;
    }
}

