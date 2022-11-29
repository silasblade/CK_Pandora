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
    public partial class AddNV : Form
    {
        public AddNV()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void AddNV_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                NHANVIEN nv = new NHANVIEN();
                nv.MaNV = textBox1.Text;
                nv.TenNV = textBox2.Text;
                nv.NamSinh = Decimal.Parse(textBox3.Text);
                nv.DiaChi = textBox4.Text;
                nv.SDT = Decimal.Parse(textBox5.Text);
                nv.GioiTinh = textBox6.Text;
                db.NHANVIENs.InsertOnSubmit(nv);
                db.SubmitChanges();
                MessageBox.Show("Bạn đã thêm nhân viên mới thành công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Có lỗi");
                this.Close();
            }
        }
    }
}
