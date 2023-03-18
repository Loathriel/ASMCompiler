using ASMEngine;

namespace OperatorsLib.LogicCMDs
{
    public class SHLOperator : Operator
    {
        public override string Name() => "SHL";

        public SHLOperator() : base() { }

        public SHLOperator(Operand Op1, Operand Op2, int Line)
        {
            if (Op1 is Register)
            {
                Op1.rm = Op1.reg;
                Op1.reg = "reg";
                Op1.mod = "11";
                Op1.types.Add(OperandType.RegisterOrMemory);
            }
            if (Op2 is Constant)
            {
                if ((Op2 as Constant).im8 == "00000001")
                    Op2 = new NullOperand("");
            }
            Initialization(Op1, Op2, Line);
        }
        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.None, "1101 000w mod 100 r/m"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.RegisterCL, "1101 001w mod 100 r/m"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.Immediate8, "1100 000w mod 100 r/m im8"));
        }
    }
}