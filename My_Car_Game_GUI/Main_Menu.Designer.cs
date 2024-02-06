namespace My_Car_Game_GUI
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.btnCarGame = new System.Windows.Forms.Button();
            this.btnArrow_Game = new System.Windows.Forms.Button();
            this.btnTopDown_Game = new System.Windows.Forms.Button();
            this.btnCastle_Game = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gameOverLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCarGame
            // 
            this.btnCarGame.BackColor = System.Drawing.Color.Teal;
            this.btnCarGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarGame.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCarGame.Location = new System.Drawing.Point(256, 192);
            this.btnCarGame.Name = "btnCarGame";
            this.btnCarGame.Size = new System.Drawing.Size(268, 31);
            this.btnCarGame.TabIndex = 0;
            this.btnCarGame.Text = "Car Game";
            this.btnCarGame.UseVisualStyleBackColor = false;
            this.btnCarGame.Click += new System.EventHandler(this.btnCarGame_Click);
            // 
            // btnArrow_Game
            // 
            this.btnArrow_Game.BackColor = System.Drawing.Color.Teal;
            this.btnArrow_Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrow_Game.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArrow_Game.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnArrow_Game.Location = new System.Drawing.Point(256, 242);
            this.btnArrow_Game.Name = "btnArrow_Game";
            this.btnArrow_Game.Size = new System.Drawing.Size(268, 31);
            this.btnArrow_Game.TabIndex = 1;
            this.btnArrow_Game.Text = "Arrow Shooter";
            this.btnArrow_Game.UseVisualStyleBackColor = false;
            this.btnArrow_Game.Click += new System.EventHandler(this.btnArrow_Game_Click);
            // 
            // btnTopDown_Game
            // 
            this.btnTopDown_Game.BackColor = System.Drawing.Color.Teal;
            this.btnTopDown_Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTopDown_Game.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopDown_Game.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnTopDown_Game.Location = new System.Drawing.Point(256, 292);
            this.btnTopDown_Game.Name = "btnTopDown_Game";
            this.btnTopDown_Game.Size = new System.Drawing.Size(268, 33);
            this.btnTopDown_Game.TabIndex = 2;
            this.btnTopDown_Game.Text = "Top Down Game";
            this.btnTopDown_Game.UseVisualStyleBackColor = false;
            this.btnTopDown_Game.Click += new System.EventHandler(this.btnTopDown_Game_Click);
            // 
            // btnCastle_Game
            // 
            this.btnCastle_Game.BackColor = System.Drawing.Color.Teal;
            this.btnCastle_Game.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCastle_Game.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCastle_Game.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCastle_Game.Location = new System.Drawing.Point(256, 351);
            this.btnCastle_Game.Name = "btnCastle_Game";
            this.btnCastle_Game.Size = new System.Drawing.Size(268, 32);
            this.btnCastle_Game.TabIndex = 3;
            this.btnCastle_Game.Text = "Get into Castle Game";
            this.btnCastle_Game.UseVisualStyleBackColor = false;
            this.btnCastle_Game.Click += new System.EventHandler(this.btnCastle_Game_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Castellar", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Teal;
            this.btnExit.Location = new System.Drawing.Point(256, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(268, 28);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gameOverLBL
            // 
            this.gameOverLBL.AutoSize = true;
            this.gameOverLBL.BackColor = System.Drawing.Color.Gray;
            this.gameOverLBL.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameOverLBL.Location = new System.Drawing.Point(275, 44);
            this.gameOverLBL.Name = "gameOverLBL";
            this.gameOverLBL.Size = new System.Drawing.Size(219, 62);
            this.gameOverLBL.TabIndex = 12;
            this.gameOverLBL.Text = "Options";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameOverLBL);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCastle_Game);
            this.Controls.Add(this.btnTopDown_Game);
            this.Controls.Add(this.btnArrow_Game);
            this.Controls.Add(this.btnCarGame);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Menu";
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarGame;
        private System.Windows.Forms.Button btnArrow_Game;
        private System.Windows.Forms.Button btnTopDown_Game;
        private System.Windows.Forms.Button btnCastle_Game;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label gameOverLBL;
    }
}