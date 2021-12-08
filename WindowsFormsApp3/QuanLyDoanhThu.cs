using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class QuanLyDoanhThu : Form
    {
        //public List<DoanhThu> People { get; set; }
        public QuanLyDoanhThu()
        {
           // People = GetDoanhThu();
            InitializeComponent();
        }

        private List<DoanhThu> GetDoanhThu()
        {
            var list = new List<DoanhThu>();
            list.Add(new DoanhThu()
            {
                DoanhThuID = 1,
                TenSanPham = "Card San Pham,",
                TenHang = "NDIVIA",
                DoanhThuQuangCao = "100000$"
            });

            list.Add(new DoanhThu()
            {
                DoanhThuID = 1,
                TenSanPham = "Card San Pham,",
                TenHang = "NDIVIA",
                DoanhThuQuangCao = "100000$"
            });

            list.Add(new DoanhThu()
            {
                DoanhThuID = 1,
                TenSanPham = "Card San Pham,",
                TenHang = "NDIVIA",
                DoanhThuQuangCao = "100000$"
            });

            return list;

        }

        private void QuanLyDoanhThu_Load(object sender, EventArgs e)
        {
            //var people = this.People;
            //dataGridView1.DataSource = people;
        }
    }
}
