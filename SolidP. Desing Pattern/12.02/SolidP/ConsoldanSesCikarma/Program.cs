
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoldanSesCikarma
{
    //using SolidP.Liskov.Bad;
    using SolidP.Liskov.Validated;
    using SolidP.DIP.Validated.Concrete;
    using SolidP.DIP.Validated.Abstract;


    class Program
    {
        static void Main(string[] args)
        {

            //Consolun belirlenen frekansda ses çıkarmasını sağlar.
            //Console.Beep(5000, 2000);
            #region Liskov Örnegi

            #region Kötü Senaryo
            //List<Sekil> sekiller = new List<Sekil>();
            //Dikdortgen d = new Dikdortgen();
            //d.Genislik = 5;
            //d.Yukseklik = 12;
            //int dikdortgenalani = d.AlanHesapla(d.Genislik, d.Yukseklik);


            //Kare k = new Kare();
            //k.Genislik = 5;

            //int karealani = k.AlanHesapla(k.Genislik, k.Yukseklik);

            //Console.WriteLine($"Dikdötgenin alanı = {dikdortgenalani}");
            //Console.WriteLine($"Karenin alanı = {karealani}");
            //sekiller.Add(d);
            //sekiller.Add(k);
            //foreach (Sekil sekil in sekiller)
            //{
            //    Console.WriteLine(sekil.AlanHesapla(sekil.Genislik,sekil.Yukseklik));
            //}

            #endregion

            #region Doğru Senaryo
            //List<Sekil> sekiller = new List<Sekil>();
            //Kare k = new Kare();
            //k.KenarUzunlugu = 5;
            //Console.WriteLine(k.AlanHesapla());

            //Dikdortgen d = new Dikdortgen();
            //d.KisaKenar = 5;
            //d.UzunKenar = 12;
            //Console.WriteLine(d.AlanHesapla());

            //sekiller.Add(k);
            //sekiller.Add(d);
            //Console.WriteLine("------------------------------------------");
            //foreach (Sekil sekil in sekiller)
            //{
            //    Console.WriteLine(sekil.AlanHesapla());
            //}


            #endregion

            #endregion


            #region DIP Ornegi

            List<IYemek> siparisler = new List<IYemek>();
            //Balik b = new Balik();
            //IYemek secilenYemek = b;
            IYemek secilenYemek = new Balik();

            IYemek SecilenYemekTavuk = new Tavuk();

            siparisler.Add(SecilenYemekTavuk);
            siparisler.Add(secilenYemek);
            

            Restoran restoran = new Restoran(siparisler);
            restoran.RestoranSipraisiVer();

            #endregion


        }
    }
}
