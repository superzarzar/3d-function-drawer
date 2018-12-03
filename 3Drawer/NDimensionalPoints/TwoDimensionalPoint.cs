using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.NDimensionalPoints
{
    class TwoDimensionalPoint
    {
        public TwoDimensionalPoint(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public PointF ToPoint()
        {
            return new PointF((float)X, (float)Y);
        }
        public TwoDimensionalPoint MultiplyByScalar(double scalar)
        {
            return new TwoDimensionalPoint(this.X * scalar, this.Y * scalar);
        }
        public double X { get; set; }
        public double Y { get; set; }
    }
}
