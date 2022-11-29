using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using Microsoft.Reporting.WinForms;

namespace QL_CK
{
    public partial class ADMENU : Form
    {
        public ADMENU()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        ReportDataSource rs = new ReportDataSource();

        private void ADMENU_Load(object sender, EventArgs e)
        {
            Refresh();
            //this.reportViewer1.RefreshReport();
        }

        private void Refresh()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            dgv.Rows.Clear();
            var list = from p in db.NHANVIENs
                       where p.MaNV == p.MaNV
                       select p;
            dgv.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNV add = new AddNV();
            add.ShowDialog();
            Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XoaNV xoa = new XoaNV();
            xoa.ShowDialog();
            Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditNV edit = new EditNV();
            edit.ShowDialog();
            Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {


                if (textBox2.Text == "")
                {
                    var list = from l in db.NHANVIENs
                               where l.MaNV.Contains(textBox1.Text)
                                        && l.TenNV.Contains(textBox3.Text)

                               select l;
                    dgv.DataSource = list;
                    dgv.Refresh();
                }
                else
                {
                    var list = from l in db.NHANVIENs
                               where l.MaNV.Contains(textBox1.Text)
                               && l.NamSinh == Decimal.Parse(textBox2.Text)
                                        && l.TenNV.Contains(textBox3.Text)

                               select l;
                    dgv.DataSource = list;
                    dgv.Refresh();
                }    
            }
            catch
            {
                MessageBox.Show("Tìm kiếm lỗi");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<nhanvien> lst = new List<nhanvien>();
            lst.Clear();

            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {

                nhanvien nv = new nhanvien
                {
                    MaNV = dgv.Rows[i].Cells[0].Value.ToString(),
                    TenNV = dgv.Rows[i].Cells[1].Value.ToString(),
                    NamSinh = dgv.Rows[i].Cells[2].Value.ToString(),
                    DiaChi = dgv.Rows[i].Cells[3].Value.ToString(),
                    SDT = dgv.Rows[i].Cells[4].Value.ToString(),
                    GioiTinh = dgv.Rows[i].Cells[5].Value.ToString(),

                };
                lst.Add(nv);
            }
                rs.Name = "DataSet1";
                rs.Value = lst;
                ReportList rl = new ReportList();
                rl.reportViewer1.LocalReport.DataSources.Clear();
                rl.reportViewer1.LocalReport.DataSources.Add(rs);
                rl.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_CK.Report1.rdlc";
                rl.ShowDialog();
             
            ReportList rp = new ReportList();
            rp.ShowDialog();
 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LuongNV lnv = new LuongNV();
            lnv.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }

    public class nhanvien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
      
    }
}
