namespace ASMEngine
{
    internal class NullOperand : Operand
    {
        internal override bool TryToCreate(string line)
        {
            return true;
        }
        public NullOperand(string line)
        {
            types = new List<OperandType>();
            types.Add(OperandType.None);
        }
    }
}
