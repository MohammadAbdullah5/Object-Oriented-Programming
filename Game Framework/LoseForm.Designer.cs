
namespace Game_Framework
{
    partial class LoseForm
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
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdRestart = new System.Windows.Forms.Button();
            this.lblWon = new System.Windows.Forms.Label();
            this.lblCongrats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.Firebrick;
            this.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdExit.Font = new System.Drawing.Font("Noto Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.ForeColor = System.Drawing.Color.Ivory;
            this.cmdExit.Location = new System.Drawing.Point(549, 335);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(142, 48);
            this.cmdExit.TabIndex = 18;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdRestart
            // 
            this.cmdRestart.BackColor = System.Drawing.Color.Firebrick;
            this.cmdRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRestart.Font = new System.Drawing.Font("Noto Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRestart.ForeColor = System.Drawing.Color.Ivory;
            this.cmdRestart.Location = new System.Drawing.Point(110, 335);
            this.cmdRestart.Name = "cmdRestart";
            this.cmdRestart.Size = new System.Drawing.Size(142, 48);
            this.cmdRestart.TabIndex = 17;
            this.cmdRestart.Text = "Restart";
            this.cmdRestart.UseVisualStyleBackColor = false;
            this.cmdRestart.Click += new System.EventHandler(this.cmdRestart_Click);
            // 
            // lblWon
            // 
            this.lblWon.AutoSize = true;
            this.lblWon.Font = new System.Drawing.Font("Niagara Solid", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWon.ForeColor = System.Drawing.Color.Ivory;
            this.lblWon.Location = new System.Drawing.Point(253, 187);
            this.lblWon.Name = "lblWon";
            this.lblWon.Size = new System.Drawing.Size(280, 103);
            this.lblWon.TabIndex = 16;
            this.lblWon.Text = "TRY AGAIN";
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.Font = new System.Drawing.Font("Niagara Solid", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrats.ForeColor = System.Drawing.Color.Ivory;
            this.lblCongrats.Location = new System.Drawing.Point(162, 68);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(465, 103);
            this.lblCongrats.TabIndex = 15;
            this.lblCongrats.Text = "OOPS !!! YOU LOST";
            // 
            // LoseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdRestart);
            this.Controls.Add(this.lblWon);
            this.Controls.Add(this.lblCongrats);
            this.Name = "LoseForm";
            this.Text = "LoseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdRestart;
        private System.Windows.Forms.Label lblWon;
        private System.Windows.Forms.Label lblCongrats;
    }
}