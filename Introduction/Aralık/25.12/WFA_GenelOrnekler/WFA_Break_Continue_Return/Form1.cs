using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Break_Continue_Return
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Continue keyword(anahtar kelime) döngü içerisinde kullanıldığında bir sonraki adıma(bir sonraki Item) geçer. Amaç kullanıldığı satırdan sonraki kodların çalıştırılmamasını sağlamak. genellikle bir durumu kontrol ederek continue kullandığımız için sanki if ile beraber kullanılır algısı oluşur. bu yanlış bir algıdır. Continue döng içerisinde kullanılır.
            for (int i = 0; i < 5; i++)
            {
                if (i%2==0)
                {
                    continue;
                }
                MessageBox.Show($"Bu sayı Tektir {i}");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //break keyword -> döngü içerisinde kullanılır ve sadece döngünün bitmesini sağlar. döngü koşul ve ya adım sayısı olarak henüz bitmemiş olsa bile döngünün sonlandırılmasını sağlar. 
            int sayi = 15;
            for (int i = 1; i < 100; i++)
            {
                if (sayi>=50)
                {
                    break;
                }
                MessageBox.Show($"Sayi={sayi}");
                sayi += i;
            }

            MessageBox.Show("Sayının sonucu break ile kesildi");
        }

        private void button3_Click(object sender, EventArgs e)
        {//A

            //return => bir döngü ve ya karar yapısı içerisinde kullanılmak zorunda değildir. programın herhangi bir bölümünde return kullanabilirsiniz. kullanıldığında kendinden sonraki kodları çalıştırmadan bulunduğu yaşam döngüsünü sonlandırır.
            //Ayrıca bir diğer görevid metot içerisinde kullanıldığında metotun geriye göndermek istediği değer tipine uygun değerleri döndürür.
            int sayi = 15;
            for (int i = 1; i < 100; i++)
            {
                if (sayi >= 50)
                {
                    return;
                }
                MessageBox.Show($"Sayi={sayi}");
                sayi += i;
            }

            MessageBox.Show("Sayının sonucu break ile kesildi");
        }//B
    }
}
