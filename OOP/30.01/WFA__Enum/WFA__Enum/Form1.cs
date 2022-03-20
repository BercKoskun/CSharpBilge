using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA__Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(KahveBoyutu));


            Kahve k = new Kahve();
            foreach (var item in this.Controls)
            {
                if (item is RadioButton)
                {
                    RadioButton rb = item as RadioButton;
                    switch (rb.Text)
                    {
                        case "Buyuk":
                            k.Boyut = KahveBoyutu.Buyuk;
                            break;
                        case "Orta":
                            k.Boyut = KahveBoyutu.Orta;
                            break;
                        case "Kucuk":
                            k.Boyut = KahveBoyutu.Kucuk;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
