using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.ThreeDimensionalExpression
{
    class PowerEvaluator : EvaluatableThreeDimensionalExpression
    {
        private EvaluatableThreeDimensionalExpression rightExpression;
        private EvaluatableThreeDimensionalExpression leftExpression;
        public const string Symbol = "^";
        public PowerEvaluator(EvaluatableThreeDimensionalExpression leftExpression, EvaluatableThreeDimensionalExpression rightExpression)
        {
            this.rightExpression = rightExpression;
            this.leftExpression = leftExpression;
        }
        public double Evaluate(double x, double y)
        {
            return Math.Pow(this.leftExpression.Evaluate(x, y), this.rightExpression.Evaluate(x, y));
        }
    }
}
