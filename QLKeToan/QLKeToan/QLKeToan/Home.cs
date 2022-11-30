using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLKeToan.BUL;
using System.IO;

namespace QLKeToan
{
    public partial class Home : Form
    {
        public static Home trangchu;
        public Home()
        {
            InitializeComponent();
            trangchu = this;
        }
        //kiểm tra kết nối đến sql
        
        DoanhThu doanhthu = new DoanhThu();
        HoaDonMuaHang hdmh = new HoaDonMuaHang();
        HoaDonBanHang hdbh = new HoaDonBanHang();
        Kho kho = new Kho();
        Thue thue = new Thue();
        BanHang banhang = new BanHang();
        MuaHang muahang = new MuaHang();
        NhanVien nhanvien = new NhanVien();
        //tạo các nút chức năng chưa có sự kiện gì
        private bool bdoanhthu = false, bhdmh = false, bnhanvien = false, bkho = false, 
                     bhdbh = false, bthue = false, bbanhang = false, bmuahang = false;

        private void MNT_MuaHang_Click(object sender, EventArgs e)
        {
            MNT_BanHang.ForeColor = SystemColors.ControlText;
            MNT_HDBH.ForeColor = SystemColors.ControlText;
            MNT_HDMH.ForeColor = SystemColors.ControlText;
            MNT_MuaHang.ForeColor = Color.Chocolate;
            MNT_Thue.ForeColor = SystemColors.ControlText;
            MNT_DoanhThu.ForeColor = SystemColors.ControlText;
            MNT_NhanVien.ForeColor = SystemColors.ControlText;
            MNT_Kho.ForeColor = SystemColors.ControlText;
            if (bbanhang == true)
            {
                bbanhang = false;
                banhang.Hide();
                bmuahang = true;              
                muahang.TopLevel = false;
                pictureBox1.Controls.Add(muahang);
                muahang.FormBorderStyle = FormBorderStyle.None;
                muahang.Show();
            }
            else if (bhdbh == true)//nếu form bàn ăn đang hiện
            {
                bhdbh = false;
                hdbh.Hide();
                bmuahang = true;
                muahang.TopLevel = false;
                pictureBox1.Controls.Add(muahang);
                muahang.FormBorderStyle = FormBorderStyle.None;
                muahang.Show();
            }
            else if (bhdmh == true)
            {
                bhdmh = false;
                hdmh.Hide();
                bmuahang = true;
                muahang.TopLevel = false;
                pictureBox1.Controls.Add(muahang);
                muahang.FormBorderStyle = FormBorderStyle.None;
                muahang.Show();
            }
            else if (bthue == true)
            {
                bthue = false;
                thue.Hide();
                bmuahang = true;
                muahang.TopLevel = false;
                pictureBox1.Controls.Add(muahang);
                muahang.FormBorderStyle = FormBorderStyle.None;
                muahang.Show();
            }
            else if (bkho == true)
            {
                bkho = false;
                kho.Hide();
                bmuahang = true;
                muahang.TopLevel = false;
                pictureBox1.Controls.Add(muahang);
                muahang.FormBorderStyle = FormBorderStyle.None;
                muahang.Show();
            }
            else if (bnhanvien == true)
            {
                bnhanvien = false;
                nhanvien.Hide();
                bmuahang = true;
                muahang.TopLevel = false;
                pictureBox1.Controls.Add(muahang);
                muahang.FormBorderStyle = FormBorderStyle.None;
                muahang.Show();
            }
            else if (bdoanhthu == true)
            {
                bdoanhthu = false;
                doanhthu.Hide();
                bmuahang = true;
                muahang.TopLevel = false;
                pictureBox1.Controls.Add(muahang);
                muahang.FormBorderStyle = FormBorderStyle.None;
                muahang.Show();
            }
            else //ko có form nào hiện
            {
                bmuahang = true;
                muahang.TopLevel = false;
                pictureBox1.Controls.Add(muahang);
                muahang.FormBorderStyle = FormBorderStyle.None;
                muahang.Show();
            }
        }

        private void MNT_HDBH_Click(object sender, EventArgs e)
        {
            MNT_BanHang.ForeColor = SystemColors.ControlText;
            MNT_MuaHang.ForeColor = SystemColors.ControlText;
            MNT_HDBH.ForeColor = Color.Chocolate;
            MNT_HDMH.ForeColor = SystemColors.ControlText;
            MNT_Thue.ForeColor = SystemColors.ControlText;
            MNT_DoanhThu.ForeColor = SystemColors.ControlText;
            MNT_NhanVien.ForeColor = SystemColors.ControlText;
            MNT_Kho.ForeColor = SystemColors.ControlText;
            if (bbanhang == true)
            {
                bbanhang = false;
                banhang.Hide();
                bhdbh = true;
                hdbh.TopLevel = false;
                pictureBox1.Controls.Add(hdbh);
                hdbh.FormBorderStyle = FormBorderStyle.None;
                hdbh.Show();
            }
            else if (bmuahang == true)//nếu form bàn ăn đang hiện
            {
                bmuahang = false;
                muahang.Hide();
                bhdbh = true;
                hdbh.TopLevel = false;
                pictureBox1.Controls.Add(hdbh);
                hdbh.FormBorderStyle = FormBorderStyle.None;
                hdbh.Show();
            }
            else if (bhdmh == true)
            {
                bhdmh = false;
                hdmh.Hide();
                bhdbh = true;
                hdbh.TopLevel = false;
                pictureBox1.Controls.Add(hdbh);
                hdbh.FormBorderStyle = FormBorderStyle.None;
                hdbh.Show();
            }
            else if (bthue == true)
            {
                bthue = false;
                thue.Hide();
                bhdbh = true;
                hdbh.TopLevel = false;
                pictureBox1.Controls.Add(hdbh);
                hdbh.FormBorderStyle = FormBorderStyle.None;
                hdbh.Show();
            }
            else if (bkho == true)
            {
                bkho = false;
                kho.Hide();
                bhdbh = true;
                hdbh.TopLevel = false;
                pictureBox1.Controls.Add(hdbh);
                hdbh.FormBorderStyle = FormBorderStyle.None;
                hdbh.Show();
            }
            else if (bnhanvien == true)
            {
                bnhanvien = false;
                nhanvien.Hide();
                bhdbh = true;
                hdbh.TopLevel = false;
                pictureBox1.Controls.Add(hdbh);
                hdbh.FormBorderStyle = FormBorderStyle.None;
                hdbh.Show();
            }
            else if (bdoanhthu == true)
            {
                bdoanhthu = false;
                doanhthu.Hide();
                bhdbh = true;
                hdbh.TopLevel = false;
                pictureBox1.Controls.Add(hdbh);
                hdbh.FormBorderStyle = FormBorderStyle.None;
                hdbh.Show();
            }
            else //ko có form nào hiện
            {
                bhdbh = true;
                hdbh.TopLevel = false;
                pictureBox1.Controls.Add(hdbh);
                hdbh.FormBorderStyle = FormBorderStyle.None;
                hdbh.Show();
            }
        }

        private void MNT_HDMH_Click(object sender, EventArgs e)
        {
            MNT_BanHang.ForeColor = SystemColors.ControlText;
            MNT_MuaHang.ForeColor = SystemColors.ControlText;
            MNT_HDBH.ForeColor = SystemColors.ControlText;
            MNT_HDMH.ForeColor = Color.Chocolate;
            MNT_Thue.ForeColor = SystemColors.ControlText;
            MNT_DoanhThu.ForeColor = SystemColors.ControlText;
            MNT_NhanVien.ForeColor = SystemColors.ControlText;
            MNT_Kho.ForeColor = SystemColors.ControlText;
            if (bbanhang == true)
            {
                bbanhang = false;
                banhang.Hide();
                bhdmh = true;
                hdmh.TopLevel = false;
                pictureBox1.Controls.Add(hdmh);
                hdmh.FormBorderStyle = FormBorderStyle.None;
                hdmh.Show();
            }
            else if (bmuahang == true)//nếu form bàn ăn đang hiện
            {
                bmuahang = false;
                muahang.Hide();
                bhdmh = true;
                hdmh.TopLevel = false;
                pictureBox1.Controls.Add(hdmh);
                hdmh.FormBorderStyle = FormBorderStyle.None;
                hdmh.Show();
            }
            else if (bhdbh == true)
            {
                bhdbh = false;
                hdbh.Hide();
                bhdmh = true;
                hdmh.TopLevel = false;
                pictureBox1.Controls.Add(hdmh);
                hdmh.FormBorderStyle = FormBorderStyle.None;
                hdmh.Show();
            }
            else if (bthue == true)
            {
                bthue = false;
                thue.Hide();
                bhdmh = true;
                hdmh.TopLevel = false;
                pictureBox1.Controls.Add(hdmh);
                hdmh.FormBorderStyle = FormBorderStyle.None;
                hdmh.Show();
            }
            else if (bkho == true)
            {
                bkho = false;
                kho.Hide();
                bhdmh = true;
                hdmh.TopLevel = false;
                pictureBox1.Controls.Add(hdmh);
                hdmh.FormBorderStyle = FormBorderStyle.None;
                hdmh.Show();
            }
            else if (bnhanvien == true)
            {
                bnhanvien = false;
                nhanvien.Hide();
                bhdmh = true;
                hdmh.TopLevel = false;
                pictureBox1.Controls.Add(hdmh);
                hdmh.FormBorderStyle = FormBorderStyle.None;
                hdmh.Show();
            }
            else if (bdoanhthu == true)
            {
                bdoanhthu = false;
                doanhthu.Hide();
                bhdmh = true;
                hdmh.TopLevel = false;
                pictureBox1.Controls.Add(hdmh);
                hdmh.FormBorderStyle = FormBorderStyle.None;
                hdmh.Show();
            }
            else //ko có form nào hiện
            {
                bhdmh = true;
                hdmh.TopLevel = false;
                pictureBox1.Controls.Add(hdmh);
                hdmh.FormBorderStyle = FormBorderStyle.None;
                hdmh.Show();
            }
        }

        private void MNT_Thue_Click(object sender, EventArgs e)
        {
            MNT_BanHang.ForeColor = SystemColors.ControlText;
            MNT_MuaHang.ForeColor = SystemColors.ControlText;
            MNT_HDBH.ForeColor = SystemColors.ControlText;
            MNT_Thue.ForeColor = Color.Chocolate;
            MNT_HDMH.ForeColor = SystemColors.ControlText;
            MNT_DoanhThu.ForeColor = SystemColors.ControlText;
            MNT_NhanVien.ForeColor = SystemColors.ControlText;
            MNT_Kho.ForeColor = SystemColors.ControlText;
            if (bbanhang == true)
            {
                bbanhang = false;
                banhang.Hide();
                bthue = true;
                hdmh.TopLevel = false;
                pictureBox1.Controls.Add(thue);
                thue.FormBorderStyle = FormBorderStyle.None;
                thue.Show();
            }
            else if (bmuahang == true)//nếu form bàn ăn đang hiện
            {
                bmuahang = false;
                muahang.Hide();
                bthue = true;
                thue.TopLevel = false;
                pictureBox1.Controls.Add(thue);
                thue.FormBorderStyle = FormBorderStyle.None;
                thue.Show();
            }
            else if (bhdbh == true)
            {
                bhdbh = false;
                hdbh.Hide();
                bthue = true;
                thue.TopLevel = false;
                pictureBox1.Controls.Add(thue);
                thue.FormBorderStyle = FormBorderStyle.None;
                thue.Show();
            }
            else if (bhdmh == true)
            {
                bhdmh = false;
                hdmh.Hide();
                bthue = true;
                thue.TopLevel = false;
                pictureBox1.Controls.Add(thue);
                thue.FormBorderStyle = FormBorderStyle.None;
                thue.Show();
            }
            else if (bkho == true)
            {
                bkho = false;
                kho.Hide();
                bthue = true;
                thue.TopLevel = false;
                pictureBox1.Controls.Add(thue);
                thue.FormBorderStyle = FormBorderStyle.None;
                thue.Show();
            }
            else if (bnhanvien == true)
            {
                bnhanvien = false;
                nhanvien.Hide();
                bthue = true;
                thue.TopLevel = false;
                pictureBox1.Controls.Add(thue);
                thue.FormBorderStyle = FormBorderStyle.None;
                thue.Show();
            }
            else if (bdoanhthu == true)
            {
                bdoanhthu = false;
                doanhthu.Hide();
                bthue = true;
                thue.TopLevel = false;
                pictureBox1.Controls.Add(thue);
                thue.FormBorderStyle = FormBorderStyle.None;
                thue.Show();
            }
            else //ko có form nào hiện
            {
                bthue = true;
                thue.TopLevel = false;
                pictureBox1.Controls.Add(thue);
                thue.FormBorderStyle = FormBorderStyle.None;
                thue.Show();
            }
        }

        private void MNT_DoanhThu_Click(object sender, EventArgs e)
        {
            MNT_BanHang.ForeColor = SystemColors.ControlText;
            MNT_MuaHang.ForeColor = SystemColors.ControlText;
            MNT_HDBH.ForeColor = SystemColors.ControlText;
            MNT_DoanhThu.ForeColor = Color.Chocolate;
            MNT_HDMH.ForeColor = SystemColors.ControlText;
            MNT_Thue.ForeColor = SystemColors.ControlText;
            MNT_NhanVien.ForeColor = SystemColors.ControlText;
            MNT_Kho.ForeColor = SystemColors.ControlText;
            if (bbanhang == true)
            {
                bbanhang = false;
                banhang.Hide();
                bdoanhthu = true;
                doanhthu.TopLevel = false;
                pictureBox1.Controls.Add(doanhthu);
                doanhthu.FormBorderStyle = FormBorderStyle.None;
                doanhthu.Show();
            }
            else if (bmuahang == true)//nếu form bàn ăn đang hiện
            {
                bmuahang = false;
                muahang.Hide();
                bdoanhthu = true;
                doanhthu.TopLevel = false;
                pictureBox1.Controls.Add(doanhthu);
                doanhthu.FormBorderStyle = FormBorderStyle.None;
                doanhthu.Show();
            }
            else if (bhdbh == true)
            {
                bhdbh = false;
                hdbh.Hide();
                bdoanhthu = true;
                doanhthu.TopLevel = false;
                pictureBox1.Controls.Add(doanhthu);
                doanhthu.FormBorderStyle = FormBorderStyle.None;
                doanhthu.Show();
            }
            else if (bhdmh == true)
            {
                bhdmh = false;
                hdmh.Hide();
                bdoanhthu = true;
                doanhthu.TopLevel = false;
                pictureBox1.Controls.Add(doanhthu);
                doanhthu.FormBorderStyle = FormBorderStyle.None;
                doanhthu.Show();
            }
            else if (bkho == true)
            {
                bkho = false;
                kho.Hide();
                bdoanhthu = true;
                doanhthu.TopLevel = false;
                pictureBox1.Controls.Add(doanhthu);
                doanhthu.FormBorderStyle = FormBorderStyle.None;
                doanhthu.Show();
            }
            else if (bnhanvien == true)
            {
                bnhanvien = false;
                nhanvien.Hide();
                bdoanhthu = true;
                doanhthu.TopLevel = false;
                pictureBox1.Controls.Add(doanhthu);
                doanhthu.FormBorderStyle = FormBorderStyle.None;
                doanhthu.Show();
            }
            else if (bthue == true)
            {
                bthue = false;
                thue.Hide();
                bdoanhthu = true;
                doanhthu.TopLevel = false;
                pictureBox1.Controls.Add(doanhthu);
                doanhthu.FormBorderStyle = FormBorderStyle.None;
                doanhthu.Show();
            }
            else //ko có form nào hiện
            {
                bdoanhthu = true;
                doanhthu.TopLevel = false;
                pictureBox1.Controls.Add(doanhthu);
                doanhthu.FormBorderStyle = FormBorderStyle.None;
                doanhthu.Show();
            }
        }

        private void MNT_NhanVien_Click(object sender, EventArgs e)
        {
            MNT_BanHang.ForeColor = SystemColors.ControlText;
            MNT_MuaHang.ForeColor = SystemColors.ControlText;
            MNT_HDBH.ForeColor = SystemColors.ControlText;
            MNT_NhanVien.ForeColor = Color.Chocolate;
            MNT_HDMH.ForeColor = SystemColors.ControlText;
            MNT_Thue.ForeColor = SystemColors.ControlText;
            MNT_DoanhThu.ForeColor = SystemColors.ControlText;
            MNT_Kho.ForeColor = SystemColors.ControlText;
            if (bbanhang == true)
            {
                bbanhang = false;
                banhang.Hide();
                bnhanvien = true;
                nhanvien.TopLevel = false;
                pictureBox1.Controls.Add(nhanvien);
                nhanvien.FormBorderStyle = FormBorderStyle.None;
                nhanvien.Show();
            }
            else if (bmuahang == true)//nếu form bàn ăn đang hiện
            {
                bmuahang = false;
                muahang.Hide();
                bnhanvien = true;
                nhanvien.TopLevel = false;
                pictureBox1.Controls.Add(nhanvien);
                nhanvien.FormBorderStyle = FormBorderStyle.None;
                nhanvien.Show();
            }
            else if (bhdbh == true)
            {
                bhdbh = false;
                hdbh.Hide();
                bnhanvien = true;
                nhanvien.TopLevel = false;
                pictureBox1.Controls.Add(nhanvien);
                nhanvien.FormBorderStyle = FormBorderStyle.None;
                nhanvien.Show();
            }
            else if (bhdmh == true)
            {
                bhdmh = false;
                hdmh.Hide();
                bnhanvien = true;
                nhanvien.TopLevel = false;
                pictureBox1.Controls.Add(nhanvien);
                nhanvien.FormBorderStyle = FormBorderStyle.None;
                nhanvien.Show();
            }
            else if (bkho == true)
            {
                bkho = false;
                kho.Hide();
                bnhanvien = true;
                nhanvien.TopLevel = false;
                pictureBox1.Controls.Add(nhanvien);
                nhanvien.FormBorderStyle = FormBorderStyle.None;
                nhanvien.Show();
            }
            else if (bdoanhthu == true)
            {
                bdoanhthu = false;
                doanhthu.Hide();
                bnhanvien = true;
                nhanvien.TopLevel = false;
                pictureBox1.Controls.Add(nhanvien);
                nhanvien.FormBorderStyle = FormBorderStyle.None;
                nhanvien.Show();
            }
            else if (bthue == true)
            {
                bthue = false;
                thue.Hide();
                bnhanvien = true;
                nhanvien.TopLevel = false;
                pictureBox1.Controls.Add(nhanvien);
                nhanvien.FormBorderStyle = FormBorderStyle.None;
                nhanvien.Show();
            }
            else //ko có form nào hiện
            {
                bnhanvien = true;
                nhanvien.TopLevel = false;
                pictureBox1.Controls.Add(nhanvien);
                nhanvien.FormBorderStyle = FormBorderStyle.None;
                nhanvien.Show();
            }
        }

        private void MNT_Kho_Click(object sender, EventArgs e)
        {
            MNT_BanHang.ForeColor = SystemColors.ControlText;
            MNT_MuaHang.ForeColor = SystemColors.ControlText;
            MNT_HDBH.ForeColor = SystemColors.ControlText;
            MNT_Kho.ForeColor = Color.Chocolate;
            MNT_HDMH.ForeColor = SystemColors.ControlText;
            MNT_Thue.ForeColor = SystemColors.ControlText;
            MNT_DoanhThu.ForeColor = SystemColors.ControlText;
            MNT_NhanVien.ForeColor = SystemColors.ControlText;
            if (bbanhang == true)
            {
                bbanhang = false;
                banhang.Hide();
                bkho = true;
                kho.TopLevel = false;
                pictureBox1.Controls.Add(kho);
                kho.FormBorderStyle = FormBorderStyle.None;
                kho.Show();
            }
            else if (bmuahang == true)//nếu form bàn ăn đang hiện
            {
                bmuahang = false;
                muahang.Hide();
                bkho = true;
                kho.TopLevel = false;
                pictureBox1.Controls.Add(kho);
                kho.FormBorderStyle = FormBorderStyle.None;
                kho.Show();
            }
            else if (bhdbh == true)
            {
                bhdbh = false;
                hdbh.Hide();
                bkho = true;
                kho.TopLevel = false;
                pictureBox1.Controls.Add(kho);
                kho.FormBorderStyle = FormBorderStyle.None;
                kho.Show();
            }
            else if (bhdmh == true)
            {
                bhdmh = false;
                hdmh.Hide();
                bkho = true;
                kho.TopLevel = false;
                pictureBox1.Controls.Add(kho);
                kho.FormBorderStyle = FormBorderStyle.None;
                kho.Show();
            }
            else if (bnhanvien == true)
            {
                bnhanvien = false;
                nhanvien.Hide();
                bkho = true;
                kho.TopLevel = false;
                pictureBox1.Controls.Add(kho);
                kho.FormBorderStyle = FormBorderStyle.None;
                kho.Show();
            }
            else if (bdoanhthu == true)
            {
                bdoanhthu = false;
                doanhthu.Hide();
                bkho = true;
                kho.TopLevel = false;
                pictureBox1.Controls.Add(kho);
                kho.FormBorderStyle = FormBorderStyle.None;
                kho.Show();
            }
            else if (bthue == true)
            {
                bthue = false;
                thue.Hide();
                bkho = true;
                kho.TopLevel = false;
                pictureBox1.Controls.Add(kho);
                kho.FormBorderStyle = FormBorderStyle.None;
                kho.Show();
            }
            else //ko có form nào hiện
            {
                bkho = true;
                kho.TopLevel = false;
                pictureBox1.Controls.Add(kho);
                kho.FormBorderStyle = FormBorderStyle.None;
                kho.Show();
            }
        }

        private void MNT_TrangChinh_Click(object sender, EventArgs e)
        {
            doanhthu.Hide();
            thue.Hide();
            hdbh.Hide();
            hdmh.Hide();
            nhanvien.Hide();
            kho.Hide();
            banhang.Hide();
            muahang.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
            EnableMNT();//ẩn hết các menustrip để hiện form đăng nhập lên
            DangNhap dn = new DangNhap();
            dn.FormClosing += new FormClosingEventHandler(dn.DangNhap_FormClosing_1);//khi này nếu thoát form đăng nhập đồng thời sẽ thoát luôn form Home
            dn.ShowDialog();
        }
        private void EnableMNT()//ẩn các menu strip
        {
            MNT_TrangChinh.Enabled = false;
            MNT_KiemKe.Enabled = false;
            MNT_KeToan.Enabled = false;
            MNT_NhanVien.Enabled = false;
            MNT_Kho.Enabled = false;
            MNT_HeThong.Enabled = false;
            lbquyen.Hide();
        }

        private void MNT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MNT_BanHang_Click(object sender, EventArgs e)
        {
            //chỉnh màu chữ cho các toolstrip khi dc chọn hoặc ko chọn
            MNT_MuaHang.ForeColor = SystemColors.ControlText;
            MNT_HDBH.ForeColor = SystemColors.ControlText;
            MNT_BanHang.ForeColor = Color.Chocolate;
            MNT_Thue.ForeColor = SystemColors.ControlText;
            MNT_DoanhThu.ForeColor = SystemColors.ControlText;
            MNT_NhanVien.ForeColor = SystemColors.ControlText;
            MNT_Kho.ForeColor = SystemColors.ControlText;
            if (bmuahang == true) //nếu form muanhang đang dc mở
            {
                bmuahang = false;//sẽ đóng form muahang
                muahang.Hide();//form muahang ẩn
                bbanhang = true;//form banhang sẽ cho true
                //vì form nhanvien được kế thừa từ tên class tên System.Windows.Forms nên khi đó topLevel sẽ bằng true lúc này sẽ báo lỗi ko add dc
                //nên phải cho nó bằng false để add vào pictureBox
                banhang.TopLevel = false;
                pictureBox1.Controls.Add(banhang);//pictureBox sẽ add form banhang vào
                banhang.FormBorderStyle = FormBorderStyle.None;//định dạng cho form ko còn dấu thoát hoặc phóng lớn
                banhang.Show();//và form banhang sẽ dc show lên
            }
            else if (bhdbh == true)
            {
                bhdbh = false;
                hdbh.Hide();
                bbanhang = true;
                banhang.TopLevel = false;
                pictureBox1.Controls.Add(banhang);
                banhang.FormBorderStyle = FormBorderStyle.None;
                banhang.Show();
            }
            else if (bhdmh == true)
            {
                bhdmh = false;
                hdmh.Hide();
                bbanhang = true;
                banhang.TopLevel = false;
                pictureBox1.Controls.Add(banhang);
                banhang.FormBorderStyle = FormBorderStyle.None;
                banhang.Show();
            }
            else if (bthue == true)
            {
                bthue = false;
                thue.Hide();
                bbanhang = true;
                banhang.TopLevel = false;
                pictureBox1.Controls.Add(banhang);
                banhang.FormBorderStyle = FormBorderStyle.None;
                banhang.Show();
            }
            else if (bkho == true)
            {
                bkho = false;
                kho.Hide();
                bbanhang = true;
                banhang.TopLevel = false;
                pictureBox1.Controls.Add(banhang);
                banhang.FormBorderStyle = FormBorderStyle.None;
                banhang.Show();
            }
            else if (bnhanvien == true)
            {
                bnhanvien = false;
                nhanvien.Hide();
                bbanhang = true;
                banhang.TopLevel = false;
                pictureBox1.Controls.Add(banhang);
                banhang.FormBorderStyle = FormBorderStyle.None;
                banhang.Show();
            }
            else if (bdoanhthu == true)
            {
                bdoanhthu = false;
                doanhthu.Hide();
                bbanhang = true;
                banhang.TopLevel = false;
                pictureBox1.Controls.Add(banhang);
                banhang.FormBorderStyle = FormBorderStyle.None;
                banhang.Show();
            }
            else //ko có form nào hiện
            {
                bbanhang = true;
                banhang.TopLevel = false;
                pictureBox1.Controls.Add(banhang);
                banhang.FormBorderStyle = FormBorderStyle.None;
                banhang.Show();
            }
        }

        private string IDNV = "", quyenofnv = "";

        private void MNT_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.ShowDialog();
            Application.Exit();
        }

        internal void EnableQuyen(string quyennv, string tennv, string idnv)
        {
            if (quyennv == "ADMIN")
            {
                MNT_TrangChinh.Enabled = true;
                MNT_KiemKe.Enabled = true;
                MNT_KeToan.Enabled = true;
                MNT_NhanVien.Enabled = true;
                MNT_Kho.Enabled = true;
                MNT_HeThong.Enabled = true;
                lbquyen.Show();
                lbquyen.Text = "Admin: " + tennv;
                IDNV = idnv;
                quyenofnv = quyennv;
            }
            else if (quyennv == "NHANVIEN")
            {
                MNT_TrangChinh.Enabled = true;               
                MNT_KeToan.Enabled = true;
                MNT_Kho.Enabled = true;
                MNT_HeThong.Enabled = true;
                lbquyen.Show();
                lbquyen.Text = "Nhân viên: " + tennv;
                IDNV = idnv;
                quyenofnv = quyennv;
            }
        }
    }
}
