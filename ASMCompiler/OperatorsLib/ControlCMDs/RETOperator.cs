using ASMEngine;

namespace OperatorsLib.ControlCMDs
{
    public class RETOperator : Operator
    {
        public override string Name() => "RET";

        public RETOperator() : base() { }

        public RETOperator(Operand op1, Operand op2, int Line)
            : base(op1, op2, Line) { }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.None, OperandType.None, "1100 0011"));
        }
    }
}
