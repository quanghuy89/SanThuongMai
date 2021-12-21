using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Kiemduyetvien : Form
    {
        public Kiemduyetvien()
        {
            InitializeComponent();
        }

        private void Kiemduyetvien_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            QuanLyKDV frmQuanLyKDV = new QuanLyKDV();
            frmQuanLyKDV.Show();
        }

        private void btn_QuanLydaugia_Click(object sender, EventArgs e)
        {
            DauGiaKDV frmDauGiaKDV = new DauGiaKDV();
            frmDauGiaKDV.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Quanlycuocdaugia frmQuanlycuocdaugia = new Quanlycuocdaugia();
            frmQuanlycuocdaugia.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan frmQuanLyTaiKhoan = new QuanLyTaiKhoan();
            frmQuanLyTaiKhoan.Show();
        }
    }
}
