using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Constructor
{
    public partial class RenkCumbusu : Form
    {
        //CONSTRUCTOR => Nesnenin dogum anina verilen addir. Yapici metot olarak da ifade edilebilir...
        //Varsayilan olarak eger nesnenize bir constructor atamazsaniz sistem otomatikman bos (parametresiz) bir constructor'ı sizin kullaniminiza sunar. Ancak siz bir constructor tanimlamasi yaptiginiz anda, sistem sizden bu destegi ceker ve tum dogum modellerinizi kendinizin tasarlamasini ister...

        //Bir constructor icerisinde muhakkak bir deger atamasi yapmak zorunda degilsiniz. Herhangi bir metodu da cagirabilirsiniz...
        public RenkCumbusu()
        {
            InitializeComponent();
        }

        public RenkCumbusu(Color renk)
        {
            InitializeComponent();
            arkaplanrengi = renk;
        }
        Color arkaplanrengi;//field
        private void RenkCumbusu_Load(object sender, EventArgs e)
        {
            this.BackColor = arkaplanrengi;
        }
    }
}
