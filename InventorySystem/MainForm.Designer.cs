namespace InventorySystem
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            panel2 = new Panel();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            a = new Label();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            buttonMenu = new FontAwesome.Sharp.IconButton();
            panelTitleBar = new Panel();
            dateNowText = new Label();
            timeNowText = new Label();
            loggedUser = new Label();
            buttonMinimize = new FontAwesome.Sharp.IconButton();
            buttonClose = new FontAwesome.Sharp.IconButton();
            timer1 = new System.Windows.Forms.Timer(components);
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DodgerBlue;
            panelMenu.Controls.Add(panel2);
            panelMenu.Controls.Add(iconButton5);
            panelMenu.Controls.Add(iconButton4);
            panelMenu.Controls.Add(a);
            panelMenu.Controls.Add(iconButton3);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(230, 556);
            panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(230, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(752, 460);
            panel2.TabIndex = 3;
            // 
            // iconButton5
            // 
            iconButton5.Cursor = Cursors.Hand;
            iconButton5.Dock = DockStyle.Bottom;
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.Font = new Font("Verdana", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton5.ForeColor = Color.White;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 30;
            iconButton5.Location = new Point(0, 500);
            iconButton5.Name = "iconButton5";
            iconButton5.Padding = new Padding(10, 0, 0, 15);
            iconButton5.Size = new Size(230, 56);
            iconButton5.TabIndex = 4;
            iconButton5.Tag = "Sign Out";
            iconButton5.Text = " Sign Out";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = true;
            iconButton5.Click += iconButton5_Click;
            // 
            // iconButton4
            // 
            iconButton4.Cursor = Cursors.Hand;
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Verdana", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 175);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(15, 0, 0, 0);
            iconButton4.Size = new Size(230, 41);
            iconButton4.TabIndex = 3;
            iconButton4.Tag = "View Inventory";
            iconButton4.Text = "  View Inventory";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Nirmala UI", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a.ForeColor = Color.Azure;
            a.Location = new Point(0, 175);
            a.Name = "a";
            a.Size = new Size(73, 30);
            a.TabIndex = 5;
            a.Text = "jangal";
            // 
            // iconButton3
            // 
            iconButton3.Cursor = Cursors.Hand;
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Verdana", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.PenSquare;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 30;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 134);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(15, 0, 0, 0);
            iconButton3.Size = new Size(230, 41);
            iconButton3.TabIndex = 2;
            iconButton3.Tag = "Edit Inventory";
            iconButton3.Text = " Edit Inventory";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.Cursor = Cursors.Hand;
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Verdana", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 30;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 93);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(15, 0, 0, 0);
            iconButton2.Size = new Size(230, 41);
            iconButton2.TabIndex = 1;
            iconButton2.Tag = "Home";
            iconButton2.Text = "  Home";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonMenu);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 93);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.m_one;
            pictureBox1.Location = new Point(21, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // buttonMenu
            // 
            buttonMenu.Cursor = Cursors.Hand;
            buttonMenu.Dock = DockStyle.Right;
            buttonMenu.FlatAppearance.BorderSize = 0;
            buttonMenu.FlatStyle = FlatStyle.Flat;
            buttonMenu.ForeColor = Color.White;
            buttonMenu.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            buttonMenu.IconColor = Color.White;
            buttonMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonMenu.IconSize = 40;
            buttonMenu.Location = new Point(164, 0);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(66, 93);
            buttonMenu.TabIndex = 1;
            buttonMenu.UseVisualStyleBackColor = true;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.White;
            panelTitleBar.Controls.Add(dateNowText);
            panelTitleBar.Controls.Add(timeNowText);
            panelTitleBar.Controls.Add(loggedUser);
            panelTitleBar.Controls.Add(buttonMinimize);
            panelTitleBar.Controls.Add(buttonClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(230, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(752, 93);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // dateNowText
            // 
            dateNowText.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold);
            dateNowText.ForeColor = Color.MediumBlue;
            dateNowText.Location = new Point(486, 71);
            dateNowText.Name = "dateNowText";
            dateNowText.Padding = new Padding(10, 0, 0, 0);
            dateNowText.Size = new Size(266, 22);
            dateNowText.TabIndex = 9;
            dateNowText.Text = "Date";
            dateNowText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timeNowText
            // 
            timeNowText.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold);
            timeNowText.ForeColor = Color.MediumBlue;
            timeNowText.Location = new Point(265, 71);
            timeNowText.Name = "timeNowText";
            timeNowText.Padding = new Padding(10, 0, 0, 0);
            timeNowText.Size = new Size(227, 22);
            timeNowText.TabIndex = 8;
            timeNowText.Text = "Time";
            timeNowText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // loggedUser
            // 
            loggedUser.Dock = DockStyle.Left;
            loggedUser.Font = new Font("Nirmala UI", 13.7454548F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loggedUser.ForeColor = Color.DodgerBlue;
            loggedUser.Location = new Point(0, 0);
            loggedUser.Name = "loggedUser";
            loggedUser.Padding = new Padding(10, 0, 0, 0);
            loggedUser.Size = new Size(181, 93);
            loggedUser.TabIndex = 7;
            loggedUser.Text = "Time";
            loggedUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonMinimize
            // 
            buttonMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMinimize.BackColor = Color.MediumTurquoise;
            buttonMinimize.Cursor = Cursors.Hand;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.ForeColor = Color.White;
            buttonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            buttonMinimize.IconColor = Color.White;
            buttonMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonMinimize.IconSize = 20;
            buttonMinimize.Location = new Point(662, 0);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(45, 28);
            buttonMinimize.TabIndex = 4;
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.BackColor = Color.Coral;
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.ForeColor = Color.White;
            buttonClose.IconChar = FontAwesome.Sharp.IconChar.X;
            buttonClose.IconColor = Color.White;
            buttonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            buttonClose.IconSize = 20;
            buttonClose.Location = new Point(707, 0);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(45, 28);
            buttonClose.TabIndex = 2;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(982, 556);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelTitleBar;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton buttonMenu;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton buttonClose;
        private FontAwesome.Sharp.IconButton buttonMinimize;
        private PictureBox pictureBox1;
        private Label a;
        private System.Windows.Forms.Timer timer1;
        private Label loggedUser;
        private Label dateNowText;
        private Label timeNowText;
        private Panel panel2;
    }
}
