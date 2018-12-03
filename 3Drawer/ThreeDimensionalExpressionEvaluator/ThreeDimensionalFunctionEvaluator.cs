using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.ThreeDimensionalExpression
{
    class ThreeDimensionalFunctionEvaluator : EvaluatableThreeDimensionalExpression
    {
        private EvaluatableThreeDimensionalExpression functionEvaluator;
        public ThreeDimensionalFunctionEvaluator(EvaluatableThreeDimensionalExpression functionEvaluator)
        {
            this.functionEvaluator = functionEvaluator;
        }
        public double Evaluate(double x, double y)
        {
            return this.functionEvaluator.Evaluate(x, y);
        }
        public static ThreeDimensionalFunctionEvaluator fromString(string expression)
        {
            return new ThreeDimensionalFunctionEvaluator(Parser.EvaluatableThreeDimensionalExpressionConvertor.FromString(expression));
            try
            {
                return new ThreeDimensionalFunctionEvaluator(Parser.EvaluatableThreeDimensionalExpressionConvertor.FromString(expression));
            }
            catch
            {
                throw new ArgumentException(string.Format("Unable to parse {0}", expression));
            }
        }
    }
}
