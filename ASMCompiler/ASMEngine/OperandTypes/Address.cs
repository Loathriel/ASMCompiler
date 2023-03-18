namespace ASMEngine
{
    internal class Address : Operand
    {
        private const string OffsetRegisters = "SI,DI";
        private const string BaseRegisters = "BX,BP";
        private const string AddressRegisters = OffsetRegisters + "," + BaseRegisters;

        internal int offset;
        internal string var;
        internal override bool TryToCreate(string line)
        {
            return true;
        }
        private void Set(string mod, string rm)
        {
            this.rm = rm;
            this.mod = mod;
        }
        private bool DoDisp(string line)
        {
            mod = "10";
            var = "";
            bool res = true;
            if (line.StartsWith("+"))
                line = line.Substring(1);
            if (line.Contains("+"))
            {
                string[] s = line.Split('+');
                res = Convertors.IsConstant(s[1]);
                if (res)
                {
                    var = s[0];
                    offset = Convertors.ToNumber(s[1]);
                }
            }
            else
            {
                if (Convertors.IsConstant(line))
                    offset = Convertors.ToNumber(line);
                else
                    var = line;
            }
            return res;
        }
        private bool Contains(string[] items, string item)
        {
            return items.Contains(item);
        }

        public Address() : base() { }
        public Address(string line)
        {
            var = "";
            line = line.ToUpper();
            while (line.Contains("]["))
                line = line.Replace("][", "]");
            string[] parts = line.Split(new char[] { ' ', '[', ']' }, 3, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < parts.Length - 1; i++)
            {
                if (!AddressRegisters.Contains(parts[i]))
                {
                    string x1 = parts[i];
                    parts[i] = parts[parts.Length - 1];
                    parts[parts.Length - 1] = x1;
                    break;
                }
            }

            if (parts.Length == 1)
            {
                switch (parts[0])
                {
                    case "SI":
                        Set("00", "100"); break;
                    case "DI":
                        Set("00", "101"); break;
                    case "BX":
                        Set("00", "111"); break;
                    default:
                        if (DoDisp(parts[0]))
                            Set("00", "110");
                        break;
                }
            }
            if (parts.Length == 2)
            {
                if (Contains(parts, "BX") && Contains(parts, "SI"))
                    Set("00", "000");
                if (Contains(parts, "BX") && Contains(parts, "DI"))
                    Set("00", "001");
                if (Contains(parts, "BP") && Contains(parts, "SI"))
                    Set("00", "010");
                if (Contains(parts, "BP") && Contains(parts, "DI"))
                    Set("00", "011");
                if (parts[0] == "SI" && DoDisp(parts[1]))
                    rm = "100";
                if (parts[0] == "DI" && DoDisp(parts[1]))
                    rm = "101";
                if (parts[0] == "BP" && DoDisp(parts[1]))
                    rm = "110";
                if (parts[0] == "BX" && DoDisp(parts[1]))
                    rm = "111";

            }
            if (parts.Length == 3)
            {
                if (Contains(parts, "BX") && Contains(parts, "SI") && DoDisp(parts[2]))
                    Set("10", "000");
                if (Contains(parts, "BX") && Contains(parts, "DI") && DoDisp(parts[2]))
                    Set("10", "001");
                if (Contains(parts, "BP") && Contains(parts, "SI") && DoDisp(parts[2]))
                    Set("10", "010");
                if (Contains(parts, "BP") && Contains(parts, "DI") && DoDisp(parts[2]))
                    Set("10", "011");
            }
            types = new List<OperandType>
            {
                OperandType.RegisterOrMemory,
                OperandType.Memory
            };
        }
    }
}
