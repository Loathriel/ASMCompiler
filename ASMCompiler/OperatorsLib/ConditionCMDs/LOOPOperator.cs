using ASMEngine;

namespace OperatorsLib.ConditionCMDs
{
    public class LOOPOperator : Operator
    {
        public override string Name() => "LOOP";

        public LOOPOperator() : base() { }

        public LOOPOperator(Operand op1, Operand op2, int Line)
        {
            op1.mod = "01";
            Initialization(op1, op2, Line);
        }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.Memory, OperandType.None, "1110 0010"));
        }
    }
}
