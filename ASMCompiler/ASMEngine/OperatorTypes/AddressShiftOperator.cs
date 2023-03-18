namespace ASMEngine
{
    public class AddressShiftOperator : Operator
    {
        protected override void initFormats() { }
        public AddressShiftOperator(int length)
        {
            Op1 = new NullOperand("");
            Op2 = new NullOperand("");
            hasAddress = false;
            CodeLine = "";
            this.length = length;
        }
    }
}
