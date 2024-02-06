namespace My_Car_Game_GUI
{
    partial class Player
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
            this.label1 = new System.Windows.Forms.Label();
            this.b3 = new System.Windows.Forms.PictureBox();
            this.b2 = new System.Windows.Forms.PictureBox();
            this.b1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Arrow = new System.Windows.Forms.PictureBox();
            this.gameOverLBL = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.b3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(119, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Score: 0";
            // 
            // b3
            // 
            this.b3.Image = global::My_Car_Game_GUI.Properties.Resources.balloon_3;
            this.b3.Location = new System.Drawing.Point(599, 167);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(31, 45);
            this.b3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.b3.TabIndex = 7;
            this.b3.TabStop = false;
            // 
            // b2
            // 
            this.b2.Image = global::My_Car_Game_GUI.Properties.Resources.balloon_2;
            this.b2.Location = new System.Drawing.Point(461, 167);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(31, 45);
            this.b2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.b2.TabIndex = 6;
            this.b2.TabStop = false;
            // 
            // b1
            // 
            this.b1.Image = global::My_Car_Game_GUI.Properties.Resources.balloon_1;
            this.b1.Location = new System.Drawing.Point(332, 167);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(31, 45);
            this.b1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.b1.TabIndex = 5;
            this.b1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(79, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(156, 41);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::My_Car_Game_GUI.Properties.Resources.idle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Arrow
            // 
            this.Arrow.Image = global::My_Car_Game_GUI.Properties.Resources.arrow;
            this.Arrow.Location = new System.Drawing.Point(123, 167);
            this.Arrow.Name = "Arrow";
            this.Arrow.Size = new System.Drawing.Size(63, 17);
            this.Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Arrow.TabIndex = 1;
            this.Arrow.TabStop = false;
            // 
            // gameOverLBL
            // 
            this.gameOverLBL.AutoSize = true;
            this.gameOverLBL.BackColor = System.Drawing.Color.Gray;
            this.gameOverLBL.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameOverLBL.Location = new System.Drawing.Point(251, 167);
            this.gameOverLBL.Name = "gameOverLBL";
            this.gameOverLBL.Size = new System.Drawing.Size(267, 62);
            this.gameOverLBL.TabIndex = 12;
            this.gameOverLBL.Text = "You Won";
            // 
            // timer2
            // 
            this.timer2.Interval = 2000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(785, 430);
            this.Controls.Add(this.gameOverLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Arrow);
            this.Name = "Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arrow Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Player_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Player_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.b3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Arrow;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox b1;
        private System.Windows.Forms.PictureBox b2;
        private System.Windows.Forms.PictureBox b3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gameOverLBL;
        private System.Windows.Forms.Timer timer2;
    }
}

