namespace car_game
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.over = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.PictureBox();
            this.c2 = new System.Windows.Forms.PictureBox();
            this.c3 = new System.Windows.Forms.PictureBox();
            this.c4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.HS = new System.Windows.Forms.Label();
            this.RESTART = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Maroon;
            this.enemy3.Image = global::car_game.Properties.Resources.indir2;
            this.enemy3.Location = new System.Drawing.Point(297, 41);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(29, 53);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy3.TabIndex = 2;
            this.enemy3.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Maroon;
            this.enemy2.Image = global::car_game.Properties.Resources.indir2;
            this.enemy2.Location = new System.Drawing.Point(12, 41);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(29, 50);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy2.TabIndex = 2;
            this.enemy2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Maroon;
            this.enemy1.Image = global::car_game.Properties.Resources.indir2;
            this.enemy1.Location = new System.Drawing.Point(183, 44);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(29, 58);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy1.TabIndex = 2;
            this.enemy1.TabStop = false;
            // 
            // car
            // 
            this.car.Image = global::car_game.Properties.Resources.images;
            this.car.Location = new System.Drawing.Point(58, 237);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(43, 99);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.car.TabIndex = 1;
            this.car.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(183, 347);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(11, 115);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(183, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(11, 115);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(12, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(11, 462);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(183, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(11, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // over
            // 
            this.over.AutoSize = true;
            this.over.BackColor = System.Drawing.Color.Coral;
            this.over.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.over.Location = new System.Drawing.Point(114, 170);
            this.over.Name = "over";
            this.over.Size = new System.Drawing.Size(153, 31);
            this.over.TabIndex = 3;
            this.over.Text = "Game Over";
            this.over.Click += new System.EventHandler(this.over_Click);
            // 
            // c1
            // 
            this.c1.Image = global::car_game.Properties.Resources.images__1_;
            this.c1.Location = new System.Drawing.Point(71, 129);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(29, 30);
            this.c1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c1.TabIndex = 4;
            this.c1.TabStop = false;
            // 
            // c2
            // 
            this.c2.Image = global::car_game.Properties.Resources.images__1_;
            this.c2.Location = new System.Drawing.Point(120, 64);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(29, 30);
            this.c2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c2.TabIndex = 4;
            this.c2.TabStop = false;
            // 
            // c3
            // 
            this.c3.Image = global::car_game.Properties.Resources.images__1_;
            this.c3.Location = new System.Drawing.Point(238, 115);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(29, 30);
            this.c3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c3.TabIndex = 4;
            this.c3.TabStop = false;
            // 
            // c4
            // 
            this.c4.Image = global::car_game.Properties.Resources.images__1_;
            this.c4.Location = new System.Drawing.Point(273, 170);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(29, 30);
            this.c4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.c4.TabIndex = 4;
            this.c4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LawnGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coins=0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblScore.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Location = new System.Drawing.Point(126, 210);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(125, 22);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Your Score=0";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblHigh.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHigh.Location = new System.Drawing.Point(126, 247);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(115, 22);
            this.lblHigh.TabIndex = 6;
            this.lblHigh.Text = "High Score=";
            // 
            // HS
            // 
            this.HS.AutoSize = true;
            this.HS.BackColor = System.Drawing.Color.MediumTurquoise;
            this.HS.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HS.Location = new System.Drawing.Point(237, 247);
            this.HS.Name = "HS";
            this.HS.Size = new System.Drawing.Size(21, 22);
            this.HS.TabIndex = 7;
            this.HS.Text = "0";
            // 
            // RESTART
            // 
            this.RESTART.BackColor = System.Drawing.Color.Aqua;
            this.RESTART.Location = new System.Drawing.Point(143, 304);
            this.RESTART.Name = "RESTART";
            this.RESTART.Size = new System.Drawing.Size(81, 32);
            this.RESTART.TabIndex = 8;
            this.RESTART.Text = "Let\'s Restard";
            this.RESTART.UseVisualStyleBackColor = false;
            this.RESTART.Click += new System.EventHandler(this.RESTART_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(361, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(11, 462);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(384, 462);
            this.Controls.Add(this.RESTART);
            this.Controls.Add(this.HS);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.over);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.PictureBox c1;
        private System.Windows.Forms.PictureBox c2;
        private System.Windows.Forms.PictureBox c3;
        private System.Windows.Forms.PictureBox c4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.Label HS;
        private System.Windows.Forms.Button RESTART;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

