using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using _3Drawer.ThreeDimensionalExpression.Evaluator;

namespace _3Drawer.ThreeDimensionalExpression.Parser
{
    class EvaluatableThreeDimensionalExpressionConvertor
    {
        public static EvaluatableThreeDimensionalExpression FromString(string expression)
        {
            return FromFormattedString(GetFormattedStringExpression(expression));
        }

        private static string GetFormattedStringExpression(string expression)
        {
            expression = expression.Replace(" ", "");
            expression = expression.ToLower();
            expression = expression.Replace("pi", Math.PI.ToString());
            if (expression.StartsWith("-"))
            {
                expression = "0" + expression;
            }
            return expression;
        }
        private static EvaluatableThreeDimensionalExpression FromFormattedString(string expression)
        {
            // Binary operations should be addressed first!
            int lastBinaryIndex = GetLastBinaryOpIndex(expression);
            if(lastBinaryIndex != -1)
            {
                return GetByBinaryEquation(expression, lastBinaryIndex);
            }
            double number;
            if(double.TryParse(expression, out number))
            {
                return new NumberEchoer(number);
            }
            if(EvaluatorRegex.ValidText(expression, RegexType.Variable))
            {
                return GetEchoer(expression);
            }
            if (EvaluatorRegex.ValidText(expression, RegexType.Parentheses))
            {
                return FromFormattedString(GetFormattedStringExpression(EvaluatorRegex.GetMatch(expression, RegexType.Parentheses)));
            }
            if(EvaluatorRegex.ValidText(expression, RegexType.UnaryOperation))
            {
                string subExpression = EvaluatorRegex.GetMatch(expression, RegexType.UnaryOperation);
                string unaryOperand = EvaluatorRegex.GetMatch(expression, RegexType.UnaryOperand);
                return GetUnaryEvaluator(FromFormattedString(GetFormattedStringExpression(subExpression)), unaryOperand);
            }
            throw new ArgumentException(string.Format("Expression {0} has an unkonwn attribute", expression));
        }
        private static int GetLastBinaryOpIndex(string expression)
        {
            var mathematicalOperandsByOrderOfOperation = MathematicalBinaryOperandGetter.GetMathematicalOperandsByOrderOfOperation();
            // In reverse
            int index = mathematicalOperandsByOrderOfOperation.Length - 1;
            while (index >= 0)
            {
                int lastOperandIndex = -1;
                string lastOperand = string.Empty;
                foreach (string operand in mathematicalOperandsByOrderOfOperation[index].operands)
                {
                    int operandIndex = GetLastIndexOfSymbolOutsideParenthesis(expression, operand);
                    if (operandIndex > lastOperandIndex)
                    {
                        lastOperandIndex = operandIndex;
                        lastOperand = operand;
                    }
                }
                if (lastOperandIndex != -1)
                {
                    return lastOperandIndex;
                }
                index--;
            }
            return -1;
        }
        private static EvaluatableThreeDimensionalExpression GetByBinaryEquation(string expression, int indexOfBinaryOperation)
        {
            string leftExpression = expression.Substring(0, indexOfBinaryOperation);
            string rightExpression = expression.Substring(indexOfBinaryOperation + 1);
            return GetBinaryEvaluator(FromFormattedString(leftExpression), FromFormattedString(rightExpression), expression[indexOfBinaryOperation].ToString());

        }
        private static int GetLastIndexOfSymbolOutsideParenthesis(string expression, string symbol)
        {
            int parenthesesCount = 0;
            int index = expression.Length - 1;
            while (index >= 0)
            {
                parenthesesCount += Convert.ToInt32(expression[index] == ')') - Convert.ToInt32(expression[index] == '(');
                if(expression.Substring(0, index + 1).EndsWith(symbol) && parenthesesCount == 0)
                {
                    return index;
                }
                index--;
            }
            return -1;
        }
        private static EvaluatableThreeDimensionalExpression GetUnaryEvaluator(EvaluatableThreeDimensionalExpression expression, string operand)
        {
            return EvaluatorsByOperands.UnaryEvaluatorGetter.GetUnaryEvaluatorByOperand(expression, operand);
        }
        private static EvaluatableThreeDimensionalExpression GetBinaryEvaluator(EvaluatableThreeDimensionalExpression left, EvaluatableThreeDimensionalExpression right, string operand)
        {
            return EvaluatorsByOperands.BinaryEvaluatorGetter.GetBinaryEvaluatorByOperand(left, right, operand);
        }
        private static EvaluatableThreeDimensionalExpression GetEchoer(string expression)
        {
            return EvaluatorsByOperands.EchoerGetter.GetEchoerByVariable(expression);
        }
    }
}
