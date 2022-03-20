using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BakiyeSorgulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bakiye = 0;
        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            try
            {
                int yatirilanpara = Convert.ToInt32(txtParaYatir.Text);
                if (yatirilanpara<0)
                {
                    MessageBox.Show("Negatif Değer Giremezsiniz!!!");
                }
                else
                {
                    bakiye += yatirilanpara;
                    lblBakiye.Text = bakiye.ToString("C2");
                    if (bakiye<100)
                    {
                        lblDurum.Text = "Çok Az Paranız Var";
                        lblDurum.BackColor = Color.Maroon;
                        lblDurum.ForeColor = Color.White;
                    }
                    else if (bakiye<500)
                    {
                        lblDurum.Text = "Yeterli Paranız Var";
                        lblDurum.BackColor = Color.Orange;
                        lblDurum.ForeColor = Color.White;
                    }
                    else
                    {
                        lblDurum.Text = "Çok Paranız Var";
                        lblDurum.BackColor = Color.DarkGreen;
                        lblDurum.ForeColor = Color.White;
                    }
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Lütfen Sayısal Bir Değer Giriniz!!!");
            }
            catch(OverflowException)
            {
                MessageBox.Show($"Bankamatik işlemleri {int.MaxValue} lira ile sınırlıdır.");
            }
            txtParaYatir.Text = string.Empty;

        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            try
            {
                int cekilentutar = Convert.ToInt32(txtParaCek.Text);
                if (cekilentutar < 0)
                {
                    MessageBox.Show("Negatif Değer Giremezsiniz!!!");
                }
                else if(cekilentutar>bakiye)
                {
                    MessageBox.Show("Yetersiz Bakiye...");
                }
                else
                {

                    bakiye -= cekilentutar;
                    lblBakiye.Text = bakiye.ToString("C2");
                    if(bakiye==0)
                    {
                        lblDurum.Text = "Para Suyunu Çekti...";
                        lblDurum.BackColor = Color.Maroon;
                        lblDurum.ForeColor = Color.White;
                    }
                    else if (bakiye < 100)
                    {
                        lblDurum.Text = "Çok Az Paranız Var";
                        lblDurum.BackColor = Color.Red;
                        lblDurum.ForeColor = Color.White;


                    }
                    else if (bakiye < 500)
                    {
                        lblDurum.Text = "Yeterli Paranız Var";
                        lblDurum.BackColor = Color.Orange;
                        lblDurum.ForeColor = Color.White;

                    }
                    else
                    {
                        lblDurum.Text = "Çok Paranız Var";
                        lblDurum.BackColor = Color.DarkGreen;
                        lblDurum.ForeColor = Color.White;

                    }
                }
            }
            catch (FormatException)
            {

                MessageBox.Show("Lütfen Sayısal Bir Değer Giriniz!!!");
            }
            catch (OverflowException)
            {
                MessageBox.Show($"Bankamatik işlemleri {int.MaxValue} lira ile sınırlıdır.");
            }

            //textbox daki değeri temizler.
            //txtParaCek.Text = "";
            //txtParaCek.Text = string.Empty;
            txtParaCek.Clear();

        }
    }
}
