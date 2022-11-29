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
    public partial class ADLOGIN : Form
    {
        public ADLOGIN()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void textBox1_Resize(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                var nv = (from s in db.TAIKHOANADMINs
                          where s.Username == textBox1.Text && s.Pass == Decimal.Parse(textBox2.Text)
                          select s
                                        ).SingleOrDefault();
                if(nv != null)
                {
                    ADMENU aDMENU = new ADMENU();
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
