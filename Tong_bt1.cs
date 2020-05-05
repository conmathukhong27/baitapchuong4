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
    public partial class Tong_bt1 : Form
    {
        public Tong_bt1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8)
|| (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8)
|| (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j, sum = 0;
            int x = Convert.ToInt32(txtX.Text);
            int y = Convert.ToInt32(txtY.Text);
            if (x > y)
            {
                MessageBox.Show("Vui lòng nhập x nhỏ hơn y");

                return;
            }
            label5.Text = x.ToString();
            label6.Text = y.ToString();
            for (j = x; j <= y; j++)
            {
                sum = sum + j;
            }
            label8.Text = sum.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtX.ResetText();
            txtY.ResetText();
            label5.ResetText();
            label6.ResetText();
            label8.ResetText();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
