using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alsalman_DBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.alsalman_DBDataSet.Customers);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          /*  SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T0830U3\SQLEXP2022;Initial Catalog=Alsalman_DB;Integrated Security=True");

            SqlCommand command = new SqlCommand("Select * from Customers", con);
            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = @"C:\Users\USER\Desktop\UniOOP practic\vtysodevi\Report2.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();*/
        }
    }
}
