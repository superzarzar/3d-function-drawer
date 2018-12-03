using _3Drawer.ThreeDimensionalExpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.ThreeDimensionalExpressionEvaluator.Evaluator
{
    class AbsEvaluator : EvaluatableThreeDimensionalExpression
    {
        private EvaluatableThreeDimensionalExpression expression;
        public const string Symbol = "abs";
        public AbsEvaluator(EvaluatableThreeDimensionalExpression expression)
        {
            this.expression = expression;
        }
        public double Evaluate(double x, double y)
        {
            return Math.Abs(this.expression.Evaluate(x, y));
        }
    }
}
