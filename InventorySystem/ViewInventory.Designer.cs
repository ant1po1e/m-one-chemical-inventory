namespace InventorySystem
{
    partial class ViewInventory
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
            pictureBox1 = new PictureBox();
            nameText = new Label();
            quantityText = new Label();
            dateCreatedText = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            customDateTimePicker1 = new Controls.CustomDateTimePicker();
            searchBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            customButton5 = new Controls.CustomButton();
            panel1 = new Panel();
            descriptionText = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Location = new Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // nameText
            // 
            nameText.AutoSize = true;
            nameText.Font = new Font("Nirmala UI", 11.7818184F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameText.ForeColor = Color.DarkSlateGray;
            nameText.Location = new Point(166, 41);
            nameText.Name = "nameText";
            nameText.Size = new Size(62, 25);
            nameText.TabIndex = 1;
            nameText.Text = "Name";
            // 
            // quantityText
            // 
            quantityText.AutoSize = true;
            quantityText.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityText.ForeColor = Color.DarkSlateGray;
            quantityText.Location = new Point(166, 66);
            quantityText.Name = "quantityText";
            quantityText.Size = new Size(38, 20);
            quantityText.TabIndex = 2;
            quantityText.Text = "Qty:";
            // 
            // dateCreatedText
            // 
            dateCreatedText.AutoSize = true;
            dateCreatedText.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateCreatedText.ForeColor = Color.DarkSlateGray;
            dateCreatedText.Location = new Point(166, 123);
            dateCreatedText.Name = "dateCreatedText";
            dateCreatedText.Size = new Size(100, 20);
            dateCreatedText.TabIndex = 3;
            dateCreatedText.Text = "Date Created";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Azure;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dateCreatedText);
            panel2.Controls.Add(quantityText);
            panel2.Controls.Add(nameText);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(170, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 395);
            panel2.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightSkyBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Left;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 47;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(170, 460);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // customDateTimePicker1
            // 
            customDateTimePicker1.BorderColor = Color.Transparent;
            customDateTimePicker1.BorderSize = 0;
            customDateTimePicker1.Font = new Font("Segoe UI", 9.5F);
            customDateTimePicker1.Location = new Point(106, 12);
            customDateTimePicker1.MinimumSize = new Size(0, 35);
            customDateTimePicker1.Name = "customDateTimePicker1";
            customDateTimePicker1.Size = new Size(229, 35);
            customDateTimePicker1.SkinColor = Color.RoyalBlue;
            customDateTimePicker1.TabIndex = 0;
            customDateTimePicker1.TextColor = Color.White;
            customDateTimePicker1.ValueChanged += customDateTimePicker1_ValueChanged;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(561, 19);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(128, 26);
            searchBox.TabIndex = 22;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(506, 22);
            label2.Name = "label2";
            label2.Size = new Size(49, 19);
            label2.TabIndex = 23;
            label2.Text = "Search";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(86, 19);
            label1.TabIndex = 24;
            label1.Text = "Sort by Date";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Azure;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(customButton5);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(searchBox);
            panel3.Controls.Add(customDateTimePicker1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(170, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(702, 65);
            panel3.TabIndex = 5;
            // 
            // customButton5
            // 
            customButton5.BackColor = Color.SkyBlue;
            customButton5.BackgroundColor = Color.SkyBlue;
            customButton5.BorderColor = Color.Transparent;
            customButton5.BorderRadius = 18;
            customButton5.BorderSize = 0;
            customButton5.FlatAppearance.BorderSize = 0;
            customButton5.FlatStyle = FlatStyle.Flat;
            customButton5.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton5.ForeColor = Color.White;
            customButton5.Location = new Point(341, 19);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(81, 28);
            customButton5.TabIndex = 25;
            customButton5.Text = "Reset";
            customButton5.TextColor = Color.White;
            customButton5.UseVisualStyleBackColor = false;
            customButton5.Click += customButton5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(descriptionText);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(170, 228);
            panel1.Name = "panel1";
            panel1.Size = new Size(702, 232);
            panel1.TabIndex = 7;
            // 
            // descriptionText
            // 
            descriptionText.BorderStyle = BorderStyle.FixedSingle;
            descriptionText.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descriptionText.ForeColor = Color.DarkSlateGray;
            descriptionText.Location = new Point(18, 47);
            descriptionText.Name = "descriptionText";
            descriptionText.Size = new Size(671, 179);
            descriptionText.TabIndex = 5;
            descriptionText.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(283, 18);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // ViewInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(872, 460);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(dataGridView1);
            Font = new Font("Nirmala UI", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewInventory";
            Load += ViewInventory_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label nameText;
        private Label quantityText;
        private Label dateCreatedText;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Controls.CustomDateTimePicker customDateTimePicker1;
        private TextBox searchBox;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private Panel panel1;
        private Label descriptionText;
        private Label label5;
        private Controls.CustomButton customButton5;
    }
}