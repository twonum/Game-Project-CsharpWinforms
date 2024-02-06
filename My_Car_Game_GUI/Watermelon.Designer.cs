namespace My_Car_Game_GUI
{
    partial class Watermelon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Watermelon));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreLBL = new System.Windows.Forms.Label();
            this.gameOverLBL = new System.Windows.Forms.Label();
            this.finalBase = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.coin1 = new System.Windows.Forms.PictureBox();
            this.coin3 = new System.Windows.Forms.PictureBox();
            this.coin2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.base1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.castle = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.finalBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.base1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.castle)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreLBL
            // 
            this.scoreLBL.AutoSize = true;
            this.scoreLBL.BackColor = System.Drawing.Color.Black;
            this.scoreLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLBL.ForeColor = System.Drawing.Color.Yellow;
            this.scoreLBL.Location = new System.Drawing.Point(541, 9);
            this.scoreLBL.Name = "scoreLBL";
            this.scoreLBL.Size = new System.Drawing.Size(85, 22);
            this.scoreLBL.TabIndex = 9;
            this.scoreLBL.Text = "Score: 0";
            // 
            // gameOverLBL
            // 
            this.gameOverLBL.AutoSize = true;
            this.gameOverLBL.BackColor = System.Drawing.Color.Gray;
            this.gameOverLBL.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameOverLBL.Location = new System.Drawing.Point(316, 195);
            this.gameOverLBL.Name = "gameOverLBL";
            this.gameOverLBL.Size = new System.Drawing.Size(301, 62);
            this.gameOverLBL.TabIndex = 11;
            this.gameOverLBL.Text = "Game Over";
            this.gameOverLBL.Click += new System.EventHandler(this.gameOverLBL_Click);
            // 
            // finalBase
            // 
            this.finalBase.BackColor = System.Drawing.Color.Black;
            this.finalBase.Image = ((System.Drawing.Image)(resources.GetObject("finalBase.Image")));
            this.finalBase.Location = new System.Drawing.Point(765, 108);
            this.finalBase.Name = "finalBase";
            this.finalBase.Size = new System.Drawing.Size(164, 12);
            this.finalBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finalBase.TabIndex = 4;
            this.finalBase.TabStop = false;
            this.finalBase.Tag = "";
            // 
            // ground
            // 
            this.ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(0, 403);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(932, 50);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 10;
            this.ground.TabStop = false;
            // 
            // coin1
            // 
            this.coin1.Image = ((System.Drawing.Image)(resources.GetObject("coin1.Image")));
            this.coin1.Location = new System.Drawing.Point(389, 86);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(30, 30);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 8;
            this.coin1.TabStop = false;
            this.coin1.Tag = "coin";
            // 
            // coin3
            // 
            this.coin3.Image = global::My_Car_Game_GUI.Properties.Resources._2;
            this.coin3.Location = new System.Drawing.Point(705, 304);
            this.coin3.Name = "coin3";
            this.coin3.Size = new System.Drawing.Size(30, 30);
            this.coin3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin3.TabIndex = 7;
            this.coin3.TabStop = false;
            this.coin3.Tag = "coin";
            // 
            // coin2
            // 
            this.coin2.Image = global::My_Car_Game_GUI.Properties.Resources._1;
            this.coin2.Location = new System.Drawing.Point(341, 216);
            this.coin2.Name = "coin2";
            this.coin2.Size = new System.Drawing.Size(30, 30);
            this.coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin2.TabIndex = 6;
            this.coin2.TabStop = false;
            this.coin2.Tag = "coin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(705, 351);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Base";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Base";
            // 
            // base1
            // 
            this.base1.BackColor = System.Drawing.Color.Black;
            this.base1.Image = ((System.Drawing.Image)(resources.GetObject("base1.Image")));
            this.base1.Location = new System.Drawing.Point(12, 279);
            this.base1.Name = "base1";
            this.base1.Size = new System.Drawing.Size(224, 19);
            this.base1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.base1.TabIndex = 1;
            this.base1.TabStop = false;
            this.base1.Tag = "Base";
            // 
            // player
            // 
            this.player.Image = global::My_Car_Game_GUI.Properties.Resources.Idle__2_;
            this.player.Location = new System.Drawing.Point(12, 195);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(68, 87);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // castle
            // 
            this.castle.Image = ((System.Drawing.Image)(resources.GetObject("castle.Image")));
            this.castle.Location = new System.Drawing.Point(820, 35);
            this.castle.Name = "castle";
            this.castle.Size = new System.Drawing.Size(100, 76);
            this.castle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.castle.TabIndex = 5;
            this.castle.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Watermelon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(932, 453);
            this.Controls.Add(this.finalBase);
            this.Controls.Add(this.gameOverLBL);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.scoreLBL);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.coin3);
            this.Controls.Add(this.coin2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.base1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.castle);
            this.DoubleBuffered = true;
            this.Name = "Watermelon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watermelon";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Watermelon_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.finalBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.base1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.castle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox base1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox finalBase;
        private System.Windows.Forms.PictureBox castle;
        private System.Windows.Forms.PictureBox coin2;
        private System.Windows.Forms.PictureBox coin3;
        private System.Windows.Forms.PictureBox coin1;
        private System.Windows.Forms.Label scoreLBL;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label gameOverLBL;
        private System.Windows.Forms.Timer timer2;
    }
}