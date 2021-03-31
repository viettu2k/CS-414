namespace QuanLyBanDoGomLuuNiem
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnu_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_LoaiTra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_NhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_HangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_HoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_HoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_BaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_HangTon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_TroGiupCon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_VaiNet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_File,
            this.mnu_DanhMuc,
            this.mnu_HoaDon,
            this.mnu_TimKiem,
            this.mnu_BaoCao,
            this.mnu_TroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnu_File
            // 
            this.mnu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Thoat});
            this.mnu_File.Name = "mnu_File";
            this.mnu_File.Size = new System.Drawing.Size(69, 24);
            this.mnu_File.Text = "Tập tin";
            // 
            // mnu_Thoat
            // 
            this.mnu_Thoat.Name = "mnu_Thoat";
            this.mnu_Thoat.Size = new System.Drawing.Size(130, 26);
            this.mnu_Thoat.Text = "Thoát";
            this.mnu_Thoat.Click += new System.EventHandler(this.mnu_Thoat_Click);
            // 
            // mnu_DanhMuc
            // 
            this.mnu_DanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_LoaiTra,
            this.mnu_NhanVien,
            this.mnu_KhachHang,
            this.mnu_HangHoa});
            this.mnu_DanhMuc.Name = "mnu_DanhMuc";
            this.mnu_DanhMuc.Size = new System.Drawing.Size(90, 24);
            this.mnu_DanhMuc.Text = "Danh mục";
            // 
            // mnu_LoaiTra
            // 
            this.mnu_LoaiTra.Name = "mnu_LoaiTra";
            this.mnu_LoaiTra.Size = new System.Drawing.Size(169, 26);
            this.mnu_LoaiTra.Text = "Loại Trà";
            this.mnu_LoaiTra.Click += new System.EventHandler(this.mnu_LoaiTra_Click);
            // 
            // mnu_NhanVien
            // 
            this.mnu_NhanVien.Name = "mnu_NhanVien";
            this.mnu_NhanVien.Size = new System.Drawing.Size(169, 26);
            this.mnu_NhanVien.Text = "Nhân viên";
            this.mnu_NhanVien.Click += new System.EventHandler(this.mnu_NhanVien_Click);
            // 
            // mnu_KhachHang
            // 
            this.mnu_KhachHang.Name = "mnu_KhachHang";
            this.mnu_KhachHang.Size = new System.Drawing.Size(169, 26);
            this.mnu_KhachHang.Text = "Khách hàng";
            this.mnu_KhachHang.Click += new System.EventHandler(this.mnu_KhachHang_Click);
            // 
            // mnu_HangHoa
            // 
            this.mnu_HangHoa.Name = "mnu_HangHoa";
            this.mnu_HangHoa.Size = new System.Drawing.Size(169, 26);
            this.mnu_HangHoa.Text = "Hàng hóa";
            this.mnu_HangHoa.Click += new System.EventHandler(this.mnu_HangHoa_Click);
            // 
            // mnu_HoaDon
            // 
            this.mnu_HoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_HoaDonBan});
            this.mnu_HoaDon.Name = "mnu_HoaDon";
            this.mnu_HoaDon.Size = new System.Drawing.Size(81, 24);
            this.mnu_HoaDon.Text = "Hóa đơn";
            // 
            // mnu_HoaDonBan
            // 
            this.mnu_HoaDonBan.Name = "mnu_HoaDonBan";
            this.mnu_HoaDonBan.Size = new System.Drawing.Size(179, 26);
            this.mnu_HoaDonBan.Text = "Hóa đơn bán";
            this.mnu_HoaDonBan.Click += new System.EventHandler(this.mnu_HoaDonBan_Click);
            // 
            // mnu_TimKiem
            // 
            this.mnu_TimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnToolStripMenuItem1,
            this.hàngToolStripMenuItem,
            this.kháchHàngToolStripMenuItem1});
            this.mnu_TimKiem.Name = "mnu_TimKiem";
            this.mnu_TimKiem.Size = new System.Drawing.Size(84, 24);
            this.mnu_TimKiem.Text = "Tìm kiếm";
            // 
            // hóaĐơnToolStripMenuItem1
            // 
            this.hóaĐơnToolStripMenuItem1.Name = "hóaĐơnToolStripMenuItem1";
            this.hóaĐơnToolStripMenuItem1.Size = new System.Drawing.Size(169, 26);
            this.hóaĐơnToolStripMenuItem1.Text = "Hóa đơn";
            
            // 
            // hàngToolStripMenuItem
            // 
            this.hàngToolStripMenuItem.Name = "hàngToolStripMenuItem";
            this.hàngToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.hàngToolStripMenuItem.Text = "Hàng";
            // 
            // kháchHàngToolStripMenuItem1
            // 
            this.kháchHàngToolStripMenuItem1.Name = "kháchHàngToolStripMenuItem1";
            this.kháchHàngToolStripMenuItem1.Size = new System.Drawing.Size(169, 26);
            this.kháchHàngToolStripMenuItem1.Text = "Khách hàng";
            // 
            // mnu_BaoCao
            // 
            this.mnu_BaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_HangTon,
            this.mnu_DoanhThu});
            this.mnu_BaoCao.Name = "mnu_BaoCao";
            this.mnu_BaoCao.Size = new System.Drawing.Size(77, 24);
            this.mnu_BaoCao.Text = "Báo cáo";
            // 
            // mnu_HangTon
            // 
            this.mnu_HangTon.Name = "mnu_HangTon";
            this.mnu_HangTon.Size = new System.Drawing.Size(161, 26);
            this.mnu_HangTon.Text = "Hàng tồn";
            // 
            // mnu_DoanhThu
            // 
            this.mnu_DoanhThu.Name = "mnu_DoanhThu";
            this.mnu_DoanhThu.Size = new System.Drawing.Size(161, 26);
            this.mnu_DoanhThu.Text = "Doanh thu";
            // 
            // mnu_TroGiup
            // 
            this.mnu_TroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_TroGiupCon,
            this.mnu_VaiNet});
            this.mnu_TroGiup.Name = "mnu_TroGiup";
            this.mnu_TroGiup.Size = new System.Drawing.Size(78, 24);
            this.mnu_TroGiup.Text = "Trợ giúp";
            // 
            // mnu_TroGiupCon
            // 
            this.mnu_TroGiupCon.Name = "mnu_TroGiupCon";
            this.mnu_TroGiupCon.Size = new System.Drawing.Size(147, 26);
            this.mnu_TroGiupCon.Text = "Trợ giúp";
            // 
            // mnu_VaiNet
            // 
            this.mnu_VaiNet.Name = "mnu_VaiNet";
            this.mnu_VaiNet.Size = new System.Drawing.Size(147, 26);
            this.mnu_VaiNet.Text = "Vài nét";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 693);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frm_Main";
            this.Text = "frm_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_File;
        private System.Windows.Forms.ToolStripMenuItem mnu_Thoat;
        private System.Windows.Forms.ToolStripMenuItem mnu_DanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnu_LoaiTra;
        private System.Windows.Forms.ToolStripMenuItem mnu_NhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnu_KhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnu_HangHoa;
        private System.Windows.Forms.ToolStripMenuItem mnu_HoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnu_HoaDonBan;
        private System.Windows.Forms.ToolStripMenuItem mnu_TimKiem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnu_BaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnu_HangTon;
        private System.Windows.Forms.ToolStripMenuItem mnu_DoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnu_TroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnu_TroGiupCon;
        private System.Windows.Forms.ToolStripMenuItem mnu_VaiNet;
    }
}