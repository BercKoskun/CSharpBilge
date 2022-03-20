using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BilgiFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string[] kisiler = new string[0]; //Tek boyutlu dizi
        string[,] kisiler = new string[2, 5]; //2 boyutlu dizi 
        private void Form1_Load(object sender, EventArgs e)
        {
            #region 2 boyutlu diziye eleman ekleme işlemi
            kisiler[0, 0] = "Rıdvan";
            kisiler[0, 1] = "Aksoy";
            kisiler[0, 2] = "0537 500 15 90";
            kisiler[0, 3] = "ridvanaksoy@hotmail.com.tr";
            kisiler[0, 4] = "Kadıköy";

            kisiler[1, 0] = "Ber";
            kisiler[1, 1] = "Çoşkun";
            kisiler[1, 2] = "12321321321";
            kisiler[1, 3] = "berkcoskun64@gmail.com";
            kisiler[1, 4] = "Ataşehir";
            #endregion

            #region ListView'a eleman ekleme işlemi

           // ListViewItem lvi = new ListViewItem();
            //lvi.Text = "İlk Sutunu";
            //lvi.SubItems.Add("sırasıyla ilk sutundan sonraki sutunlar");
            //lvi.SubItems.Add("sırasıyla ilk sutundan sonraki sutunlar");
            //lvi.SubItems.Add("sırasıyla ilk sutundan sonraki sutunlar");
            //lvi.SubItems.Add("sırasıyla ilk sutundan sonraki sutunlar");
            //lvBilgiler.Items.Add(lvi);
            #endregion

            //dizinin satır sayısını almak için => toplam eleman sayısı / kolon sayısı  => kisiler.Lenght/5
            for (int i = 0; i < 2; i++)
            {
                ListViewItem lvi = new ListViewItem();
                for (int j = 0; j < 5; j++)
                {
                    if (j == 0)
                    {
                        lvi.Text = kisiler[i, j];
                    }
                    else
                    {
                        lvi.SubItems.Add(kisiler[i, j]);
                    }

                }
                lvBilgiler.Items.Add(lvi);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            FormInputlariniKontrolEt();

            ListViewItem lvi = ListViewItemOlusturucu(txtAd.Text, txtSoyad.Text, txtTelefon.Text, txtEmail.Text, txtAdres.Text);
            lvBilgiler.Items.Add(lvi);

            Temizle();
           
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        //void=> geriye deger döndürmeyen metotları temsil eder
        //degerin tipi=> geriye deger döndürenleri temsil eder(tüm value type ve tüm references type )

        #region Geriye Değer döndürmeyen Metot
        //void Metotadı()
        //{

        //    //çalışmasını istediğin kodlar
        //} 

        void MesajVer()
        {
            MessageBox.Show("Merhaba Dünya","Anımsatıcı",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }


       /// <summary>
       /// Form ekranındaki inputları temizler
       /// </summary>
      /// <exception cref="FormatException">Hata vermez, yinede dikkatli olmakta fayda var</exception>
        void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
                else if (item is MaskedTextBox)
                {
                    MaskedTextBox mtxt = item as MaskedTextBox;
                    mtxt.Clear();
                   
                }
            }
        }
        #endregion

        #region Geriye Değer Döndüren Metot
        //int metotadi()
        //{
        //    //çalışmasını istediğimiz kodlar
        //    return geriyedönecekdeğer;
        //}
        #endregion

        void FormInputlariniKontrolEt()
        {
            //string.IsNullOrEmpty() parantez içerisinde verilen nesnenin text özelliği hiç oluşmamış ya da boş bırakılmış mı kontrol eder.
            //string.IsNullOrWhiteSpace() parantez içerisinde verilen nesnenin text özelliği hiç oluşmamış ya da boş bırakılmış mı kontrol eder. buna ek olarak text özelliğine boşluk değeri girilmiş mi? kontrolu yapar
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Ad boş bırakılamaz.");
                return;//evetn sonlandırılır.
            }
            else if (string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Soyad boş bırakılamaz");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Telefon boş bırakılamaz");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email boş bırakılamaz");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtAdres.Text))
            {
                MessageBox.Show("Adres boş bırakılamaz");
                return;
            }
        }

        ListViewItem ListViewItemOlusturucu(string ad,string soyad,string telefon,string email,string adres)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = ad;
            lvi.SubItems.Add(soyad);
            lvi.SubItems.Add(telefon);
            lvi.SubItems.Add(email);
            lvi.SubItems.Add(adres);
            
            return lvi;

        }
    }
}
