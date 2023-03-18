namespace ASMEngine
{
    public class Constant : Operand
    {
        private int data;

        internal override bool TryToCreate(string line)
        {
            return Convertors.IsConstant(line.ToUpper()) || (line.Length == 3 && line.StartsWith("\"") && line.EndsWith("\""));
        }

        public Constant() : base() { }
        public Constant(string line, int bytes)
        {
            line = line.ToUpper();
            if (line.StartsWith("\""))
                data = (int)line[1];
            else
                data = Convertors.ToNumber(line);
            im8 = Convertors.ExpandTo(Convertors.DecimalToBase(data, 2), 1);
            im16 = Convertors.ExpandTo(Convertors.DecimalToBase(data, 2), 2);
            types = new List<OperandType>();
            if (im8.Length <= 8 && bytes == 1)
                types.Add(OperandType.Immediate8);
            else
                types.Add(OperandType.Immediate16);
        }
    }
}
