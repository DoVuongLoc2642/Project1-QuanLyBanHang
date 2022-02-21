using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quanlycuahang.Class;
namespace Quanlycuahang
{
    public partial class frmMain : Form
    {
        public bool isExit = true;
        public event EventHandler Logout;
        public frmMain()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frm = new frmDMKhachHang();
            frm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            frmTimKiemHD frm = new frmTimKiemHD();
            frm.Show();
        }

        private void mnuHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmDMChatLieu frm = new frmDMChatLieu();
            frm.ShowDialog(); //Hiển thị 1 cửa sổ 
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHangHoa frm = new frmDMHangHoa();
            frm.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frm = new frmDMNhanVien();       
            frm.Show();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frm = new frmHoaDonBan();
            frm.Show();
        }

        private void mnuBCHangTon_Click(object sender, EventArgs e)
        {
            frmBaoCao frm = new frmBaoCao();
            frm.Show();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            Logout(this, new EventArgs());
        }
    }
}
