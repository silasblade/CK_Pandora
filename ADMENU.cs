using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLNSTL
{
    public partial class ADMENU : Form
    {
        public ADMENU()
        {
            InitializeComponent();
        }

        SqlConnection sc = default!;
        SqlCommand scm = default!;
        string str = @"Data Source=VISHAGNA;Initial Catalog=QLNSTL;Integrated Security=True";
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();

        void loaddata()
        {
            scm = sc.CreateCommand();
            scm.CommandText = "select * FROM NHANVIEN";
            sda.SelectCommand = scm;
            dt.Clear();
            sda.Fill(dt);
            dgv.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ADMENU_Load(object sender, EventArgs e)
        {
            sc = new SqlConnection(str);
            sc.Open();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNV add = new AddNV();
            add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XoaNV xoa = new XoaNV();
            xoa.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditNV edit = new EditNV();
            edit.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            loaddata();
        }
    }
}
