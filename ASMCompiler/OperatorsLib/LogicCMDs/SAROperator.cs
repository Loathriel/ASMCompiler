using ASMEngine;

namespace OperatorsLib.LogicCMDs
{
    public class SAROperator : Operator
    {
        public override string Name() => "SAR";

        public SAROperator() : base() { }

        public SAROperator(Operand Op1, Operand Op2, int Line)
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
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.None, "1101 000w mod 111 r/m"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.RegisterCL, "1101 001w mod 111 r/m"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.Immediate8, "1100 000w mod 111 r/m im8"));
        }
    }
}
