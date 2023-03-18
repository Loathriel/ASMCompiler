using ASMEngine;

namespace OperatorsLib.ArifmeticCMDs
{
    public class DECOperator : Operator
    {
        public override string Name() => "DEC";

        public DECOperator() : base() { }

        public DECOperator(Operand op1, Operand op2, int Line) 
            : base(op1, op2, Line) { }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.None, "0100 1 reg"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.None, "1111 111w mod 001 r/m"));
        }
    }
}
