using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quản_lý_kho_hàng.EL;
using Quản_lý_kho_hàng.BL;

namespace Quản_lý_kho_hàng
{
    public partial class Form1 : Form
    {
        AccountBUS accountBUS;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigureManager.SqlConnection.Open();
            accountBUS = new AccountBUS();
        }

        private void bntLogin_Click(object sender, EventArgs e)
        {
            if(accountBUS.CheckLogin(new Account(tbUser.Text, tbPass.Text)))
            {
                MessageBox.Show("Login successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PL.FormProduct formProduct = new PL.FormProduct();
                formProduct.Show();
            }
            else
            {
                MessageBox.Show("Login failed", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntRegi_Click(object sender, EventArgs e)
        {
            accountBUS.Add(new Account(tbUser.Text, tbPass.Text));
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
