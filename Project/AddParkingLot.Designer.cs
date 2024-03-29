namespace Paradise_Car_Park_System
{
    partial class AddParkingLot
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
            label2 = new Label();
            txtLotID = new TextBox();
            txtLocation = new TextBox();
            label4 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            label3 = new Label();
            txtCapacity = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 40);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 1;
            label1.Text = "Add Parking Lot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 54);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 2;
            label2.Text = "Lot ID: ";
            // 
            // txtLotID
            // 
            txtLotID.Location = new Point(115, 54);
            txtLotID.Margin = new Padding(3, 4, 3, 4);
            txtLotID.Name = "txtLotID";
            txtLotID.Size = new Size(100, 26);
            txtLotID.TabIndex = 3;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(115, 104);
            txtLocation.Margin = new Padding(3, 4, 3, 4);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(100, 26);
            txtLocation.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 104);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 6;
            label4.Text = "Location: ";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(262, 419);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 44);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(467, 419);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 44);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtCapacity);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtLotID);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtLocation);
            groupBox2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(285, 117);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(249, 268);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lot Details";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 154);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 8;
            label3.Text = "Capacity: ";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(113, 154);
            txtCapacity.Margin = new Padding(3, 4, 3, 4);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(100, 26);
            txtCapacity.TabIndex = 9;
            // 
            // AddParkingLot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(groupBox2);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddParkingLot";
            Text = "AddParkingLot";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLotID;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private Label label3;
        private TextBox txtCapacity;
    }
}