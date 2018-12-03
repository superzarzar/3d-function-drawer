using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Drawer
{
    public partial class ViewForm : Form
    {
        private ControlForm controlForm;
        public ViewForm()
        {
            InitializeComponent();
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            PanelGetter.SetPanel(drawingPanel);
            controlForm = new ControlForm();
            controlForm.Show();
        }

        private void drawingPanel_Click(object sender, EventArgs e)
        {
            var x = Cursor.Position.X - drawingPanel.Width / 2;
            var y = Cursor.Position.Y - drawingPanel.Height / 2;
            controlForm.SetStartingCoordinates(new NDimensionalPoints.TwoDimensionalPoint(x, y));
        }
    }
}
