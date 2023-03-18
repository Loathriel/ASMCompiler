namespace ASMEngine
{
    public class Line
    {
        public string LineNumber;
        public string Address;
        public string Code;
        public string Source;

        public Line(string LineNumber, string Address, string Code, string Source)
        {
            this.LineNumber = LineNumber;
            this.Address = Address;
            this.Code = Code;
            this.Source = Source;
        }
    }
}
