namespace Project
{
    partial class ForgotPassword
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
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            btnExit = new Button();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 157);
            label2.Name = "label2";
            label2.Size = new Size(309, 175);
            label2.TabIndex = 7;
            label2.Text = "Steps for forget password are:\r\n\r\nYou have to enter you email id \r\n\r\nYou will receive a mail verify your mail\r\n\r\nThen you can reset your password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(226, 59);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 27);
            txtEmail.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(85, 59);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 10;
            label1.Text = "Email Id";
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonShadow;
            btnExit.Location = new Point(484, 488);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 50);
            btnExit.TabIndex = 12;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = SystemColors.ButtonShadow;
            btnSubmit.Location = new Point(85, 488);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 50);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 653);
            Controls.Add(btnSubmit);
            Controls.Add(btnExit);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
        private Button btnExit;
        private Button btnSubmit;
    }
}