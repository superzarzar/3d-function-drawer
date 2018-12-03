using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.Graphics
{
    struct DrawableRectangle
    {
        public PointF A { get; set; }
        public PointF B { get; set; }
        public PointF C { get; set; }
        public PointF D { get; set; }
        public double AverageZ {get; set;}

    }
}
