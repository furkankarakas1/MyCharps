﻿namespace çerezHighscore_örnek
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SCORE = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HİGHSCORE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "tıkla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 72);
            this.button2.TabIndex = 1;
            this.button2.Text = "restart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "score:";
            // 
            // SCORE
            // 
            this.SCORE.AutoSize = true;
            this.SCORE.Location = new System.Drawing.Point(369, 85);
            this.SCORE.Name = "SCORE";
            this.SCORE.Size = new System.Drawing.Size(13, 13);
            this.SCORE.TabIndex = 3;
            this.SCORE.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "High score:";
            // 
            // HİGHSCORE
            // 
            this.HİGHSCORE.AutoSize = true;
            this.HİGHSCORE.Location = new System.Drawing.Point(369, 122);
            this.HİGHSCORE.Name = "HİGHSCORE";
            this.HİGHSCORE.Size = new System.Drawing.Size(13, 13);
            this.HİGHSCORE.TabIndex = 5;
            this.HİGHSCORE.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 451);
            this.Controls.Add(this.HİGHSCORE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SCORE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "High score:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SCORE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label HİGHSCORE;
    }
}

