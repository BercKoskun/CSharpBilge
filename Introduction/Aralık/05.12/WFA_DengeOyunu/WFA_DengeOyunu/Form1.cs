using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_DengeOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Bir nesnenin konum ve kapladığı yer ile ilgili bilgiler.
            //bir nesnenin konumlanmaıs için belirtilen nokta(pixcel) Point sınıfı ile betimlenir
            //bir nesnenin sol üst köşesi 0 noktasıdır. ve form ve form içerisinde ki nesneler bu 0 noktası ile konumlandırılır. buna location denir.
            //lblStart.Left = 500;
            //lblStart.Top = 500;

            //Form ya da form içerisinde ki nesneler 0 noktasında konumlandıktan sonra genişlik ve uzunluklarına göre alan kaplarlar. buna da Size denir.
            //lblStart.Width = 100;
            //lblStart.Height = 100; 
            #endregion

            //Cursor => fare yi temsil eden sınıf
            //point => ekranda ki her hangi bir pixcel'i temsil eden sınıf.
            //new Point() =>ekranda bir nokta oluşturma. ekran da noktalar var ama program bunu bilemez. biz programa monitorde gördümüz bir konumu aslında tanıtıp oraya gitmesini istiyoruz.
            int labelinXKonumu = lblStart.Location.X;
            int labelinYKonumu = lblStart.Location.Y;
            int labelinSoldanOrtaNoktasi = lblStart.Width / 2;
            int labelinYukaridanOrtaNoktasi = lblStart.Height/2;
            Point konum = new Point(labelinXKonumu+labelinSoldanOrtaNoktasi, labelinYKonumu+labelinYukaridanOrtaNoktasi);
            Cursor.Position = this.PointToScreen(konum);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            int labelinXKonumu = lblStart.Location.X;
            int labelinYKonumu = lblStart.Location.Y;
            int labelinSoldanOrtaNoktasi = lblStart.Width / 2;
            int labelinYukaridanOrtaNoktasi = lblStart.Height / 2;
            Point konum = new Point(labelinXKonumu + labelinSoldanOrtaNoktasi, labelinYKonumu + labelinYukaridanOrtaNoktasi);
            Cursor.Position = this.PointToScreen(konum);
            
            //Application.Exit(); uygulamayı kapatır.
        }

        private void lblFinish_MouseEnter(object sender, EventArgs e)
        {
            //mbox + tab +tab
            
            MessageBox.Show("Merhaba Oyuncu \nOyunu Kazandınız. Tebrikler!!!");
        }
    }
}
