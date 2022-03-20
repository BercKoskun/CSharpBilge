using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OutPameter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int degerfirlat;
        private void btnOut_Click(object sender, EventArgs e)
        {
            geriyeDegerFirlatanMetot(out degerfirlat);
            MessageBox.Show(degerfirlat.ToString());

        }

        #region Ornek1
        void geriyeDegerFirlatanMetot(out int degisken)
        {
            degisken = 15;
        } 
        #endregion

        private void btnOutIki_Click(object sender, EventArgs e)
        {
            int kacelemansilindi;
            ElemanlariTemizle(listBox1,out kacelemansilindi);
            MessageBox.Show(kacelemansilindi.ToString());

        }

        #region OrnekIki

        void ElemanlariTemizle(ListBox list,out int silinenElemanSayisi)
        {
          silinenElemanSayisi=list.Items.Count;
            list.Items.Clear();
        }

        #endregion
    }
}
