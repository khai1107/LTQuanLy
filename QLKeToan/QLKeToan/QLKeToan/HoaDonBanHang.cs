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
    public partial class HoaDonBanHang : Form
    {
        public HoaDonBanHang()
        {
            InitializeComponent();
        }
        HDBANHANG_BUL hdbanhang_bul = new HDBANHANG_BUL();
        private void xulybutton(bool b)
        {
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = btThoat.Enabled = b;
            btHuy.Enabled = !b;
        }
        private bool nutThem = false, nutSua = false;
        private void tat()
        {
            txtMaHD.ReadOnly = true;
            txtTenSPHD.ReadOnly = true;
            txtSoLuongHD.ReadOnly = true;
            dtNgayBanHD.Show();
            txtNguoiBanHD.ReadOnly = true;
            txtGiaHD.ReadOnly = true;
            txtTongHD.ReadOnly = true;

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            nutThem = true;
            xulybutton(false);
            //mo();
            txtMaHD.Focus();         
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
            if (DialogResult.Yes == MessageBox.Show("Muốn xóa hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                delete();
                LoadDataGrid();
            }
        }
        private void delete()
        {
            HDBANHANG_PUBLIC hdbanhang_public = new HDBANHANG_PUBLIC();
            hdbanhang_public.MAHD = txtMaHD.Text;
            hdbanhang_bul.cancel_hdbanhang(hdbanhang_public);
        }
        private void insert()
        {
            
            HDBANHANG_PUBLIC hdbanhang_public = new HDBANHANG_PUBLIC();
            hdbanhang_public.MAHD = txtMaHD.Text;
            hdbanhang_public.TENSP = txtTenSPHD.Text;
            hdbanhang_public.SOLUONG = int.Parse(txtSoLuongHD.Text);
            hdbanhang_public.NGAYBAN = DateTime.Parse(dtNgayBanHD.Text);
            hdbanhang_public.NGUOIBAN = txtNguoiBanHD.Text;
            hdbanhang_public.GIA = int.Parse(txtGiaHD.Text);
            hdbanhang_public.TONG = int.Parse(txtTongHD.Text);
            hdbanhang_bul.insert_hdbanhang(hdbanhang_public);
        }
        private void update()
        {
            
            HDBANHANG_PUBLIC hdbanhang_public = new HDBANHANG_PUBLIC();
            hdbanhang_public.MAHD = txtMaHD.Text;
            hdbanhang_public.TENSP = txtTenSPHD.Text;
            hdbanhang_public.SOLUONG = int.Parse(txtSoLuongHD.Text);
            hdbanhang_public.NGAYBAN = DateTime.Parse(dtNgayBanHD.Text);
            hdbanhang_public.NGUOIBAN = txtNguoiBanHD.Text;
            hdbanhang_public.GIA = int.Parse(txtGiaHD.Text);
            hdbanhang_public.TONG = int.Parse(txtTongHD.Text);
            hdbanhang_bul.update_hdbanhang(hdbanhang_public);
        }
        private void tinhtongtien()
        {
            double tongtien = 0;
            tongtien = Convert.ToDouble(int.Parse(txtSoLuongHD.Text) * int.Parse(txtGiaHD.Text));
            txtTongHD.Text = tongtien.ToString("###,###,##0");
        }
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (nutThem == true)
            {
                if (txtMaHD.Text == "")
                {
                    MessageBox.Show("Chưa chọn mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtTenSPHD.Text == "")
                {
                    MessageBox.Show("Chưa chọn tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSoLuongHD.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtNgayBanHD.Value.Year == DateTime.Today.Year)
                {
                    MessageBox.Show("Chưa chọn ngày bán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNguoiBanHD.Text == "")
                {
                    MessageBox.Show("Chưa chọn người bán sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtGiaHD.Text == "")
                {
                    MessageBox.Show("Giá HD không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtTongHD.Text == "")
                {
                    MessageBox.Show("Tổng HD không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if(txtMaHD.Text == "")
                {
                    MessageBox.Show("Chưa chọn mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtTenSPHD.Text == "")
                {
                    MessageBox.Show("Chưa chọn tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSoLuongHD.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtNgayBanHD.Value.Year == DateTime.Today.Year)
                {
                    MessageBox.Show("Chưa chọn ngày bán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNguoiBanHD.Text == "")
                {
                    MessageBox.Show("Chưa chọn người bán sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtGiaHD.Text == "")
                {
                    MessageBox.Show("Giá HD không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtTongHD.Text == "")
                {
                    MessageBox.Show("Tổng HD không được để trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtMaHD.Clear();
            dtNgayBanHD.ResetText();
            txtTenSPHD.Clear();
            txtNguoiBanHD.Clear();
            txtSoLuongHD.Clear();
            txtGiaHD.Clear();
            txtTongHD.Clear();
        }
        private void HoaDonBanHang_Load(object sender, EventArgs e)
        {
            xulybutton(true);
            LoadDataGrid();
            EditDataGrid();
            dg_HDBanHang.Rows[0].Selected = true;
        }
        private void LoadDataGrid()
        {
            bindingSource1.DataSource = hdbanhang_bul.load_hdbanhang();
            dg_HDBanHang.DataSource = bindingSource1;
        }
        private void dg_HDBanHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaHD.Text = dg_HDBanHang.Rows[dong].Cells[0].Value.ToString();
                txtTenSPHD.Text = dg_HDBanHang.Rows[dong].Cells[1].Value.ToString();
                txtSoLuongHD.Text = dg_HDBanHang.Rows[dong].Cells[2].Value.ToString();
                dtNgayBanHD.Text = dg_HDBanHang.Rows[dong].Cells[3].Value.ToString();
                txtNguoiBanHD.Text = dg_HDBanHang.Rows[dong].Cells[4].Value.ToString();
                txtGiaHD.Text = dg_HDBanHang.Rows[dong].Cells[5].Value.ToString();
                txtTongHD.Text = dg_HDBanHang.Rows[dong].Cells[6].Value.ToString();
            }
            catch
            { }
        }

        private void btTongHD_Click(object sender, EventArgs e)
        {
            double tongtien = 0;
            tongtien = Convert.ToDouble(int.Parse(txtSoLuongHD.Text) * int.Parse(txtGiaHD.Text));
            txtTongHD.Text = tongtien.ToString("###,###,##0");
        }

        private void EditDataGrid()
        {
            dg_HDBanHang.ReadOnly = true;
            dg_HDBanHang.Columns[0].HeaderText = "Mã hóa đơn";
            dg_HDBanHang.Columns[1].HeaderText = "Tên sản phẩm";
            dg_HDBanHang.Columns[2].HeaderText = "Số lượng";
            dg_HDBanHang.Columns[3].HeaderText = "Ngày bán";
            dg_HDBanHang.Columns[4].HeaderText = "Người bán";
            dg_HDBanHang.Columns[5].HeaderText = "Giá";
            dg_HDBanHang.Columns[6].HeaderText = "Tổng";
        }
    }
}
