using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Etut
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random           rnd =         new      Random();
     // ramde           ramde          yeni     ramde
     // oluşturulacak   oluşturulan            Random sınıfının 
     // sınıfın         adresi                   adresini 
     // adı             taşıyan nesne            oluştur.
            
       private void Form2_Load(object sender, EventArgs e)
        {
            char karakter = Convert.ToChar(rnd.Next(65,91)); //Random sınıfı ile karakter döndürme
            
        }
    }
}
