using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chuong4_b1
{
    public partial class frmChuongTrinhTinhTong : Form  {
        public frmChuongTrinhTinhTong()
        {
            InitializeComponent();
        }

        private void texta_TextChanged(object sender, EventArgs e)
        {

        }

        private void texta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
(e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8)
|| (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void textb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
(e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8)
|| (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;
        }

        private void textboxa_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxb_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void btnTong_Click(object sender, EventArgs e)
        {

            double tong =0;
            double a = Convert.ToDouble(texta.Text);
            double b = Convert.ToDouble(textb.Text);
           
           
              if(a<=b)
            {
                for (double i = a; i <= b; i++)
                    tong += i;

            }
              if(a>b)
           {
               for (double i = b; i <= a; i++)
                    tong += i;
            }
            labela.Text = a.ToString();
            labelb.Text = b.ToString();

            labeltong.Text = tong.ToString();
           

        }

        private void texttong_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            texta.Text = "";
            textb.Text = "";
            labela.Text = "";
            labelb.Text = "";
            labeltong.Text = "";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
