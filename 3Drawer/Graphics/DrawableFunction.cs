using _3Drawer.Graphics;
using _3Drawer.NDimensionalPoints;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.NDimensionalFunctions
{
    class DrawableFunction
    {
        ThreeDimensionalPoint[,] points;
        private double zoomIndex;
        HeightColorGetter heightColorGetter;
        public DrawableFunction(double zoomIndex, ThreeDimensionalPoint[,] points)
        {
            this.points = points;
            this.zoomIndex = zoomIndex;
            double max = double.MinValue;
            double min = double.MaxValue;
            foreach(ThreeDimensionalPoint point in points)
            {
                max = Math.Max(point.Z, max);
                min = Math.Min(point.Z, min);
            }
            this.heightColorGetter = new HeightColorGetter(max, min);
        }

        public DrawableRectangle[] GetDrawableRactangles()
        {
            List<DrawableRectangle> drawableRectangles = new List<DrawableRectangle>();
            for(int x = 0; x < this.points.GetLength(0) - 1; x++)
            {
                for(int y = 0; y < this.points.GetLength(0) - 1; y++)
                {
                    drawableRectangles.Add(new DrawableRectangle()
                    {
                        A = points[x, y].ToTwoDimensionalPoint().MultiplyByScalar(this.zoomIndex).ToPoint(),
                        B = points[x, y + 1].ToTwoDimensionalPoint().MultiplyByScalar(this.zoomIndex).ToPoint(),
                        C = points[x + 1, y].ToTwoDimensionalPoint().MultiplyByScalar(this.zoomIndex).ToPoint(),
                        D = points[x + 1, y + 1].ToTwoDimensionalPoint().MultiplyByScalar(this.zoomIndex).ToPoint(),
                        AverageZ = (points[x, y].Z + points[x, y + 1].Z + points[x + 1, y + 1].Z + points[x + 1, y].Z) / 4.0
                    });
                }
            }
            return drawableRectangles.ToArray();
        }
        public HeightColorGetter GetheightColorGetter()
        {
            return this.heightColorGetter;
        }

        public void SetZoom(double zoomIndex)
        {
            this.zoomIndex = zoomIndex;
        }
    }
}
