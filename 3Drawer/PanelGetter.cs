using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Drawer
{
    class PanelGetter
    {
        private static Panel panel;
        public static void SetPanel(Panel panel)
        {
            PanelGetter.panel = panel;
        }
        public static Panel GetPanel()
        {
            return PanelGetter.panel;
        }
    }
}
