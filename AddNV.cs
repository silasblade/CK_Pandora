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

namespace QLNSTL
{
    public partial class AddNV : Form
    {
        public AddNV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=VISHAGNA;Initial Catalog=QLNSTL;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            string id = textBox1.Text;
            string tennv = textBox2.Text;
            string namsinh = textBox3.Text;
            string diachi = textBox4.Text;
            string sdt = textBox5.Text;
            string gioitinh = textBox6.Text;

            try
            {
                string query = "INSERT INTO NHANVIEN VALUES(" + id + ",N'" + tennv + "', " + namsinh + ", N'" + diachi + "',  " + sdt + " ,N'" + gioitinh + "') ";
                SqlCommand cmd = new SqlCommand(query, con);
                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }

            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
            con.Close();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
