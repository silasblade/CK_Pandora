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

namespace QLNSTL
{
    public partial class QLLOGIN : Form
    {
        public QLLOGIN()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=VISHAGNA;Initial Catalog=QLNSTL;Integrated Security=True");
      

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username, password;
            username = textBox1.Text;
            password = textBox2.Text;

            try
            {
                String query = "SELECT * FROM TAIKHOANADMIN WHERE Username = '"+textBox1.Text+"' AND Pass = '"+textBox2.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt); 
                if(dt.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    password = textBox2.Text;
                    ADMENU admn = new ADMENU();
                    admn.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                } 
                    
            }

            catch
            {
                MessageBox.Show("Sai");
            }

            finally
            {
                conn.Close();
            }


        }
    }
}
