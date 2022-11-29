using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QL_CK
{
    public partial class LuongNV : Form
    {
        public LuongNV()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        ReportDataSource rs = new ReportDataSource();

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "")
            {
                MessageBox.Show("ID trống");
            }
            else
            {
                try
                {

                    var st = (from s in db.BANGCHAMCONGs where s.MaNV == textBox1.Text && s.Thang.ToString() == textBox2.Text select s).First();
                    textBox4.Text = st.SoNgayDiLam.ToString();
                    textBox5.Text = (st.SoNgayDiLam*120).ToString();
             
                }
                catch
                {
                    MessageBox.Show("Không lấy được thông tin");
                }

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<luong> lst = new List<luong>();
            lst.Clear();


            luong l = new luong
            {
                    MaNV = textBox1.Text,
                    Thang = textBox2.Text,
                    SoNgayDiLam = textBox4.Text,
                    TongLuongThang = textBox5.Text,

                };
                lst.Add(l);
            
            rs.Name = "DataSet2";
            rs.Value = lst;
            ReportLuong rl = new ReportLuong();
            rl.reportViewer1.LocalReport.DataSources.Clear();
            rl.reportViewer1.LocalReport.DataSources.Add(rs);
            rl.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_CK.Report2.rdlc";
            rl.ShowDialog();

            ReportLuong rp = new ReportLuong();
            rp.ShowDialog();
        }
    }

    public class luong
    {
        public string MaNV { get; set; }
        public string Thang { get; set; }
        public string SoNgayDiLam { get; set; }
        public string TongLuongThang { get; set; }

    }
}
