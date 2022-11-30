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
    public partial class BanHang : Form
    {
        public BanHang()
        {
            InitializeComponent();
        }
        BANHANG_BUL banhang_bul = new BANHANG_BUL();
        private void xulybutton(bool b)
        {
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = btThoat.Enabled = b;
            btHuy.Enabled = !b;
        }
        private bool nutThem = false, nutSua = false;
        private void tat()
        {
            txtMaSP.ReadOnly = true;
            txtTenSP.ReadOnly = true;
            txtSoLuongBH.ReadOnly = true;
            dtNgayBan.Show();
            txtNguoiBan.ReadOnly = true;           
        }
        private void mo()
        {
            txtMaSP.Hide();
            txtTenSP.Hide();
            txtSoLuongBH.Hide();
            dtNgayBan.Hide();
            txtNguoiBan.Hide();
        }
        private void BanHang_Load(object sender, EventArgs e)
        {
            xulybutton(true);
            LoadDataGrid();
            EditDataGrid();
            dg_SPBan.Rows[0].Selected = true;
        }
        private void LoadDataGrid()
        {
            bindingSource1.DataSource = banhang_bul.load_banhang();
            dg_SPBan.DataSource = bindingSource1;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            nutThem = true;
            xulybutton(false);
            //mo();
            txtMaSP.Focus();
            Clear();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            nutSua = true;
            xulybutton(false);
            //mo();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Muốn xóa sản phẩm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                delete();
                LoadDataGrid();
            }
        }
        private void delete()
        {
            BANHANG_PUBLIC banhang_public = new BANHANG_PUBLIC();
            banhang_public.MASPBH = txtMaSP.Text;
            banhang_bul.delete_banhang(banhang_public);
        }
        private void insert()
        {
            BANHANG_PUBLIC banhang_public = new BANHANG_PUBLIC();
            banhang_public.MASPBH = txtMaSP.Text;
            banhang_public.TENSP = txtTenSP.Text;
            banhang_public.SOLUONG = int.Parse(txtSoLuongBH.Text);
            banhang_public.NGAYBAN = DateTime.Parse(dtNgayBan.Text);
            banhang_public.NGUOIBAN = txtNguoiBan.Text;
            banhang_bul.insert_banhang(banhang_public);
        }
        private void update()
        {
            BANHANG_PUBLIC banhang_public = new BANHANG_PUBLIC();
            banhang_public.MASPBH = txtMaSP.Text;
            banhang_public.TENSP = txtTenSP.Text;
            banhang_public.SOLUONG = int.Parse(txtSoLuongBH.Text);
            banhang_public.NGAYBAN = DateTime.Parse(dtNgayBan.Text);
            banhang_public.NGUOIBAN = txtNguoiBan.Text;
            banhang_bul.update_banhang(banhang_public);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (nutThem == true)
            {
                if (txtMaSP.Text == "")
                {
                    MessageBox.Show("Chưa chọn mã sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtTenSP.Text == "")
                {
                    MessageBox.Show("Chưa chọn tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSoLuongBH.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtNgayBan.Value.Year == DateTime.Today.Year)
                {
                    MessageBox.Show("Chưa chọn ngày bán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNguoiBan.Text == "")
                {
                    MessageBox.Show("Chưa chọn người bán sản phẩm..", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        nutThem = false;
                        insert();
                        tat();
                        xulybutton(true);
                        LoadDataGrid();
                    }
                    catch
                    { }
                }
            }
            else if (nutSua == true)
            {
                if (txtMaSP.Text == "")
                {
                    MessageBox.Show("Chưa chọn mã sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtTenSP.Text == "")
                {
                    MessageBox.Show("Chưa chọn tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSoLuongBH.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtNgayBan.Value.Year == DateTime.Today.Year)
                {
                    MessageBox.Show("Chưa chọn ngày bán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNguoiBan.Text == "")
                {
                    MessageBox.Show("Chưa chọn người bán sản phẩm..", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    update();
                    tat();
                    xulybutton(true);
                    nutSua = false;
                    LoadDataGrid();
                }
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (nutThem == true)
            {
                //
                LoadDataGrid();
                xulybutton(true);
                tat();
                nutThem = false;
            }
            else if (nutSua == true)
            {
                //
                tat();
                xulybutton(true);
                nutSua = false;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Clear()
        {
            txtMaSP.Clear();
            dtNgayBan.ResetText();
            txtTenSP.Clear();
            txtNguoiBan.Clear();
            txtSoLuongBH.Clear();
        }

        private void dg_SPBan_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaSP.Text = dg_SPBan.Rows[dong].Cells[0].Value.ToString();
                txtTenSP.Text = dg_SPBan.Rows[dong].Cells[1].Value.ToString();
                txtSoLuongBH.Text = dg_SPBan.Rows[dong].Cells[2].Value.ToString();
                dtNgayBan.Text = dg_SPBan.Rows[dong].Cells[3].Value.ToString();
                txtNguoiBan.Text = dg_SPBan.Rows[dong].Cells[4].Value.ToString();
            }
            catch
            { }
        }

        private void EditDataGrid()
        {
            dg_SPBan.ReadOnly = true;
            dg_SPBan.Columns[0].HeaderText = "Mã sản phẩm";
            dg_SPBan.Columns[1].HeaderText = "Tên sản phẩm";
            dg_SPBan.Columns[2].HeaderText = "Số lượng";
            dg_SPBan.Columns[3].HeaderText = "Ngày bán";
            dg_SPBan.Columns[4].HeaderText = "Người bán";
        }
    }
}
