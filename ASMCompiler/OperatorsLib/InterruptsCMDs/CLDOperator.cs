using ASMEngine;

namespace OperatorsLib.InterruptsCMDs
{
    public class CLDOperator : Operator
    {
        public override string Name() => "CLD";

        public CLDOperator() : base() { }

        public CLDOperator(Operand op1, Operand op2, int Line) 
            : base(op1, op2, Line) { }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.None, OperandType.None, "1111 1100"));
        }
    }
}
