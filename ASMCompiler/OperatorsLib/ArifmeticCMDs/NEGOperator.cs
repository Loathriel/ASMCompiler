using ASMEngine;

namespace OperatorsLib.ArifmeticCMDs
{
    public class NEGOperator : Operator
    {
        public override string Name() => "NEG";

        public NEGOperator() : base() { }

        public NEGOperator(Operand Op1, Operand Op2, int Line)
        {
            if (Op1 is Register)
            {
                Op1.rm = Op1.reg;
                Op1.reg = "reg";
                Op1.mod = "11";
                Op1.types.Add(OperandType.RegisterOrMemory);

            }
            Initialization(Op1, Op2, Line);
        }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.None, "1111 011w mod 011 r/m"));
        }
    }
}
