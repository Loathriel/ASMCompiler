using ASMEngine;

namespace OperatorsLib.ArifmeticCMDs
{
    public class IDIVOperator : Operator
    {
        public override string Name() => "IDIV";

        public IDIVOperator() : base() { }

        public IDIVOperator(Operand op1, Operand op2, int Line) 
            : base(op1, op2, Line) { }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.None, "1111 011w mod 111 r/m"));
        }
    }
}
