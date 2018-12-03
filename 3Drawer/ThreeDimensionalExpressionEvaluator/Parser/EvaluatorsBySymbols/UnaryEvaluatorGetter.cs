using _3Drawer.ThreeDimensionalExpressionEvaluator.Evaluator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.ThreeDimensionalExpression.Parser.EvaluatorsByOperands
{
    class UnaryEvaluatorGetter
    {
        public static EvaluatableThreeDimensionalExpression GetUnaryEvaluatorByOperand(EvaluatableThreeDimensionalExpression expression, string operand)
        {
            switch (operand)
            {
                case SinEvaluater.Symbol:
                    return new SinEvaluater(expression);
                case TanEvaluater.Symbol:
                    return new TanEvaluater(expression);
                case CosEvaluater.Symbol:
                    return new CosEvaluater(expression);
                case AbsEvaluator.Symbol:
                    return new AbsEvaluator(expression);
                default:
                    throw new ArgumentException(string.Format("Uknown unary operand {0}", operand));
            }
        }
    }
}
