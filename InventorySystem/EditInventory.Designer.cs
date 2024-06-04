namespace InventorySystem
{
    partial class EditInventory
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
            panel1 = new Panel();
            label2 = new Label();
            searchBox = new TextBox();
            label1 = new Label();
            customButton5 = new Controls.CustomButton();
            customButton4 = new Controls.CustomButton();
            customButton3 = new Controls.CustomButton();
            customButton2 = new Controls.CustomButton();
            quantityBox = new NumericUpDown();
            pictureBox1 = new PictureBox();
            customButton1 = new Controls.CustomButton();
            descriptionBox = new TextBox();
            idBox = new TextBox();
            nameBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)quantityBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightSkyBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 47;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(872, 188);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(searchBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(customButton5);
            panel1.Controls.Add(customButton4);
            panel1.Controls.Add(customButton3);
            panel1.Controls.Add(customButton2);
            panel1.Controls.Add(quantityBox);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(customButton1);
            panel1.Controls.Add(descriptionBox);
            panel1.Controls.Add(idBox);
            panel1.Controls.Add(nameBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 188);
            panel1.Name = "panel1";
            panel1.Size = new Size(872, 272);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(669, 236);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 21;
            label2.Text = "Search";
            // 
            // searchBox
            // 
            searchBox.Location = new Point(728, 233);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(128, 27);
            searchBox.TabIndex = 20;
            searchBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(384, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 19;
            label1.Text = "Quantity:";
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
            customButton5.Location = new Point(389, 222);
            customButton5.Name = "customButton5";
            customButton5.Size = new Size(119, 38);
            customButton5.TabIndex = 18;
            customButton5.Text = "Clear";
            customButton5.TextColor = Color.White;
            customButton5.UseVisualStyleBackColor = false;
            customButton5.Click += customButton5_Click;
            // 
            // customButton4
            // 
            customButton4.BackColor = Color.LightSalmon;
            customButton4.BackgroundColor = Color.LightSalmon;
            customButton4.BorderColor = Color.Transparent;
            customButton4.BorderRadius = 18;
            customButton4.BorderSize = 0;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton4.ForeColor = Color.White;
            customButton4.Location = new Point(264, 222);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(119, 38);
            customButton4.TabIndex = 17;
            customButton4.Text = "Delete";
            customButton4.TextColor = Color.White;
            customButton4.UseVisualStyleBackColor = false;
            customButton4.Click += customButton4_Click;
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.Khaki;
            customButton3.BackgroundColor = Color.Khaki;
            customButton3.BorderColor = Color.Transparent;
            customButton3.BorderRadius = 18;
            customButton3.BorderSize = 0;
            customButton3.FlatAppearance.BorderSize = 0;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton3.ForeColor = Color.White;
            customButton3.Location = new Point(139, 222);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(119, 38);
            customButton3.TabIndex = 16;
            customButton3.Text = "Update";
            customButton3.TextColor = Color.White;
            customButton3.UseVisualStyleBackColor = false;
            customButton3.Click += customButton3_Click;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.MediumAquamarine;
            customButton2.BackgroundColor = Color.MediumAquamarine;
            customButton2.BorderColor = Color.Transparent;
            customButton2.BorderRadius = 18;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(14, 222);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(119, 38);
            customButton2.TabIndex = 15;
            customButton2.Text = "Insert";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // quantityBox
            // 
            quantityBox.Location = new Point(458, 7);
            quantityBox.Name = "quantityBox";
            quantityBox.Size = new Size(87, 27);
            quantityBox.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.CornflowerBlue;
            pictureBox1.Location = new Point(669, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 192);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.RoyalBlue;
            customButton1.BackgroundColor = Color.RoyalBlue;
            customButton1.BorderColor = Color.Transparent;
            customButton1.BorderRadius = 18;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(551, 6);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(108, 46);
            customButton1.TabIndex = 12;
            customButton1.Text = "File";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // descriptionBox
            // 
            descriptionBox.Location = new Point(217, 6);
            descriptionBox.Multiline = true;
            descriptionBox.Name = "descriptionBox";
            descriptionBox.PlaceholderText = "Description";
            descriptionBox.Size = new Size(161, 142);
            descriptionBox.TabIndex = 11;
            // 
            // idBox
            // 
            idBox.Location = new Point(14, 6);
            idBox.Name = "idBox";
            idBox.PlaceholderText = "#";
            idBox.ReadOnly = true;
            idBox.Size = new Size(30, 27);
            idBox.TabIndex = 10;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(50, 6);
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Name";
            nameBox.Size = new Size(161, 27);
            nameBox.TabIndex = 9;
            // 
            // EditInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(872, 460);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Font = new Font("Nirmala UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditInventory";
            Text = "EditInventory";
            Load += EditInventory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)quantityBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private Controls.CustomButton customButton5;
        private Controls.CustomButton customButton4;
        private Controls.CustomButton customButton3;
        private Controls.CustomButton customButton2;
        private NumericUpDown quantityBox;
        private PictureBox pictureBox1;
        private Controls.CustomButton customButton1;
        private TextBox descriptionBox;
        private TextBox idBox;
        private TextBox nameBox;
        private TextBox searchBox;
        private Label label2;
    }
}