namespace ASMEngine
{
    public class CompileError : Exception
    {
        public int LineNumber;
        public new string Message;

        public static CompileError WrongOperatorFormat(string Name, int Line)
            => new CompileError(Line, "No acceptable format found for operator : " + Name);

        public static CompileError VariableNotDefined(string Variable, int Line)
            => new CompileError(Line, "Variable not found : " + Variable);

        public static CompileError IdentifierUndeclared(string Variable, int Line)
            => new CompileError(Line, "Identifier undeclared : " + Variable);

        public static CompileError ComMultisegment()
            => new CompileError(-1, " Can't create multisegment com file");

        public static CompileError WrongNumericInput(string line)
            => new CompileError(-1, "Wrong numeric input : " + line);

        public static CompileError WrongRegister(string Line)
            => new CompileError(-1, "Wrong register : " + Line);

        public static CompileError WrongSegmentRegister(string Line)
            => new CompileError(-1, "Wrong segment register : " + Line);

        public static CompileError WrongOperand(string Description, int Line)
            => new CompileError(Line, Description);

        public static CompileError NoOpertor(int Line)
            => new CompileError(Line, "No operator found for this line");

        public static CompileError WrongLineFormat(int Line)
            => new CompileError(Line, "Wrong formatted line");

        public static CompileError ErrorInByte(int p)
            => new CompileError(-1, "Error in byte : " + p);

        public CompileError(int LineNumber, string Message)
        {
            this.Message = Message;
            this.LineNumber = LineNumber;
        }
    }
}
