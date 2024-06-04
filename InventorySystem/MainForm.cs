using System.Runtime.InteropServices;

namespace InventorySystem
{
    public partial class MainForm : Form
    {
        private int borderSize = 2;
        private Size formSize;

        string loggedUsername;

        Home home;
        EditInventory editInventory;
        ViewInventory viewInventory;

        public MainForm(string username)
        {
            InitializeComponent();
            CollapseMenu();
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.DodgerBlue;

            loggedUsername = username;
            loggedUser.Text = "  " + loggedUsername;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 100;
                pictureBox1.Visible = false;
                buttonMenu.Dock = DockStyle.Fill;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 230;
                pictureBox1.Visible = true;
                buttonMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "  " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(15, 0, 0, 0);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;

            timer1.Start();
            timeNowText.Text = DateTime.Now.ToLongTimeString();
            dateNowText.Text = DateTime.Now.ToLongDateString();

            ShowHomeForm();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ShowHomeForm();
        }

        private void ShowHomeForm()
        {
            if (home == null || home.IsDisposed)
            {
                home = new Home();
                home.FormClosed += Home_FormClosed;
                home.MdiParent = this;
                home.Dock = DockStyle.Fill;
                home.Show();
            }
            else
            {
                home.BringToFront();
                home.Activate();
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            home = null;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (editInventory == null || editInventory.IsDisposed)
            {
                editInventory = new EditInventory();
                editInventory.FormClosed += EditInventory_FormClosed;
                editInventory.MdiParent = this;
                editInventory.Dock = DockStyle.Fill;
                editInventory.Show();
            }
            else
            {
                editInventory.BringToFront();
                editInventory.Activate();
            }
        }

        private void EditInventory_FormClosed(object? sender, FormClosedEventArgs e)
        {
            editInventory = null;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (viewInventory == null || viewInventory.IsDisposed)
            {
                viewInventory = new ViewInventory();
                viewInventory.FormClosed += ViewInventory_FormClosed;
                viewInventory.MdiParent = this;
                viewInventory.Dock = DockStyle.Fill;
                viewInventory.Show();
            }
            else
            {
                viewInventory.BringToFront();
                viewInventory.Activate();
            }
        }

        private void ViewInventory_FormClosed(object? sender, FormClosedEventArgs e)
        {
            viewInventory = null;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure?", "Question Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.No)
            {
                MessageBox.Show("Operation canceled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeNowText.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
