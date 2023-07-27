
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txtBoxEnterName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxEnterName
            // 
            this.txtBoxEnterName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBoxEnterName.Font = new System.Drawing.Font("Microsoft YaHei", 14F);
            this.txtBoxEnterName.Location = new System.Drawing.Point(241, 54);
            this.txtBoxEnterName.Multiline = true;
            this.txtBoxEnterName.Name = "txtBoxEnterName";
            this.txtBoxEnterName.Size = new System.Drawing.Size(277, 33);
            this.txtBoxEnterName.TabIndex = 0;
            this.txtBoxEnterName.Text = "Hello World !!!";
            this.txtBoxEnterName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxEnterName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxEnterName;
    }
}

