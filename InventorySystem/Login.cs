using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-44VPTOK;Initial Catalog=""M-One Chemical"";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM users WHERE (username = @usernameOrEmail OR email = @usernameOrEmail) AND password = @password", conn))
                        {
                            cmd.Parameters.AddWithValue("@usernameOrEmail", usernameBox.Texts);
                            cmd.Parameters.AddWithValue("@password", passwordBox.Texts);

                            SqlDataAdapter sda = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();

                            sda.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                string username = dt.Rows[0]["username"].ToString();

                                MessageBox.Show("Logged in successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm mainForm = new MainForm(username);
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect login details.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private bool IsValid()
        {
            if (usernameBox.Texts == "" || passwordBox.Texts == "")
            {
                MessageBox.Show("Please input the empty fields.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordBox.PasswordChar = false;
            }
            else
            {
                passwordBox.PasswordChar = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
