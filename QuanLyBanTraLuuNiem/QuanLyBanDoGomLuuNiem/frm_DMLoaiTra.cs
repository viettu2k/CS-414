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
    public partial class frm_DMLoaiTra : Form
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public frm_DMLoaiTra()
        {
            InitializeComponent();
        }


        public void ResetInput()
        {
            txt_MaLoaiTra.Clear();
            txt_TenLoaiTra.Clear();
        }
        

        public void load()
        {
            string sql = "Select MaLoaiTra as [Mã Loại Trà], TenLoaiTra as [Tên Loại Trà] from LoaiTra";
            dtgv_LoaiTra.DataSource = lopchung.loadDataTable(sql);
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into LoaiTra values (N'" + txt_MaLoaiTra.Text + "',N'" + txt_TenLoaiTra.Text + "')";
            lopchung.editData(sql);
            load();
            ResetInput();
        }

        private void frm_DMLoaiTra_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dtgv_LoaiTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaLoaiTra.Text = dtgv_LoaiTra.CurrentRow.Cells["Mã Loại Trà"].Value.ToString();
            txt_TenLoaiTra.Text = dtgv_LoaiTra.CurrentRow.Cells["Tên Loại Trà"].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from LoaiTra where MaLoaiTra = '" + txt_MaLoaiTra.Text + "'";
            lopchung.editData(sql);
            load();
            ResetInput();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update LoaiTra set TenLoaiTra = N'" + txt_TenLoaiTra.Text + "' where MaLoaiTra = N'" + txt_MaLoaiTra.Text + "'";
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
