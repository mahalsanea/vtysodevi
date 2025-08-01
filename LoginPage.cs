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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Clear_Bottun_Click(object sender, EventArgs e)
        {
            // Clear the relevant controls on the form
            textBox1.Text = ""; // Clear username textbox
            textBox2.Text = ""; // Clear password textbox
        }

        private void Login_Click(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-T0830U3\SQLEXP2022;Initial Catalog=Alsalman_DB;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from login_new where username=@username and password =@password", con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //Connection open here   
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Successfully loged in");
                    //after successful it will redirect  to next page .  
                    uygulama_raporu uygulama_raporu = new uygulama_raporu();
                    uygulama_raporu.Show();

                }

                else
                {
                    MessageBox.Show("Please enter Correct Username and Password");
                }

            
        }

        private void EXIT_BOTTUN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
