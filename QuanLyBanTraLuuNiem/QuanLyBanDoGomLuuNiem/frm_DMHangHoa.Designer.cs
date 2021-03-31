namespace QuanLyBanDoGomLuuNiem
{
    partial class frm_DMHangHoa
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
            this.btn_Dong = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dtgv_HangHoa = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.txt_MaHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DonGiaNhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_DonGiaBan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_GhiChu = new System.Windows.Forms.RichTextBox();
            this.pb_HangHoa = new System.Windows.Forms.PictureBox();
            this.cb_MaLoaiTra = new System.Windows.Forms.ComboBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_Anh = new System.Windows.Forms.TextBox();
            this.btn_BoQua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Dong
            // 
            this.btn_Dong.Location = new System.Drawing.Point(858, 602);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(103, 42);
            this.btn_Dong.TabIndex = 45;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(295, 602);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(103, 42);
            this.btn_Sua.TabIndex = 43;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(164, 602);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(103, 42);
            this.btn_Xoa.TabIndex = 41;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(41, 602);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(103, 42);
            this.btn_Them.TabIndex = 40;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dtgv_HangHoa
            // 
            this.dtgv_HangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_HangHoa.Location = new System.Drawing.Point(23, 283);
            this.dtgv_HangHoa.Name = "dtgv_HangHoa";
            this.dtgv_HangHoa.RowHeadersWidth = 51;
            this.dtgv_HangHoa.RowTemplate.Height = 24;
            this.dtgv_HangHoa.Size = new System.Drawing.Size(938, 288);
            this.dtgv_HangHoa.TabIndex = 39;
            this.dtgv_HangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_HangHoa_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "DANH MỤC HÀNG HÓA";
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.Location = new System.Drawing.Point(138, 114);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.Size = new System.Drawing.Size(190, 22);
            this.txt_TenHang.TabIndex = 37;
            // 
            // txt_MaHang
            // 
            this.txt_MaHang.Location = new System.Drawing.Point(138, 86);
            this.txt_MaHang.Name = "txt_MaHang";
            this.txt_MaHang.Size = new System.Drawing.Size(190, 22);
            this.txt_MaHang.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tên hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã hàng";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(138, 170);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(190, 22);
            this.txt_SoLuong.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 47;
            this.label4.Text = "Số lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 46;
            this.label5.Text = "Mã loại trà";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(371, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "Tên Ảnh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(374, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Ghi chú";
            // 
            // txt_DonGiaNhap
            // 
            this.txt_DonGiaNhap.Location = new System.Drawing.Point(138, 198);
            this.txt_DonGiaNhap.Name = "txt_DonGiaNhap";
            this.txt_DonGiaNhap.Size = new System.Drawing.Size(190, 22);
            this.txt_DonGiaNhap.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 18);
            this.label8.TabIndex = 52;
            this.label8.Text = "Đơn giá nhập";
            // 
            // txt_DonGiaBan
            // 
            this.txt_DonGiaBan.Location = new System.Drawing.Point(138, 226);
            this.txt_DonGiaBan.Name = "txt_DonGiaBan";
            this.txt_DonGiaBan.Size = new System.Drawing.Size(190, 22);
            this.txt_DonGiaBan.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 18);
            this.label9.TabIndex = 54;
            this.label9.Text = "Đơn giá bán";
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(377, 114);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(304, 134);
            this.txt_GhiChu.TabIndex = 56;
            this.txt_GhiChu.Text = "";
            // 
            // pb_HangHoa
            // 
            this.pb_HangHoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_HangHoa.Location = new System.Drawing.Point(704, 56);
            this.pb_HangHoa.Name = "pb_HangHoa";
            this.pb_HangHoa.Size = new System.Drawing.Size(257, 192);
            this.pb_HangHoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_HangHoa.TabIndex = 57;
            this.pb_HangHoa.TabStop = false;
            this.pb_HangHoa.Click += new System.EventHandler(this.pb_HangHoa_Click);
            // 
            // cb_MaLoaiTra
            // 
            this.cb_MaLoaiTra.FormattingEnabled = true;
            this.cb_MaLoaiTra.Location = new System.Drawing.Point(138, 143);
            this.cb_MaLoaiTra.Name = "cb_MaLoaiTra";
            this.cb_MaLoaiTra.Size = new System.Drawing.Size(190, 24);
            this.cb_MaLoaiTra.TabIndex = 58;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(564, 602);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(246, 42);
            this.btn_TimKiem.TabIndex = 59;
            this.btn_TimKiem.Text = "Tìm kiếm theo mã hàng";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_Anh
            // 
            this.txt_Anh.Location = new System.Drawing.Point(442, 60);
            this.txt_Anh.Name = "txt_Anh";
            this.txt_Anh.Size = new System.Drawing.Size(239, 22);
            this.txt_Anh.TabIndex = 60;
            // 
            // btn_BoQua
            // 
            this.btn_BoQua.Location = new System.Drawing.Point(418, 602);
            this.btn_BoQua.Name = "btn_BoQua";
            this.btn_BoQua.Size = new System.Drawing.Size(103, 42);
            this.btn_BoQua.TabIndex = 61;
            this.btn_BoQua.Text = "Bỏ qua";
            this.btn_BoQua.UseVisualStyleBackColor = true;
            this.btn_BoQua.Click += new System.EventHandler(this.btn_BoQua_Click);
            // 
            // frm_DMHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 667);
            this.Controls.Add(this.btn_BoQua);
            this.Controls.Add(this.txt_Anh);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.cb_MaLoaiTra);
            this.Controls.Add(this.pb_HangHoa);
            this.Controls.Add(this.txt_GhiChu);
            this.Controls.Add(this.txt_DonGiaBan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_DonGiaNhap);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dtgv_HangHoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TenHang);
            this.Controls.Add(this.txt_MaHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_DMHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_DMHangHoa";
            this.Load += new System.EventHandler(this.frm_DMHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_HangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_HangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dtgv_HangHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenHang;
        private System.Windows.Forms.TextBox txt_MaHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DonGiaNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DonGiaBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txt_GhiChu;
        private System.Windows.Forms.PictureBox pb_HangHoa;
        private System.Windows.Forms.ComboBox cb_MaLoaiTra;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_Anh;
        private System.Windows.Forms.Button btn_BoQua;
    }
}