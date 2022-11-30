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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        
        private void xulybutton(bool b)
        {
            btThem.Enabled = dg_nhanvien.Enabled = bttim.Enabled = txttim.Enabled = btSua.Enabled = btXoa.Enabled = b;
             btHuy.Enabled = !b;
        }
        
        private bool nutThem = false, nutSua = false;

        private void NhanVien_Load(object sender, EventArgs e)
        {
            xulybutton(true);
            LoadDataGrid();
            EditDataGrid();
            dg_nhanvien.Rows[0].Selected = true;
            txtmanv.ReadOnly = true;
            txttentk.ReadOnly = true;
            Tat();

            cbquyen.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        NHANVIEN_BUL nv_bul = new NHANVIEN_BUL();
        TAIKHOAN_BUL tk_bul = new TAIKHOAN_BUL();
        int manv;
        private void Mo()
        {
            txttennv.ReadOnly = false;
            datengaysinh.Enabled = true;
            txtsdt.ReadOnly = false;
            cbgioitinh.Enabled = true;
            txtmatkhau.ReadOnly = false;
            cbquyen.Enabled = true;
            txttentk.ReadOnly = false;

            txtmanv.Hide();
            lbmanv.Hide();
        }
        private void Tat()
        {
            txttennv.ReadOnly = true;
            datengaysinh.Enabled = false;
            txtsdt.ReadOnly = true;
            cbgioitinh.Enabled = false;
            txtmatkhau.ReadOnly = true;
            cbquyen.Enabled = false;
            txttentk.ReadOnly = true;

            txtmanv.Show();
            lbmanv.Show();
        }
        private void LoadDataGrid()
        {
            bindingSource1.DataSource = nv_bul.load_nhanvien();
            dg_nhanvien.DataSource = bindingSource1;
        }
        private void EditDataGrid()
        {
            dg_nhanvien.ReadOnly = true;
            dg_nhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dg_nhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dg_nhanvien.Columns[2].HeaderText = "Ngày sinh";
            dg_nhanvien.Columns[3].HeaderText = "Số điện thoại";
            dg_nhanvien.Columns[4].HeaderText = "Giới tính";
            dg_nhanvien.Columns[5].HeaderText = "Tên tài khoản";
            dg_nhanvien.Columns[6].HeaderText = "Mật khẩu";
            dg_nhanvien.Columns[7].HeaderText = "Quyền";
        }
        private void InsertNhanVien()
        {
            NHANVIEN_PUBLIC nv_public = new NHANVIEN_PUBLIC();
            manv = nv_bul.count_nhanvien();
            nv_public.IDNV = "NV" + manv.ToString();
            nv_public.TENNV = txttennv.Text;
            nv_public.NGAYSINH = DateTime.Parse(datengaysinh.Text);
            nv_public.SDT = txtsdt.Text;
            nv_public.GIOITINH = cbgioitinh.Text;
            nv_bul.insert_nhanvien(nv_public);
        }
        private void InsertTaiKhoan()
        {
            TAIKHOAN_PUBLIC tk_public = new TAIKHOAN_PUBLIC();
            tk_public.TENTK = txttentk.Text;
            tk_public.MATKHAU = txtmatkhau.Text;
            tk_public.QUYEN = cbquyen.Text;
            tk_public.IDNV = "NV" + manv.ToString();
            tk_bul.insert_taikhoan(tk_public);
        }
        private void UpdateNhanVien()
        {
            NHANVIEN_PUBLIC nhanvien_public = new NHANVIEN_PUBLIC();
            nhanvien_public.IDNV = txtmanv.Text;
            nhanvien_public.TENNV = txttennv.Text;
            nhanvien_public.NGAYSINH = DateTime.Parse(datengaysinh.Text);
            nhanvien_public.SDT = txtsdt.Text;
            nhanvien_public.GIOITINH = cbgioitinh.Text;
            nv_bul.update_nhanvien(nhanvien_public);
        }
        private void UpdateTaiKhoan()
        {
            TAIKHOAN_PUBLIC taikhoan_public = new TAIKHOAN_PUBLIC();
            taikhoan_public.TENTK = txttentk.Text;
            taikhoan_public.MATKHAU = txtmatkhau.Text;
            taikhoan_public.QUYEN = cbquyen.Text;
            taikhoan_public.IDNV = txtmanv.Text;
            tk_bul.update_taikhoan(taikhoan_public);
        }
        private void DeleteTaiKhoan()
        {
            TAIKHOAN_PUBLIC taikhoan_public = new TAIKHOAN_PUBLIC();
            taikhoan_public.TENTK = txttentk.Text;
            tk_bul.delete_taikhoan(taikhoan_public);
        }
        private void DeleteNhanVien()
        {
            NHANVIEN_PUBLIC nhanvien_public = new NHANVIEN_PUBLIC();
            nhanvien_public.IDNV = txtmanv.Text;
            nv_bul.delete_nhanvien(nhanvien_public);
        }
        private void DeleteNhanVien_Loi()
        {
            NHANVIEN_PUBLIC nhanvien_public = new NHANVIEN_PUBLIC();
            nhanvien_public.IDNV = "NV" + manv.ToString();
            nv_bul.delete_nhanvien(nhanvien_public);
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            nutThem = true;
            Mo();
            xulybutton(false);
            txtmanv.Focus();
            Clear();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            nutSua = true;
            Mo();
            txttentk.ReadOnly = true;
            xulybutton(false);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (nutThem == true)
            {
                //
                LoadDataGrid();
                xulybutton(true);
                Tat();
                nutThem = false;
            }
            else if (nutSua == true)
            {
                //
                Tat();
                xulybutton(true);
                nutSua = false;
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Muốn xóa một nhân viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                DeleteTaiKhoan();
                DeleteNhanVien();
                LoadDataGrid();
            }
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            if (txttim.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên nhân viên cần tìm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                NHANVIEN_PUBLIC nv_public = new NHANVIEN_PUBLIC();
                nv_public.TIMTEN = txttim.Text;
                dg_nhanvien.DataSource = nv_bul.Tim_nv(nv_public);
                dg_nhanvien.Rows[0].Selected = true;
            }
        }

        private void Clear()
        {
            txttennv.Clear();
            datengaysinh.ResetText();
            txtsdt.Clear();
            cbgioitinh.SelectedIndex = -1;
            txttentk.Clear();
            txtmatkhau.Clear();
            cbquyen.SelectedIndex = -1;
        }

        private void txttim_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void dg_nhanvien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtmanv.Text = dg_nhanvien.Rows[dong].Cells[0].Value.ToString();
                txttennv.Text = dg_nhanvien.Rows[dong].Cells[1].Value.ToString();
                datengaysinh.Text = dg_nhanvien.Rows[dong].Cells[2].Value.ToString();
                txtsdt.Text = dg_nhanvien.Rows[dong].Cells[3].Value.ToString();
                cbgioitinh.Text = dg_nhanvien.Rows[dong].Cells[4].Value.ToString();
                txttentk.Text = dg_nhanvien.Rows[dong].Cells[5].Value.ToString();
                txtmatkhau.Text = dg_nhanvien.Rows[dong].Cells[6].Value.ToString();
                cbquyen.Text = dg_nhanvien.Rows[dong].Cells[7].Value.ToString();
            }
            catch
            { }
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (nutThem == true)
            {
                if (txttennv.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (datengaysinh.Value.Year == DateTime.Today.Year)
                {
                    MessageBox.Show("Chưa chọn ngày sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //else if (txtsdt.TextLength == 0)
                //{
                //    MessageBox.Show("Chưa nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                else if (cbgioitinh.Text == "")
                {
                    MessageBox.Show("Chưa chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txttentk.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền tên tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtmatkhau.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtmatkhau.TextLength < 6)
                {
                    MessageBox.Show("Mật khẩu quá ngắn, phải lớn hơn 6 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cbquyen.Text == "")
                {
                    MessageBox.Show("Chưa chọn quyền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txttentk.TextLength <= 3)
                {
                    MessageBox.Show("Tên tài khoản quá ngắn, phải dài hơn 3 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txttennv.TextLength >= 100)
                {
                    MessageBox.Show("Tên nhân viên quá dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtsdt.TextLength >= 13)
                {
                    MessageBox.Show("Số điện thoại quá dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txttentk.TextLength >= 50)
                {
                    MessageBox.Show("Tên tài quá dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtmatkhau.TextLength > 20)
                {
                    MessageBox.Show("Mật khẩu quá dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        nutThem = false;
                        InsertNhanVien();
                        InsertTaiKhoan();
                        LoadDataGrid();
                        Tat();
                        xulybutton(true);
                    }
                    catch (SqlException loi)
                    {
                        if (loi.Message.Contains("Violation of PRIMARY KEY constraint 'PK_TENTK'"))
                        {
                            MessageBox.Show("Tên tài khoản bị trùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            DeleteNhanVien_Loi();
                            nutThem = true;
                        }
                    }
                }
            }
            else if (nutSua == true)
            {
                if (txttennv.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (datengaysinh.Value.Year == DateTime.Today.Year)
                {
                    MessageBox.Show("Chưa chọn ngày sinh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                //else if (txtsdt.TextLength == 0)
                //{
                //    MessageBox.Show("Chưa nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
                else if (cbgioitinh.Text == "")
                {
                    MessageBox.Show("Chưa chọn giới tính.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txttentk.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền tên tài khoản.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtmatkhau.TextLength == 0)
                {
                    MessageBox.Show("Chưa điền mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtmatkhau.TextLength < 6)
                {
                    MessageBox.Show("Mật khẩu quá ngắn, phải lớn hơn 6 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cbquyen.Text == "")
                {
                    MessageBox.Show("Chưa chọn quyền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txttentk.TextLength <= 3)
                {
                    MessageBox.Show("Tên tài khoản quá ngắn, phải lớn hơn 3 ký tự.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txttennv.TextLength >= 100)
                {
                    MessageBox.Show("Tên nhân viên quá dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtsdt.TextLength >= 13)
                {
                    MessageBox.Show("Số điện thoại quá dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txttentk.TextLength >= 50)
                {
                    MessageBox.Show("Tên tài quá dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtmatkhau.TextLength > 20)
                {
                    MessageBox.Show("Mật khẩu quá dài.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    UpdateNhanVien();
                    UpdateTaiKhoan();
                    Tat();
                    xulybutton(true);
                    nutSua = false;
                    LoadDataGrid();
                }
            }
        }

        private void btLui_Click(object sender, EventArgs e)
        {
            try
            {
                int lui = dg_nhanvien.CurrentRow.Index - 1;
                if (lui != dg_nhanvien.Rows.Count + 1)
                {
                    dg_nhanvien.CurrentCell = dg_nhanvien.Rows[lui].Cells[dg_nhanvien.CurrentCell.ColumnIndex];
                    dg_nhanvien.Rows[lui].Selected = true;
                }
            }
            catch
            { }
        }

        private void btToii_Click(object sender, EventArgs e)
        {
            try
            {
                int toi = dg_nhanvien.CurrentRow.Index + 1;
                if (toi != dg_nhanvien.Rows.Count - 1)
                {
                    dg_nhanvien.CurrentCell = dg_nhanvien.Rows[toi].Cells[dg_nhanvien.CurrentCell.ColumnIndex];
                    dg_nhanvien.Rows[toi].Selected = true;
                }
            }
            catch
            { }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ChiDuocNhapSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // chỉ cho phép dấu thập phân
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
