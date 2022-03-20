using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Parametre_Out_Ref_Params
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Parametreler :=> bir metot parametresi üzerine atana değeri metot içerisinde kullanmak için kopyalar. yani bir değişkeni metot parametresi olarak kullandığınızda bu parametrede değşiklik yapınca degişkeninizde bir değişiklik olmaz.

        string[] sehirler = { "İstanbul", "Ankara", "İzmir", "Rize" };
        int girilendeger = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            // girilendeger = 5;

            //sayidegistir(girilendeger);
            //DiziElemanlarınıSil(sehirler);
            DiziBoyutuDegistir(sehirler, 6);
        }

       void sayidegistir(int sayi)
        {
            sayi = 15;
        }
        void DiziElemanlarınıSil(string[] liste)
        {
            for (int i = 0; i < liste.Length; i++)
            {
                liste[i] = string.Empty;
            }
        }

        void DiziBoyutuDegistir(string[] liste,int elemansayisi)
        {

            liste = new string[elemansayisi];

        }


        

    }
}
