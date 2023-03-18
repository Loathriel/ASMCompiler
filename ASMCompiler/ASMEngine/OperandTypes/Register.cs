namespace ASMEngine
{
    public class Register : Operand
    {
        private const string OperationRegisters8 = "AL,BL,CL,DL,AH,BH,CH,DH";
        private const string OperationRegisters16 = "AX,BX,CX,DX";
        private const string OperationRegisters32 = "EAX,EBX,ECX,EDX"; // left only as a reminder
        private const string OffsetRegisters = "SI,DI";
        private const string BaseRegisters = "BX,BP";

        private const string AddressRegisters = OffsetRegisters + "," + BaseRegisters;
        private const string OperationRegistres = OperationRegisters16 + "," + OperationRegisters8;
        private static string GetCode(string line, out string w)
        {
            if (line.Contains("L") || line.Contains("H"))
                w = "0";
            else
                w = "1";
            if (line == "AL" || line == "AX")
                return "000";
            if (line == "CL" || line == "CX")
                return "001";
            if (line == "DL" || line == "DX")
                return "010";
            if (line == "BL" || line == "BX")
                return "011";
            if (line == "AH" || line == "SP")
                return "100";
            if (line == "CH" || line == "BP")
                return "101";
            if (line == "DH" || line == "SI")
                return "110";
            if (line == "BH" || line == "DI")
                return "111";
            throw CompileError.WrongRegister(line);
        }
        internal override bool TryToCreate(string line)
        {
            line = line.ToUpper();
            return OperationRegistres.Contains(line) || AddressRegisters.Contains(line);
        }

        public Register() : base() { }
        public Register(string line)
        {
            line = line.ToUpper();
            reg = GetCode(line, out w);
            types = new List<OperandType>();
            types.Add(OperandType.Register);
            if (line.StartsWith("A"))
                types.Add(OperandType.RegisterAX);
            if (line == "CL")
                types.Add(OperandType.RegisterCL);
        }
        public Register(string line, bool first)
        {
            line = line.ToUpper();
            types = new List<OperandType>();
            types.Add(OperandType.Register);
            if (line.StartsWith("A"))
                types.Add(OperandType.RegisterAX);
            if (line == "CL")
                types.Add(OperandType.RegisterCL);
            if (first)
                reg = GetCode(line, out w);
            else
            {
                reg = GetCode(line, out w);
                rm = GetCode(line, out w);
                mod = "11";
                types.Add(OperandType.RegisterOrMemory);
            }
        }
    }
}
