using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Control_Collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

            //Bu işlem sadece Form üzerinde eklenen elemanlar içindir. ve bu elemanların içerisinde başka elemanlar var ise bu kod blogu ile görünmez.
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    MessageBox.Show("TextBox");
                }
                else if (item is Button)
                {
                    MessageBox.Show("Button");
                }
                else if (item is Label)
                {
                    MessageBox.Show("Label");
                }
            }

            metotControl(groupBox1);
            metotListe(this.Controls);
        }

        //Metot parametresinde verilen control sınıfından türeyen nesnenin elemanlarında döner. Formda bulunan diğer elemanları etkilemez. Form nesnesinin kendisi verildiyse  sadece form elemanlarını listeler. örneğin groupbox gibi nesnelerin kendisini görür ama içindeki elemanları göremez.
        void metotControl(Control item)
        {

            foreach (Control ctrl in item.Controls)
            {
                if (item is TextBox)
                {
                    MessageBox.Show("TextBox");
                }
                else if (item is Button)
                {
                    MessageBox.Show("Button");
                }
                else if (item is Label)
                {
                    MessageBox.Show("Label");
                }
            }
        }

        //Metot parametresinde verilen listenin elemanlarında döner. Formda bulunan diğer elemanları etkilemez. Form nesnesinin listesi verildiyse sadece form elemanlarını listeler. örneğin groupbox gibi nesnelerin kendisini görür ama içindeki elemanları göremez.
        void metotListe(Control.ControlCollection items)
        {
            foreach (Control item in items)
            {
                if (item is TextBox)
                {
                    MessageBox.Show("TextBox");
                }
                else if (item is Button)
                {
                    MessageBox.Show("Button");
                }
                else if (item is Label)
                {
                    MessageBox.Show("Label");
                }
            }
        }
    }
}
