using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class quangcao
    {
        private string stt;
        public string STT {  get => stt; set => stt = value; }

        private string masanpham;
        public string MaSanPham { get => masanpham; set => masanpham = value; }

        private string tensanpham;
        public string TenSanPham { get => tensanpham; set => tensanpham = value; }

        private string mataikhoan;
        public string MaTaiKhoan { get => mataikhoan; set => mataikhoan = value; }

        private string tentaikhoan;
        public string TenTaiKhoan { get => tentaikhoan; set => tentaikhoan = value; }

        private string thoigianquangcao;
        public string ThoiGianQuangCao { get => thoigianquangcao; set => thoigianquangcao = value; }

        private string gia;
        public string Gia { get => gia; set => gia = value; }

        public quangcao(string stt, string masanpham, string tensanpham, string mataikhoan, string tentaikhoan, string thoigianquangcao, string gia )
        {
            STT = stt;
            MaSanPham = masanpham;
            TenSanPham= tensanpham;
            MaTaiKhoan = mataikhoan;
            TenTaiKhoan = tentaikhoan;
            ThoiGianQuangCao = thoigianquangcao;
            Gia = gia;

        }

    }
}
