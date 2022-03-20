using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_GenelOrnekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rıdvan");
            listBox1.Items.Add("Kürşat");
            listBox1.Items.Add("Emre");
            listBox1.Items.Add("Gözde");
            listBox1.Items.Add("Cemil");
            listBox1.Items.Add("Rüstem");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Secili Elemanı Getirme

           string kisi= cmbKisiler.SelectedItem.ToString();
            MessageBox.Show(kisi);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //standart combobox Secili Elemanı Getirme
            string kisi = cmbStandart.SelectedItem.ToString();
            MessageBox.Show(kisi);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //cmbKisiler Eleman Ekleme
            cmbKisiler.Items.Add("Bora");
            cmbKisiler.Items.Add(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cmbKisiler son elemanı seçme

            //Count -> Collection olarak tanımlanan nesnelerde eleman sayısını verir.
            int elemansayısı = cmbKisiler.Items.Count;
            object eleman = cmbKisiler.Items[elemansayısı - 1];
            MessageBox.Show(eleman.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //cmbStandar son elemanı seçme
            int elemansayısı = cmbStandart.Items.Count;
            object eleman = cmbStandart.Items[elemansayısı - 1];
            MessageBox.Show(eleman.ToString());
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmbKisiler.Items.Remove("Rıdvan");//Elemanın kendisini vererek silinir.
            cmbKisiler.Items.RemoveAt(1);//elamnın sıra numarası verilerek silinmesini sağlar.

        }

        private void button8_Click(object sender, EventArgs e)
        {
            cmbStandart.Items.Remove("Rıdvan");//Elemanın kendisini vererek silinir.
            cmbStandart.Items.RemoveAt(1);//elamnın sıra numarası verilerek silinmesini sağlar.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //cmbKisiler.Items[1] = "Utku";// mevcut indexin üstüne yazar.
            //Insert metodu ise belirtilen indexe ekleme yapar orada mevcut değer var ise bir alt indexe kaydırır.
            cmbKisiler.Items.Insert(2,"Laden");
        }

        private void cmbKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
         
         MessageBox.Show(cmbKisiler.SelectedItem.ToString());
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }
    }
}
//object -> veri tiplerinin atası, aslında her ver tipi bir objecttir. biz diğer veritiplerini boxing - unboxing işlemlerini azalmak için kullanırız.
//boxing - unboxing nedir?
//boxing -> bir değer ya da nesnenin object olarak tanımlanması
//unboxing-> bir object nesne veya değerin kendi tipine dönüştürülmesi
