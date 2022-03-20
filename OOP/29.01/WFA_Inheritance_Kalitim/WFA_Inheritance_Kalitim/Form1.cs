using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Inheritance_Kalitim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hayvan h = new Hayvan();
            
            
            Kopek k = new Kopek();
            
            MessageBox.Show(k.SesCikar());
           
            Kedi kedi = new Kedi();
            
            MessageBox.Show(kedi.SesCikar());
           
            Kus kus = new Kus();
            MessageBox.Show(kus.SesCikar());

            Balik b = new Balik();
            MessageBox.Show(b.SesCikar());
        }
    }
}
