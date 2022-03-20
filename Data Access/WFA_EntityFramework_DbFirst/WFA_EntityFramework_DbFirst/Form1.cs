using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EntityFramework_DbFirst
{
    using Models;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();

        public List<Category> GetCategories()
        {
            //NorthwindEntities db = new NorthwindEntities();
           return db.Categories.ToList();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKategoriler.DisplayMember = "CategoryName"; //satırın nasıl görüneceği
            cmbKategoriler.ValueMember = "CategoryID";//satırın sakladığı veri
            cmbKategoriler.DataSource = GetCategories();
            
            dataGridView1.DataSource = GetCategories();
        }


        /// <summary>
        /// Kategori oluşturur.
        /// </summary>
        /// <param name="categoryName"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        /// <exception cref="FormatException">Eğer parametreler boş gelirse hata veriyor. Try ile kontrol ediniz.</exception>
        public Category CreateCategory(string categoryName,string description)
        {
            if (string.IsNullOrWhiteSpace(categoryName)||string.IsNullOrWhiteSpace(description))
            {
                throw new FormatException("Bilgiler Eksik, Lütfden Doldurunuz");
                //return null;
            }
            Category newCategory = new Category();
            newCategory.CategoryName = categoryName;
            newCategory.Description = description;

            return newCategory;
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            #region spaghetti
            //if (string.IsNullOrWhiteSpace(txtAd.Text)||string.IsNullOrWhiteSpace(txtAciklama.Text))
            //{
            //    MessageBox.Show("Tüm verileri doldurunuz");
            //    return;
            //}

            //Category newCategory = new Category();
            //newCategory.CategoryName = txtAd.Text;
            //newCategory.Description = txtAciklama.Text; 




            //NorthwindEntities db = new NorthwindEntities();
            //db.Categories.Add(newCategory);//Dbset ile oluşturulan sanal tabolaya yeni kategorimizi ekler ama veritabanının bundan haber yoktur. haberi olması için aşağıdaki kod kullanılır..
            //db.SaveChanges();//sanal tabloda yapılan değişiklikleri veritabanıile karşılaştır. veritabanında olmayan bir değişiklik varsa veritabanında bu işlemeleri gerçekleştir.
            #endregion

            try
            {

                Category yenikategori = CreateCategory(txtAd.Text, txtAciklama.Text);
               //NorthwindEntities db = new NorthwindEntities();
                db.Categories.Add(yenikategori);
                //db.Categories.Add(CreateCategory(txtAd.Text,txtAciklama.Text));
               int ess= db.SaveChanges();
                if (ess>0)
                {
                    MessageBox.Show($"Ekleme İşlemi Başarılıdır. Etkilenen Satır Sayısı {ess}");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            FormuGuncelle();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }


        private void btnSil_Click(object sender, EventArgs e)
        {
          
            if (secilenCategory!=null)
            {
                //NorthwindEntities db = new NorthwindEntities();
                db.Categories.Remove(secilenCategory);
                db.SaveChanges();
                FormuGuncelle();
                secilenCategory = null;
            }
           
        }

      
        Category secilenCategory=null;
        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //NorthwindEntities db = new NorthwindEntities();

            int seciliID = Convert.ToInt32(cmbKategoriler.SelectedValue);
            secilenCategory = db.Categories.Find(seciliID);
            txtAciklama.Text = secilenCategory.Description;
            txtAd.Text = secilenCategory.CategoryName;
           
        }

        public void FormuGuncelle()
        {
            cmbKategoriler.DataSource = GetCategories();
            dataGridView1.DataSource = GetCategories();
        }
    }
}
