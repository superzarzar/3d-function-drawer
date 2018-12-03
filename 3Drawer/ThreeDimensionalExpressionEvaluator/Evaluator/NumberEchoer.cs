using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.ThreeDimensionalExpression.Evaluator
{
    class NumberEchoer : EvaluatableThreeDimensionalExpression
    {
        private double number;
        public NumberEchoer(double number)
        {
            this.number = number;
        }
        public double Evaluate(double x, double y)
        {
            return number;
        }
    }
}
