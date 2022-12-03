using ExcelDataReader;
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
using Z.Dapper.Plus;
using System.Data.Sql;
using System.Data.SqlClient;

namespace QL_CK
{
    public partial class ExNV : Form
    {
        public ExNV()
        {
            InitializeComponent();
        }
        DataTableCollection tableCollection;
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = ofd.FileName;
                    using(var stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using(IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow  = true}
                                }); 
                            tableCollection = result.Tables;
                            cboSheet.Items.Clear();
                            foreach (DataTable table in tableCollection)
                                cboSheet.Items.Add(table.TableName);
                        }    
                    }    
                }    
            }    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cboSheet.SelectedItem.ToString()];
            //dataGridView1.DataSource = dt;
            if(dt!=null)
            {
                List<nhanvien> nv = new List<nhanvien>();
                for(int i=0; i<dt.Rows.Count; i++)
                {
                    nhanvien nv1 = new nhanvien();
                    nv1.MaNV = dt.Rows[i][0].ToString();
                    nv1.TenNV = dt.Rows[i][1].ToString();
                    nv1.NamSinh = dt.Rows[i][2].ToString();
                    nv1.DiaChi = dt.Rows[i][3].ToString();
                    nv1.SDT = dt.Rows[i][4].ToString();
                    nv1.GioiTinh = dt.Rows[i][5].ToString();
                    nv.Add(nv1);
                }    
                nHANVIENBindingSource3.DataSource = nv;
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADMENU ad = new ADMENU();
            ad.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Data Source=VISHAGNA;Initial Catalog=QLNSTL;Integrated Security=True";
                DapperPlusManager.Entity<nhanvien>().Table("NHANVIEN");
                List<nhanvien> nv = nHANVIENBindingSource3.DataSource as List<nhanvien>;
                if(nv != null)
                    using(IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(nv);
                    }
                MessageBox.Show("Đã thêm nhân viên thành công");
            }

            catch 
            {
                MessageBox.Show("Có lỗi xảy ra");
             }
        }
    }
}
