using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TelefonRehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Sehir> sehiler = new List<Sehir>()
        {
          new Sehir()
          {
            SehirAdi="İstanbul Avrupa Yakası",
             AlanKodu="212",
             Ulke=new Ulke(){ UlkeAdi="Türkiye", UlkeKodu="90" }
          }
        
        };



        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kisi yeniKisi = new Kisi();
            yeniKisi.Ad = txtAd.Text;
            yeniKisi.Soyad = txtSoyad.Text;
            yeniKisi.Sehir = cmbSehir.SelectedItem as Sehir;


            if (!string.IsNullOrWhiteSpace(yeniKisi.Sehir.AlanKodu))
            {
                yeniKisi.Telefon = new AlanKoduOlanNumaralar()
                {
                    AlanKodu = yeniKisi.Sehir.AlanKodu,
                    Numara = mtxtTelefon.Text,
                    UlkeKodu = yeniKisi.Sehir.Ulke.UlkeKodu
                };
            }
            else
            {
                yeniKisi.Telefon = new AlanKoduOlmayanNumaralar()
                {
                    Numara = mtxtTelefon.Text,
                    UlkeKodu = yeniKisi.Sehir.Ulke.UlkeKodu
                };
            }


            ListViewItem lvi = new ListViewItem();
            lvi.Tag = yeniKisi;
            lvi.Text = yeniKisi.Ad;
            lvi.SubItems.Add(yeniKisi.Soyad);
            lvi.SubItems.Add(yeniKisi.Sehir.SehirAdi);
            lvi.SubItems.Add(yeniKisi.Telefon.ToString());

            listView1.Items.Add(lvi);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSehir.DataSource = sehiler;
        }
    }
}
