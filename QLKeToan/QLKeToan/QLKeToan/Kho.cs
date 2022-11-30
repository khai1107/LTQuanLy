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
    public partial class Kho : Form
    {
        public Kho()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        private void xulybutton(bool b)
        {
            dg_Kho.Enabled = btnTim.Enabled = txtTimTen.Enabled = b;
        }
        private bool nutThem = false, nutLamMoi = false;
        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTimTen.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên nhân viên cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MUAHANG_PUBLIC muahang_public = new MUAHANG_PUBLIC();
                muahang_public.TIMHANG = txtTimTen.Text;
                dg_Kho.DataSource = muahang_bul.Tim_hang(muahang_public);
                dg_Kho.Rows[0].Selected = true;
            }
        }

        private void Kho_Load(object sender, EventArgs e)
        {

            xulybutton(true);
            LoadDataGrid();
            EditDataGrid();
            dg_Kho.Rows[0].Selected = true;
            Tat();
        }
        MUAHANG_BUL muahang_bul = new MUAHANG_BUL();
        private void Tat()
        {
            txtTimTen.ReadOnly = false; 
            
        }
        private void LoadDataGrid()
        {
            bindingSource1.DataSource = muahang_bul.load_muahang();
            dg_Kho.DataSource = bindingSource1;
        }

        private void dg_Kho_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnTim_MouseMove(object sender, MouseEventArgs e)
        {
            btnTim.BackColor = Color.Chocolate;
            btnTim.ForeColor = Color.Yellow;
        }

        private void btnTim_MouseLeave(object sender, EventArgs e)
        {
            btnTim.BackColor = Color.Transparent;
            btnTim.ForeColor = SystemColors.ControlText;
        }

        private void EditDataGrid()
        {
            dg_Kho.ReadOnly = true;
            dg_Kho.Columns[0].HeaderText = "Mã sản phẩm";
            dg_Kho.Columns[1].HeaderText = "Tên sản phẩm";
            dg_Kho.Columns[2].HeaderText = "Số lượng";
            dg_Kho.Columns[3].HeaderText = "Ngày mua";
            dg_Kho.Columns[4].HeaderText = "Người mua";
        }
    }
}
