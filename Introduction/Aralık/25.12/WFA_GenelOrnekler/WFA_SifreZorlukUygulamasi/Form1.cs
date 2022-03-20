using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SifreZorlukUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ozelkaraketer = "*?/.,!+%&";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sifre = textBox1.Text;
            if (sifre.Length<6)
            {
                errorProvider1.SetError(textBox1, "Şifre en az 6 karakter olmalı");
                return;//kendisinden sonraki kodları çalıştırmadan bulunduğu kod blogundan çıkar.
            }
            errorProvider1.Clear();
            bool buyukharfvarmi = false;
            for (int i = 0; i < sifre.Length; i++)
            {
                //if (char.IsUpper(sifre[i]))
                //{
                //    buyukharfvarmi = true;
                //    break;
                //}

                if (sifre[i] == Convert.ToChar(sifre[i].ToString().ToUpper()))
                {
                    buyukharfvarmi = true;
                    break;
                }
            }

            if (!buyukharfvarmi)
            {
                errorProvider1.SetError(textBox1, "Şirede en az birtane büyük harf olmalı");
                return;
            }

            bool ozelkaraktervarmi = false;
            for (int i = 0; i < sifre.Length; i++)
            {
                if (ozelkaraketer.Contains(sifre[i].ToString()))
                {
                    ozelkaraktervarmi = true;
                }
            }

            if (!ozelkaraktervarmi)
            {
                errorProvider1.SetError(textBox1, "Şifrede en az birtane özel karakter olmalı");
            }

            //Eğer 6 karakter ise kolay şifre
            //eğer 6 karakter ve bir rakam var ise orta ya da bir büyük harf varsa orta ya da bir sembol varsa orta şifre
            //Eğer 6 harf ve bir rakam ve bir sembol ve bir büyük harf var ise zor şifre yazsın.

        }
    }
}
