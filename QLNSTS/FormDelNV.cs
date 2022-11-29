﻿using System;
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
    public partial class Form1 : Form
    {
        QLNSEntities database = new QLNSEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                var user = database.ThongTinNhanViens.Where(s => s.Id == id).FirstOrDefault();
                database.ThongTinNhanViens.Remove(user);
            }
            catch
            {
                string message = "data is not existed";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
