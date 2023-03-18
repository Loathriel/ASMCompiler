namespace ASMEngine
{
    public class Format
    {
        public OperandType Op1Type;
        public OperandType Op2Type;
        public string FormatLine;
        public string TryToFormat(Operand Op1, Operand Op2)
        {
            if (Op1.types.Contains(Op1Type) && Op2.types.Contains(Op2Type))
            {
                return FormatLine
                    .Replace("w", Op1.w)
                    .Replace("w", Op2.w)
                    .Replace("reg", Op1.reg)
                    .Replace("reg", Op2.reg)
                    .Replace("r/m", Op1.rm)
                    .Replace("r/m", Op2.rm)
                    .Replace("mod", Op1.mod)
                    .Replace("mod", Op2.mod)
                    .Replace("im8", Op1.im8)
                    .Replace("im8", Op2.im8)
                    .Replace("im16", Op1.im16)
                    .Replace("im16", Op2.im16)
                    .Replace("xreg", Op1.sreg)
                    .Replace("xreg", Op2.sreg)
                    .Replace("cond", "y")
                    .Replace("d", "1")
                    .Replace("y", "cond");
            }
            return "";
        }
        public Format(OperandType Op1Type, OperandType Op2Type, string FormatLine)
        {
            this.Op1Type = Op1Type;
            this.Op2Type = Op2Type;
            this.FormatLine = FormatLine.Trim().Replace("s", "0");
        }
    }
}
