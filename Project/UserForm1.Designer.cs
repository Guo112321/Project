namespace Project
{
    partial class UserForm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelWelcomeUser = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            carGrid = new DataGridView();
            CarNos = new DataGridViewTextBoxColumn();
            Brands = new DataGridViewTextBoxColumn();
            Models = new DataGridViewTextBoxColumn();
            Colors = new DataGridViewTextBoxColumn();
            Statuss = new DataGridViewTextBoxColumn();
            panelChildForm = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carGrid).BeginInit();
            SuspendLayout();
            // 
            // labelWelcomeUser
            // 
            labelWelcomeUser.AutoSize = true;
            labelWelcomeUser.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcomeUser.Location = new Point(416, 19);
            labelWelcomeUser.Name = "labelWelcomeUser";
            labelWelcomeUser.Size = new Size(120, 30);
            labelWelcomeUser.TabIndex = 0;
            labelWelcomeUser.Text = "welcome";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(carGrid);
            groupBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            groupBox1.Location = new Point(10, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1055, 347);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Your Vehicle";
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Location = new Point(782, 207);
            button1.Name = "button1";
            button1.Size = new Size(220, 72);
            button1.TabIndex = 1;
            button1.Text = "Vehicle Management";
            button1.UseVisualStyleBackColor = true;
            // 
            // carGrid
            // 
            carGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carGrid.Columns.AddRange(new DataGridViewColumn[] { CarNos, Brands, Models, Colors, Statuss });
            carGrid.Location = new Point(29, 41);
            carGrid.Name = "carGrid";
            carGrid.ReadOnly = true;
            carGrid.RowHeadersWidth = 51;
            carGrid.Size = new Size(733, 259);
            carGrid.TabIndex = 0;
            carGrid.CellContentClick += carGrid_CellContentClick;
            // 
            // CarNos
            // 
            CarNos.HeaderText = "CarNo";
            CarNos.MinimumWidth = 6;
            CarNos.Name = "CarNos";
            CarNos.ReadOnly = true;
            CarNos.Width = 125;
            // 
            // Brands
            // 
            Brands.HeaderText = "Brand";
            Brands.MinimumWidth = 6;
            Brands.Name = "Brands";
            Brands.ReadOnly = true;
            Brands.Width = 125;
            // 
            // Models
            // 
            Models.HeaderText = "Model";
            Models.MinimumWidth = 6;
            Models.Name = "Models";
            Models.ReadOnly = true;
            Models.Width = 125;
            // 
            // Colors
            // 
            Colors.HeaderText = "Color";
            Colors.MinimumWidth = 6;
            Colors.Name = "Colors";
            Colors.ReadOnly = true;
            Colors.Width = 125;
            // 
            // Statuss
            // 
            Statuss.HeaderText = "Status";
            Statuss.MinimumWidth = 6;
            Statuss.Name = "Statuss";
            Statuss.ReadOnly = true;
            Statuss.Width = 125;
            // 
            // panelChildForm
            // 
            panelChildForm.Location = new Point(23, 433);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1123, 184);
            panelChildForm.TabIndex = 2;
            // 
            // UserForm1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 654);
            Controls.Add(panelChildForm);
            Controls.Add(groupBox1);
            Controls.Add(labelWelcomeUser);
            Name = "UserForm1";
            Text = "UserMenu";
            Load += UserForm1_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)carGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcomeUser;
        private GroupBox groupBox1;
        private DataGridView carGrid;
        private DataGridViewTextBoxColumn CarNos;
        private DataGridViewTextBoxColumn Brands;
        private DataGridViewTextBoxColumn Models;
        private DataGridViewTextBoxColumn Colors;
        private DataGridViewTextBoxColumn Statuss;
        private Button button1;
        private Panel panelChildForm;
    }
}
