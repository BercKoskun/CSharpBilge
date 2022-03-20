using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Sender_Tag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // bir eventı kim tetikledi bilgisini sender parametresinden alırız.
            //object tipinde olmasının sebebi ise bu event, event tetikleme yeteneği olan tüm nesneler tarafından tetiklenebilir. 

            MessageBox.Show(sender.GetType().Name);

            //biz eğer bu eventı tetikleyen nesneyi kendi özelliğiyle kullanmak istersek aşağıdaki gibi casting(unboxing) işlemini yapmalıyız.
            if (sender is TextBox)
            {
                TextBox txt = sender as TextBox;
                txt.Clear();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
