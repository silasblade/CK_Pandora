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
    public partial class XoaNV : Form
    {
        public XoaNV()
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
            string query = "DELETE FROM NHANVIEN WHERE MaNV = " + id;
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã sa thải nhân viên này");
            con.Close();
            this.Close();
        }
    }
}
