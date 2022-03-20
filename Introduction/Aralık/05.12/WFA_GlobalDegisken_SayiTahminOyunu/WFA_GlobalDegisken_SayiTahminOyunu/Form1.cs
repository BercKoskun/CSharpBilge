using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_GlobalDegisken_SayiTahminOyunu
{
    public partial class Form1 : Form
    {//A
       
        //A-B noktaları Global Alan
            //Global alan  değişkenleri tüm event ve metotlar tarafından okunup üzerine yeni değerler eklenebilir. 
            //Global alan değişkenleri program kapatılana dek ramde saklanmaya devam eder.
        //C-D noktarı Local Alan
            //Local alan değişkenleri sadece tanımlandıkları local bölgede ulaşılabilir.
            //Local bölge çalışmasını tamamladığında ramden bu değişkenler kaldırılır.
        public Form1()
        {
            InitializeComponent();
        }
        int altlimit = 0; 
        int ustlimit = 100, tahmin = 0, tahminsayisi = 0;
        private void btnBasla_Click(object sender, EventArgs e)
        {//C
            tahmin = (altlimit + ustlimit) / 2;
            lblTahmin.Text = tahmin.ToString();
            lblTahminSayisi.Text = (++tahminsayisi).ToString();
        }//D
        private void btnYukari_Click(object sender, EventArgs e)
        {
            altlimit = tahmin;
            tahmin = (altlimit + ustlimit) / 2;
            lblTahmin.Text = tahmin.ToString();
            tahminsayisi++;
            lblTahminSayisi.Text = tahminsayisi.ToString();
        }
        private void btnAsagi_Click(object sender, EventArgs e)
        {
            ustlimit = tahmin;
            tahmin = (altlimit + ustlimit) / 2;
            lblTahmin.Text = tahmin.ToString();
            tahminsayisi++;
            lblTahminSayisi.Text = tahminsayisi.ToString();
        }

      
    }//B
}
