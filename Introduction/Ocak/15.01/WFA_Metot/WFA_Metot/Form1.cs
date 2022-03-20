using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Metot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            Boyaci(this,Color.Black);
            Boyaci(btnVoid,Color.White);
       
          
        }
        /// <summary>
        /// Formun Rengini Gri yapar
        /// </summary>
        public void Boyaci()
        {
            this.BackColor = Color.Gray;
        }
        /// <summary>
        /// Her hangi bir kontrolün rengini gri yapar
        /// </summary>
        /// <param name="ctrl"></param>
        public void Boyaci(Control ctrl)
        {
            ctrl.BackColor = Color.Gray;
        }

        /// <summary>
        /// herhangi bir kontrolün rengini istenilen renk yapar
        /// </summary>
        /// <param name="ctrl"></param>
        /// <param name="renk"></param>
        public void Boyaci(Control ctrl, Color renk)
        {
            ctrl.BackColor = renk;
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            #region Boyaci
            //bool islemsonucu = Boyaci(Color.Maroon, this);
            //if (islemsonucu)
            //{
            //    MessageBox.Show("İşlem Tamamlanmıştır.");
            //}
            //else
            //{
            //    MessageBox.Show("Boyacı İşe Gelmedi.");

            //}
            MesajVer(Boyaci(Color.Maroon, btnFunction), "Renk Değişti", "Hata Oluştu Renk Değiştirilemedi.");
            #endregion


            #region Tek Çift
            //if (SayiCiftmi(3))
            //    MessageBox.Show("Sayi Çift");
            //else
            //    MessageBox.Show("Sayi Tek"); 
            MesajVer(SayiCiftmi(2), "Sayı Çift", "Sayı Tek");
            #endregion

        }

        bool Boyaci(Color renk,Control ctrl)
        {
            try
            {
                ctrl.BackColor = renk;
            }
            catch
            {
                return false;
            }

            return true;

        }

        bool SayiCiftmi(int sayi)
        {
            #region Uzun Hali
            //if (sayi%2==0)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //} 
            #endregion
            return sayi % 2 == 0;
        }

        void MesajVer(bool sonuc,string dogrumesaj,string yanlismesaj)
        {
            if (sonuc)
                MessageBox.Show(dogrumesaj);
            else
                MessageBox.Show(yanlismesaj);
        }



        private void btnRecursive_Click(object sender, EventArgs e)
        {
            Temizle(this.Controls);
        }

        void Temizle(Control ctrl)
        {
            foreach (Control item in ctrl.Controls)
            {
                if (item is TextBox)
                {
                    
                    //TextBox txt=item as TextBox;//Casting
                    //txt.Clear();
                    item.Text = string.Empty;
                }
                else if (item is GroupBox)
                {
                    GroupBox groupBox = item as GroupBox;
                    Temizle(groupBox);
                }

            }
        }

        /// <summary>
        /// Formdaki herhangi bir nesnenin varsa içerisinde TextBox bu metot ile temizlenir.
        /// </summary>
        /// <param name="ctrl"></param>
        void Temizle(Control.ControlCollection ctrl)
        {
            foreach (Control item in ctrl)
            {
                if (item is TextBox)
                {

                    //TextBox txt=item as TextBox;//Casting
                    //txt.Clear();
                    item.Text = string.Empty;
                }
                else if (item.Controls.Count>0)
                {
                    Temizle(item.Controls);
                }

            }
        }
        /*
         Access Modifier (Erişim Belirteci)
        private - mevcut class dışında kimse göremez.
        protected
        internal - mevcut proje içerisinden erilşilebilir.
        protected internal
        public - tüm projelerden erişilebilir.
         
         */








    }
}
