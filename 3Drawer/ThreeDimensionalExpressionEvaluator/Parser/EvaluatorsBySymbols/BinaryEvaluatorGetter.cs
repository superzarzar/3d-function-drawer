using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.ThreeDimensionalExpression.Parser.EvaluatorsByOperands
{
    class BinaryEvaluatorGetter
    {
        public static EvaluatableThreeDimensionalExpression GetBinaryEvaluatorByOperand(EvaluatableThreeDimensionalExpression left, EvaluatableThreeDimensionalExpression right, string operand)
        {
            switch (operand)
            {
                case AdditionEvaluator.Symbol:
                    return new AdditionEvaluator(left, right);
                case SubtractionEvaluator.Symbol:
                    return new SubtractionEvaluator(left, right);
                case MultiplicationEvaluator.Symbol:
                    return new MultiplicationEvaluator(left, right);
                case DivisionEvaluator.Symbol:
                    return new DivisionEvaluator(left, right);
                case PowerEvaluator.Symbol:
                    return new PowerEvaluator(left, right);
                default:
                    throw new ArgumentException(string.Format("Uknown binary operand {0}", operand));
            }
        }
    }
}
