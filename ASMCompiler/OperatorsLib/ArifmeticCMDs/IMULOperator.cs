using ASMEngine;

namespace OperatorsLib.ArifmeticCMDs
{
    public class IMULOperator : Operator
    {
        public override string Name() => "IMUL";

        public IMULOperator() : base() { }

        public IMULOperator(Operand op1, Operand op2, int Line) 
            : base(op1, op2, Line) { }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.None, "1111 0111 mod 101 r/m"));
            RegistredFormats.Add(new Format(OperandType.Register, OperandType.RegisterOrMemory, "0000 1111 1010 1111 mod reg r/m"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.Immediate8, "0110 10s1 mod reg r/m im8"));
            RegistredFormats.Add(new Format(OperandType.RegisterOrMemory, OperandType.Immediate16, "0110 10s1 mod reg r/m im16"));
        }
    }
}
