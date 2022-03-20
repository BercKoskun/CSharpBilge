using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MasaUstuUygulamalar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // this => üzerinde kod yazdığımız class'ı (bu ekran için düşünecek olursak Form2 yi ) temsil eder.
        private void btnClickOlayi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(132, 45, 89);
        }

        private void btnUpOlayi_MouseUp(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Red;

        }

        private void btnDownOlayi_MouseDown(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Orange;

        }

        private void btnHoverOlayi_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

        }

        private void btnEnterOlayi_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;

        }

        private void btnLeaveOlayi_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;

        }
        Random rnd = new Random();//=> rastgele sayı üreten metotları saklayan sınıf. bu sınıfın öğesini kullanmak istediğimde Ramde oluşturmam gerekir. new anahtar kelimesi ile yapılan bu tanımlama instance(öğe) oluşturma  işlemi yaparız.
        private void btnMoveOlayi_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }
    }
}
