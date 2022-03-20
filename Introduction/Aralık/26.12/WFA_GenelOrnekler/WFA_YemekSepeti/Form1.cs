using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_YemekSepeti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
       Kebap ve Pilav olmak üzere 2 adet yemeğim de Comboxlara gelsin
       karşılarındaki numericupdown lardan porsiyon miktarı buçuklu olarak da seçilebilsin
       heriki alandan da aynı yemek seçilemesin

       Kebap porsiyon => 9.5
       Pilav porsiyon => 3.5

       Buttona bastığımda bana toplam bir hesap çıkarsın
       numericupdown kontrolünün değeri value sudur, dcimal döner 
       artış miktarı Increment özelliğidir
       ondalıksal karakter sayısı decimalPlaces özelliğidir

    */
        //const -> sabit değişken tanımlamak için kullanılır. const olarak işaretlenen değişken değeri programın herhangi bir bölümünde değiştirilemez. örn -> int.MaxValue örnek gösterilebilir.
       const  decimal kebapPosiyonFiyat = 9.5m;
       const decimal pilavPorsiyonFiyat = 3.5m;
        decimal toplamfiyat = 0;

        string[] menu = { "--Lütfen Bir Yemek Seçiniz--", "Kebap", "Pilav" };
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Eğer Dizi Kullanmazsak Yemekleri Nasıl Ekleriz?
            // cmbBirinciYemek.Items.Add("--Lütfen Bir Yemek Seçiniz--");
            // cmbBirinciYemek.Items.Add("Kebap");
            // cmbBirinciYemek.Items.Add("Pilav");
            // cmbBirinciYemek.SelectedIndex = 0;

            // // ALT + Mause Sol Tuş + Sürükle -> toplu seçim

            //cmbIkinciYemek.Items.Add("--Lütfen Bir Yemek Seçiniz--");
            //cmbIkinciYemek.Items.Add("Kebap");
            //cmbIkinciYemek.Items.Add("Pilav");
            //cmbIkinciYemek.SelectedIndex = 0; 
            #endregion

            cmbBirinciYemek.Items.AddRange(menu);
            cmbIkinciYemek.Items.AddRange(menu);
            cmbBirinciYemek.SelectedIndex =0;
            cmbIkinciYemek.SelectedIndex =0;
        }

        private void cmbBirinciYemek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBirinciYemek.SelectedIndex == 0)
            {
                return;
            }

            if (cmbBirinciYemek.SelectedIndex==cmbIkinciYemek.SelectedIndex)
            {
                MessageBox.Show("İki Yemek Aynı Olamaz","Seçim Uyarısı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //cmbBirinciYemek.SelectedIndex = -1;// eğer varsayılan bir item eklemediyseniz, hiçbir item seçili olmasın istediğinizde -1 değerini kullanırsınız.
                cmbBirinciYemek.SelectedIndex = 0;

            }



        }

        private void cmbIkinciYemek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIkinciYemek.SelectedIndex==0)
            {
                return;
            }

            if (cmbBirinciYemek.SelectedIndex == cmbIkinciYemek.SelectedIndex)
            {
                MessageBox.Show("İki Yemek Aynı Olamaz", "Seçim Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //cmbBirinciYemek.SelectedIndex = -1;// eğer varsayılan bir item eklemediyseniz, hiçbir item seçili olmasın istediğinizde -1 değerini kullanırsınız.
                cmbIkinciYemek.SelectedIndex = 0;

            }
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            if (cmbBirinciYemek.SelectedIndex==0 && cmbIkinciYemek.SelectedIndex==0)
            {
                MessageBox.Show("en az bir yemek seçmek zorundasın");
                return;
            }
            toplamfiyat = 0;

            if (cmbBirinciYemek.SelectedIndex == 1 && cmbIkinciYemek.SelectedIndex == 0)
            {
                toplamfiyat += kebapPosiyonFiyat * nudBirinci.Value;
            }
            else if (cmbBirinciYemek.SelectedIndex == 1 && cmbIkinciYemek.SelectedIndex == 2)
            {
                toplamfiyat += kebapPosiyonFiyat * nudBirinci.Value + pilavPorsiyonFiyat * nudIkinci.Value;
            }
            else if (cmbBirinciYemek.SelectedIndex == 2 && cmbIkinciYemek.SelectedIndex == 0)
            {
                toplamfiyat += pilavPorsiyonFiyat * nudBirinci.Value;
            }
            else if (cmbBirinciYemek.SelectedIndex == 2 && cmbIkinciYemek.SelectedIndex == 1)
            {
                toplamfiyat += pilavPorsiyonFiyat * nudBirinci.Value + kebapPosiyonFiyat * nudIkinci.Value;
            }
            else if (cmbIkinciYemek.SelectedIndex == 1 && cmbBirinciYemek.SelectedIndex == 0)
            {
                toplamfiyat += kebapPosiyonFiyat * nudIkinci.Value;
            }
            else if (cmbIkinciYemek.SelectedIndex == 1 && cmbBirinciYemek.SelectedIndex == 2)
            {
                toplamfiyat += kebapPosiyonFiyat * nudIkinci.Value + pilavPorsiyonFiyat * nudBirinci.Value;
            }
            else if (cmbIkinciYemek.SelectedIndex == 2 && cmbBirinciYemek.SelectedIndex == 0)
            {
                toplamfiyat += pilavPorsiyonFiyat * nudIkinci.Value;
            }
            else if (cmbIkinciYemek.SelectedIndex == 2 && cmbBirinciYemek.SelectedIndex == 1)
            {
                toplamfiyat += pilavPorsiyonFiyat * nudIkinci.Value + kebapPosiyonFiyat * nudBirinci.Value;
            }

            MessageBox.Show($"Sipariş Toplam Tutarı : {toplamfiyat.ToString("C2")}");

        }
    }
}
