namespace Project
{
    partial class ViewTransection
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
            dgvTransectionID = new DataGridViewTextBoxColumn();
            dgvUserID = new DataGridViewTextBoxColumn();
            dgvCarNo = new DataGridViewTextBoxColumn();
            dgvLotID = new DataGridViewTextBoxColumn();
            dgvStartingTime = new DataGridViewTextBoxColumn();
            dgvEndingTime = new DataGridViewTextBoxColumn();
            dgvDate = new DataGridViewTextBoxColumn();
            dgvFees = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.CausesValidation = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dgvTransectionID, dgvUserID, dgvCarNo, dgvLotID, dgvStartingTime, dgvEndingTime, dgvDate, dgvFees });
            dataGridView1.Location = new Point(1, 83);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(1050, 604);
            dataGridView1.TabIndex = 5;
            // 
            // dgvTransectionID
            // 
            dgvTransectionID.HeaderText = "TransectionID";
            dgvTransectionID.MinimumWidth = 6;
            dgvTransectionID.Name = "dgvTransectionID";
            dgvTransectionID.Width = 125;
            // 
            // dgvUserID
            // 
            dgvUserID.HeaderText = "UserID";
            dgvUserID.MinimumWidth = 6;
            dgvUserID.Name = "dgvUserID";
            dgvUserID.Width = 125;
            // 
            // dgvCarNo
            // 
            dgvCarNo.HeaderText = "Car No.";
            dgvCarNo.MinimumWidth = 6;
            dgvCarNo.Name = "dgvCarNo";
            dgvCarNo.Width = 125;
            // 
            // dgvLotID
            // 
            dgvLotID.HeaderText = "Lot ID";
            dgvLotID.MinimumWidth = 6;
            dgvLotID.Name = "dgvLotID";
            dgvLotID.Width = 125;
            // 
            // dgvStartingTime
            // 
            dgvStartingTime.HeaderText = "Starting Time";
            dgvStartingTime.MinimumWidth = 6;
            dgvStartingTime.Name = "dgvStartingTime";
            dgvStartingTime.Width = 125;
            // 
            // dgvEndingTime
            // 
            dgvEndingTime.HeaderText = "Ending Time";
            dgvEndingTime.MinimumWidth = 6;
            dgvEndingTime.Name = "dgvEndingTime";
            dgvEndingTime.Width = 125;
            // 
            // dgvDate
            // 
            dgvDate.HeaderText = "Date";
            dgvDate.MinimumWidth = 6;
            dgvDate.Name = "dgvDate";
            dgvDate.Width = 125;
            // 
            // dgvFees
            // 
            dgvFees.HeaderText = "Fees";
            dgvFees.MinimumWidth = 6;
            dgvFees.Name = "dgvFees";
            dgvFees.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(471, 28);
            label1.Name = "label1";
            label1.Size = new Size(174, 28);
            label1.TabIndex = 6;
            label1.Text = "Transection Details";
            // 
            // ViewTransection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 687);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ViewTransection";
            Text = "ViewTransection";
            Load += ViewTransection_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn dgvTransectionID;
        private DataGridViewTextBoxColumn dgvUserID;
        private DataGridViewTextBoxColumn dgvCarNo;
        private DataGridViewTextBoxColumn dgvLotID;
        private DataGridViewTextBoxColumn dgvStartingTime;
        private DataGridViewTextBoxColumn dgvEndingTime;
        private DataGridViewTextBoxColumn dgvDate;
        private DataGridViewTextBoxColumn dgvFees;
    }
}