using _3Drawer.NDimensionalFunctions;
using _3Drawer.NDimensionalPoints;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Drawer.Graphics
{
    class FunctionDrawer
    {
        private int height;
        private int width;
        private System.Drawing.Graphics drawer;
        private Color defaultColor;
        private TwoDimensionalPoint startingPoint = new TwoDimensionalPoint(0, 0);
        public FunctionDrawer(System.Drawing.Graphics drawer, Color defaultColor, int height, int width)
        {
            this.drawer = drawer;
            this.height = height;
            this.width = width;
            this.defaultColor = defaultColor;
        }
        public void DrawFunction(DrawableFunction drawableFunction)
        {
            drawer.Clear(drawer.GetNearestColor(defaultColor));
            foreach(var drawableRactangle in drawableFunction.GetDrawableRactangles())
            {
                DrawRactangle(drawableRactangle, drawableFunction.GetheightColorGetter().GetColorByHeight(drawableRactangle.AverageZ));
            }
        }
        public void DrawRactangle(DrawableRectangle drawableRactangle, Color color)
        {
            Point[] PrintingPoint = new Point[4];
            PrintingPoint[0] = ToPanelPoint(drawableRactangle.A);
            PrintingPoint[1] = ToPanelPoint(drawableRactangle.B);
            PrintingPoint[3] = ToPanelPoint(drawableRactangle.C);
            PrintingPoint[2] = ToPanelPoint(drawableRactangle.D);
            SolidBrush Brush = new SolidBrush(color);
            try
            {
                drawer.FillPolygon(Brush, PrintingPoint);
            }
            catch
            {
                // asymptote 
            }

        }

        public void SetStartingPoint(TwoDimensionalPoint startingPoint)
        {
            this.startingPoint = startingPoint;
        }

        private Point ToPanelPoint(PointF p)
        {
            return new Point(ToPanelX(p.X), ToPanelY(p.Y));
        }
        private int ToPanelX(float x)
        {
            return (int)(x + width / 2) + (int)this.startingPoint.X;
        }

        public int ToPanelY(float y)
        {
            return (int)(height / 2 - y) + (int)(this.startingPoint.Y);
        }
    }
}
