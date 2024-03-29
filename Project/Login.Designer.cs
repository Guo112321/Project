namespace Paradise_Car_Park_System
{
    partial class Login
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
            panel1 = new Panel();
            btnForgot = new Button();
            pictureBox1 = new PictureBox();
            textBox3 = new TextBox();
            btnLogin = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btnForgot);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(7, 10);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1358, 824);
            panel1.TabIndex = 0;
            // 
            // btnForgot
            // 
            btnForgot.BackColor = SystemColors.ButtonShadow;
            btnForgot.Location = new Point(292, 319);
            btnForgot.Margin = new Padding(3, 4, 3, 4);
            btnForgot.Name = "btnForgot";
            btnForgot.Size = new Size(121, 42);
            btnForgot.TabIndex = 22;
            btnForgot.Text = "Forgot Password";
            btnForgot.UseVisualStyleBackColor = false;
            btnForgot.Click += btnForgot_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.InactiveCaption;
            pictureBox1.Location = new Point(809, 138);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveCaption;
            textBox3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(782, 72);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(368, 531);
            textBox3.TabIndex = 17;
            textBox3.Text = "  WELCOME TO PARASITE CAR PARKING ";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ButtonShadow;
            btnLogin.Location = new Point(506, 323);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(131, 38);
            btnLogin.TabIndex = 16;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(438, 179);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(199, 27);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(431, 86);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 27);
            textBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 183);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 13;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 92);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 12;
            label1.Text = "Email id";
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 844);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login ";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnForgot;
        private PictureBox pictureBox1;
        private TextBox textBox3;
        private Button btnLogin;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
    }
}