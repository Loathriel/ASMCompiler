using ASMEngine;

namespace OperatorsLib.ArifmeticCMDs
{
    public class INCOperator : Operator
    {
        public override string Name() => "INC";

        public INCOperator() : base() { }

        public INCOperator(Operand op1, Operand op2, int Line) 
            : base(op1, op2, Line) { }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.None, "0100 0 reg"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.None, "1111 1111 mod 000 r/m"));
        }
    }
}
