using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Constructor_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ev yeniev = new Ev();
            yeniev.Sehir = "İstanbul";
            yeniev.Ilce = "Kadıköy";
            yeniev.Mahalle = "Caferağa";
            yeniev.Sokak = "Mühürdar";
            yeniev.Konum = "Deniz Manzaralı";


            Ev evyeni = new Ev(2, 5, false, "Bogazgören mah,ahmet mehmet sokak,yamuk apt kat:5 daire 15", textBox1.Text, 25);
        }
    }
}
