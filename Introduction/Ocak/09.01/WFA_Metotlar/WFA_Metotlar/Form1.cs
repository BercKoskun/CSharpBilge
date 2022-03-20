using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!TextleriKontrolEt(this.Controls))
            {
                MessageBox.Show("Formu Boş Bırakmadan Doldurunuz...");
                return;
            }

            lblMail.Text = MailUret(txtAd.Text, txtSoyad.Text, txtSirket.Text);
        }

        bool TextleriKontrolEt(Control.ControlCollection collection)
        {
            foreach (Control item in collection)
            {
                if (item is TextBox)
                {

                    if (String.IsNullOrWhiteSpace(item.Text))
                    {
                        MessageBox.Show(string.Format("{0} Boş Bırakılamaz.", item.Name.Substring(3)));

                        return false;
                    }
                }
            }

            return true;
        }

        string MailUret(string ad,string soyad,string sirket)
        {
            return string.Format("{0}.{1}@{2}.com", ad.ToLower(), soyad.ToLower(), sirket.ToLower());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
