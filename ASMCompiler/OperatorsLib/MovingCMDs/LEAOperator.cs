using ASMEngine;

namespace OperatorsLib.MovingCMDs
{
    public class LEAOperator : Operator
    {
        public override string Name() => "LEA";

        public LEAOperator() : base() { }

        public LEAOperator(Operand op1, Operand op2, int Line) 
            : base(op1, op2, Line) { }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.Memory, "1000 1101 mod reg r/m"));
        }
    }
}
