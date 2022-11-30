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
    public partial class HoaDonMuaHang : Form
    {
        public HoaDonMuaHang()
        {
            InitializeComponent();
        }
        HDMUAHANG_BUL hdmuahang_bul = new HDMUAHANG_BUL();
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
            dtNgayMuaHD.Show();
            txtNguoiMuaHD.ReadOnly = true;
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

        private void btTongHD_Click(object sender, EventArgs e)
        {
            double tongtien = 0;
            tongtien = Convert.ToDouble(int.Parse(txtSoLuongHD.Text) * int.Parse(txtGiaHD.Text));
            txtTongHD.Text = tongtien.ToString("###,###,##0");
        }
        private void EditDataGrid()
        {
            dg_HDMuaHang.ReadOnly = true;
            dg_HDMuaHang.Columns[0].HeaderText = "Mã hóa đơn";
            dg_HDMuaHang.Columns[1].HeaderText = "Tên sản phẩm";
            dg_HDMuaHang.Columns[2].HeaderText = "Số lượng";
            dg_HDMuaHang.Columns[3].HeaderText = "Ngày mua";
            dg_HDMuaHang.Columns[4].HeaderText = "Người mua";
            dg_HDMuaHang.Columns[5].HeaderText = "Giá";
            dg_HDMuaHang.Columns[6].HeaderText = "Tổng";
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Muốn xóa hóa đơn này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                delete();
                LoadDataGrid();
            }
        }
        private void delete()
        {
            HDMUAHANG_PUBLIC hdmuahang_public = new HDMUAHANG_PUBLIC();
            hdmuahang_public.MAHDMH = txtMaHD.Text;
            hdmuahang_bul.cancel_hdmuahang(hdmuahang_public);
        }
        private void insert()
        {

            HDMUAHANG_PUBLIC hdmuahang_public = new HDMUAHANG_PUBLIC();
            hdmuahang_public.MAHDMH = txtMaHD.Text;
            hdmuahang_public.TENSP = txtTenSPHD.Text;
            hdmuahang_public.SOLUONG = int.Parse(txtSoLuongHD.Text);
            hdmuahang_public.NGAYMUA = DateTime.Parse(dtNgayMuaHD.Text);
            hdmuahang_public.NGUOIMUA = txtNguoiMuaHD.Text;
            hdmuahang_public.GIA = int.Parse(txtGiaHD.Text);
            hdmuahang_public.TONG = int.Parse(txtTongHD.Text);
            hdmuahang_bul.insert_hdmuahang(hdmuahang_public);
        }
        private void update()
        {

            HDMUAHANG_PUBLIC hdmuahang_public = new HDMUAHANG_PUBLIC();
            hdmuahang_public.MAHDMH = txtMaHD.Text;
            hdmuahang_public.TENSP = txtTenSPHD.Text;
            hdmuahang_public.SOLUONG = int.Parse(txtSoLuongHD.Text);
            hdmuahang_public.NGAYMUA = DateTime.Parse(dtNgayMuaHD.Text);
            hdmuahang_public.NGUOIMUA = txtNguoiMuaHD.Text;
            hdmuahang_public.GIA = int.Parse(txtGiaHD.Text);
            hdmuahang_public.TONG = int.Parse(txtTongHD.Text);
            hdmuahang_bul.update_hdmuahang(hdmuahang_public);
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
                else if (dtNgayMuaHD.Value.Year == DateTime.Today.Year)
                {
                    MessageBox.Show("Chưa chọn ngày mua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNguoiMuaHD.Text == "")
                {
                    MessageBox.Show("Chưa chọn người mua sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                else if (dtNgayMuaHD.Value.Year == DateTime.Today.Year)
                {
                    MessageBox.Show("Chưa chọn ngày mua.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNguoiMuaHD.Text == "")
                {
                    MessageBox.Show("Chưa chọn người mua sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            dtNgayMuaHD.ResetText();
            txtTenSPHD.Clear();
            txtNguoiMuaHD.Clear();
            txtSoLuongHD.Clear();
            txtGiaHD.Clear();
            txtTongHD.Clear();
        }
        private void LoadDataGrid()
        {
            bindingSource1.DataSource = hdmuahang_bul.load_hdmuahang();
            dg_HDMuaHang.DataSource = bindingSource1;
        }
        private void dg_HDMuaHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaHD.Text = dg_HDMuaHang.Rows[dong].Cells[0].Value.ToString();
                txtTenSPHD.Text = dg_HDMuaHang.Rows[dong].Cells[1].Value.ToString();
                txtSoLuongHD.Text = dg_HDMuaHang.Rows[dong].Cells[2].Value.ToString();
                dtNgayMuaHD.Text = dg_HDMuaHang.Rows[dong].Cells[3].Value.ToString();
                txtNguoiMuaHD.Text = dg_HDMuaHang.Rows[dong].Cells[4].Value.ToString();
                txtGiaHD.Text = dg_HDMuaHang.Rows[dong].Cells[5].Value.ToString();
                txtTongHD.Text = dg_HDMuaHang.Rows[dong].Cells[6].Value.ToString();
            }
            catch
            { }
        }
    }
}
