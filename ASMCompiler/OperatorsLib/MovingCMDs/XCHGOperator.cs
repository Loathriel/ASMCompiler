using ASMEngine;

namespace OperatorsLib.MovingCMDs
{
    public class XCHGOperator : Operator
    {
        public override string Name() => "XCHG";

        public XCHGOperator() : base() { }

        public XCHGOperator(Operand op1, Operand op2, int Line) 
            : base(op1, op2, Line) { }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.RegisterAX, OperandType.Register, "1001 0 reg"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.Register, "1000 011w mod reg r/m"));
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.RegisterOrMemory, "1000 011w mod reg r/m"));

        }
    }
}
