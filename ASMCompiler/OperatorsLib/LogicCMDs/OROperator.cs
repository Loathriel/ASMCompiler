using ASMEngine;

namespace OperatorsLib.LogicCMDs
{
    public class OROperator : Operator
    {
        public override string Name() => "OR";

        public OROperator() : base() { }

        public OROperator(Operand Op1, Operand Op2, int Line)
        {
            if (Op1 is Register && Op2 is Constant && !Op1.types.Contains(OperandType.RegisterAX))
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
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.Register, "0000 00dw mod reg r/m"));
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.Memory, "0000 001w mod reg r/m"));
            RegistredFormats.Add(new Format(OperandType.Memory, OperandType.Register, "0000 000w mod reg r/m"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.Immediate8, "1000 00sw mod 001 r/m im8"));
            RegistredFormats.Add(new Format(OperandType.RegisterAX, OperandType.Immediate8, "0000 110w im8"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.Immediate16, "1000 00sw mod 001 r/m im16"));
            RegistredFormats.Add(new Format(OperandType.RegisterAX, OperandType.Immediate16, "0000 110w im16"));
        }
    }
}
