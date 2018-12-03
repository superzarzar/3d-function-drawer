using _3Drawer.Graphics;
using _3Drawer.NDimensionalFunctions;
using _3Drawer.NDimensionalPoints;
using _3Drawer.ThreeDimensionalExpression;
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
    partial class ControlForm : Form
    {
        private ThreeDimensionalFunction function;// = new ThreeDimensionalFunction(30, 1, null);
        private DrawableFunction drawableFuncion; // = new DrawableFunction(1, null);
        private FunctionDrawer functionDrawer;

        private double zoomIndex = 10;
        public ControlForm()
        {
            InitializeComponent();
        }

        private void ControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void praseFunctionBtn_Click(object sender, EventArgs e)
        {
            function.UpdateZEvaluator(ThreeDimensionalFunctionEvaluator.fromString(functionField.Text));
            drawableFuncion = new DrawableFunction(this.zoomIndex, function.GetPoints());
        }

        private void drawFunctionBtn_Click(object sender, EventArgs e)
        {
            functionDrawer.DrawFunction(drawableFuncion);
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            function = new ThreeDimensionalFunction(30, 1, ThreeDimensionalFunctionEvaluator.fromString("sin(x) + cos(y)"));
            drawableFuncion = new DrawableFunction(this.zoomIndex, function.GetPoints());
            Panel drawingPanel = PanelGetter.GetPanel();
            functionDrawer = new FunctionDrawer(drawingPanel.CreateGraphics(), drawingPanel.BackColor, drawingPanel.Height, drawingPanel.Width);
        }

        private void zoomField_KeyUp(object sender, KeyEventArgs e)
        {
            double zoom;
            if(!double.TryParse(zoomField.Text, out zoom))
            {
                MessageBox.Show("Value must be a number!");
            }
            else
            {
                drawableFuncion.SetZoom(zoom);
                zoomIndex = zoom;
            }
        }
        private void dxApplyBtn_Click(object sender, EventArgs e)
        {
            double dx;
            if (!double.TryParse(dxField.Text, out dx))
            {
                MessageBox.Show("Value must be a number!");
            }
            else
            {
                function.SetDx(dx);
                drawableFuncion = new DrawableFunction(this.zoomIndex, function.GetPoints());
            }
        }

        private void pointCountApplyBtn_Click(object sender, EventArgs e)
        {
            function.UpdatePointCount(Convert.ToInt32(pointCountField.Value));
            drawableFuncion = new DrawableFunction(this.zoomIndex, function.GetPoints());
        }

        private void xRotationBtn_Click(object sender, EventArgs e)
        {
            function.RotateAbout(Axis.X, Convert.ToInt32(angleField.Value));
            drawableFuncion = new DrawableFunction(this.zoomIndex, function.GetPoints());
        }

        private void yRotationBtn_Click(object sender, EventArgs e)
        {
            function.RotateAbout(Axis.Y, Convert.ToInt32(angleField.Value));
            drawableFuncion = new DrawableFunction(this.zoomIndex, function.GetPoints());
        }

        private void zRotationBtn_Click(object sender, EventArgs e)
        {
            function.RotateAbout(Axis.Z, Convert.ToInt32(angleField.Value));
            drawableFuncion = new DrawableFunction(this.zoomIndex, function.GetPoints());
        }

        public void SetStartingCoordinates(TwoDimensionalPoint startingPoint)
        {
            functionDrawer.SetStartingPoint(startingPoint);
            functionDrawer.DrawFunction(drawableFuncion);
        }
    }
}
