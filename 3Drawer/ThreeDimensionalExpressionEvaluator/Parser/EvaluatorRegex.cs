using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _3Drawer.ThreeDimensionalExpression.Parser
{
    class EvaluatorRegex
    {
        private static Regex variableRegex = new Regex(@"^([xy])$");
        private static Regex parenthesesRegex = new Regex(@"^\((.*)\)$");
        private static Regex unaryOperationRegex = new Regex(@"^[a-zA-Z][a-zA-Z0-9]*\((.*)\)$");
        private static Regex unaryOperandRegex = new Regex(@"^([a-zA-Z][a-zA-Z0-9]*)\(.*\)$");

        public static bool ValidText(string text, RegexType regexType)
        {
            return GetRegexByRegexType(regexType).IsMatch(text);
        }
        public static string GetMatch(string text, RegexType regexType)
        {
            return GetRegexByRegexType(regexType).Match(text).Groups[1].Value;
        }
        private static Regex GetRegexByRegexType(RegexType regexType)
        {
            Dictionary<RegexType, Regex> regexTypeToRegex = new Dictionary<RegexType, Regex>();
            regexTypeToRegex.Add(RegexType.Variable, variableRegex);
            regexTypeToRegex.Add(RegexType.Parentheses, parenthesesRegex);
            regexTypeToRegex.Add(RegexType.UnaryOperation, unaryOperationRegex);
            regexTypeToRegex.Add(RegexType.UnaryOperand, unaryOperandRegex);
            return regexTypeToRegex[regexType];
        }
    }
    enum RegexType
    {
        Variable,
        Parentheses,
        UnaryOperation,
        UnaryOperand
    }
}
