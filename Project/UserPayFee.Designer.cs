namespace Project
{
    partial class UserPayFee
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
            labelNotice = new Label();
            btnPay = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(164, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 31);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 1;
            label1.Text = "Departure Time:";
            // 
            // labelNotice
            // 
            labelNotice.AutoSize = true;
            labelNotice.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            labelNotice.ForeColor = Color.Red;
            labelNotice.Location = new Point(461, 36);
            labelNotice.Name = "labelNotice";
            labelNotice.Size = new Size(0, 20);
            labelNotice.TabIndex = 2;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(418, 88);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(150, 29);
            btnPay.TabIndex = 3;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // UserPayFee
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 137);
            Controls.Add(btnPay);
            Controls.Add(labelNotice);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "UserPayFee";
            Text = "UserPayFee";
            Load += UserPayFee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label labelNotice;
        private Button btnPay;
    }
}