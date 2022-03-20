using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KapsullemeOrnek
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        //Urun classı oluştutup aşağıdaki istenenleri yapmanız.
        //ad, stok, fiyat, sonkullanma tarihi field ve property lerini hazırlayınız
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Urun yeniUrun = new Urun();
                yeniUrun.Ad = txtUrunAdi.Text;
                yeniUrun.Fiyat = nudFiyat.Value;
                yeniUrun.Stok = (short)nudStok.Value;//null değerde hata verir.aynı zamanda değer short için çok büyükse short olarak kabul edebildiği kadarını atamasını yapar. hata vermez.
                                                     //yeniUrun.Stok = Convert.ToInt16(nudStok.Value);//gelen değer null ise hata vermez. aynı zamanda gelen değer short için büyükse hata verir.
                yeniUrun.SonKullanmaTarihi = dateTimePicker1.Value;
            
                listBox1.Items.Add(yeniUrun);
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Urun)
            {
                Urun secili = listBox1.SelectedItem as Urun;
                //MessageBox.Show($"{secili.Ad}\n{secili.Fiyat}\n{secili.Stok}\n{secili.SonKullanmaTarihi}"); override öncesi bu kullanılır.

                //override sonrası aşağıdaki kod yeterli olur.
                MessageBox.Show(secili.ToString());
            }
            
        }
    }
}
