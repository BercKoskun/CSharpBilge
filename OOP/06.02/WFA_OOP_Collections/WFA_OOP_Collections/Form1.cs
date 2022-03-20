using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
//using WFA_OOP_Collections.Models;
namespace WFA_OOP_Collections
{
    using Models;
   

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Personel[] personeller = new Personel[0];
       
        //object[] personeller = new object[0];
        ArrayList personeller = new ArrayList();//Boxing-Unboxing yapar, sıfır eleman kapasitesi ile başlar.
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personel yenipersonel = new Personel()
            {
                Ad = txtAd.Text,
                SoyAd = txtSoyad.Text,
                Yas = Convert.ToByte(nudYas.Value)
            };
            personeller.Add(yenipersonel);
            personeller.Add(txtAd);
            personellerListesi.Add(yenipersonel);
            personellerListesi.TrimExcess();//ArrayList için kulandığımız TrimToSize metodu ile aynı işi yapar. List sınıfında ismi TrimExcess olarak verilmiştir.
            
        }

        private void btnListeElemanlari_Click(object sender, EventArgs e)
        {

           
            foreach (Personel item in personeller)
            {
                MessageBox.Show(item.ToString());
            }

            MessageBox.Show(personeller.Count.ToString());//Eleman Sayısı
            MessageBox.Show(personeller.Capacity.ToString());//Max alabileceği eleman sayısı.bir eleman eklendiği anda max eleman sayısı, kapasite 4 olur. her kapasite dolumu mevcut kapasitesinin 2 katına çıkmasına sebebiyet verir.
            personeller.TrimToSize();//Kapasiteyi eleman sayısına eşit hale getirir.
            MessageBox.Show(personeller.Capacity.ToString()); ;

        }
        //Generic=> bir sınıfa bağlı olmayan(veritipine) istenilen veri tipi için kullanılabilen nesnelerdir. bu istenilen herhangi bir veri tipi Type'ın T si ile temsil edilir. Bir nesneyi generic yapmak için <T> ile tanımlarsınız.
        List<Personel> personellerListesi = new List<Personel>();//List<Personel> => senin bana sunduğun listeyi personel listesi olarak kullanmak istiyorum demek oluyor.
        private void btnList_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < personellerListesi.Count; i++)
            {
                //Personel ArrayListSecili = personeller[i] as Personel; Array list kullanınca değeri cast etmenden kullanamayız. çünkü listeye object olarak ekliyoruz. bunu kendi tipine döndürmek lazım

                //Personel secili = personellerListesi[i];
                //MessageBox.Show(secili.Ad);
                MessageBox.Show(personellerListesi[i].Ad); //List sınıfı Personel tipinde olduğu için listenin içinde personel dışında bir kayıt olmayacağından listenin bir elemanını aldığımızda bunu Personele gönüştümek zorunda kalmayız. direk kullanabiliriz
            }

        }
    }
}


