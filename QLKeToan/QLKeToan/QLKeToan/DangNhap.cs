using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PUBLIC;
using BUL;

namespace QLKeToan
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        TAIKHOAN_BUL taikhoan_pul = new TAIKHOAN_BUL();
        string quyen = "", ten = "", idnv = "";
        //internal FormClosingEventHandler DangNhap_FormClosing;

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txttendangnhap.Focus();
        }

        

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TAIKHOAN_PUBLIC taikhoan_public = new TAIKHOAN_PUBLIC();
            taikhoan_public.TENTK = txttendangnhap.Text;//gán biến đã khai báo vào các textbox tưởng ứng
            taikhoan_public.MATKHAU = txtmatkhau.Text;
            int checkpass = taikhoan_pul.check_taikhoan(taikhoan_public);
            if (checkpass == 0)
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttendangnhap.Focus();
            }
            else if (checkpass == 1)
            {
                DataTable dt_quyenvaten = taikhoan_pul.get_tenvaquyen_taikhoan(taikhoan_public);//tạo bảng để chứa quyền và tên của tài khoản
                quyen = dt_quyenvaten.Rows[0][0].ToString();//quyền sẽ là cột 1 
                ten = dt_quyenvaten.Rows[0][1].ToString(); //tên sẽ là cột 2
                idnv = dt_quyenvaten.Rows[0][2].ToString(); //ID của nhân viên sẽ là cột 3
                this.Close();
            }
        }     

        private void btnThoat_MouseMove(object sender, MouseEventArgs e)
        {
            btnThoat.BackColor = Color.Chocolate;
            btnThoat.ForeColor = Color.Yellow;
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.Transparent;
            btnThoat.ForeColor = SystemColors.ControlText;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        internal void DangNhap_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Home.trangchu.EnableQuyen(quyen, ten, idnv);
        }

        private void btnDangNhap_MouseMove(object sender, MouseEventArgs e)
        {
            btnDangNhap.BackColor = Color.Chocolate;
            btnDangNhap.ForeColor = Color.Yellow;
        }

        private void btnDangNhap_MouseLeave(object sender, EventArgs e)
        {
            btnDangNhap.BackColor = Color.Transparent;
            btnDangNhap.ForeColor = SystemColors.ControlText;
        }

    }
}
