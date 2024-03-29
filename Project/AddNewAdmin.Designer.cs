namespace Project
{
    partial class AddNewAdmin
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
            btnAdd = new Button();
            txtCnfPassword = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtLName = new TextBox();
            txtFName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            txtPhone = new TextBox();
            label7 = new Label();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonShadow;
            btnAdd.Location = new Point(22, 419);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(196, 44);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCnfPassword
            // 
            txtCnfPassword.Location = new Point(264, 356);
            txtCnfPassword.Margin = new Padding(3, 4, 3, 4);
            txtCnfPassword.Name = "txtCnfPassword";
            txtCnfPassword.Size = new Size(241, 27);
            txtCnfPassword.TabIndex = 5;
            txtCnfPassword.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(263, 292);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(241, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(262, 163);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(243, 27);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 361);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 2;
            label3.Text = "Re-enter the password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 301);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Create a Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 168);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Email id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(310, 84);
            label4.Name = "label4";
            label4.Size = new Size(165, 20);
            label4.TabIndex = 13;
            label4.Text = "Create an Account";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(264, 98);
            txtLName.Margin = new Padding(3, 4, 3, 4);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(241, 27);
            txtLName.TabIndex = 11;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(262, 39);
            txtFName.Margin = new Padding(3, 4, 3, 4);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(242, 27);
            txtFName.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 107);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 9;
            label6.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 46);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 8;
            label5.Text = "First Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtLName);
            groupBox1.Controls.Add(txtFName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtCnfPassword);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(264, 129);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(607, 496);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Admin";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(261, 231);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(243, 27);
            txtPhone.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 236);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 12;
            label7.Text = "Phone No.";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ButtonShadow;
            btnCancel.Location = new Point(309, 419);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(196, 44);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddNewAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 708);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "AddNewAdmin";
            Text = "AddNewAdmin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtCnfPassword;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox txtLName;
        private TextBox txtFName;
        private Label label6;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox txtPhone;
        private Label label7;
        private Button btnCancel;
    }
}