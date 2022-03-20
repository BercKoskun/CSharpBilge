using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

            //typeof() => parantez içerisinde ki nesnenin sahip olduğu tipi döndürür.
            //Enum.GetValues(typeof(KnownColor))=>  Enum yani sirali sabit liste olarak tanımlanan nesnenin içerisindeki elemanları döndürü.
            foreach (var color in Enum.GetValues(typeof(KnownColor)))
            {
                cmbRenkler.Items.Add(color);
            }
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            #region bir class üzerinden çağrı ile nesne özelliği değştirme işlemidir. Yani diğer nesneye bir bilgi göndermeden işlem yapmak demektir.
            //RenkCumbusu rnkcmb = new RenkCumbusu();
            //KnownColor renk = (KnownColor)cmbRenkler.SelectedItem;
            //rnkcmb.BackColor = Color.FromKnownColor(renk);
            //rnkcmb.Show();
            #endregion

            KnownColor renk = (KnownColor)cmbRenkler.SelectedItem;
            Color gonderilecekrenk = Color.FromKnownColor(renk);
            RenkCumbusu rnkcmb = new RenkCumbusu(gonderilecekrenk);
            rnkcmb.Show();

        }
    }
}
