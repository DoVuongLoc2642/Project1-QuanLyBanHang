using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quanlycuahang.Class;
namespace Quanlycuahang.Class
{
    class User
    {

        private string TaiKhoan;
        private string MatKhau;

        public string TaiKhoan1 { get => TaiKhoan; set => TaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }

        public User(string TaiKhoan, string MatKhau)
        {
            this.TaiKhoan1 = TaiKhoan;
            this.MatKhau1 = MatKhau;
        }
    }
}
