using ASMEngine;

namespace OperatorsLib.MovingCMDs
{
    public class PUSHOperator : Operator
    {
        public override string Name() => "PUSH";

        public PUSHOperator() : base() { }

        public PUSHOperator(Operand op1, Operand op2, int Line) 
            : base(op1, op2, Line) { }
        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.None, "01010 reg"));
            RegistredFormats.Add(new Format(OperandType.Memory, OperandType.None, "1111 1111 mod 110 r/m"));
            RegistredFormats.Add(new Format(OperandType.Immediate8, OperandType.None, "0110 10s0 im8"));
            RegistredFormats.Add(new Format(OperandType.Immediate16, OperandType.None, "0110 10s0 im16"));
        }
    }
}
