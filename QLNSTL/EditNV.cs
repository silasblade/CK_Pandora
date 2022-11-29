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
    public partial class EditNV : Form
    {
        public EditNV()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

            if (id == "")
            {
                MessageBox.Show("ID không được để trống");
            }
            else
            {
                    string query = "UPDATE NHANVIEN SET TenNV= N'" + tennv + "',NamSinh=" + namsinh + ",DiaChi=N'" +diachi + "', SDT=" + sdt + ",GioiTinh=N'" + gioitinh +"' WHERE MaNV =" + textBox1.Text;
                    SqlCommand cmd = new SqlCommand(query, con);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        MessageBox.Show("Chỉnh sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                
                con.Close();
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=VISHAGNA;Initial Catalog=QLNSTL;Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            con.Open();

     

            try
            {
        
                SqlCommand cmd = new SqlCommand("SELECT TenNV, NamSinh, DiaChi, SDT, GioiTinh FROM NHANVIEN WHERE MaNV = '" + textBox1.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox2.Text = dr.GetValue(0).ToString();
                    textBox3.Text = dr.GetValue(1).ToString();
                    textBox4.Text = dr.GetValue(2).ToString();
                    textBox5.Text = dr.GetValue(3).ToString();
                    textBox6.Text = dr.GetValue(4).ToString();
                }
                con.Close();

            }
            catch
            {
                MessageBox.Show("Xảy ra lỗi");
                con.Close();

            }
        }
    }
}
