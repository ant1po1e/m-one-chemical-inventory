using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventorySystem
{
    public partial class ViewInventory : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-44VPTOK;Initial Catalog=""M-One Chemical"";Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private string query = "SELECT name AS Name, description AS Description, image AS Image, quantity AS 'Qty.', date_created AS 'Date Created' FROM items";
        private bool dateFilterEnabled = false;

        public ViewInventory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                nameText.Text = row.Cells["Name"].Value.ToString();
                descriptionText.Text = row.Cells["Description"].Value.ToString();
                quantityText.Text = "Qty: " + row.Cells["Qty."].Value.ToString();
                dateCreatedText.Text = "Date Created: " + row.Cells["Date Created"].Value.ToString();

                byte[] imageData = (byte[])row.Cells["Image"].Value;

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
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

                    dataGridView1.Columns["Description"].Visible = false;
                    dataGridView1.Columns["Image"].Visible = false;
                    dataGridView1.Columns["Qty."].Visible = false;
                    dataGridView1.Columns["Date Created"].Visible = false;
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

        private void ViewInventory_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void customDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
            dateFilterEnabled = true;
        }

        private void ApplyFilters()
        {
            try
            {
                conn.Open();

                string searchQuery = query + " WHERE (name LIKE @searchText OR description LIKE @searchText OR quantity LIKE @searchText)";

                if (dateFilterEnabled)
                {
                    searchQuery += " AND CONVERT(date, date_created) = @date";
                }

                SqlCommand cmd = new SqlCommand(searchQuery, conn);
                cmd.Parameters.AddWithValue("@searchText", '%' + searchBox.Text + '%');
                if (dateFilterEnabled)
                {
                    cmd.Parameters.AddWithValue("@date", customDateTimePicker1.Value.Date);
                }

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

        private void customButton5_Click(object sender, EventArgs e)
        {
            searchBox.Text = string.Empty;
            dateFilterEnabled = false;

            LoadDataGrid();
        }
    }
}