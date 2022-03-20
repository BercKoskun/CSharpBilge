using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_SayisalKuponuOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int rasgelesayi = 0;
        private void btnKuponOlustur_Click(object sender, EventArgs e)
        {

            #region For ile
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is ListBox)
                {
                    ListBox lst = this.Controls[i] as ListBox;
                    lst.Items.Clear();
                    for (int j = 0; j < 6;)
                    {
                        rasgelesayi = rnd.Next(1, 50);
                        if (!lst.Items.Contains(rasgelesayi))
                        {
                            lst.Items.Add(rasgelesayi);
                            j++;
                        }
                    }
                }
            }
            #endregion
            //this.Controls  -> form içerisine bir kontrol eklediğimizde kaydedildiği liste
            #region Foreach ile
            foreach (Control item in this.Controls)
            {
                if (item is ListBox)
                {

                    ListBox lst = item as ListBox;
                    lst.Items.Clear();
                    for (int i = 0; i < 6;)
                    {
                        rasgelesayi = rnd.Next(1, 50);
                        if (!lst.Items.Contains(rasgelesayi))
                        {
                            lst.Items.Add(rasgelesayi);
                            i++;
                        }
                    }
                }
            } 
            #endregion


        }
    }
}
