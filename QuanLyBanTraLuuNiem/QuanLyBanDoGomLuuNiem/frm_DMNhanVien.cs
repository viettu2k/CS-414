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
    public partial class frm_DMNhanVien : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public frm_DMNhanVien()
        {
            InitializeComponent();
        }
        public void ResetInput()
        {
            txt_MaNhanVien.Clear();
            txt_TenNhanVien.Clear();
            txt_DiaChi.Clear();
            txt_DienThoai.Clear();
           
        }
        private void frm_DMNhanVien_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            string sql = "Select MaNhanVien as [Mã Nhân Viên], TenNhanVien as [Tên Nhân Viên], GioiTinh as [Giới Tính], DiaChi as [Địa Chỉ], DienThoai as [SĐT], NgaySinh as [Ngày Sinh]  from NhanVien";
            dtgv_NhanVien.DataSource = lopchung.loadDataTable(sql);
        }

        private void dtgv_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNhanVien.Text = dtgv_NhanVien.CurrentRow.Cells["Mã Nhân Viên"].Value.ToString();
            txt_TenNhanVien.Text = dtgv_NhanVien.CurrentRow.Cells["Tên Nhân Viên"].Value.ToString();
            txt_DiaChi.Text = dtgv_NhanVien.CurrentRow.Cells["Địa Chỉ"].Value.ToString();
            txt_DienThoai.Text = dtgv_NhanVien.CurrentRow.Cells["SĐT"].Value.ToString();
            if (dtgv_NhanVien.CurrentRow.Cells["Giới Tính"].Value.ToString() == "Nam")
            {
                ckb_GioiTinhNam.Checked = true;
            }
            dtp_NgaySinh.Text = dtgv_NhanVien.CurrentRow.Cells["Ngày Sinh"].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sex = "Nữ";
            if (ckb_GioiTinhNam.Checked == true)
            {
                sex = "Nam";
            }
            string sql = "Insert into NhanVien values (N'" + txt_MaNhanVien.Text + "',N'" + txt_TenNhanVien.Text + "',N'" + sex + "',N'" + txt_DiaChi.Text + "',N'" + txt_DienThoai.Text + "',N'" + dtp_NgaySinh.Value.ToString() + "')";
            lopchung.editData(sql);
            load();
            ResetInput();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from NhanVien where MaNhanVien = '" + txt_MaNhanVien.Text + "'";
            lopchung.editData(sql);
            load();
            ResetInput();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sex = "Nữ";
            if (ckb_GioiTinhNam.Checked == true)
            {
                sex = "Nam";
            }
            string sql = "Update NhanVien set TenNhanVien = N'" + txt_TenNhanVien.Text + "', GioiTinh = N'" + sex + "', DiaChi = N'" + txt_DiaChi.Text + "', DienThoai = N'" + txt_DienThoai.Text + "', NgaySinh = N'" + dtp_NgaySinh.Value.ToString() + "' where MaNhanVien = N'" + txt_MaNhanVien.Text + "'";
            lopchung.editData(sql);
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
    }
}
