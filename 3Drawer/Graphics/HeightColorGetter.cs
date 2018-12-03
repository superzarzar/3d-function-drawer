using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.Graphics
{
    class HeightColorGetter
    {
        double lowestValue;
        double gradient;
        public HeightColorGetter(double highestValue, double lowestValue)
        {
            gradient = 255 / ((highestValue - lowestValue) == 0 ? 1 : (highestValue - lowestValue));
            this.lowestValue = lowestValue;
        }

        public Color GetColorByHeight(double height)
        {
            return Color.FromArgb(255, GetColourNumber(gradient, lowestValue, height), 255 - GetColourNumber(gradient, lowestValue, height), 255 - GetColourNumber(gradient, lowestValue, height));
        }
        private int GetColourNumber(double gradient, double lowestValue, double currentValue)
        {
            int q = (int)((gradient * currentValue) - gradient * lowestValue);

            if (q >= 255)
                return 254;

            if (q <= 0)
                return 1;

            return q;
        }
    }
}
