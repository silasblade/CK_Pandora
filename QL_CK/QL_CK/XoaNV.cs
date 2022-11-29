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
    public partial class XoaNV : Form
    {
        public XoaNV()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var NV = db.NHANVIENs.SingleOrDefault(nv => nv.MaNV == textBox1.Text);
                db.NHANVIENs.DeleteOnSubmit(NV);
                db.SubmitChanges();
                MessageBox.Show("Xóa nhân viên thành công!");
            }

            catch
            {
                MessageBox.Show("Không xóa được!");
            }
            this.Close();


        }
    }
}
