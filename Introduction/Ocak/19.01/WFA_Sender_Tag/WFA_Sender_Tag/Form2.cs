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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
              
               Button btn= sender as Button;
               
                string mesaj = btn.Tag.ToString();

                MessageBox.Show(mesaj);
            }
        }
    }
}
