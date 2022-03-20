using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Ref
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        REF ANAHTAR KELİMESİ

        ref parametre niteleyicisi C#’ın “değer olarak çağrı” yerine “referans olarak çağrı” oluşturmasını sağlar. ref kullanarak, void tipli methodlardan değer alabilirsiniz. Üstelik bu değeri alabilmek için yeni bir değişken atamanıza gerek bile kalmaz. ref, methoda parametre olarak soktuğunuz, elinizdeki varolan değişkeni değiştirebilir.

        */
       
        private void Form1_Load(object sender, EventArgs e)
        {
            //değişken tanımı local bölümde yapılırsa başlangıç değeri tanımlanmalı. NEdeni ise ref anahtar kelimesi referans yani ramde bulunan adres üzerinden çağrı yaptığı için değişkenin ramde bir değeri olması gerekir.
            string[] sehirler = { "İstanbul", "İzmir" };
            int sayi=1;
            degerDegistir(ref sayi);
            DiziElemanSayisiDegistir(ref sehirler, 6);
        }

        void degerDegistir(ref int degistirileceksayi)
        {
            degistirileceksayi = 15;
        }

        void DiziElemanSayisiDegistir(ref string[] dizi, int elemansayisi)
        {
            string[] yenidizi = new string[elemansayisi];
          
            if (dizi.Length>elemansayisi)
            {
                Array.Copy(dizi, yenidizi, elemansayisi);
            }
            else if (dizi.Length<=elemansayisi)
            {
                Array.Copy(dizi, yenidizi, dizi.Length);
            }

            dizi = yenidizi;
        }

    }
}
