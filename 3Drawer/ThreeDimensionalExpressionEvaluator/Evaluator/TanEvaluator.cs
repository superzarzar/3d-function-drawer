using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.ThreeDimensionalExpression
{
    class TanEvaluater : EvaluatableThreeDimensionalExpression
    {
        private EvaluatableThreeDimensionalExpression expression;
        public const string Symbol = "tan";
        public TanEvaluater(EvaluatableThreeDimensionalExpression expression)
        {
            this.expression = expression;
        }
        public double Evaluate(double x, double y)
        {
            return Math.Tan(this.expression.Evaluate(x, y));
        }
    }
}
