using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4_bai1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void chaoMungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formchaomung c1 = new Formchaomung();
            c1.Show();
        }

        private void tínhTổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTinhTong c2 = new FormTinhTong();
            c2.Show();

        }

        private void tongbt1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tong_bt1 c3 = new Tong_bt1();
            c3.Show();
        }
    }
}
