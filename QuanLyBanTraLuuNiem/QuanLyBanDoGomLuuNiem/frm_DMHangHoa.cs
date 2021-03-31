using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QuanLyBanDoGomLuuNiem
{
    public partial class frm_DMHangHoa : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\img\\";
        public frm_DMHangHoa()
        {
            InitializeComponent();
        }

        private void pb_HangHoa_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Hãy chọn ảnh";
            open.Filter = "Ảnh JPG|*.JPG|Ảnh PNG|*.PNG|Tất cả|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pb_HangHoa.Image = Image.FromFile(open.FileName);
            }
        }

        public void load()
        {
            string sql = "Select MaHang as [Mã Hàng], TenHang as [Tên Hàng], MaLoaiTra as [Mã Loại Trà], SoLuong as [Số Lượng], DonGiaNhap as [Đơn Giá Nhập], DonGiaBan as [Đơn Giá Bán], Anh as [Ảnh], GhiChu as [Ghi Chú]  from Hang";
            dtgv_HangHoa.DataSource = lopchung.loadDataTable(sql);
        }
        public void loadCombo()
        {
            string sql = "Select * from LoaiTra";
            cb_MaLoaiTra.DataSource = lopchung.loadDataTable(sql);
            cb_MaLoaiTra.DisplayMember = "TenLoaiTra";
            cb_MaLoaiTra.ValueMember = "MaLoaiTra";
        }
        private void frm_DMHangHoa_Load(object sender, EventArgs e)
        {
            load();
            loadCombo();
        }

        private void dtgv_HangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaHang.Text = dtgv_HangHoa.CurrentRow.Cells["Mã Hàng"].Value.ToString();
            txt_TenHang.Text = dtgv_HangHoa.CurrentRow.Cells["Tên Hàng"].Value.ToString();
            cb_MaLoaiTra.SelectedValue = dtgv_HangHoa.CurrentRow.Cells["Mã Loại Trà"].Value.ToString();
            txt_SoLuong.Text = dtgv_HangHoa.CurrentRow.Cells["Số Lượng"].Value.ToString();
            txt_DonGiaNhap.Text = dtgv_HangHoa.CurrentRow.Cells["Đơn Giá Nhập"].Value.ToString();
            txt_DonGiaBan.Text = dtgv_HangHoa.CurrentRow.Cells["Đơn Giá Bán"].Value.ToString();
            txt_GhiChu.Text = dtgv_HangHoa.CurrentRow.Cells["Ghi Chú"].Value.ToString();
            txt_Anh.Text = dtgv_HangHoa.CurrentRow.Cells["Ảnh"].Value.ToString();
            pb_HangHoa.ImageLocation = duongdan + txt_Anh.Text;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Hang values (N'" + txt_MaHang.Text + "',N'" + txt_TenHang.Text + "',N'" + cb_MaLoaiTra.SelectedValue + "',N'" + float.Parse(txt_SoLuong.Text) + "',N'" + float.Parse(txt_DonGiaNhap.Text) + "',N'" + float.Parse(txt_DonGiaBan.Text) + "',N'" + txt_Anh.Text + "',N'" + txt_GhiChu.Text + "')";
            lopchung.editData(sql);
            pb_HangHoa.Image.Save(duongdan + txt_Anh.Text);
            load();
            resetInput();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from Hang where MaHang = '" + txt_MaHang.Text + "'";
            lopchung.editData(sql);
            File.Delete(duongdan + txt_Anh.Text);
            load();
            resetInput();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update Hang set TenHang = N'" + txt_TenHang.Text + "', MaLoaiTra = N'" + cb_MaLoaiTra.SelectedValue + "', SoLuong = N'" + float.Parse(txt_SoLuong.Text) + "', DonGiaNhap = N'" + float.Parse(txt_DonGiaNhap.Text) + "', DonGiaBan = N'" + float.Parse(txt_DonGiaBan.Text) + "', Anh = N'" + txt_Anh.Text + "', GhiChu = N'" + txt_GhiChu.Text + "'  where MaHang = N'" + txt_MaHang.Text + "'";
            lopchung.editData(sql);
            pb_HangHoa.Image.Save(duongdan + txt_Anh.Text);
            load();
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
            string sql = "Select MaHang as [Mã Hàng], TenHang as [Tên Hàng], MaLoaiTra as [Mã Loại Trà], SoLuong as [Số Lượng], DonGiaNhap as [Đơn Giá Nhập], DonGiaBan as [Đơn Giá Bán], Anh as [Ảnh], GhiChu as [Ghi Chú]  from Hang where MaHang = N'" + txt_MaHang.Text + "'";
            dtgv_HangHoa.DataSource = lopchung.loadDataTable(sql);
        }

        public void resetInput()
        {
            txt_Anh.Clear();
            txt_TenHang.Clear();
            txt_MaHang.Clear();
            txt_SoLuong.Clear();
            txt_DonGiaNhap.Clear();
            txt_DonGiaBan.Clear();
            txt_GhiChu.Clear();
        }
        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            resetInput();
            load();
            loadCombo();
        }
    }
}
