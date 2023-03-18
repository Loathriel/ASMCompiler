namespace ASMEngine
{
    public class AddressOperator : Operator
    {
        protected override void initFormats() { }
        public AddressOperator(string line, int bytes)
        {
            Op1 = new NullOperand("");
            Op2 = new NullOperand("");
            hasAddress = false;
            if (line.Contains(new string(',', 1)))
            {
                string[] lines = line.Split(',');
                CodeLine = "";
                foreach (string s in lines)
                {
                    CodeLine += Convertors.ExpandTo(Convertors.DecimalToBase(Convertors.ToNumber(s), 2), bytes);
                }
            }
            else
            {
                if (line.Contains(new string('"', 1)))
                {
                    CodeLine = "";
                    line = line.Trim('"');
                    foreach (char c in line)
                    {
                        CodeLine += Convertors.ExpandTo(Convert.ToString(Convert.ToUInt16(c), 2), 1);
                    }
                }
                else
                {
                    CodeLine = Convertors.ExpandTo(Convertors.DecimalToBase(Convertors.ToNumber(line), 2), bytes);
                }
            }
            length = CodeLine.Length / 8;
        }
    }
}
