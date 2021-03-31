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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void mnu_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có thật sự muốn thoát hay không", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnu_LoaiTra_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DMLoaiTra"] == null)
            {
                frm_DMLoaiTra frmCL = new frm_DMLoaiTra();
                frmCL.MdiParent = this;
                frmCL.Show();

            }
            else
            {
                Application.OpenForms["frm_DMLoaiTra"].Activate();
            }
        }

        private void mnu_NhanVien_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DMNhanVien"] == null)
            {
                frm_DMNhanVien frmCL = new frm_DMNhanVien();
                frmCL.MdiParent = this;
                frmCL.Show();

            }
            else
            {
                Application.OpenForms["frm_DMNhanVien"].Activate();
            }
        }

        private void mnu_KhachHang_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DMKhachHang"] == null)
            {
                frm_DMKhachHang frmCL = new frm_DMKhachHang();
                frmCL.MdiParent = this;
                frmCL.Show();

            }
            else
            {
                Application.OpenForms["frm_DMKhachHang"].Activate();
            }
        }

        private void mnu_HangHoa_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DMHangHoa"] == null)
            {
                frm_DMHangHoa frmCL = new frm_DMHangHoa();
                frmCL.MdiParent = this;
                frmCL.Show();

            }
            else
            {
                Application.OpenForms["frm_DMHangHoa"].Activate();
            }
        }

        private void mnu_HoaDonBan_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_HoaDonBanHang"] == null)
            {
                frm_HoaDonBanHang frmCL = new frm_HoaDonBanHang();
                frmCL.MdiParent = this;
                frmCL.Show();

            }
            else
            {
                Application.OpenForms["frm_HoaDonBanHang"].Activate();
            }
        }

        
    }
}
