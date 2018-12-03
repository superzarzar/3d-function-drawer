using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.ThreeDimensionalExpression.Parser.EvaluatorsByOperands
{
    class EchoerGetter
    {
        public static EvaluatableThreeDimensionalExpression GetEchoerByVariable(string variable)
        {
            switch (variable)
            {
                case XEchoer.Symbol:
                    return new XEchoer();
                case YEchoer.Symbol:
                    return new YEchoer();
                default:
                    throw new ArgumentException(string.Format("Uknown variable {0}", variable));
            }
        }
    }
}
