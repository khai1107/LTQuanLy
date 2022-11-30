
namespace QLKeToan
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MNT_TrangChinh = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_KiemKe = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_BanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_MuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_KeToan = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_HDBH = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_HDMH = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_Thue = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_DoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_Kho = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.MNT_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.lbquyen = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNT_TrangChinh,
            this.MNT_KiemKe,
            this.MNT_KeToan,
            this.MNT_NhanVien,
            this.MNT_Kho,
            this.MNT_HeThong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(957, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MNT_TrangChinh
            // 
            this.MNT_TrangChinh.Name = "MNT_TrangChinh";
            this.MNT_TrangChinh.Size = new System.Drawing.Size(107, 25);
            this.MNT_TrangChinh.Text = "Trang chính";
            this.MNT_TrangChinh.Click += new System.EventHandler(this.MNT_TrangChinh_Click);
            // 
            // MNT_KiemKe
            // 
            this.MNT_KiemKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNT_BanHang,
            this.MNT_MuaHang});
            this.MNT_KiemKe.Name = "MNT_KiemKe";
            this.MNT_KiemKe.Size = new System.Drawing.Size(79, 25);
            this.MNT_KiemKe.Text = "Kiểm kê";
            // 
            // MNT_BanHang
            // 
            this.MNT_BanHang.Name = "MNT_BanHang";
            this.MNT_BanHang.Size = new System.Drawing.Size(152, 26);
            this.MNT_BanHang.Text = "Bán hàng";
            this.MNT_BanHang.Click += new System.EventHandler(this.MNT_BanHang_Click);
            // 
            // MNT_MuaHang
            // 
            this.MNT_MuaHang.Name = "MNT_MuaHang";
            this.MNT_MuaHang.Size = new System.Drawing.Size(152, 26);
            this.MNT_MuaHang.Text = "Mua hàng";
            this.MNT_MuaHang.Click += new System.EventHandler(this.MNT_MuaHang_Click);
            // 
            // MNT_KeToan
            // 
            this.MNT_KeToan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNT_HDBH,
            this.MNT_HDMH,
            this.MNT_Thue,
            this.MNT_DoanhThu});
            this.MNT_KeToan.Name = "MNT_KeToan";
            this.MNT_KeToan.Size = new System.Drawing.Size(77, 25);
            this.MNT_KeToan.Text = "Kế toán";
            // 
            // MNT_HDBH
            // 
            this.MNT_HDBH.Name = "MNT_HDBH";
            this.MNT_HDBH.Size = new System.Drawing.Size(217, 26);
            this.MNT_HDBH.Text = "Hóa đơn bán hàng";
            this.MNT_HDBH.Click += new System.EventHandler(this.MNT_HDBH_Click);
            // 
            // MNT_HDMH
            // 
            this.MNT_HDMH.Name = "MNT_HDMH";
            this.MNT_HDMH.Size = new System.Drawing.Size(217, 26);
            this.MNT_HDMH.Text = "Hóa đơn mua hàng";
            this.MNT_HDMH.Click += new System.EventHandler(this.MNT_HDMH_Click);
            // 
            // MNT_Thue
            // 
            this.MNT_Thue.Name = "MNT_Thue";
            this.MNT_Thue.Size = new System.Drawing.Size(217, 26);
            this.MNT_Thue.Text = "Thuế";
            this.MNT_Thue.Click += new System.EventHandler(this.MNT_Thue_Click);
            // 
            // MNT_DoanhThu
            // 
            this.MNT_DoanhThu.Name = "MNT_DoanhThu";
            this.MNT_DoanhThu.Size = new System.Drawing.Size(217, 26);
            this.MNT_DoanhThu.Text = "Báo cáo doanh thu";
            this.MNT_DoanhThu.Click += new System.EventHandler(this.MNT_DoanhThu_Click);
            // 
            // MNT_NhanVien
            // 
            this.MNT_NhanVien.Name = "MNT_NhanVien";
            this.MNT_NhanVien.Size = new System.Drawing.Size(95, 25);
            this.MNT_NhanVien.Text = "Nhân viên";
            this.MNT_NhanVien.Click += new System.EventHandler(this.MNT_NhanVien_Click);
            // 
            // MNT_Kho
            // 
            this.MNT_Kho.Name = "MNT_Kho";
            this.MNT_Kho.Size = new System.Drawing.Size(50, 25);
            this.MNT_Kho.Text = "Kho";
            this.MNT_Kho.Click += new System.EventHandler(this.MNT_Kho_Click);
            // 
            // MNT_HeThong
            // 
            this.MNT_HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNT_DangXuat,
            this.MNT_Thoat});
            this.MNT_HeThong.Name = "MNT_HeThong";
            this.MNT_HeThong.Size = new System.Drawing.Size(88, 25);
            this.MNT_HeThong.Text = "Hệ thống";
            // 
            // MNT_DangXuat
            // 
            this.MNT_DangXuat.Name = "MNT_DangXuat";
            this.MNT_DangXuat.Size = new System.Drawing.Size(155, 26);
            this.MNT_DangXuat.Text = "Đăng xuất";
            this.MNT_DangXuat.Click += new System.EventHandler(this.MNT_DangXuat_Click);
            // 
            // MNT_Thoat
            // 
            this.MNT_Thoat.Name = "MNT_Thoat";
            this.MNT_Thoat.Size = new System.Drawing.Size(155, 26);
            this.MNT_Thoat.Text = "Thoát";
            this.MNT_Thoat.Click += new System.EventHandler(this.MNT_Thoat_Click);
            // 
            // lbquyen
            // 
            this.lbquyen.AutoSize = true;
            this.lbquyen.Location = new System.Drawing.Point(745, 9);
            this.lbquyen.Name = "lbquyen";
            this.lbquyen.Size = new System.Drawing.Size(47, 13);
            this.lbquyen.TabIndex = 1;
            this.lbquyen.Text = "Quyền:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interface.Properties.Resources.kt;
            this.pictureBox1.Location = new System.Drawing.Point(0, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(957, 639);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbquyen);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Kế Toán Hàng Hóa";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MNT_TrangChinh;
        private System.Windows.Forms.ToolStripMenuItem MNT_KiemKe;
        private System.Windows.Forms.ToolStripMenuItem MNT_KeToan;
        private System.Windows.Forms.ToolStripMenuItem MNT_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem MNT_Kho;
        private System.Windows.Forms.ToolStripMenuItem MNT_HeThong;
        private System.Windows.Forms.ToolStripMenuItem MNT_BanHang;
        private System.Windows.Forms.ToolStripMenuItem MNT_MuaHang;
        private System.Windows.Forms.ToolStripMenuItem MNT_HDBH;
        private System.Windows.Forms.ToolStripMenuItem MNT_HDMH;
        private System.Windows.Forms.ToolStripMenuItem MNT_Thue;
        private System.Windows.Forms.ToolStripMenuItem MNT_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem MNT_Thoat;
        private System.Windows.Forms.ToolStripMenuItem MNT_DoanhThu;
        private System.Windows.Forms.Label lbquyen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

