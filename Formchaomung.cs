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
    public partial class Formchaomung : Form
    {
        public Formchaomung()
        {
            InitializeComponent();
        }

        //private void label2_Click(object sender, EventArgs e)
       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtTen.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập tên");
                txtTen.Focus();
                return;
            }    
            if(txtLop.Text=="")
            {
                MessageBox.Show("Bạn chưa nhập lớp");
                txtLop.Focus();
                return;
            }
            MessageBox.Show("Chao mung " + txtTen.Text + "học" + txtLop.Text);
        }

        private void Formchaomung_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Đã bật form formchaomung");
        }
    }
}
