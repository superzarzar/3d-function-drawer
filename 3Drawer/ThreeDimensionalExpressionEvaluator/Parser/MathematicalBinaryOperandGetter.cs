using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.ThreeDimensionalExpression
{
    class MathematicalBinaryOperandGetter
    {
        private static MathematicalOperands firstOperations = new MathematicalOperands(PowerEvaluator.Symbol);
        private static MathematicalOperands secondOperations = new MathematicalOperands(MultiplicationEvaluator.Symbol,
            DivisionEvaluator.Symbol);
        private static MathematicalOperands thridOperations = new MathematicalOperands(AdditionEvaluator.Symbol,
            SubtractionEvaluator.Symbol);
        public static MathematicalOperands[] GetMathematicalOperandsByOrderOfOperation()
        {
            return new MathematicalOperands[] { firstOperations, secondOperations, thridOperations };
        }

    }
}
