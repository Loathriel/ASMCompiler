namespace ASMEngine
{
    public abstract class Operator
    {
        public List<Format> RegistredFormats;
        internal int length;
        internal int address;
        internal bool hasAddress = false;
        internal Operand Op1;
        internal Operand Op2;
        internal string CodeLine;

        protected abstract void initFormats();

        public virtual string Name() => "";

        public virtual bool TryToCreate(string line)
        {
            return line.ToUpper() == Name();
        }

        public Operator()
        {
            RegistredFormats = new List<Format>();
            initFormats();
        }

        public Operator(Operand Op1, Operand Op2, int Line)
        {                
            Initialization(Op1, Op2, Line);
        }

        protected void Initialization(Operand Op1, Operand Op2, int Line)
        {
            this.Op1 = Op1;
            this.Op2 = Op2;
            RegistredFormats = new List<Format>();
            initFormats();
            foreach (Format f in RegistredFormats)
            {
                CodeLine = f.TryToFormat(Op1, Op2);
                CodeLine = CodeLine.Replace(" ", "");
                if (CodeLine != "")
                    break;
            }
            if (CodeLine == "")
                throw CompileError.WrongOperatorFormat(Name(), Line);
            length = CodeLine.Length / 8;
            if (Op1 is Address)
            {
                if (Op1.mod == "01")
                    length++;
                if (Op1.mod == "10")
                    length += 2;
                if (Op1.mod == "00" && Op1.rm == "110")
                    length += 2;
                hasAddress = (Op1 as Address).var != "";
            }
            if (Op2 is Address)
            {
                if (Op2.mod == "01")
                    length++;
                if (Op2.mod == "10")
                    length += 2;
                if (Op2.mod == "00" && Op2.rm == "110")
                    length += 2;
                hasAddress = (Op2 as Address).var != "";
            }
        }
    }
}
