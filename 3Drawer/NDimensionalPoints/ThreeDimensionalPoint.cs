using _3Drawer.NDimensionalFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.NDimensionalPoints
{
    class ThreeDimensionalPoint
    {
        const double AngleOfPorjection = 45;
        public ThreeDimensionalPoint(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public TwoDimensionalPoint ToTwoDimensionalPoint()
        {
            double x = X + Y * Math.Cos(AngleOfPorjection * Math.PI / 180);
            double y = Z + Y * Math.Sin(AngleOfPorjection * Math.PI / 180);
            return new TwoDimensionalPoint(x, y);
        }

        public void RotateAbout(Axis axis, int angle)
        {
            double angleInRadians = angle *  Math.PI / 180;
            switch (axis)
            {
                case Axis.X:
                    Y = Y * Math.Cos(angleInRadians) - Z * Math.Sin(angleInRadians);
                    Z = Y * Math.Sin(angleInRadians) + Z * Math.Cos(angleInRadians);
                    break;
                case Axis.Y:
                    X = X * Math.Cos(angleInRadians) + Z * Math.Sin(angleInRadians);
                    Z = -X * Math.Sin(angleInRadians) + Z * Math.Cos(angleInRadians);
                    break;
                case Axis.Z:
                    X = X * Math.Cos(angleInRadians) - Y * Math.Sin(angleInRadians);
                    Y = X * Math.Sin(angleInRadians) + Y * Math.Cos(angleInRadians);
                    break;
            }
        }

        public void Shift(Axis axis, int addition)
        {
            switch (axis)
            {
                case Axis.X:
                    X += addition;
                    break;
                case Axis.Y:
                    Y += addition;
                    break;
                case Axis.Z:
                    Z += addition;
                    break;
            }
        }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

    }
}
