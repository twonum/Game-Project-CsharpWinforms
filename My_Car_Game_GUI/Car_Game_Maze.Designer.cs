namespace My_Car_Game_GUI
{
    partial class Car_Game_Maze
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameOverLBL = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pbHeart3 = new System.Windows.Forms.PictureBox();
            this.pbHeart2 = new System.Windows.Forms.PictureBox();
            this.pbHeart1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameOverLBL
            // 
            this.gameOverLBL.AutoSize = true;
            this.gameOverLBL.BackColor = System.Drawing.Color.Gray;
            this.gameOverLBL.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameOverLBL.Location = new System.Drawing.Point(679, 531);
            this.gameOverLBL.Name = "gameOverLBL";
            this.gameOverLBL.Size = new System.Drawing.Size(301, 62);
            this.gameOverLBL.TabIndex = 13;
            this.gameOverLBL.Text = "Game Over";
            this.gameOverLBL.Click += new System.EventHandler(this.gameOverLBL_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1270, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Lives";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1259, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Player Health";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.Color.Green;
            this.progressBar1.Location = new System.Drawing.Point(1262, 92);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(249, 23);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Value = 100;
            // 
            // pbHeart3
            // 
            this.pbHeart3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHeart3.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart3.Image = global::My_Car_Game_GUI.Properties.Resources._removal_ai__a57f3c40_39d6_465a_83fc_9df6986f68e8_heart;
            this.pbHeart3.Location = new System.Drawing.Point(1398, 208);
            this.pbHeart3.Name = "pbHeart3";
            this.pbHeart3.Size = new System.Drawing.Size(41, 28);
            this.pbHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeart3.TabIndex = 19;
            this.pbHeart3.TabStop = false;
            // 
            // pbHeart2
            // 
            this.pbHeart2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHeart2.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart2.Image = global::My_Car_Game_GUI.Properties.Resources._removal_ai__a57f3c40_39d6_465a_83fc_9df6986f68e8_heart;
            this.pbHeart2.Location = new System.Drawing.Point(1332, 208);
            this.pbHeart2.Name = "pbHeart2";
            this.pbHeart2.Size = new System.Drawing.Size(41, 28);
            this.pbHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeart2.TabIndex = 18;
            this.pbHeart2.TabStop = false;
            // 
            // pbHeart1
            // 
            this.pbHeart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHeart1.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart1.Image = global::My_Car_Game_GUI.Properties.Resources._removal_ai__a57f3c40_39d6_465a_83fc_9df6986f68e8_heart;
            this.pbHeart1.Location = new System.Drawing.Point(1262, 208);
            this.pbHeart1.Name = "pbHeart1";
            this.pbHeart1.Size = new System.Drawing.Size(41, 28);
            this.pbHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeart1.TabIndex = 17;
            this.pbHeart1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1270, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Lives";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1259, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Player Health";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::My_Car_Game_GUI.Properties.Resources._removal_ai__a57f3c40_39d6_465a_83fc_9df6986f68e8_heart;
            this.pictureBox1.Location = new System.Drawing.Point(1470, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1259, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Enemy Health";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1259, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 24;
            this.label7.Text = "Player Health";
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.BackColor = System.Drawing.Color.Green;
            this.progressBar2.Location = new System.Drawing.Point(1262, 383);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(249, 23);
            this.progressBar2.TabIndex = 23;
            this.progressBar2.Value = 100;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 400;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Car_Game_Maze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1582, 704);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbHeart3);
            this.Controls.Add(this.pbHeart2);
            this.Controls.Add(this.pbHeart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gameOverLBL);
            this.DoubleBuffered = true;
            this.Name = "Car_Game_Maze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car_Game_Maze";
            this.Load += new System.EventHandler(this.Car_Game_Maze_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label gameOverLBL;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pbHeart3;
        private System.Windows.Forms.PictureBox pbHeart2;
        private System.Windows.Forms.PictureBox pbHeart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer3;
    }
}