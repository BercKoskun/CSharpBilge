using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Events (Olaylar) kullanıcının fare ile tıklaması, klavyeden bir tuşa basma gibi işletim sistemi üzerinden gerçekleştirdiği eylemlerdir. Bir bileşen üzerinde meydana gelen olayları takip eden ve bunları yakalayan mekanizma event handler olarak adlandırılır. 

        // Event Handler ilgili olay gerçekleştiği zaman tetiklenir. Olay gerçekleştikten sonra hangi işlemlerin yapılacağı olay yöneticileri için delegeler ile temsil edilir. Bir kullanıcının fare ile tıklaması örneğin bir Click olayıdır, bir tuşa basma olayı bir Keypress olayıdır ve bu olayların sonucunda nelerin yapılması gerektiğini biz kodlarımızla belirtebiliriz.
        private void btnGazla_Click(object sender, EventArgs e)
        {
            Araba a = new Araba(0,"BMW");
            a.HizAsimi += A_HizAsimi;

            //Arabayı Çalıştırıp Gaza Bastık
            for (int i = 0;i<13 ; i++)
            {
                a.Hiz += 10;
                lstHizGostergesi.Items.Add($"Hiziniz = {a.Hiz}");
            }

        }

        private void A_HizAsimi()
        {
            lstHizGostergesi.Items.Add("Çok Hızlısın!!!");
        }
    }
}
