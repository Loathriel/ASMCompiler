namespace ASMEngine
{
    public class SegmentRegister : Operand
    {
        private const string SegmentRegisters = "ES,SS,DS,CS";

        private static string GetCode(string line)
        {
            if (line == "ES")
                return "000";
            if (line == "CS")
                return "001";
            if (line == "SS")
                return "010";
            if (line == "DS")
                return "011";
            throw CompileError.WrongSegmentRegister(line);
        }

        internal override bool TryToCreate(string line)
        {
            line = line.ToUpper();
            return SegmentRegisters.Contains(line);
        }

        public SegmentRegister() : base() { }
        public SegmentRegister(string line)
        {
            line = line.ToUpper();
            sreg = GetCode(line);
            types = new List<OperandType>
            {
                OperandType.SegmentRegister
            };
        }
    }
}
