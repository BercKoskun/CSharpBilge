using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SayisalLotoSonuclari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int rasgelesayi = 0;
        private void btnSonucGoster_Click(object sender, EventArgs e)
        {
            lstSonuclar.Items.Clear();
            for (int i = 0; i < 6; )
            {
                rasgelesayi = rnd.Next(1, 50);
                if (!lstSonuclar.Items.Contains(rasgelesayi))
                {
                    lstSonuclar.Items.Add(rasgelesayi);
                    i++;
                }
            }
        }
    }
}
