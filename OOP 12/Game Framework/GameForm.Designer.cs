
namespace Game_Framework
{
    partial class GameForm
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
            this.timerGameLoop = new System.Windows.Forms.Timer(this.components);
            this.playerHealthBar = new System.Windows.Forms.ProgressBar();
            this.vEnemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.rEnemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.sEnemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.hEnemyHealthBar = new System.Windows.Forms.ProgressBar();
            this.pbEnemyCyanLbl = new System.Windows.Forms.PictureBox();
            this.pbPlayerLabel = new System.Windows.Forms.PictureBox();
            this.pbEnemyPurpleLbl = new System.Windows.Forms.PictureBox();
            this.pbEnemyYellowLbl = new System.Windows.Forms.PictureBox();
            this.pbEnemyRedLbl = new System.Windows.Forms.PictureBox();
            this.lblStrScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyCyanLbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyPurpleLbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyYellowLbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyRedLbl)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGameLoop
            // 
            this.timerGameLoop.Enabled = true;
            this.timerGameLoop.Tick += new System.EventHandler(this.timerGameLoop_Tick);
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.Location = new System.Drawing.Point(106, 671);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(179, 23);
            this.playerHealthBar.TabIndex = 0;
            this.playerHealthBar.Value = 100;
            // 
            // vEnemyHealthBar
            // 
            this.vEnemyHealthBar.Location = new System.Drawing.Point(923, 671);
            this.vEnemyHealthBar.Name = "vEnemyHealthBar";
            this.vEnemyHealthBar.Size = new System.Drawing.Size(179, 23);
            this.vEnemyHealthBar.TabIndex = 1;
            this.vEnemyHealthBar.Value = 100;
            this.vEnemyHealthBar.Visible = false;
            // 
            // rEnemyHealthBar
            // 
            this.rEnemyHealthBar.Location = new System.Drawing.Point(923, 671);
            this.rEnemyHealthBar.Name = "rEnemyHealthBar";
            this.rEnemyHealthBar.Size = new System.Drawing.Size(179, 23);
            this.rEnemyHealthBar.TabIndex = 2;
            this.rEnemyHealthBar.Value = 100;
            this.rEnemyHealthBar.Visible = false;
            // 
            // sEnemyHealthBar
            // 
            this.sEnemyHealthBar.Location = new System.Drawing.Point(923, 671);
            this.sEnemyHealthBar.Name = "sEnemyHealthBar";
            this.sEnemyHealthBar.Size = new System.Drawing.Size(179, 23);
            this.sEnemyHealthBar.TabIndex = 4;
            this.sEnemyHealthBar.Value = 100;
            this.sEnemyHealthBar.Visible = false;
            // 
            // hEnemyHealthBar
            // 
            this.hEnemyHealthBar.Location = new System.Drawing.Point(923, 671);
            this.hEnemyHealthBar.Name = "hEnemyHealthBar";
            this.hEnemyHealthBar.Size = new System.Drawing.Size(179, 23);
            this.hEnemyHealthBar.TabIndex = 3;
            this.hEnemyHealthBar.Value = 100;
            // 
            // pbEnemyCyanLbl
            // 
            this.pbEnemyCyanLbl.Image = global::Game_Framework.Properties.Resources.enemy_cyan;
            this.pbEnemyCyanLbl.Location = new System.Drawing.Point(841, 657);
            this.pbEnemyCyanLbl.Name = "pbEnemyCyanLbl";
            this.pbEnemyCyanLbl.Size = new System.Drawing.Size(60, 46);
            this.pbEnemyCyanLbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnemyCyanLbl.TabIndex = 6;
            this.pbEnemyCyanLbl.TabStop = false;
            this.pbEnemyCyanLbl.Visible = false;
            // 
            // pbPlayerLabel
            // 
            this.pbPlayerLabel.Image = global::Game_Framework.Properties.Resources.player;
            this.pbPlayerLabel.Location = new System.Drawing.Point(30, 657);
            this.pbPlayerLabel.Name = "pbPlayerLabel";
            this.pbPlayerLabel.Size = new System.Drawing.Size(60, 46);
            this.pbPlayerLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayerLabel.TabIndex = 5;
            this.pbPlayerLabel.TabStop = false;
            // 
            // pbEnemyPurpleLbl
            // 
            this.pbEnemyPurpleLbl.Image = global::Game_Framework.Properties.Resources.enemy_purple;
            this.pbEnemyPurpleLbl.Location = new System.Drawing.Point(841, 657);
            this.pbEnemyPurpleLbl.Name = "pbEnemyPurpleLbl";
            this.pbEnemyPurpleLbl.Size = new System.Drawing.Size(60, 46);
            this.pbEnemyPurpleLbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnemyPurpleLbl.TabIndex = 7;
            this.pbEnemyPurpleLbl.TabStop = false;
            this.pbEnemyPurpleLbl.Visible = false;
            // 
            // pbEnemyYellowLbl
            // 
            this.pbEnemyYellowLbl.Image = global::Game_Framework.Properties.Resources.enemy_yellow;
            this.pbEnemyYellowLbl.Location = new System.Drawing.Point(841, 657);
            this.pbEnemyYellowLbl.Name = "pbEnemyYellowLbl";
            this.pbEnemyYellowLbl.Size = new System.Drawing.Size(60, 46);
            this.pbEnemyYellowLbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnemyYellowLbl.TabIndex = 8;
            this.pbEnemyYellowLbl.TabStop = false;
            this.pbEnemyYellowLbl.Visible = false;
            // 
            // pbEnemyRedLbl
            // 
            this.pbEnemyRedLbl.Image = global::Game_Framework.Properties.Resources.enemy_red;
            this.pbEnemyRedLbl.Location = new System.Drawing.Point(841, 657);
            this.pbEnemyRedLbl.Name = "pbEnemyRedLbl";
            this.pbEnemyRedLbl.Size = new System.Drawing.Size(60, 46);
            this.pbEnemyRedLbl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnemyRedLbl.TabIndex = 9;
            this.pbEnemyRedLbl.TabStop = false;
            this.pbEnemyRedLbl.Visible = false;
            // 
            // lblStrScore
            // 
            this.lblStrScore.AutoSize = true;
            this.lblStrScore.Font = new System.Drawing.Font("Niagara Solid", 24.25F, System.Drawing.FontStyle.Bold);
            this.lblStrScore.ForeColor = System.Drawing.Color.Ivory;
            this.lblStrScore.Location = new System.Drawing.Point(475, 659);
            this.lblStrScore.Name = "lblStrScore";
            this.lblStrScore.Size = new System.Drawing.Size(76, 35);
            this.lblStrScore.TabIndex = 10;
            this.lblStrScore.Text = "Score: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Niagara Solid", 24.25F, System.Drawing.FontStyle.Bold);
            this.lblScore.ForeColor = System.Drawing.Color.Ivory;
            this.lblScore.Location = new System.Drawing.Point(557, 659);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 35);
            this.lblScore.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(86)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblStrScore);
            this.Controls.Add(this.pbEnemyRedLbl);
            this.Controls.Add(this.pbEnemyYellowLbl);
            this.Controls.Add(this.pbEnemyPurpleLbl);
            this.Controls.Add(this.pbEnemyCyanLbl);
            this.Controls.Add(this.pbPlayerLabel);
            this.Controls.Add(this.sEnemyHealthBar);
            this.Controls.Add(this.hEnemyHealthBar);
            this.Controls.Add(this.rEnemyHealthBar);
            this.Controls.Add(this.vEnemyHealthBar);
            this.Controls.Add(this.playerHealthBar);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyCyanLbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyPurpleLbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyYellowLbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnemyRedLbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerGameLoop;
        private System.Windows.Forms.ProgressBar playerHealthBar;
        private System.Windows.Forms.ProgressBar vEnemyHealthBar;
        private System.Windows.Forms.ProgressBar rEnemyHealthBar;
        private System.Windows.Forms.ProgressBar sEnemyHealthBar;
        private System.Windows.Forms.ProgressBar hEnemyHealthBar;
        private System.Windows.Forms.PictureBox pbPlayerLabel;
        private System.Windows.Forms.PictureBox pbEnemyCyanLbl;
        private System.Windows.Forms.PictureBox pbEnemyPurpleLbl;
        private System.Windows.Forms.PictureBox pbEnemyYellowLbl;
        private System.Windows.Forms.PictureBox pbEnemyRedLbl;
        private System.Windows.Forms.Label lblStrScore;
        private System.Windows.Forms.Label lblScore;
    }
}

