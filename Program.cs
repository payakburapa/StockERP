using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace StockManagementApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // เริ่มต้นฟอร์มหลัก
        }
    }
    public partial class Form1 : Form
    {
        string connectionString = "Server=PAYAKBURAPA\\SQLEXPRESS;Database=StockManagement;Integrated Security=True;TrustServerCertificate=True;";
        SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            LoadProducts();
            LoadProductNames(); // โหลดรายชื่อสินค้าเข้า ComboBox
        }

        private void LoadProducts()
        {
            string query = "SELECT ProductID, ProductName, Quantity FROM Products";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void AddProduct(string productName, int quantity)
        {
            string query = "INSERT INTO Products (ProductName, Quantity) VALUES (@ProductName, @Quantity)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductName", productName);
            command.Parameters.AddWithValue("@Quantity", quantity);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void ReduceProduct(int productId, int quantity)
        {
            string query = "UPDATE Products SET Quantity = Quantity - @Quantity WHERE ProductID = @ProductID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Quantity", quantity);
            command.Parameters.AddWithValue("@ProductID", productId);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            int quantity = (int)nudQuantity.Value;

            if (string.IsNullOrEmpty(productName) || quantity <= 0)
            {
                MessageBox.Show("Please enter valid product details.");
                return;
            }

            AddProduct(productName, quantity);
            LoadProducts();
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            int productId = (int)dataGridView1.SelectedRows[0].Cells["ProductID"].Value;
            int quantity = (int)nudQuantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return;
            }

            // ตรวจสอบว่าจำนวนสินค้าหลังจากลดแล้วไม่น้อยกว่า 0
            int currentQuantity = GetCurrentQuantity(productId);
            if (currentQuantity - quantity < 0)
            {
                MessageBox.Show("Cannot reduce quantity below 0.");
                return;
            }

            ReduceProduct(productId, quantity);
            LoadProducts();
        }

        private int GetCurrentQuantity(int productId)
        {
            string query = "SELECT Quantity FROM Products WHERE ProductID = @ProductID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductID", productId);
            connection.Open();
            int quantity = (int)command.ExecuteScalar();
            connection.Close();
            return quantity;
        }

        private void LoadProductNames()
        {
            string query = "SELECT ProductID, ProductName FROM Products";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBoxProducts.Items.Add(new
                {
                    ProductID = reader["ProductID"],
                    ProductName = reader["ProductName"]
                });
            }
            connection.Close();
            comboBoxProducts.DisplayMember = "ProductName"; // แสดงชื่อสินค้า
            comboBoxProducts.ValueMember = "ProductID"; // ค่าที่ใช้คือ ProductID
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxProducts.SelectedItem == null)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            int productId = (int)((dynamic)comboBoxProducts.SelectedItem).ProductID;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DeleteProduct(productId);
                LoadProducts();
                LoadProductNames(); // โหลดรายชื่อสินค้าใหม่หลังจากลบ
            }
        }

        private void DeleteProduct(int productId)
        {
            string query = "DELETE FROM Products WHERE ProductID = @ProductID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductID", productId);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
