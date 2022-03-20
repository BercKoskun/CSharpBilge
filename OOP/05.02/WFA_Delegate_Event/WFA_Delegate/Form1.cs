using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        /*
          * DELEGATE
          * Bir olay gerçekleştiğinde birden fazla fonksiyonu çağırmak istediğinizi düşünelim. Örneğin kullanıcı bir düğmeye tıkladığında birden fazla method'un otomatik olarak çağrılmasını istiyorsunuz. Bunun için delagate kullanabilirsiniz. Burada amaç şu. Bir olay olduğunda birden fazla yere bu olayı bildirebilmek. Bu olay ile ilgilenler delegate ile olaydan haberleri olur.
          * 
          * yada
          * 
          * Temsilci olarak adlandirilabilecek bu yapi, projeyi asil ayakta tutan nesneleri yormak yerine, onlarin islerini uzerine alarak gerceklestirmekten sorumlu olan tiptir. Bu sayede uygulamamizin her bir kolu, uzerine dusen gorevi eksiksiz yerine getirerek daha uzun sureli ve performansli uygulamalar ortaya koyma sansina sahip olabiliriz.
          * Unutulmamasi gereken nokta ise, delegeler de aslinda birer class'tır.
          * Delege tanimlamak icin;
          * 1) Oncelikle delege tanımlamasi gerceklestirilir (geri donus tipi unutulmamalidir!)
          * 2) Delege'nin calismasi konusunda sorumlu olabilecegi metotlar yazilir...
          * 3) Delege'de instance alindigi asamada ilgili metot delegeye baglanir ve metot yerine delege'nin Invoke() metodu cagrilir...
          */

        public delegate void Logger(string mesaj);
        Logger izleyici;
        private void btnLog_Click(object sender, EventArgs e)
        {
            izleyici.Invoke("Merhaba Dünya...");

        }

        public void SmsLogger(string mesaj)
        {
            lblSms.Text = mesaj;
        }
        public void MailLogger(string mesaj)
        {
            lblMail.Text = mesaj;
        }
        public void XmlLogger(string mesaj)
        {
            lblXml.Text = mesaj;
        }
        public void DbLogger(string mesaj)
        {
            lblDb.Text = mesaj;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            izleyici = new Logger(SmsLogger);
            izleyici += MailLogger;
            izleyici += XmlLogger;
            izleyici += DbLogger;

           
        }
    }
}
