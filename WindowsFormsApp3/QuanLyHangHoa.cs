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
    public partial class QuanLyHangHoa : Form
    {
        public QuanLyHangHoa()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CapNhatSanPham frmCapNhatSanPham = new CapNhatSanPham();
            frmCapNhatSanPham.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
