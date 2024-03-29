namespace Project
{
    partial class ViewUser
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
            dataGridView1 = new DataGridView();
            First_Name = new DataGridViewTextBoxColumn();
            Last_Name = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            User_type = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { First_Name, Last_Name, Email, Phone, Password, User_type });
            dataGridView1.Location = new Point(30, 83);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(964, 606);
            dataGridView1.TabIndex = 1;
            // 
            // First_Name
            // 
            First_Name.HeaderText = "First Name";
            First_Name.MinimumWidth = 8;
            First_Name.Name = "First_Name";
            First_Name.Width = 150;
            // 
            // Last_Name
            // 
            Last_Name.HeaderText = "Last Name";
            Last_Name.MinimumWidth = 8;
            Last_Name.Name = "Last_Name";
            Last_Name.Width = 150;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.Width = 150;
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone no";
            Phone.MinimumWidth = 8;
            Phone.Name = "Phone";
            Phone.Width = 150;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 8;
            Password.Name = "Password";
            Password.Width = 150;
            // 
            // User_type
            // 
            User_type.HeaderText = "User Type";
            User_type.MinimumWidth = 8;
            User_type.Name = "User_type";
            User_type.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(462, 28);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 7;
            label1.Text = "User Details";
            // 
            // ViewUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 718);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ViewUser";
            Text = "ViewUser";
            Load += ViewUser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn First_Name;
        private DataGridViewTextBoxColumn Last_Name;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn User_type;
        private Label label1;
    }
}