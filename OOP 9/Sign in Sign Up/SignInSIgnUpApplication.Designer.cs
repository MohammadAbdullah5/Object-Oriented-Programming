
namespace Sign_in_Sign_Up
{
    partial class SignInSIgnUpApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdBtnSignIn = new System.Windows.Forms.RadioButton();
            this.rdBtnsignUp = new System.Windows.Forms.RadioButton();
            this.nextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "SignIn SignUp Application";
            // 
            // rdBtnSignIn
            // 
            this.rdBtnSignIn.AutoSize = true;
            this.rdBtnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnSignIn.Location = new System.Drawing.Point(203, 186);
            this.rdBtnSignIn.Name = "rdBtnSignIn";
            this.rdBtnSignIn.Size = new System.Drawing.Size(90, 29);
            this.rdBtnSignIn.TabIndex = 1;
            this.rdBtnSignIn.TabStop = true;
            this.rdBtnSignIn.Text = "SignIn";
            this.rdBtnSignIn.UseVisualStyleBackColor = true;
            // 
            // rdBtnsignUp
            // 
            this.rdBtnsignUp.AutoSize = true;
            this.rdBtnsignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdBtnsignUp.Location = new System.Drawing.Point(456, 186);
            this.rdBtnsignUp.Name = "rdBtnsignUp";
            this.rdBtnsignUp.Size = new System.Drawing.Size(100, 29);
            this.rdBtnsignUp.TabIndex = 2;
            this.rdBtnsignUp.TabStop = true;
            this.rdBtnsignUp.Text = "SignUp";
            this.rdBtnsignUp.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(309, 252);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(139, 47);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseCompatibleTextRendering = true;
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // SignInSIgnUpApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.rdBtnsignUp);
            this.Controls.Add(this.rdBtnSignIn);
            this.Controls.Add(this.label1);
            this.Name = "SignInSIgnUpApplication";
            this.Text = "SignInSIgnUpApplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBtnSignIn;
        private System.Windows.Forms.RadioButton rdBtnsignUp;
        private System.Windows.Forms.Button nextBtn;
    }
}