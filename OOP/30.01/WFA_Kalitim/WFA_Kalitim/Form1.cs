using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Samsung s = new Samsung();
            Samsung s2 = new Samsung(DateTime.Now.AddDays(10));
            MessageBox.Show(s.UretimTarihi.ToLongDateString());
            MessageBox.Show(s2.CikisTarihi.ToLongDateString());
        }
    }
}
