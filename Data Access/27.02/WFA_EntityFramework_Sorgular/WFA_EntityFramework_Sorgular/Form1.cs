using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_EntityFramework_Sorgular.Models;
namespace WFA_EntityFramework_Sorgular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            #region Soru
            // Fiyatı 20 ile 50 arasında olan ürünlerin Id,Ürün Adı, Fiyatı, Stok Miktarını ve Kategorisini getiren sorgu 
            #endregion

            #region SQL

            //Select ProductID,ProductName,UnitPrice,UnitsInStock,CategoryID from products where unitprice between 20 and 50  
            #endregion

            #region LinQ
            //dataGridView1.DataSource= db.Products.Where(p => p.UnitPrice >= 20 & p.UnitPrice < 51).ToList(); tüm kolonlar

            dataGridView1.DataSource = db.Products.Where(p => p.UnitPrice >= 20 & p.UnitPrice < 51).Select(p => new
            {
                p.ProductID,
                p.ProductName,
                p.UnitPrice,
                p.UnitsInStock,
                p.CategoryID
            }).ToList();


            #endregion


        }
        private void button2_Click(object sender, EventArgs e)
        {
            #region Soru
            // Siparişler tablosundan MusteriSiketAdi, CalisanAdiSoyadi, SiparisId, SiparisTarihi ve KargoSirketiAdi getiren sorgu 
            #endregion

            #region SQL Server
            //Select  * from Orders o 
            //    join Customer c on c.CustomerId=o.CustomerID
            //    join Employees e on e.EmployeeID=o.EmployeeID
            //    join Shippers s on s.ShipperID=o.ShipVia
            #endregion
            //Ödev => LazyLoad/LazyLoading

            #region LinQ
            dataGridView1.DataSource = db.Orders.Select(o => new
            {
                SiparisNumarası = o.OrderID,
                SiparisTarihi = o.OrderDate,
                Calisan = o.Employee.FirstName + " " + o.Employee.LastName,
                Musteri = o.Customer.CompanyName,
                Kargo = o.Shipper.CompanyName

            }).ToList();
            #endregion

        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region Sorgu
            // CompanyName içerisinde restaurant geçen müşterilerin listelenmesi 
            #endregion

            #region LinQ
            dataGridView1.DataSource = db.Customers.Where(c => c.CompanyName.Contains("restaurant")).ToList();
            #endregion
        }

        private void button4_Click(object sender, EventArgs e)
        {
            #region Soru
            // Çalışanların Adını, Soyadını, Doğum Tarihini ve Yaşını Getiren Sorgu Yazınız 
            #endregion
            dataGridView1.DataSource = db.Employees.Select(x => new
            {
                x.FirstName,
                x.LastName,
                x.BirthDate,
                //Yas=DateTime.Now.Year - e.BirthDate.Value.Year,
                Yas = SqlFunctions.DateDiff("year", x.BirthDate, DateTime.Now)
            }).ToList();

            //SqlFunctions kullanmak için using System.Data.Entity.SqlServer; ekliyoruz
        }

        private void button5_Click(object sender, EventArgs e)
        {
            #region Soru
            // Kategorilerine stoktaki ürün sayısını veren sorgu 
            #endregion
            //Select CategoryID,Sum(unitsinstock) from PRoducts group by CategoryID

            #region LinQ
            #region Join olmadan
            //dataGridView1.DataSource = db.Products.GroupBy(p => p.CategoryID).Select(p => new
            //{
            //    Kategori = p.Key,
            //    ToplamStok = p.Sum(x => x.UnitsInStock)

            //}).ToList(); 
            #endregion
            #region Join ile
            dataGridView1.DataSource = db.Products.GroupBy(p => p.Category.CategoryName).Select(p => new
            {
                Kategori = p.Key,
                ToplamStok = p.Sum(x => x.UnitsInStock)

            }).ToList();
            #endregion
            #endregion
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Hangi Kategoriden ve hangi tedarikçiden, depoda kaç tane ürünüm var ?
            //Select CategoryID, SupplierID, Sum(UnitsInStock) 
            //from Products
            //group by CategoryID, SupplierID

            #region LinQ
            #region Join Olmadan
            //dataGridView1.DataSource = db.Products.GroupBy(p => new { p.CategoryID, p.SupplierID }).Select(p => new
            //{

            //    Kategori = p.Key.CategoryID,
            //    Tedarikci = p.Key.SupplierID,
            //    Toplam = p.Sum(x => x.UnitsInStock)


            //}).ToList(); 
            #endregion
            #region Joinli

            dataGridView1.DataSource = db.Products
                .GroupBy(p => new { p.Category.CategoryName, p.Supplier.CompanyName })
                .Select(p => new
                {

                    Kategori = p.Key.CategoryName,
                    Tedarikci = p.Key.CompanyName,
                    Toplam = p.Sum(x => x.UnitsInStock)


                }).OrderByDescending(p => p.Toplam).ToList();
            #endregion
            #endregion
            //OrderBy(p=>p.Toplam) azdan - çok
            //OrderByDescending(p=>p.Toplam) çokdan az

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //--Hangi ulkeye kac tane sipariş gitmis ?
            dataGridView1.DataSource = db.Orders.GroupBy(o => o.ShipCountry).Select(o => new
            {
                Country = o.Key,
                Count = o.Count()
            }).OrderByDescending(o => o.Count).ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //--Ulkesi Ingiltere olmayan, adi A ile baslayip soyadi R ile biten, dogum tarihi 1985'ten once olan calisanim kimdir?

            //Employee arananKisi = db.Employees.Where(x => x.Country != "UK" & x.FirstName.StartsWith("A") & x.LastName.EndsWith("R") & x.BirthDate.Value.Year < 1985).FirstOrDefault(); 


            dataGridView1.DataSource = db.Employees.Where(x => x.Country != "UK" & x.FirstName.StartsWith("A") & x.LastName.EndsWith("R") & x.BirthDate.Value.Year < 1985).ToList();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //--Japoncayi akici konusan personel kimdir?
            dataGridView1.DataSource = db.Employees.Where(x => x.Notes.Contains("fluent in Japanese")).ToList();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //--Hangi kategorili üründen(categoryName) ve hangi müşteriye(CompanyName) toplam ne kadarlık ürün satılmıştır ?
            dataGridView1.DataSource = db.Order_Details
                .AsEnumerable()//veritabanından sorguyu bitirir. Programa liste verir.
                .GroupBy(x => new
                {
                    x.Product.Category.CategoryName,
                    x.Order.Customer.CompanyName
                })
                .Select(a => new
                {
                    Kategori = a.Key.CategoryName,
                    Musteri = a.Key.CompanyName,
                    Toplam = a.Sum(x => (x.Quantity * x.UnitPrice) * (1 - (decimal)x.Discount))
                }).ToList();


        }

        private void button11_Click(object sender, EventArgs e)
        {
            //-hangi firmanın satın aldığı siparişi hangi kargo şirketi taşımıştır ?
            dataGridView1.DataSource = db.Orders.Select(o => new
            {
                Musteri = o.Customer.CompanyName,
                Tasıyıcı = o.Shipper.CompanyName


            }).Distinct().ToList();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //outer(left-right) join -  kullanımı 

            //select CompanyName,OrderID from Customers c left
            //join Orders o on o.customerID = c.CustomerID
            //where OrderID is null
            //Şimdiye kadar hangi müşteriler benden hiçbir ürün almamıştır ?
           dataGridView1.DataSource = db.Customers.
                GroupJoin
                (
                db.Orders,
                customer => customer.CustomerID,
                order => order.CustomerID,
                (x, y) => new { customer = x, order = y }
                ).
                SelectMany
                (
                 orderlistesi => orderlistesi.order.DefaultIfEmpty(),
                (x, y) => new { Musteri = x.customer.CompanyName, Siparis = y }
                ).Where(z => z.Siparis == null).ToList();
                
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //1996 yılında benden ürün alan müşteriler kimlerdir ?
            dataGridView1.DataSource = db.Orders
                .Where(x => x.OrderDate.Value.Year == 1996)
                .Select(x => new
                {
                    x.Customer.CompanyName

                }).Distinct().ToList();

            //dataGridView1.DataSource = db.Orders.
            //    Join
            //    (db.Customers,
            //    o => o.CustomerID,
            //    c => c.CustomerID,
            //    (x, y) => new { Siparis = x, Musteri = y })
            //    .Where(z=>z.Siparis.OrderDate.Value.Year==1996)
            //    .ToList();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}
