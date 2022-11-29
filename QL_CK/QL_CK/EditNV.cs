using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CK
{
    public partial class EditNV : Form
    {
        public EditNV()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ID trống");
            }
            else
            {
                try
                {
                    var st = (from s in db.NHANVIENs where s.MaNV == textBox1.Text select s).First();
                    textBox2.Text = st.TenNV;
                    textBox3.Text = st.NamSinh.ToString();
                    textBox4.Text = st.DiaChi;
                    textBox5.Text = st.SDT.ToString();
                    textBox6.Text = st.GioiTinh;
                }
                catch
                {
                    MessageBox.Show("Không lấy được thông tin");
                }
     
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Không được để ID trống");
            }
            else
            {

                try
                {
                    var nv = (from s in db.NHANVIENs
                              where s.MaNV == textBox1.Text
                              select s
                                    ).SingleOrDefault();
                    nv.TenNV = textBox2.Text;
                    nv.NamSinh = Decimal.Parse(textBox3.Text);
                    nv.DiaChi = textBox4.Text;
                    nv.SDT = Decimal.Parse(textBox5.Text);
                    nv.GioiTinh = textBox6.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Chỉnh sửa thành công");
                }

                catch
                {
                    MessageBox.Show("Không chỉnh sửa được");
                }
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
