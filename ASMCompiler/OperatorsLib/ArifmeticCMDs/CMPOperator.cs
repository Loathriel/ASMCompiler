using ASMEngine;

namespace OperatorsLib.ArifmeticCMDs
{
    public class CMPOperator : Operator
    {
        public override string Name() => "CMP";

        public CMPOperator() : base() { }

        public CMPOperator(Operand op1, Operand op2, int Line) 
            : base(op1, op2, Line) { }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.Register, "0011 10dw mod reg r/m"));
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.Memory, "0011 100w mod reg r/m"));
            RegistredFormats.Add(new Format(OperandType.Memory, OperandType.Register, "0011 101w mod reg r/m"));
            RegistredFormats.Add(new Format(OperandType.RegisterAX, OperandType.Immediate8, "0011 110w im8"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.Immediate8, "1000 00sw mod 111 r/m im8"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.Immediate16, "1000 00sw mod 111 r/m im16"));
            RegistredFormats.Add(new Format(OperandType.RegisterAX, OperandType.Immediate16, "0011 110w im16"));
        }
    }
}
