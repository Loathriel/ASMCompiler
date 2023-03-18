using ASMEngine;

namespace OperatorsLib.MovingCMDs
{
    public class MOVOperator : Operator
    {
        public override string Name() => "MOV";

        public MOVOperator() : base() { }

        public MOVOperator(Operand op1, Operand op2, int Line) 
            : base(op1, op2, Line) { }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.Register, "1000 100w mod reg r/m"));
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.RegisterOrMemory, "1000 101w mod reg r/m"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.Immediate8, "1100 011w mod 000 r/m im8"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.Immediate16, "1100 011w mod 000 r/m im16"));

            RegistredFormats.Add(new Format(OperandType.Register, OperandType.Immediate8, "1011 w reg im8"));
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.Immediate16, "1011 w reg im16"));

            RegistredFormats.Add(new Format(OperandType.SegmentRegister, OperandType.RegisterOrMemory, "1000 1110 mod xreg r/m"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.SegmentRegister, "1000 1100 mod xreg r/m"));
        }
    }
}
