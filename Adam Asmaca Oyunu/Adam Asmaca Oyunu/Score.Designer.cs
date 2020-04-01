namespace Adam_Asmaca_Oyunu
{
    partial class Score
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
            this.listScore = new System.Windows.Forms.ListBox();
            this.btn_restart = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_score = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listScore
            // 
            this.listScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listScore.FormattingEnabled = true;
            this.listScore.ItemHeight = 16;
            this.listScore.Location = new System.Drawing.Point(12, 58);
            this.listScore.Name = "listScore";
            this.listScore.ScrollAlwaysVisible = true;
            this.listScore.Size = new System.Drawing.Size(300, 292);
            this.listScore.TabIndex = 5;
            this.listScore.Visible = false;
            // 
            // btn_restart
            // 
            this.btn_restart.Location = new System.Drawing.Point(12, 361);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(75, 50);
            this.btn_restart.TabIndex = 6;
            this.btn_restart.Text = "Yeniden Başlat";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(237, 361);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 50);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Oyundan Çık";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "SKOR - İSİM";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(102, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "SKOR  TABLOSU";
            // 
            // btn_score
            // 
            this.btn_score.Location = new System.Drawing.Point(123, 58);
            this.btn_score.Name = "btn_score";
            this.btn_score.Size = new System.Drawing.Size(75, 50);
            this.btn_score.TabIndex = 6;
            this.btn_score.Text = "Skor Tablosu Göster";
            this.btn_score.UseVisualStyleBackColor = true;
            this.btn_score.Click += new System.EventHandler(this.btn_score_Click);
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_score);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.listScore);
            this.Name = "Score";
            this.Text = "Score";
            this.Load += new System.EventHandler(this.Score_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ListBox listScore;
        private System.Windows.Forms.Button btn_score;
    }
}