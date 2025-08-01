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


namespace vtysodevi
{
    public partial class uygulama_raporu : Form
    {
        public uygulama_raporu()
        {
            InitializeComponent();
        }
       
        private const string connectionString = @"Data Source=DESKTOP-T0830U3\SQLEXP2022;Initial Catalog=Alsalman_DB;Integrated Security=True";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uygulama_raporu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("CustomerID", "ID");
            dataGridView1.Columns.Add("FirstName", "First Name");
            dataGridView1.Columns.Add("LastName", "Last Name");
            dataGridView1.Columns.Add("PhoneNumber", "Phone");
           

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Customers";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    // Execute the command and load the results into the DataGridView
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear(); // Clear existing data
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["CustomerID"], reader["FirstName"], reader["LastName"], reader["PhoneNumber"]);
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Clear the existing columns and rows
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();


            dataGridView1.Columns.Add("OrderID", "ID");
            dataGridView1.Columns.Add("CustomerID", "Customer");
            dataGridView1.Columns.Add("OrderDate", "Order Date");
            dataGridView1.Columns.Add("ShippingAddress", "Shipping Address");
            dataGridView1.Columns.Add("PaymentType", "PaymentType");
            dataGridView1.Columns.Add("OrderStatus", "Order Status");




            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Orders WHERE PaymentType = 'Credit Card'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    // Execute the command and load the results into the DataGridView
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataGridView1.Rows.Clear(); // Clear existing data
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["OrderID"], reader["CustomerID"], reader["OrderDate"], reader["ShippingAddress"], reader["PaymentType"], reader["OrderStatus"]);
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Clear the existing columns and rows
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ProductID", "ID");
            dataGridView1.Columns.Add("ProductName", "Product Name");
            dataGridView1.Columns.Add("TotalSold", "Total Sold");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Improved query for better performance
                string query = @"
                SELECT P.ProductID, P.ProductName, SUM (OD.Quantity) AS TotalSold
                FROM Products P INNER JOIN OrderDetails OD ON P.ProductID = OD.ProductID JOIN Orders O on O.OrderID = OD.OrderID
                GROUP BY P.ProductID, P.ProductName
                ORDER BY TotalSold DESC;
                ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["ProductID"], reader["ProductName"], reader["TotalSold"]);
                        }
                    }
                }
            }
        }

        private void Exsit_button_Click(object sender, EventArgs e)
        {
         
                // Close the current form (application window)
                this.Close();
                Application.Exit();

        }
    }
    
   
}
