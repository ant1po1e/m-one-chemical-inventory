using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class Register : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-44VPTOK;Initial Catalog=""M-One Chemical"";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private Login login;

        public Register()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (IsValid() && IsValidEmail(emailBox.Texts))
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand getUser = new SqlCommand("SELECT * FROM users WHERE username = @username", conn))
                        {
                            getUser.Parameters.AddWithValue("@username", usernameBox.Texts.Trim());

                            SqlDataAdapter sda = new SqlDataAdapter(getUser);
                            DataTable dt = new DataTable();

                            sda.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                MessageBox.Show("Username already exist.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                using (SqlCommand insertUser = new SqlCommand("INSERT INTO users (username, email, password) VALUES (@username, @email, @password)", conn))
                                {
                                    insertUser.Parameters.AddWithValue("@username", usernameBox.Texts);
                                    insertUser.Parameters.AddWithValue("@email", emailBox.Texts);
                                    insertUser.Parameters.AddWithValue("@password", passwordBox.Texts);

                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("User registered successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    login = new Login();
                                    login.Show();
                                    this.Hide();
                                }
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
            if (usernameBox.Texts == "" || emailBox.Texts == "" || passwordBox.Texts == "")
            {
                MessageBox.Show("Please input the empty fields.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);

                return true;
            }
            catch
            {
                MessageBox.Show("Please input valid email addres.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            login = new Login();
            login.Show();
            this.Hide();
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}