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
    public partial class NVLOGIN : Form
    {
        public string id;
        public NVLOGIN()
        {
            InitializeComponent();
            
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var nv = (from s in db.TAIKHOANNVs
                          where s.Username == textBox1.Text && s.Pass == Decimal.Parse(textBox2.Text)
                          select s).SingleOrDefault();
                if (nv != null)
                {
                    NVMENU aDMENU = new NVMENU(nv.MaNV);
                    
                    aDMENU.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Không đăng nhập được");
            }

        }
    }
    
}
