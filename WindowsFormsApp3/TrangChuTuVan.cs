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
    public partial class TrangChuTuVan : Form
    {
        public TrangChuTuVan()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void TrangChuTuVan_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            
        }

        private void hỗTrợSảnPhẩmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
          
        }

        private void hỗTrợTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TuVan frmTuVan = new TuVan();
            frmTuVan.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tưVấnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void khóaChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void sựKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapNhatThonTin frmCapNhatThongTin = new CapNhatThonTin();
            frmCapNhatThongTin.ShowDialog();
        }

        private void lịchSửTưVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LichSuTuVan frmLichSuTuVan = new LichSuTuVan();
            frmLichSuTuVan.ShowDialog();
        }

        private void lịchSửKhóaChatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LichSuLKhoa frmLichSuKhoa = new LichSuLKhoa();  
            frmLichSuKhoa.ShowDialog(); 
        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tínhNăngKhóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TinhNangKhoa frmTinhNangKhoa = new TinhNangKhoa();
            frmTinhNangKhoa.ShowDialog();
        }
    }
}
