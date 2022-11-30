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
    public partial class MuaHang : Form
    {
        public MuaHang()
        {
            InitializeComponent();
        }
        MUAHANG_BUL muahang_bul = new MUAHANG_BUL();
        private void xulybutton(bool b)
        {
            btThem.Enabled = btSua.Enabled = btXoa.Enabled = btThoat.Enabled = b;
             btHuy.Enabled = !b;
        }
        private bool nutThem = false, nutSua = false;
        private void tat()
        {
            txtMaSP.Show();
            txtTenSP.Show();
            txtSoLuongMH.ReadOnly = true;
            dtNgayMua.Show();
            txtNguoiMua.Show();
        }
        private void mo()
        {
            txtMaSP.Hide();
            txtTenSP.Hide();
            txtSoLuongMH.ReadOnly = false;
            dtNgayMua.Hide();
            txtNguoiMua.Hide();
        }
        private void MuaHang_Load(object sender, EventArgs e)
        {
            xulybutton(true);
            LoadDataGrid();
            EditDataGrid();
            dg_MuaHang.Rows[0].Selected = true;
            
        }
        private void LoadDataGrid()
        {
            bindingSource1.DataSource = muahang_bul.load_muahang();
            dg_MuaHang.DataSource = bindingSource1;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            nutThem = true;
            xulybutton(false);
            //mo();
            txtMaSP.Focus();
            Clear();

        }
        private void Clear()
        {
            txtMaSP.Clear();
            dtNgayMua.ResetText();
            txtTenSP.Clear();
            txtNguoiMua.Clear();
            txtSoLuongMH.Clear();
        }
        private void btSua_Click(object sender, EventArgs e)
        {
            nutSua = true;
            xulybutton(false);
            //mo();
            
        }
        private void delete()
        {
            MUAHANG_PUBLIC muahang_public = new MUAHANG_PUBLIC();
            
            muahang_bul.delete_muahang(muahang_public);
        }
        private void insert()
        {
            MUAHANG_PUBLIC muahang_public = new MUAHANG_PUBLIC();
            muahang_public.MASPMH = txtMaSP.Text;
            muahang_public.TENSP = txtTenSP.Text;
            muahang_public.SOLUONG = int.Parse(txtSoLuongMH.Text);
            muahang_public.NGAYMUA = DateTime.Parse(dtNgayMua.Text);
            muahang_public.NGUOIMUA = txtNguoiMua.Text;
            muahang_bul.insert_muahang(muahang_public);
        }
        private void update()
        {
            MUAHANG_PUBLIC muahang_public = new MUAHANG_PUBLIC();
            muahang_public.MASPMH = txtMaSP.Text;
            muahang_public.TENSP = txtTenSP.Text;
            muahang_public.SOLUONG = int.Parse(txtSoLuongMH.Text);
            muahang_public.NGAYMUA = DateTime.Parse(dtNgayMua.Text);
            muahang_public.NGUOIMUA = txtNguoiMua.Text;
            muahang_bul.update_muahang(muahang_public);
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Muốn xóa sản phẩm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                delete();
                LoadDataGrid();
            }
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
                else if (txtSoLuongMH.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtNgayMua.Value.Year == DateTime.Today.Year)
                {
                    MessageBox.Show("Chưa chọn ngày mua.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNguoiMua.Text == "")
                {
                    MessageBox.Show("Chưa chọn người mua sản phẩm..", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                else if (txtSoLuongMH.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtNgayMua.Value.Year == DateTime.Today.Year)
                {
                    MessageBox.Show("Chưa chọn ngày mua.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtNguoiMua.Text == "")
                {
                    MessageBox.Show("Chưa chọn người mua sản phẩm..", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dg_MuaHang_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaSP.Text = dg_MuaHang.Rows[dong].Cells[0].Value.ToString();
                txtTenSP.Text = dg_MuaHang.Rows[dong].Cells[1].Value.ToString();
                txtSoLuongMH.Text = dg_MuaHang.Rows[dong].Cells[2].Value.ToString();
                dtNgayMua.Text = dg_MuaHang.Rows[dong].Cells[3].Value.ToString();
                txtNguoiMua.Text = dg_MuaHang.Rows[dong].Cells[4].Value.ToString();          
            }
            catch
            { }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /*
private void btLuu_Click(object sender, EventArgs e)
{
if (nutThem == true)
{
try
{
  insert();
  xulybutton(true);
  nutThem = false;
  tat();

}
catch
{
  MessageBox.Show("Trạng thái của bàn là Trống hoặc Có người");
}

}
else if (nutSua == true)
{
try
{
  update();
  xulybuttion(true);
  nutSua = false;
  tat();
  treedsban.Nodes.Clear();
  hienthitreeds();
}
catch
{
  MessageBox.Show("Trạng thái của bàn là Trống hoặc Có người");
}
}
}
*/
        private void EditDataGrid()
        {
            dg_MuaHang.ReadOnly = true;
            dg_MuaHang.Columns[0].HeaderText = "Mã sản phẩm";
            dg_MuaHang.Columns[1].HeaderText = "Tên sản phẩm";
            dg_MuaHang.Columns[2].HeaderText = "Số lượng";
            dg_MuaHang.Columns[3].HeaderText = "Ngày mua";
            dg_MuaHang.Columns[4].HeaderText = "Người mua";
        }
    }
}
