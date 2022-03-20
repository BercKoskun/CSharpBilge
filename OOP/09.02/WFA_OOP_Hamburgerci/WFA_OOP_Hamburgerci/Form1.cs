using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_OOP_Hamburgerci.Models;

namespace WFA_OOP_Hamburgerci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<Yemek> FakeDb()
        {
            List<Yemek> yemekler = new List<Yemek>()
            {
                new Yemek(){ Ad="Whooper Menü",Fiyat=54 },
                new Yemek(){ Ad="Kral İkili Menü",Fiyat=50},
                new Yemek(){ Ad="Mangalda Izgara Tavuk Menü",Fiyat=49},
                new Yemek(){ Ad="Big King",Fiyat=39},

            };

            return yemekler;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMenuler.Items.Add("Lütfen Bir Menü Seçiniz...");
            foreach (Yemek item in FakeDb())
            {
                cmbMenuler.Items.Add(item);
            }

            cmbMenuler.SelectedIndex = 0;
        }

        private void cmbMenuler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMenuler.SelectedItem is Yemek)
            {
                Yemek seciliYemek = cmbMenuler.SelectedItem as Yemek;
                MessageBox.Show(seciliYemek.Fiyat.ToString("C2"));
            }
        }

        private void btnSiparisAl_Click(object sender, EventArgs e)
        {
            lstSiparisler.Items.Add(SiparisOlustur());
        }

        private Siparis SiparisOlustur()
        {
            Siparis yeniSiparis = new Siparis();

            yeniSiparis.Hamburger = cmbMenuler.SelectedItem as Yemek;
            #region Boyut Enum Seçimi
            if (rbBuyuk.Checked)
            {
                yeniSiparis.MenuBoyu = Boyut.Buyuk;
            }
            else if (rbKing.Checked)
            {
                yeniSiparis.MenuBoyu = Boyut.King;
            }
            else
            {
                yeniSiparis.MenuBoyu = Boyut.Orta;
            }
            #endregion

            #region ekstralar bölümü sınıfta string tutulursa
            //string _ekstralar="";
            //foreach (CheckBox ch in gbEkstralar.Controls)
            //{
            //    if (ch.Checked)
            //    {
            //        _ekstralar += ch.Text + " , ";
            //    }
            //}
            //_ekstralar = _ekstralar.Trim(' ', ','); 
            //yeniSiparis.Ekstralar = _ekstralar;
            #endregion

            #region Dizi ile ekstralar yönetimi
            string[] _ekstralar = new string[0];
            foreach (CheckBox ch in gbEkstralar.Controls)
            {
                if (ch.Checked)
                {
                    Array.Resize(ref _ekstralar, _ekstralar.Length + 1);
                    _ekstralar[_ekstralar.Length - 1] = ch.Text;
                }
            }
            yeniSiparis.Ekstralar = _ekstralar; 
            #endregion

            yeniSiparis.Adet=(short)nuAdet.Value;
            yeniSiparis.SiparisEkle(yeniSiparis);

            return yeniSiparis;
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            #region Listboxdan değer okuma
            //decimal totalFiyat = 0;
            //short totalAdet = 0;
            //foreach (Siparis item in lstSiparisler.Items)
            //{
            //    totalFiyat += item.AraToplam;
            //    totalAdet += item.Adet;
            //}

            //MessageBox.Show($"{totalFiyat.ToString("C2")}");
            #endregion

            MessageBox.Show($"Toplam Sipariş Tutarınız => {Siparis.ToplamSiparis().ToString("C2")}");
        }
    }
}
