namespace Project
{
    partial class Welcome
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
            btnLogout = new Button();
            btnExit = new Button();
            btnAboutUs = new Button();
            btnDeveloperContact = new Button();
            btnSignup = new Button();
            btnLogin = new Button();
            btnHome = new Button();
            label1 = new Label();
            panelMain = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.AutoScroll = true;
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnAboutUs);
            panel1.Controls.Add(btnDeveloperContact);
            panel1.Controls.Add(btnSignup);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnHome);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(197, 816);
            panel1.TabIndex = 15;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ButtonShadow;
            btnLogout.Location = new Point(23, 387);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 50);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "&Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExit.BackColor = SystemColors.ButtonShadow;
            btnExit.Location = new Point(23, 754);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 50);
            btnExit.TabIndex = 8;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnAboutUs
            // 
            btnAboutUs.BackColor = SystemColors.ButtonShadow;
            btnAboutUs.Location = new Point(22, 313);
            btnAboutUs.Margin = new Padding(3, 4, 3, 4);
            btnAboutUs.Name = "btnAboutUs";
            btnAboutUs.Size = new Size(150, 50);
            btnAboutUs.TabIndex = 1;
            btnAboutUs.Text = "&About Us";
            btnAboutUs.UseVisualStyleBackColor = false;
            btnAboutUs.Click += btnAboutUs_Click;
            // 
            // btnDeveloperContact
            // 
            btnDeveloperContact.BackColor = SystemColors.ButtonShadow;
            btnDeveloperContact.Location = new Point(22, 239);
            btnDeveloperContact.Margin = new Padding(3, 4, 3, 4);
            btnDeveloperContact.Name = "btnDeveloperContact";
            btnDeveloperContact.Size = new Size(150, 50);
            btnDeveloperContact.TabIndex = 7;
            btnDeveloperContact.Text = "Developer &Contact";
            btnDeveloperContact.UseVisualStyleBackColor = false;
            btnDeveloperContact.Click += btnDeveloperContact_Click;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = SystemColors.ButtonShadow;
            btnSignup.Location = new Point(22, 165);
            btnSignup.Margin = new Padding(3, 4, 3, 4);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(150, 50);
            btnSignup.TabIndex = 3;
            btnSignup.Text = "&Signup";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ButtonShadow;
            btnLogin.Location = new Point(22, 89);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 50);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "&Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ButtonShadow;
            btnHome.Location = new Point(22, 15);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(150, 50);
            btnHome.TabIndex = 0;
            btnHome.Text = "&Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(617, 15);
            label1.Name = "label1";
            label1.Size = new Size(323, 25);
            label1.TabIndex = 16;
            label1.Text = "Car Parking Managment System";
            // 
            // panelMain
            // 
            panelMain.Location = new Point(197, 43);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1157, 774);
            panelMain.TabIndex = 17;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 817);
            Controls.Add(panelMain);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Welcome";
            Text = "Welcome";
            Load += Welcome_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Button btnExit;
        private Button btnAboutUs;
        private Button btnDeveloperContact;
        private Button btnSignup;
        private Button btnLogin;
        private Button btnHome;
        private Label label1;
        private Panel panelMain;
    }
}