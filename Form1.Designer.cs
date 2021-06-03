
namespace Alien_Blastar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ammo = new System.Windows.Forms.Label();
            this.Kills = new System.Windows.Forms.Label();
            this.Health = new System.Windows.Forms.Label();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.YouWin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Ammo
            // 
            this.Ammo.AutoSize = true;
            this.Ammo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ammo.ForeColor = System.Drawing.SystemColors.Control;
            this.Ammo.Location = new System.Drawing.Point(16, 18);
            this.Ammo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ammo.Name = "Ammo";
            this.Ammo.Size = new System.Drawing.Size(79, 20);
            this.Ammo.TabIndex = 0;
            this.Ammo.Tag = "Ammo";
            this.Ammo.Text = "Ammo: 0";
            this.Ammo.Click += new System.EventHandler(this.Ammo_Click);
            // 
            // Kills
            // 
            this.Kills.AutoSize = true;
            this.Kills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Kills.ForeColor = System.Drawing.SystemColors.Control;
            this.Kills.Location = new System.Drawing.Point(240, 18);
            this.Kills.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Kills.Name = "Kills";
            this.Kills.Size = new System.Drawing.Size(61, 20);
            this.Kills.TabIndex = 0;
            this.Kills.Tag = "Kills";
            this.Kills.Text = "Kills: 0";
            this.Kills.Click += new System.EventHandler(this.Kills_Click);
            // 
            // Health
            // 
            this.Health.AutoSize = true;
            this.Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Health.ForeColor = System.Drawing.SystemColors.Control;
            this.Health.Location = new System.Drawing.Point(402, 18);
            this.Health.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Health.Name = "Health";
            this.Health.Size = new System.Drawing.Size(72, 20);
            this.Health.TabIndex = 0;
            this.Health.Tag = "Health";
            this.Health.Text = "Health: ";
            this.Health.Click += new System.EventHandler(this.Health_Click);
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(482, 13);
            this.HealthBar.Margin = new System.Windows.Forms.Padding(4);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(212, 25);
            this.HealthBar.TabIndex = 0;
            this.HealthBar.Tag = "HealthBar";
            this.HealthBar.Value = 100;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tag = "gameTimer";
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Alien_Blastar.Properties.Resources.Up;
            this.Player.Location = new System.Drawing.Point(284, 493);
            this.Player.Margin = new System.Windows.Forms.Padding(4);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(91, 77);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 1;
            this.Player.TabStop = false;
            this.Player.Tag = "Player";
            this.Player.Click += new System.EventHandler(this.Player_Click);
            // 
            // YouWin
            // 
            this.YouWin.AutoSize = true;
            this.YouWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YouWin.ForeColor = System.Drawing.SystemColors.Control;
            this.YouWin.Location = new System.Drawing.Point(549, 68);
            this.YouWin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YouWin.Name = "YouWin";
            this.YouWin.Size = new System.Drawing.Size(81, 20);
            this.YouWin.TabIndex = 0;
            this.YouWin.Tag = "You win lol";
            this.YouWin.Text = "You Win!";
            this.YouWin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.YouWin.Visible = false;
            this.YouWin.Click += new System.EventHandler(this.Kills_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(712, 583);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.Health);
            this.Controls.Add(this.YouWin);
            this.Controls.Add(this.Kills);
            this.Controls.Add(this.Ammo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Alien Blastar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ammo;
        private System.Windows.Forms.Label Kills;
        private System.Windows.Forms.Label Health;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label YouWin;
    }
}

