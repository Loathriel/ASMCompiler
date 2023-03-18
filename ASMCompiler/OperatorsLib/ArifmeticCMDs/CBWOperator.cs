using ASMEngine;

namespace OperatorsLib.ArifmeticCMDs
{
    public class CBWOperator : Operator
    {
        public override string Name() => "CBW";

        public CBWOperator() : base() { }

        public CBWOperator(Operand op1, Operand op2, int Line) 
            : base(op1, op2, Line) { }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.None, OperandType.None, "1001 1000"));
        }
    }
}
