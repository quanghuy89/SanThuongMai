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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
        }

        private void quảnLýHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHangHoa frmQuanLyHangHoa = new QuanLyHangHoa();
            frmQuanLyHangHoa.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            /*QuanLyTaiKhoan frmQuanlytaukhoan = new QuanLyTaiKhoan();
            frmQuanlytaukhoan.ShowDialog();*/

        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKy frmDangKy = new DangKy();
            frmDangKy.Show();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*BaoCao frmBaocao = new BaoCao();
            frmBaocao.Show();*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau frmDoimatkhau = new DoiMatKhau();
            frmDoimatkhau.ShowDialog();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan frmThongtincanhan = new ThongTinCaNhan();
            frmThongtincanhan.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void thờiTrangNữToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoViPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCao frmBaocao = new BaoCao();
            frmBaocao.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            QuanLyDauGia frmQuanLyDauGia = new QuanLyDauGia();
            frmQuanLyDauGia.Show();
        }

        private void đăngNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DangNhap frmDangNhap = new DangNhap();
            frmDangNhap.ShowDialog();
        }

        private void đăngKýToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DangKy frmDangKy = new DangKy();
            frmDangKy.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan frmQuanlytaukhoan = new QuanLyTaiKhoan();
            frmQuanlytaukhoan.ShowDialog();
        }
    }
}
