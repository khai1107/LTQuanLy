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
    public partial class Thue : Form
    {
        public Thue()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        THUE_BUL thue_bul = new THUE_BUL();

        private void xulybutton(bool b)
        {
            btThem.Enabled = dg_Thue.Enabled = btnTim.Enabled = txtTenThue.Enabled = btSua.Enabled = btXoa.Enabled = b;
            btHuy.Enabled = !b;
        }
        private bool nutThem = false, nutSua = false;
        private void tat()
        {
            txtTenThue.ReadOnly = true;
            txtTongChiPhi.ReadOnly = true;

            cbTrangThai.Show();
        }
        private void Thue_Load(object sender, EventArgs e)
        {
            xulybutton(true);
            LoadDataGrid();
            EditDataGrid();
            dg_Thue.Rows[0].Selected = true;
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
            if (DialogResult.Yes == MessageBox.Show("Muốn xóa loại thuế này.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                delete();
                LoadDataGrid();
            }
        }
        private void delete()
        {
            THUE_PUBLIC thue_public = new THUE_PUBLIC();
            thue_public.MAHD = txtMaHD.Text;
            thue_bul.delete_thue(thue_public);
        }
        private void insert()
        {
            THUE_PUBLIC thue_public = new THUE_PUBLIC();
            thue_public.MATHUE = int.Parse(txtMaHD.Text);
            thue_public.LOAITHUE = cbLoaiThue.Text;
            thue_public.TRANGTHAI = cbTrangThai.Text;
            thue_public.TONGCHIPHI = int.Parse(txtTongChiPhi.Text);
            thue_bul.insert_thue(thue_public);
        }
        private void update()
        {
            THUE_PUBLIC thue_public = new THUE_PUBLIC();
            thue_public.MATHUE = int.Parse(txtMaHD.Text);
            thue_public.LOAITHUE = cbLoaiThue.Text;
            thue_public.TRANGTHAI = cbTrangThai.Text;
            thue_public.TONGCHIPHI = int.Parse(txtTongChiPhi.Text);
            thue_bul.update_thue(thue_public);
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (nutThem == true)
            {
                if (txtMaHD.Text == "")
                {
                    MessageBox.Show("Chưa điền mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cbLoaiThue.Text == "")
                {
                    MessageBox.Show("Chưa chọn loại thuế.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cbTrangThai.Text == "")
                {
                    MessageBox.Show("Chưa chọn trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtTongChiPhi.Text == "")
                {
                    MessageBox.Show("Chi phí không thể bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Chưa điền mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cbLoaiThue.Text == "")
                {
                    MessageBox.Show("Chưa chọn loại thuế.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cbTrangThai.Text == "")
                {
                    MessageBox.Show("Chưa chọn trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtTongChiPhi.Text == "")
                {
                    MessageBox.Show("Chi phí không thể bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            
            txtTongChiPhi.Clear();
            cbTrangThai.SelectedIndex = -1;
            cbLoaiThue.SelectedIndex = -1;
        }
        private void LoadDataGrid()
        {
            bindingSource1.DataSource = thue_bul.load_thue();
            dg_Thue.DataSource = bindingSource1;
        }

        private void dg_Thue_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMaHD.Text = dg_Thue.Rows[dong].Cells[0].Value.ToString();
                cbLoaiThue.Text = dg_Thue.Rows[dong].Cells[1].Value.ToString();
                cbTrangThai.Text = dg_Thue.Rows[dong].Cells[2].Value.ToString();
                txtTongChiPhi.Text = dg_Thue.Rows[dong].Cells[3].Value.ToString();

            }
            catch
            { }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtTenThue.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên thuế cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                THUE_PUBLIC thue_public = new THUE_PUBLIC();
                thue_public.TIMLOAITHUE = txtTenThue.Text;
                dg_Thue.DataSource = thue_bul.Tim_loaithue(thue_public);
                dg_Thue.Rows[0].Selected = true;
            }
        }

        private void EditDataGrid()
        {
            dg_Thue.ReadOnly = true;
            dg_Thue.Columns[0].HeaderText = "Mã hóa đơn";
            dg_Thue.Columns[1].HeaderText = "Loại thuế";
            dg_Thue.Columns[2].HeaderText = "Trạng thái";
            dg_Thue.Columns[3].HeaderText = "Tổng chi phí";
        }
    }
}
