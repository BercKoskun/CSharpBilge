using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_OOP_Etut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            Product yeniurun = new Product();//ramde Product şablonu nesneye dönüştü.
            yeniurun.ID = 1;
            yeniurun.Name = "Çizi";
            yeniurun.Price = 4;
            yeniurun.Stock = 250;
            yeniurun.CategoryID = 1;

            listBox1.Items.Add(yeniurun.NesneyiGoruntule());

            ListViewItem lvi = new ListViewItem();
            lvi.Text = yeniurun.ID.ToString();
            lvi.SubItems.Add(yeniurun.Name);
            lvi.SubItems.Add(yeniurun.Price.ToString("C2"));
            lvi.SubItems.Add(yeniurun.Stock.ToString());
            lvi.SubItems.Add(yeniurun.CategoryID.ToString());
            lvi.Tag = yeniurun;
            listView1.Items.Add(lvi);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem !=null)
            {
                Product seciliUrun = listBox1.SelectedItem as Product;
                MessageBox.Show(seciliUrun.ToString());
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].Tag!=null)
            {
                Product seciliUrun = listView1.SelectedItems[0].Tag as Product;
                MessageBox.Show(seciliUrun.ToString());
            }
        }

        private void btnCategoryEkle_Click(object sender, EventArgs e)
        {
            Category yeniKategori = new Category();
            yeniKategori.ID = 1;
            yeniKategori.Name = "Yiyecek";
            yeniKategori.Description = "hede hödö";

            listBox1.Items.Add(yeniKategori.NesneyiGoruntule());
        }
    }
}
