using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanDoGomLuuNiem
{
    public partial class frm_HoaDonBanHang : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_HoaDonBanHang()
        {
            InitializeComponent();
        }

        private void frm_HoaDonBanHang_Load(object sender, EventArgs e)
        {
            load();
            loadCombo();
            MessageBox.Show("Nếu bạn muốn thêm hóa đơn chỉ cần nhập các ô gồm: ID, Mã Hóa Đơn, Mã Hàng, Số Lượng, Đơn Giá, Giảm Giá, Thành Tiền");
        }

        public void load()
        {
            string sql;
            sql = "select distinct a.MaHDBan as [Mã Hóa Đơn], a.MaHang as [Mã Hàng], b.TenHang as [Tên Hàng], a.SoLuong as [Số Lượng], b.DonGiaBan as [Đơn Giá], a.GiamGia as [Giảm Giá %], a.ThanhTien as [Thành Tiền], c.MaKhach, c.TenKhach, c.DiaChi, c.DienThoai, d.MaHDBan, e.MaNhanVien, d.NgayBan, e.TenNhanVien, a.ID  from ChiTietHDBan as a, Hang as b, Khach as c, HDBan as d, NhanVien as e where a.MaHang=b.MaHang and a.MaHDBan=d.MaHDBan and c.MaKhach=d.Makhach and e.MaNhanVien=d.MaNhanVien";
            dtgv_HoaDonBanHang.DataSource = lopchung.loadDataTable(sql);
            //dtgv_HoaDonBanHang.Columns[6].Visible = false;
            dtgv_HoaDonBanHang.Columns[7].Visible = false;
            dtgv_HoaDonBanHang.Columns[8].Visible = false;
            dtgv_HoaDonBanHang.Columns[9].Visible = false;
            dtgv_HoaDonBanHang.Columns[10].Visible = false;
            dtgv_HoaDonBanHang.Columns[11].Visible = false;
            dtgv_HoaDonBanHang.Columns[12].Visible = false;
            dtgv_HoaDonBanHang.Columns[13].Visible = false;
            dtgv_HoaDonBanHang.Columns[14].Visible = false;
            dtgv_HoaDonBanHang.Columns[15].Visible = true;
        }

        public void loadCombo()
        {
            
            string sql = "Select * from Hang";
            cb_MaHang.DataSource = lopchung.loadDataTable(sql);
            cb_MaHang.DisplayMember = "MaHang";
            cb_MaHang.ValueMember = "MaHang";

            string sql1 = "Select * from Khach";
            cb_MaKhachHang.DataSource = lopchung.loadDataTable(sql1);
            cb_MaKhachHang.DisplayMember = "MaKhach";
            cb_MaKhachHang.ValueMember = "MaKhach";

            string sql2 = "Select * from NhanVien";
            cb_MaNhanVien.DataSource = lopchung.loadDataTable(sql2);
            cb_MaNhanVien.DisplayMember = "MaNhanVien";
            cb_MaNhanVien.ValueMember = "MaNhanVien";

            string sql3 = "Select * from HDBan";
            cb_MaHoaDon.DataSource = lopchung.loadDataTable(sql3);
            cb_MaHoaDon.DisplayMember = "MaHDBan";
            cb_MaHoaDon.ValueMember = "MaHDBan";
        }
        
        private void dtgv_HoaDonBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_SoLuong.Text = dtgv_HoaDonBanHang.CurrentRow.Cells["Số Lượng"].Value.ToString();
            txt_TenHang.Text = dtgv_HoaDonBanHang.CurrentRow.Cells["Tên Hàng"].Value.ToString();
            cb_MaHang.SelectedValue = dtgv_HoaDonBanHang.CurrentRow.Cells["Mã Hàng"].Value.ToString();
            txt_DonGia.Text = dtgv_HoaDonBanHang.CurrentRow.Cells["Đơn Giá"].Value.ToString();
            txt_GiamGia.Text = dtgv_HoaDonBanHang.CurrentRow.Cells["Giảm Giá %"].Value.ToString();
            txt_ThanhTien.Text = dtgv_HoaDonBanHang.CurrentRow.Cells["Thành Tiền"].Value.ToString();
            cb_MaKhachHang.SelectedValue = dtgv_HoaDonBanHang.CurrentRow.Cells["MaKhach"].Value.ToString();
            txt_TenKhachHang.Text = dtgv_HoaDonBanHang.CurrentRow.Cells["TenKhach"].Value.ToString();
            txt_DiaChi.Text = dtgv_HoaDonBanHang.CurrentRow.Cells["DiaChi"].Value.ToString();
            txt_DienThoai.Text = dtgv_HoaDonBanHang.CurrentRow.Cells["DienThoai"].Value.ToString();
            txt_TenNhanVien.Text = dtgv_HoaDonBanHang.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            cb_MaNhanVien.Text = dtgv_HoaDonBanHang.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            txt_MaHoaDon.Text = dtgv_HoaDonBanHang.CurrentRow.Cells["MaHDBan"].Value.ToString();
            dtp_NgayBan.Text = dtgv_HoaDonBanHang.CurrentRow.Cells["NgayBan"].Value.ToString();
            txt_ID.Text = dtgv_HoaDonBanHang.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn thật sự có muốn đóng hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "select distinct a.MaHDBan as [Mã Hóa Đơn], a.MaHang as [Mã Hàng], b.TenHang as [Tên Hàng], a.SoLuong as [Số Lượng], b.DonGiaBan as [Đơn Giá], a.GiamGia as [Giảm Giá %], a.ThanhTien as [Thành Tiền], c.MaKhach, c.TenKhach, c.DiaChi, c.DienThoai, d.MaHDBan, e.MaNhanVien, d.NgayBan, e.TenNhanVien  from ChiTietHDBan as a, Hang as b, Khach as c, HDBan as d, NhanVien as e where a.MaHang=b.MaHang and a.MaHDBan=d.MaHDBan and c.MaKhach=d.Makhach and e.MaNhanVien=d.MaNhanVien and a.MaHDBan = N'" + cb_MaHoaDon.SelectedValue.ToString() + "' ";
            dtgv_HoaDonBanHang.DataSource = lopchung.loadDataTable(sql);
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            load();
            loadCombo();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into ChitietHDBan values (N'" + txt_ID.Text + "',N'" + txt_MaHoaDon.Text + "',N'" + cb_MaHang.SelectedValue.ToString() + "',N'" + float.Parse(txt_SoLuong.Text) + "',N'" + float.Parse(txt_DonGia.Text) + "',N'" + float.Parse(txt_GiamGia.Text) + "',N'" + float.Parse(txt_ThanhTien.Text) + "')";
            lopchung.editData(sql);
            load();
            loadCombo();
        }

        private void btn_HuyHoaDon_Click(object sender, EventArgs e)
        {
            string sql = "Delete from ChiTietHDBan where MaHDBan = '" + txt_MaHoaDon.Text + "' and MaHang = '" + cb_MaHang.SelectedValue.ToString() + "'" ;
            lopchung.editData(sql);
            load();
            loadCombo();
        }
    }
}
