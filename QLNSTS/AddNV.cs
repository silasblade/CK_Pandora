using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNSTS.Models;

namespace QLNSTS
{
    public partial class FormAddNV : Form
    {
        QLNSEntities database = new QLNSEntities();
        public FormAddNV()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Value);
            int pos = (comboBox1.Text == "Nhân viên") ? 0 : 1;
            bool sex = (radioButton1.Checked) ? true : false;
            var user = new ThongTinNhanVien()
            {
                Id = id,
                TenNV = txtName.Text,
                SDT = txtSDT.Text,
                NgaySinh = NgaySinh.Value,
                Diachi = txtAddress.Text,
                GioiTinh = sex,
                ChucVu = pos,
                MaNV = id.ToString() + pos.ToString(),
            };
            database.ThongTinNhanViens.Add(user);
            database.SaveChanges();
        }
    }
}
