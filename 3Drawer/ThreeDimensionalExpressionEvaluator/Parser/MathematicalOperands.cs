using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Drawer.ThreeDimensionalExpression
{
    struct MathematicalOperands
    {
        public List<string> operands;
        public MathematicalOperands(params string[] operands)
        {
            this.operands = new List<string>(operands);
        }
        public void AddOperand(string operand)
        {
            this.operands.Add(operand);
        }
        public MathematicalOperands Join(MathematicalOperands mathematicalOperands)
        {
            MathematicalOperands newOperandCollection = new MathematicalOperands();
            foreach (string operand in mathematicalOperands.operands)
            {
                newOperandCollection.AddOperand(operand);
            }
            foreach (string operand in this.operands)
            {
                newOperandCollection.AddOperand(operand);
            }
            return newOperandCollection;
        }
    }
}
