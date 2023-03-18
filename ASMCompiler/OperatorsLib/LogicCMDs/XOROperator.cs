using ASMEngine;

namespace OperatorsLib.LogicCMDs
{
    public class XOROperator : Operator
    {
        public override string Name() => "XOR";

        public XOROperator() : base() { }

        public XOROperator(Operand op1, Operand op2, int Line) 
            : base(op1, op2, Line) { }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.Register, "0011 00dw mod reg r/m"));
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.Memory, "0011 001w mod reg r/m"));
            RegistredFormats.Add(new Format(OperandType.Memory, OperandType.Register, "0011 000w mod reg r/m"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.Immediate8, "1000 00sw mod 110 r/m im8"));
            RegistredFormats.Add(new Format(OperandType.RegisterAX, OperandType.Immediate8, "0011 010w im8"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.Immediate16, "1000 00sw mod 110 r/m im16"));
            RegistredFormats.Add(new Format(OperandType.RegisterAX, OperandType.Immediate16, "0011 010w im16"));
        }
    }
}
