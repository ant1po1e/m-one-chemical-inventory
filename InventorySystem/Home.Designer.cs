namespace InventorySystem
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
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Nirmala UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(848, 381);
            label1.TabIndex = 0;
            label1.Text = "Welcome to M-One Chemical Inventory System. M-One Chemical is part of M-One and SMK Muhammadiyah 1 Sukoharjo. \r\n\r\nThis desktop Application is made by Apriansyah Yudha Pratama.\r\n\r\n";
            // 
            // label2
            // 
            label2.Font = new Font("Nirmala UI", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(369, 46);
            label2.TabIndex = 1;
            label2.Text = "M-One Chemical Inventory System";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(872, 460);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
    }
}