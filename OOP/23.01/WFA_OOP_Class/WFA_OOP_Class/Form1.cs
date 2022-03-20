#region Bu kod ekranında kullanabileceğiniz kütüphanelerin referanslarını ekleme işlemidir.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
#endregion

namespace WFA_OOP_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {

           
            Hayvan Kopek = new Hayvan();
            Kopek.Ad = "Boji";
            Kopek.Cinsi = "Sokak Köpeği";
            Kopek.Agirlik = 4;
            Kopek.Renk = "Kahve Rengi";
            Kopek.Yas = 8;
            Kopek.SesCikar();
            
            MessageBox.Show(Kopek.Ad);

           
        }
    }

   
}
