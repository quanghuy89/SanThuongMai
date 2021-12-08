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
    public partial class QuanLyNhanSu : Form
    {
        public QuanLyNhanSu()
        {
            InitializeComponent();
        }

        private void trởVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void thêmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThemNhanVien frmThemNhanVien = new ThemNhanVien();
            frmThemNhanVien.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void trởVềToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLyNhanSu_Load(object sender, EventArgs e)
        {

        }
    }
}
