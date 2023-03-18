using ASMEngine;

namespace OperatorsLib.ControlCMDs
{
    public class STOSBOperator : Operator
    {
        public override string Name() => "STOSB";

        public STOSBOperator() : base() { }

        public STOSBOperator(Operand op1, Operand op2, int Line)
            : base(op1, op2, Line) { }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.None, OperandType.None, "1010 1010"));
        }
    }
}
