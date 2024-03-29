namespace Paradise_Car_Park_System
{
    partial class Admin
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
            label1 = new Label();
            btnAddParkingLot = new Button();
            btnViewParkingLot = new Button();
            btnAddNewAdmin = new Button();
            btnViewTransection = new Button();
            lblUserId = new Label();
            lblBack = new Label();
            btnViewUsers = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(410, 39);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 0;
            label1.Text = "Admin Panel";
            // 
            // btnAddParkingLot
            // 
            btnAddParkingLot.Location = new Point(381, 114);
            btnAddParkingLot.Margin = new Padding(3, 4, 3, 4);
            btnAddParkingLot.Name = "btnAddParkingLot";
            btnAddParkingLot.Size = new Size(182, 55);
            btnAddParkingLot.TabIndex = 1;
            btnAddParkingLot.Text = "Add Parking Lot";
            btnAddParkingLot.UseVisualStyleBackColor = true;
            btnAddParkingLot.Click += btnAddParkingLot_Click;
            // 
            // btnViewParkingLot
            // 
            btnViewParkingLot.Location = new Point(381, 202);
            btnViewParkingLot.Margin = new Padding(3, 4, 3, 4);
            btnViewParkingLot.Name = "btnViewParkingLot";
            btnViewParkingLot.Size = new Size(182, 56);
            btnViewParkingLot.TabIndex = 2;
            btnViewParkingLot.Text = "View Parking Lot Status";
            btnViewParkingLot.UseVisualStyleBackColor = true;
            btnViewParkingLot.Click += btnViewParkingLot_Click;
            // 
            // btnAddNewAdmin
            // 
            btnAddNewAdmin.Location = new Point(381, 295);
            btnAddNewAdmin.Margin = new Padding(3, 4, 3, 4);
            btnAddNewAdmin.Name = "btnAddNewAdmin";
            btnAddNewAdmin.Size = new Size(182, 54);
            btnAddNewAdmin.TabIndex = 3;
            btnAddNewAdmin.Text = "Add New Admin";
            btnAddNewAdmin.UseVisualStyleBackColor = true;
            btnAddNewAdmin.Click += btnAddNewAdmin_Click;
            // 
            // btnViewTransection
            // 
            btnViewTransection.Location = new Point(381, 390);
            btnViewTransection.Margin = new Padding(3, 4, 3, 4);
            btnViewTransection.Name = "btnViewTransection";
            btnViewTransection.Size = new Size(182, 51);
            btnViewTransection.TabIndex = 4;
            btnViewTransection.Text = "View Transections";
            btnViewTransection.UseVisualStyleBackColor = true;
            btnViewTransection.Click += btnViewTransection_Click;
            // 
            // lblUserId
            // 
            lblUserId.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserId.AutoSize = true;
            lblUserId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserId.Location = new Point(855, 39);
            lblUserId.Name = "lblUserId";
            lblUserId.Size = new Size(77, 25);
            lblUserId.TabIndex = 5;
            lblUserId.Text = "User ID";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBack.Location = new Point(12, 39);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(56, 25);
            lblBack.TabIndex = 6;
            lblBack.Text = "Back";
            lblBack.Click += lblBack_Click;
            // 
            // btnViewUsers
            // 
            btnViewUsers.Location = new Point(381, 482);
            btnViewUsers.Margin = new Padding(3, 4, 3, 4);
            btnViewUsers.Name = "btnViewUsers";
            btnViewUsers.Size = new Size(182, 54);
            btnViewUsers.TabIndex = 7;
            btnViewUsers.Text = "View Users";
            btnViewUsers.UseVisualStyleBackColor = true;
            btnViewUsers.Click += btnViewUsers_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 597);
            Controls.Add(btnViewUsers);
            Controls.Add(lblBack);
            Controls.Add(lblUserId);
            Controls.Add(btnViewTransection);
            Controls.Add(btnAddNewAdmin);
            Controls.Add(btnViewParkingLot);
            Controls.Add(btnAddParkingLot);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin";
            Text = "Form1";
            Load += Admin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddParkingLot;
        private System.Windows.Forms.Button btnViewParkingLot;
        private System.Windows.Forms.Button btnAddNewAdmin;
        private System.Windows.Forms.Button btnViewTransection;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblBack;
        private Button btnViewUsers;
    }
}

