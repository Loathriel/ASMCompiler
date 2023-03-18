using ASMEngine;

namespace OperatorsLib.ArifmeticCMDs
{
    public class ADDOperator : Operator
    {
        public override string Name() => "ADD";

        public ADDOperator() : base() { }

        public ADDOperator(Operand op1, Operand op2, int Line) 
            : base(op1, op2, Line) { }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.Register, "0000 00dw mod reg r/m"));
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.Memory, "0000 001w mod reg r/m"));
            RegistredFormats.Add(new Format(OperandType.Memory, OperandType.Register, "0000 000w mod reg r/m"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.Immediate8, "1000 00sw mod 000 r/m im8"));
            RegistredFormats.Add(new Format(OperandType.RegisterAX, OperandType.Immediate8, "0000 010w im8"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.Immediate16, "1000 00sw mod 000 r/m im16"));
            RegistredFormats.Add(new Format(OperandType.RegisterAX, OperandType.Immediate16, "0000 010w im16"));
        }
    }
}
