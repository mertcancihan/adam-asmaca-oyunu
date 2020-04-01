namespace Adam_Asmaca_Oyunu
{
    partial class WordProcess
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
            this.btn_addWord = new System.Windows.Forms.Button();
            this.btn_deleteWord = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listWord = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addWord
            // 
            this.btn_addWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_addWord.Location = new System.Drawing.Point(335, 61);
            this.btn_addWord.Name = "btn_addWord";
            this.btn_addWord.Size = new System.Drawing.Size(140, 32);
            this.btn_addWord.TabIndex = 1;
            this.btn_addWord.Text = "Kelime Ekle";
            this.btn_addWord.UseVisualStyleBackColor = true;
            this.btn_addWord.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_deleteWord
            // 
            this.btn_deleteWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_deleteWord.Location = new System.Drawing.Point(335, 99);
            this.btn_deleteWord.Name = "btn_deleteWord";
            this.btn_deleteWord.Size = new System.Drawing.Size(140, 27);
            this.btn_deleteWord.TabIndex = 2;
            this.btn_deleteWord.Text = "Kelime Sil";
            this.btn_deleteWord.UseVisualStyleBackColor = true;
            this.btn_deleteWord.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(335, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 3;
            // 
            // listWord
            // 
            this.listWord.FormattingEnabled = true;
            this.listWord.Location = new System.Drawing.Point(12, 12);
            this.listWord.Name = "listWord";
            this.listWord.Size = new System.Drawing.Size(307, 394);
            this.listWord.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(353, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kelime Giriniz";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(400, 383);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Geri";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // WordProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listWord);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_deleteWord);
            this.Controls.Add(this.btn_addWord);
            this.Name = "WordProcess";
            this.Text = "Score";
            this.Load += new System.EventHandler(this.Score_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_addWord;
        private System.Windows.Forms.Button btn_deleteWord;
        private System.Windows.Forms.ListBox listWord;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_back;
    }
}