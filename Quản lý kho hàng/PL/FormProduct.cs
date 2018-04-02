using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Quản_lý_kho_hàng.BL;

namespace Quản_lý_kho_hàng.PL
{
    public partial class FormProduct : Form
    {

        HangHoaBUS hangHoaBUS;
        DataTable dataTable;
        int currentRow = 0;
        public FormProduct()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            hangHoaBUS = new HangHoaBUS();
            dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn("MaHang"));
            dataTable.Columns.Add(new DataColumn("TenHang"));
            dataTable.Columns.Add(new DataColumn("NoiChua"));
            dataTable.Columns.Add(new DataColumn("SoLuongBan"));
            dataTable.Columns.Add(new DataColumn("GiaHang"));
            GetAllToGridView();
            
        }


        private void btAdd_Click(object sender, EventArgs e)
        {
            hangHoaBUS.Insert(new EL.HangHoa(tbMaHang.Text, tbTenHang.Text, tbNoiChua.Text, double.Parse(tbGiaHang.Text), int.Parse(tbSLHang.Text)));
            GetAllToGridView();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            hangHoaBUS.Update(dataTable.Rows[currentRow].Field<string>(0), new EL.HangHoa(tbMaHang.Text, tbTenHang.Text, tbNoiChua.Text, double.Parse(tbGiaHang.Text), int.Parse(tbSLHang.Text)));
            GetAllToGridView();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            hangHoaBUS.Delete(tbMaHang.Text);
            GetAllToGridView();
        }
        public void GetAllToGridView()
        {
            List<EL.HangHoa> listHangHoa = hangHoaBUS.ViewAll();
            dataTable.Rows.Clear();
            foreach(EL.HangHoa hanghoa in listHangHoa)
            {
                dataTable.Rows.Add(hanghoa.MaHang, hanghoa.TenHang, hanghoa.NoiChua, hanghoa.SoLuongHang, hanghoa.GiaHang);
            }
            dataGridView1.DataSource = dataTable;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.DataSource != null)
            {
                if (e.RowIndex < dataTable.Rows.Count && e.RowIndex > -1)
                {
                    currentRow = e.RowIndex;
                    tbMaHang.Text = dataTable.Rows[e.RowIndex].Field<string>(0);
                    tbTenHang.Text = dataTable.Rows[e.RowIndex].Field<string>(1);
                    tbNoiChua.Text = dataTable.Rows[e.RowIndex].Field<string>(2);
                    tbGiaHang.Text = dataTable.Rows[e.RowIndex].Field<string>(3);
                    tbSLHang.Text = dataTable.Rows[e.RowIndex].Field<string>(4);
                }
            }
        }
    }
}
