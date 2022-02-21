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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        bool CheckLogin(string TaiKhoan, string MatKhau)
        {
           for(int i = 0; i < ListUser.Instance.ListAccountUser.Count;i++)
            {
                if (TaiKhoan == ListUser.Instance.ListAccountUser[i].TaiKhoan1 && MatKhau == ListUser.Instance.ListAccountUser[i].MatKhau1)
                    return true;
            }
            return false;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string TaiKhoan = txtTaiKhoan.Text;
            string MatKhau = txtMatKhau.Text;
            if (CheckLogin(TaiKhoan, MatKhau))
            {
                frmMain f = new frmMain();
                f.Show();
                this.Hide();
                f.Logout += F_Logout;
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu, vui lòng kiểm tra lại", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void F_Logout(object sender, EventArgs e)
        {
            (sender as frmMain).isExit = false;
            (sender as frmMain).Close();
            this.Show();
        }
        private void chkHTMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHTMK.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
