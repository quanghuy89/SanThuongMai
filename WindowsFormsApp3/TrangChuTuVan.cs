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
            TuVan frmTuVan = new TuVan();
            frmTuVan.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
