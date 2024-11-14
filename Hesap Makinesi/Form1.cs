using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {

        int secim = 0;
        double sayi1, sayi2, sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void Butonlar(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
            {
                txtEkran.Text = "";
            }
            txtEkran.Text = txtEkran.Text + ((Button)sender).Text;
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(txtEkran.Text);
            secim = 1;
            txtEkran.Text = "0";
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(txtEkran.Text);
            secim = 2;
            txtEkran.Text = "0";
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(txtEkran.Text);
            secim = 3;
            txtEkran.Text = "0";
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(txtEkran.Text);
            secim = 4;
            txtEkran.Text = "0";
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(txtEkran.Text);
            if (secim == 1)
            {
                sonuc = sayi1 + sayi2;
            }
            txtEkran.Text = sonuc.ToString();
            if (secim == 2)
            {
                sonuc = sayi1 - sayi2;
            }
            txtEkran.Text = sonuc.ToString();
            if (secim == 3)
            {
                sonuc = sayi1 * sayi2;
            }
            txtEkran.Text = sonuc.ToString();
            if (secim == 4)
            {
                sonuc = sayi1 / sayi2;
            }
            txtEkran.Text = sonuc.ToString();
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            if(txtEkran.Text.IndexOf(",")<1)
            {
                txtEkran.Text += ",";
            }
        }

        private void btnNegatif_Click(object sender, EventArgs e)
        {
            if(txtEkran.Text!="0")
            {
                if(txtEkran.Text.StartsWith("-"))
                {
                    txtEkran.Text = txtEkran.Text.Replace("-", "");
                }
                else if(txtEkran.Text.StartsWith(""))
                {
                    txtEkran.Text = "-" + txtEkran.Text;
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "0";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            txtEkran.Text = txtEkran.Text.Substring(0, txtEkran.Text.Length - 1);

            if (txtEkran.Text == "")
            {
                txtEkran.Text = "0";
            }
        }

    }
}
