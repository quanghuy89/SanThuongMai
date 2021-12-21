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
    public partial class TrangChuAdmin : Form
    {
        public TrangChuAdmin()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanSu frmQuanLyNhanSu = new QuanLyNhanSu();  
            frmQuanLyNhanSu.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void quảnLýQuảngCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanlyQuangCao frmQuanlyQuangCao = new QuanlyQuangCao();
            frmQuanlyQuangCao.ShowDialog();
        }

        private void quảnLýDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDoanhThu frmQuanLyDoanhThu = new QuanLyDoanhThu();
            frmQuanLyDoanhThu.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKhachHang frmQuanLyKhachHang = new QuanLyKhachHang();
            frmQuanLyKhachHang.ShowDialog();
        }
    }
}
