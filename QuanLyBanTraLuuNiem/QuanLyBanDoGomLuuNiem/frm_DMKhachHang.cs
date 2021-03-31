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
    public partial class frm_DMKhachHang : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_DMKhachHang()
        {
            InitializeComponent();
        }

        

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Khach values (N'" + txt_MaKhachHang.Text + "',N'" + txt_TenKhachHang.Text + "',N'" + txt_DiaChi.Text + "',N'" + txt_DienThoai.Text + "')";
            lopchung.editData(sql);
            resetInput();
            load();
        }

        private void frm_DMKhachHang_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            string sql = "Select MaKhach as [Mã Khách], TenKhach as [Tên Khách Hàng], DiaChi as [Địa Chỉ], DienThoai as [SĐT] from Khach";
            dtgv_KhachHang.DataSource = lopchung.loadDataTable(sql);
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn thật sự có muốn đóng hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from Khach where MaKhach = '" + txt_MaKhachHang.Text + "'";
            lopchung.editData(sql);
            resetInput();
            load();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update Khach set TenKhach = N'" + txt_TenKhachHang.Text + "', DiaChi = N'" + txt_DiaChi.Text + "', DienThoai = N'" + txt_DienThoai.Text + "'   where MaKhach = N'" + txt_MaKhachHang.Text + "'";
            lopchung.editData(sql);
            load();
        }

        private void dtgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKhachHang.Text = dtgv_KhachHang.CurrentRow.Cells["Mã Khách"].Value.ToString();
            txt_TenKhachHang.Text = dtgv_KhachHang.CurrentRow.Cells["Tên Khách Hàng"].Value.ToString();
            txt_DiaChi.Text = dtgv_KhachHang.CurrentRow.Cells["Địa Chỉ"].Value.ToString();
            txt_DienThoai.Text = dtgv_KhachHang.CurrentRow.Cells["SĐT"].Value.ToString();
        }
        public void resetInput()
        {
            txt_MaKhachHang.Clear();
            txt_TenKhachHang.Clear();
            txt_DiaChi.Clear();
            txt_DienThoai.Clear();
        }

        private void btn_BoQua_Click(object sender, EventArgs e)
        {
            resetInput();
            load();
        }
    }
}
