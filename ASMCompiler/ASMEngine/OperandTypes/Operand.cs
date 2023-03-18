namespace ASMEngine
{
    public abstract class Operand
    {
        internal string im8 = "im8";
        internal string im16 = "im16";
        internal string reg = "reg";
        internal string w = "w";
        internal string rm = "r/m";
        internal string mod = "mod";
        internal string s = "s";
        internal string sreg = "sreg";
        internal List<OperandType> types;

        internal abstract bool TryToCreate(string line);
    }
}
