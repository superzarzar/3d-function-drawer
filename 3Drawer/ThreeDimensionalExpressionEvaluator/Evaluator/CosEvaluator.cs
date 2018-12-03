using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.ThreeDimensionalExpression
{
    class CosEvaluater : EvaluatableThreeDimensionalExpression
    {
        private EvaluatableThreeDimensionalExpression expression;
        public const string Symbol = "cos";
        public CosEvaluater(EvaluatableThreeDimensionalExpression expression)
        {
            this.expression = expression;
        }
        public double Evaluate(double x, double y)
        {
            return Math.Cos(this.expression.Evaluate(x, y));
        }
    }
}
