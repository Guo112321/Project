namespace Paradise_Car_Park_System
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label2 = new Label();
            panelHome = new Panel();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            panelHome.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 151);
            label2.Name = "label2";
            label2.Size = new Size(0, 16);
            label2.TabIndex = 17;
            // 
            // panelHome
            // 
            panelHome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelHome.Controls.Add(label4);
            panelHome.Controls.Add(label1);
            panelHome.Controls.Add(label3);
            panelHome.Location = new Point(0, 0);
            panelHome.MinimumSize = new Size(1066, 650);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(1066, 650);
            panelHome.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(238, 27);
            label3.Name = "label3";
            label3.Size = new Size(590, 41);
            label3.TabIndex = 0;
            label3.Text = "Welcome to Paradise Car Parking System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 146);
            label1.Name = "label1";
            label1.Size = new Size(565, 200);
            label1.TabIndex = 20;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(723, 149);
            label4.Name = "label4";
            label4.Size = new Size(314, 405);
            label4.TabIndex = 21;
            label4.Text = "CAR\r\n\r\nPARKING \r\n\r\nSYSTEM";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 650);
            Controls.Add(panelHome);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            Text = "Home page";
            WindowState = FormWindowState.Maximized;
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label2;
        private Panel panelHome;
        private Label label3;
        private Button button9;
        private Button button5;
        private Label label4;
        private Label label1;
    }
}

