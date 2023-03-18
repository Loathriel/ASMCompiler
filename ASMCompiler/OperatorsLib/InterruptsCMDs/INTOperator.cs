using ASMEngine;

namespace OperatorsLib.InterruptsCMDs
{
    public class INTOperator : Operator
    {
        public override string Name() => "INT";

        public INTOperator() : base() { }

        public INTOperator(Operand op1, Operand op2, int Line) 
            : base(op1, op2, Line) { }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.Immediate8, OperandType.None, "1100 1101 im8"));
        }
    }
}
