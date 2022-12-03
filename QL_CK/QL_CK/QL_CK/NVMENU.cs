using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_CK
{
    public partial class NVMENU : Form
    {
        public NVMENU( )
        {
            InitializeComponent();
        }

        public NVMENU(string id)
        {
            InitializeComponent();
            this.Id = id;
        }
        DataClasses1DataContext db = new DataClasses1DataContext();


       public string Id { get; set; }

        private void NVMENU_Load(object sender, EventArgs e)
        {
            autoload();
        }

        private void autoload()
        {
            NVLOGIN nl = new NVLOGIN();
            textBox1.Text = Id;
            var st = (from s in db.NHANVIENs where s.MaNV == textBox1.Text select s).First();
            textBox2.Text = st.TenNV;
            textBox3.Text = st.NamSinh.ToString();
            textBox5.Text = st.DiaChi;
            textBox6.Text = st.SDT.ToString();
            textBox7.Text = st.GioiTinh;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                DateTime dt = DateTime.Now;
                
                
                var checkin = (from t in db.CHECKINs where t.MaNV == textBox1.Text && t.Thang == dt.Month && t.Ngay == dt.Day select t).SingleOrDefault();
                if (checkin == null)
                {
                    CHECKIN ck = new CHECKIN();
                    ck.MaNV = textBox1.Text;
                    ck.Thang = dt.Month;
                    ck.Ngay = dt.Day;
                    db.CHECKINs.InsertOnSubmit(ck);


                    var st = (from s in db.BANGCHAMCONGs where s.MaNV == textBox1.Text && s.Thang == dt.Month select s).SingleOrDefault();
                    if(st == null)
                {
                    BANGCHAMCONG bcc = new BANGCHAMCONG();
                    bcc.MaNV = textBox1.Text;
                    bcc.Thang = dt.Month;
                    bcc.SoNgayDiLam = 1;
                    db.BANGCHAMCONGs.InsertOnSubmit(bcc);
                    db.SubmitChanges();
                }
                else
                {
                    st.SoNgayDiLam = st.SoNgayDiLam + 1;
                    db.SubmitChanges();
                }
                    
                    MessageBox.Show("Bạn đã điểm danh thành công");
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Bạn đã điểm danh trước đó rồi");
                    this.Close();
                } 
                    
                
            
            
        }
    }
}
