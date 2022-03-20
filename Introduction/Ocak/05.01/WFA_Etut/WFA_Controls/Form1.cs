using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        //Stack        //Heap
        Random rnd = new Random();
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            //this => Bu form (Form1)
            //Control => form veya form içerisine toolboxdan eklenen bir nesne
            //this.Controls => formun içerisine eklenen nesneler.
            decimal para = 100000;
            MessageBox.Show($"{para.ToString("C2")}");
            int intpara = 10000;
            string format = string.Format("{0:C2}", intpara);
            MessageBox.Show(format);
            //ToString("C2") decimal değişkenlerle kullanıldığında sistem bölgesel para biri sembolu artı para birimi cinsini kullanır.
            string sonrakam = "";
            foreach (Control item in this.Controls)
            {
                MessageBox.Show($"kontrol : {item.GetType().Name}");
                if (item is TextBox)
                {
                    //Stack          //Heap
                    TextBox txt = item as TextBox;
                    #region isimdeki rakamı alma yolu
                    //if (txt.Name.Length < 9)
                    //{
                    //    sonrakam= txt.Name.Substring(txt.Name.Length - 1, 1);
                    //}
                    //else if (txt.Name.Length < 10)
                    //{
                    //   sonrakam= txt.Name.Substring(txt.Name.Length - 2, 2);
                    //} 
                    #endregion
                    MessageBox.Show(sonrakam);
                    MessageBox.Show($"txt: {txt.GetType().Name}");
                    txt.Clear();


                }

            }



        }
    }
}
