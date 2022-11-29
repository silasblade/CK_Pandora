using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLNSTS.Models;

namespace QLNSTS
{
    public partial class FindId : Form
    {
        QLNSEntities database = new QLNSEntities();
        public FindId()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                var user = database.ThongTinNhanViens.Where(s => s.Id == id).FirstOrDefault();
                if (user != null)
                {
                    detailNV form = new detailNV();
                    form.ShowDialog();
                }
            }
            catch(IOException error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
