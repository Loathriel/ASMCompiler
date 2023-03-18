using ASMEngine;

namespace OperatorsLib.MovingCMDs
{
    public class POPOperator : Operator
    {
        public override string Name() => "POP";

        public POPOperator() : base() { }

        public POPOperator(Operand op1, Operand op2, int Line) 
            : base(op1, op2, Line) { }
        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.Memory, OperandType.None, "1000 1111 mod 000 r/m"));
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.None, "0101 1 reg"));
        }
    }
}
