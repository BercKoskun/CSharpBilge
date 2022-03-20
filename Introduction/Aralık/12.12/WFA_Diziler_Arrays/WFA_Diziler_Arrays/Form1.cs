using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Diziler_Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * DİZİ (ARRAY)
         * Ayni tipte birden fazla verinin bir arada tutulmasini saglayan nesnelerimize dizi denir...
         * .NET ortamında bir dizi tanımlamak icin iki temel kosul vardir. Bunlardan bir tanesi tip belirtme zorunlulugu, bir tanesi ise boyut belirtme (alternatif => elemanlari ilk anda atama) zorunlulugudur...
         *  değişkeni ismiyle çağırırız, dizideki bir elemanı sıfırdan başlayan değerlerle belirliyoruz.buna index nosu diyoruz.
            neden sıfırdan başlar? başlangıçından itibaren kaçıncı elemaın istiyoruz. Doğduğumuzda yaşımızın 1 değil de 0 olması gibi
            bütün diziler refranas tiptir. int tipindeki bir dizi bile referans tiplidir.
         */

        //Index was outside the bounds of the array.
        //hatasini aliyorsaniz, bilin ki olmayan bir indexe atama yapmaya calisiyorsunuz ya da dizinizin eleman sayisi sinirini astiniz. Hatayi bulmak icin atama kodlariniza bakin!

        string[] sehirler = new string[81]; // belirli bir eleman sayısına sahip ama içerisine değer girilmeyen dizi.
        string[] sehirler2 = { "İstanbul", "Ankara", "İzmir", "Hakkari", "Diyarbakır", "Antalya", "Edirne", "Samsun", "Rize" };

        private void Form1_Load(object sender, EventArgs e)
        {
            //tanımlanan bir diziye eleman atama
            sehirler[0] = "İstanbul";
            sehirler[1] = "Yozgat";
            sehirler[2] = "Trabzon";
            sehirler[3] = "Ankara";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(sehirler2);
        }
    }
}
