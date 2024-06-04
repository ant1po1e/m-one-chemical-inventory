namespace InventorySystem
{
    partial class Login
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
            passwordBox = new Controls.CustomTextBox();
            label3 = new Label();
            label2 = new Label();
            usernameBox = new Controls.CustomTextBox();
            customButton1 = new Controls.CustomButton();
            pictureBox1 = new PictureBox();
            buttonClose = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.White;
            passwordBox.BorderColor = Color.RoyalBlue;
            passwordBox.BorderFocusColor = Color.CornflowerBlue;
            passwordBox.BorderRadius = 10;
            passwordBox.BorderSize = 2;
            passwordBox.Cursor = Cursors.Hand;
            passwordBox.Font = new Font("Segoe UI", 9.5F);
            passwordBox.ForeColor = Color.DimGray;
            passwordBox.Location = new Point(70, 319);
            passwordBox.Margin = new Padding(4);
            passwordBox.Multiline = false;
            passwordBox.Name = "passwordBox";
            passwordBox.Padding = new Padding(10, 7, 10, 7);
            passwordBox.PasswordChar = true;
            passwordBox.PlaceholderColor = Color.DarkGray;
            passwordBox.PlaceholderText = "Password";
            passwordBox.Size = new Size(211, 35);
            passwordBox.TabIndex = 2;
            passwordBox.Texts = "";
            passwordBox.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(70, 295);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 11;
            label3.Text = "Password";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(69, 232);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 10;
            label2.Text = "Username or Email";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // usernameBox
            // 
            usernameBox.BackColor = Color.White;
            usernameBox.BorderColor = Color.RoyalBlue;
            usernameBox.BorderFocusColor = Color.CornflowerBlue;
            usernameBox.BorderRadius = 10;
            usernameBox.BorderSize = 2;
            usernameBox.Font = new Font("Segoe UI", 9.5F);
            usernameBox.ForeColor = Color.DimGray;
            usernameBox.Location = new Point(69, 256);
            usernameBox.Margin = new Padding(4);
            usernameBox.Multiline = false;
            usernameBox.Name = "usernameBox";
            usernameBox.Padding = new Padding(10, 7, 10, 7);
            usernameBox.PasswordChar = false;
            usernameBox.PlaceholderColor = Color.DarkGray;
            usernameBox.PlaceholderText = "Username or Email";
            usernameBox.Size = new Size(212, 35);
            usernameBox.TabIndex = 1;
            usernameBox.Texts = "";
            usernameBox.UnderlinedStyle = false;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.RoyalBlue;
            customButton1.BackgroundColor = Color.RoyalBlue;
            customButton1.BorderColor = Color.Transparent;
            customButton1.BorderRadius = 15;
            customButton1.BorderSize = 0;
            customButton1.Cursor = Cursors.Hand;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(69, 386);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(212, 46);
            customButton1.TabIndex = 4;
            customButton1.Text = "Login";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.solution_r;
            pictureBox1.Location = new Point(69, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.Coral;
            buttonClose.Dock = DockStyle.Right;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.ForeColor = Color.White;
            buttonClose.IconChar = FontAwesome.Sharp.IconChar.X;
            buttonClose.IconColor = Color.White;
            buttonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonClose.IconSize = 20;
            buttonClose.Location = new Point(305, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(45, 34);
            buttonClose.TabIndex = 99;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Azure;
            label1.Location = new Point(12, 7);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 9;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(buttonClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 34);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Nirmala UI", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.DodgerBlue;
            checkBox1.Location = new Point(173, 361);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Nirmala UI", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SteelBlue;
            label4.Location = new Point(73, 526);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 14;
            label4.Text = "Don't have an Account?";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Nirmala UI", 7.85454559F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(211, 526);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 5;
            label5.Text = "Register";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            label5.Click += label5_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(350, 550);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(passwordBox);
            Controls.Add(label2);
            Controls.Add(usernameBox);
            Controls.Add(customButton1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.CustomTextBox passwordBox;
        private Label label3;
        private Label label2;
        private Controls.CustomTextBox usernameBox;
        private Controls.CustomButton customButton1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton buttonClose;
        private Label label1;
        private Panel panel1;
        private CheckBox checkBox1;
        private Label label4;
        private Label label5;
    }
}