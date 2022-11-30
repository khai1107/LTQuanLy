using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using PUBLIC;
using System.IO;
using System.Data.SqlClient;
using System.Threading;

namespace QLKeToan
{
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        HDBANHANG_BUL hdbanhang_bul = new HDBANHANG_BUL();
        private void DoanhThu_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
            EditDataGrid();
            dg_DoanhThu.Rows[0].Selected = true;
        }
        private void LoadDataGrid()
        {
            bindingSource1.DataSource = hdbanhang_bul.load_hdbanhang();
            dg_DoanhThu.DataSource = bindingSource1;
        }
        private void EditDataGrid()
        {
            dg_DoanhThu.ReadOnly = true;
            dg_DoanhThu.Columns[0].HeaderText = "Mã hóa đơn";
            dg_DoanhThu.Columns[1].HeaderText = "Tên sản phẩm";
            dg_DoanhThu.Columns[2].HeaderText = "Số lượng";
            dg_DoanhThu.Columns[3].HeaderText = "Ngày bán";
            dg_DoanhThu.Columns[4].HeaderText = "Người bán";
            dg_DoanhThu.Columns[5].HeaderText = "Giá";
            dg_DoanhThu.Columns[6].HeaderText = "Tổng";
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtMaHD.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập mã hóa đơn cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                HDBANHANG_PUBLIC hdbanhang_public = new HDBANHANG_PUBLIC();
                hdbanhang_public.TIMHDBH = txtMaHD.Text;
                dg_DoanhThu.DataSource = hdbanhang_bul.Tim_hdbh(hdbanhang_public);
                dg_DoanhThu.Rows[0].Selected = true;
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            tinhtongtien(6);
        }
        private void tinhtongtien(int vitri)
        {
            double tongtien = 0;
            for (int i = 0; i < dg_DoanhThu.Rows.Count - 1; ++i)
            {
                tongtien += Convert.ToDouble(dg_DoanhThu.Rows[i].Cells[vitri].Value.ToString());
            }
            txtTongDoanhThu.Text = tongtien.ToString("###,###,##0");
        }
    }
}
