
namespace Game_Framework
{
    partial class VictoryForm
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
            this.lblCongrats = new System.Windows.Forms.Label();
            this.lblWon = new System.Windows.Forms.Label();
            this.cmdRestart = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.Font = new System.Drawing.Font("Niagara Solid", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrats.ForeColor = System.Drawing.Color.Ivory;
            this.lblCongrats.Location = new System.Drawing.Point(118, 77);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(540, 103);
            this.lblCongrats.TabIndex = 11;
            this.lblCongrats.Text = "CONGRATULATIONS !!!";
            // 
            // lblWon
            // 
            this.lblWon.AutoSize = true;
            this.lblWon.Font = new System.Drawing.Font("Niagara Solid", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWon.ForeColor = System.Drawing.Color.Ivory;
            this.lblWon.Location = new System.Drawing.Point(256, 194);
            this.lblWon.Name = "lblWon";
            this.lblWon.Size = new System.Drawing.Size(244, 103);
            this.lblWon.TabIndex = 12;
            this.lblWon.Text = "YOU WON";
            // 
            // cmdRestart
            // 
            this.cmdRestart.BackColor = System.Drawing.Color.MediumAquamarine;
            this.cmdRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdRestart.Font = new System.Drawing.Font("Noto Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRestart.ForeColor = System.Drawing.Color.Ivory;
            this.cmdRestart.Location = new System.Drawing.Point(95, 342);
            this.cmdRestart.Name = "cmdRestart";
            this.cmdRestart.Size = new System.Drawing.Size(142, 48);
            this.cmdRestart.TabIndex = 13;
            this.cmdRestart.Text = "Restart";
            this.cmdRestart.UseVisualStyleBackColor = false;
            this.cmdRestart.Click += new System.EventHandler(this.cmdRestart_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdExit.Font = new System.Drawing.Font("Noto Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.ForeColor = System.Drawing.Color.Ivory;
            this.cmdExit.Location = new System.Drawing.Point(534, 342);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(142, 48);
            this.cmdExit.TabIndex = 14;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // VictoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdRestart);
            this.Controls.Add(this.lblWon);
            this.Controls.Add(this.lblCongrats);
            this.Name = "VictoryForm";
            this.Text = "VictoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.Label lblWon;
        private System.Windows.Forms.Button cmdRestart;
        private System.Windows.Forms.Button cmdExit;
    }
}