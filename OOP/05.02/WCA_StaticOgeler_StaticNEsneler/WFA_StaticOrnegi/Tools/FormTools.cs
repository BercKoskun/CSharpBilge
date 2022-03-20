using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_StaticOrnegi.Tools
{
   static class FormTools
    {

        public static void Temizle(Control.ControlCollection formelemanlarilistesi)
        {
            foreach (Control item in formelemanlarilistesi)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is CheckBox)
                {
                    CheckBox chb=item as CheckBox;
                    chb.Checked = false;
                }
                else if(item is GroupBox)
                {
                    GroupBox grb = item as GroupBox;
                    Temizle(grb.Controls);
                }
                else if (item is Panel)
                {
                    Panel pnl = item as Panel;
                    Temizle(pnl.Controls);
                }
                else if (item is FlowLayoutPanel)
                {
                    FlowLayoutPanel fpnl = item as FlowLayoutPanel;
                    Temizle(fpnl.Controls);
                }
            }
        }
    }
}
