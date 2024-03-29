namespace Project
{
    partial class UserEnterParking
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
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            cboParkinglots = new ComboBox();
            label3 = new Label();
            btnPark = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(411, 23);
            dateTimePicker1.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 25);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Date: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(728, 25);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Time: ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(787, 23);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(191, 27);
            dateTimePicker2.TabIndex = 3;
            // 
            // cboParkinglots
            // 
            cboParkinglots.FormattingEnabled = true;
            cboParkinglots.Location = new Point(130, 23);
            cboParkinglots.Name = "cboParkinglots";
            cboParkinglots.Size = new Size(151, 28);
            cboParkinglots.TabIndex = 4;
            cboParkinglots.SelectedIndexChanged += cboParkinglots_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 25);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 5;
            label3.Text = "Parkinglot: ";
            // 
            // btnPark
            // 
            btnPark.Location = new Point(481, 88);
            btnPark.Name = "btnPark";
            btnPark.Size = new Size(94, 29);
            btnPark.TabIndex = 6;
            btnPark.Text = "Park";
            btnPark.UseVisualStyleBackColor = true;
            btnPark.Click += btnPark_Click;
            // 
            // UserEnterParking
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 137);
            Controls.Add(btnPark);
            Controls.Add(label3);
            Controls.Add(cboParkinglots);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "UserEnterParking";
            Text = "UserEnterParking";
            Load += UserEnterParking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private ComboBox cboParkinglots;
        private Label label3;
        private Button btnPark;
    }
}