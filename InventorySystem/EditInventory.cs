using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace InventorySystem
{
    public partial class EditInventory : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-44VPTOK;Initial Catalog=""M-One Chemical"";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private string query = "SELECT id as '#', name AS Name, description AS Description, image AS Image, quantity AS 'Qty.', date_created AS 'Date Created' FROM items";

        private int key;

        public EditInventory()
        {
            InitializeComponent();
        }
        private void EditInventory_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();

                    dt.Load(sdr);
                    dataGridView1.DataSource = dt;
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

        private void InsertData()
        {
            if (IsValid())
            {
                try
                {
                    byte[] imageBytes = ConvertImageToBytes(pictureBox1.Image);

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO items (name, description, image, quantity, date_created) VALUES (@name, @desc, @img, @qty, @dateCreated)", conn);
                    cmd.Parameters.AddWithValue("@name", nameBox.Text);
                    cmd.Parameters.AddWithValue("@desc", descriptionBox.Text);
                    cmd.Parameters.AddWithValue("@img", imageBytes);
                    cmd.Parameters.AddWithValue("@qty", quantityBox.Text);
                    cmd.Parameters.AddWithValue("@dateCreated", DateTime.Now.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully added.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    LoadDataGrid();
                    ClearFields();
                }
            }
        }

        private void UpdateData()
        {
            if (IsValid())
            {
                try
                {
                    byte[] imageBytes = ConvertImageToBytes(pictureBox1.Image);

                    conn.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE items SET name = @name, description = @desc, image = @img, quantity = @qty WHERE id = @ID", conn);
                    cmd.Parameters.AddWithValue("@name", nameBox.Text);
                    cmd.Parameters.AddWithValue("@desc", descriptionBox.Text);
                    cmd.Parameters.AddWithValue("@img", imageBytes);
                    cmd.Parameters.AddWithValue("@qty", quantityBox.Text);
                    cmd.Parameters.AddWithValue("@ID", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully updated.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    LoadDataGrid();
                    ClearFields();
                }
            }
        }

        private void DeleteData()
        {
            if (IsValid())
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM items WHERE id = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully deleted.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    LoadDataGrid();
                    ClearFields();
                }
            }
        }

        private void ClearFields()
        {
            nameBox.Text = "";
            descriptionBox.Text = "";
            pictureBox1.Image = null;
            quantityBox.Value = 0;
            idBox.Text = "";
        }

        private bool IsValid()
        {
            if (nameBox.Text == "" || descriptionBox.Text == "" || pictureBox1 == null || quantityBox.Text == "")
            {
                MessageBox.Show("Please fill the empty fields.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private byte[] ConvertImageToBytes(Image image)
        {
            if (image == null)
                throw new ArgumentNullException("Image cannot be null");

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                nameBox.Text = row.Cells["Name"].Value.ToString();
                descriptionBox.Text = row.Cells["Description"].Value.ToString();

                byte[] imageData = (byte[])row.Cells["Image"].Value;

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }

                quantityBox.Value = Convert.ToInt32(row.Cells["Qty."].Value);
            }

            if (nameBox.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                idBox.Text = key.ToString();
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure?", "Question Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.No)
            {
                MessageBox.Show("Operation canceled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateData();
            }
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure?", "Question Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.No)
            {
                MessageBox.Show("Operation canceled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DeleteData();
            }
        }

        private void customButton5_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string searchQuery = query + " WHERE name LIKE @searchText OR description LIKE @searchText OR quantity LIKE @searchText";
                SqlCommand cmd = new SqlCommand(searchQuery, conn);
                cmd.Parameters.AddWithValue("@searchText", '%' + searchBox.Text + '%');

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                dataGridView1.DataSource = dt;
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