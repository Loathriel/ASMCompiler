using ASMEngine;

namespace OperatorsLib.ControlCMDs
{
    public class JMPOperator : Operator
    {
        public override string Name() => "JMP";

        public JMPOperator() : base() { }

        public JMPOperator(Operand op1, Operand op2, int Line)
            : base(op1, op2, Line) { }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.Memory, OperandType.None, "1110 1001"));
        }
    }
}
