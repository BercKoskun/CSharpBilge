using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TimerNesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         Milisaniye cinsinden belirtilen zaman aralıklarında kodlarımızı çalıştırmak için kullandığımız kontroldür. Örneğin bir
işlemin 10 saniyede bir kez yapılmasını istediğimizde kullanabiliriz. Bu işlemi yapmak için kullanıcının herhangi bir
butona tıklaması gerekmez. Timer kontrolü otomatik olarak 10 saniyede bir çalışacaktır.
         
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
