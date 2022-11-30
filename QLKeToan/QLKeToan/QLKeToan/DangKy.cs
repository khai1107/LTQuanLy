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
using System.Threading;

namespace QLKeToan
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            CheckForIllegalCrossThreadCalls = false;//cái này dùng để kiểm tra xem có form nào đang tồn tại ở form chính ko nếu có thì sẽ tắt
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            rdnhanvien.Enabled = false;
        }
        NHANVIEN_BUL nv_bul = new NHANVIEN_BUL();
        TAIKHOAN_BUL tk_bul = new TAIKHOAN_BUL();
        int manv;
        string quyen = "";
        private void insertnhanvien()
        {
            NHANVIEN_PUBLIC nv_public = new NHANVIEN_PUBLIC();
            manv = nv_bul.count_nhanvien();
            nv_public.IDNV = "NV" + manv.ToString();
            nv_public.TENNV = txtHoVaTen.Text;          
            nv_public.SDT = txtSDT.Text;
            nv_public.NGAYSINH = DateTime.Parse(datengaysinh.Text);
            nv_public.GIOITINH = cboGioiTinh.Text;          
            nv_bul.insert_nhanvien(nv_public);
        }
        private void inserttaikhoan()
        {
            TAIKHOAN_PUBLIC tk_public = new TAIKHOAN_PUBLIC();
            tk_public.TENTK = txtTenTK.Text;
            tk_public.MATKHAU = txtMatKhau.Text;
            tk_public.QUYEN = quyen;
            tk_public.IDNV = "NV" + manv.ToString();
            tk_bul.insert_taikhoan(tk_public);
        }
        string duongdandk = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private void tatlbtrangthai()
        {
            Thread.Sleep(2000);
            lbtrangthai.Text = "";
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTenTK.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền tên tài khoản.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txtTenTK.TextLength <= 3)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Tên tài khoản quá ngắn.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txtTenTK.TextLength >= 50)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Tên tài khoản quá dài.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txtMatKhau.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền mật khẩu.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txtMatKhau.TextLength <= 6)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Mật khẩu quá ngắn.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txtMatKhau.TextLength >= 20)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "mật khẩu quá dài.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txtHoVaTen.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền họ và tên.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txtHoVaTen.TextLength >= 100)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Họ và tên quá dài.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }                 
            else if (txtSDT.TextLength == 0)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa điền số điện thoại.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else if (txtSDT.TextLength >= 12)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Số điện thoại quá dài.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            
            else if (cboGioiTinh.Text == "")
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa chọn giới tính.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            
            else if (rdadmin.Checked == false && rdnhanvien.Checked == false)
            {
                lbtrangthai.ForeColor = Color.Red;
                lbtrangthai.Text = "Chưa chọn quyền của tài khoản.";
                Thread t = new Thread(new ThreadStart(tatlbtrangthai));
                t.IsBackground = false;
                t.Start();
            }
            else
            {

                insertnhanvien();
                inserttaikhoan();
                this.Close();

            }
        }
        private void DeleteNhanVien_Loi()
        {
            NHANVIEN_PUBLIC nhanvien_public = new NHANVIEN_PUBLIC();
            nhanvien_public.IDNV = "NV" + manv.ToString();
            nv_bul.delete_nhanvien(nhanvien_public);
        }

        private void rdadmin_CheckedChanged(object sender, EventArgs e)
        {
            if (rdadmin.Checked == true)
            {
                quyen = "ADMIN";
            }
        }

        private void rdnhanvien_CheckedChanged(object sender, EventArgs e)
        {
            if (rdnhanvien.Checked == true)
            {
                quyen = "NHANVIEN";
            }
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

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChiDuocNhapSo(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
