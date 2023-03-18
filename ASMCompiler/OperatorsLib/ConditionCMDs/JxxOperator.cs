using ASMEngine;

namespace OperatorsLib.ConditionCMDs
{
    public class JxxOperator : Operator
    { 
        private static string cond = "xx";
        private static Dictionary<string, string> conditions = InitConditions();
        private static Dictionary<string, string> InitConditions() => new Dictionary<string, string>()
        {
            { "E", "0100" },
            { "NE", "0101" },
            { "Z", "0100" },
            { "NZ", "0101" },
            { "L", "1100" },
            { "NL", "1101" },
            { "NGE", "1100" },
            { "GE", "1101" },
            { "LE", "1110" },
            { "NLE", "1111" },
            { "NG", "1110" },
            { "G", "1111" }
        };

        public override string Name() => "J" + cond;

        public override bool TryToCreate(string line)
        {
            if (line == "")
                return false;
            line = line.ToUpper();
            bool res = line[0] == 'J' && conditions.ContainsKey(line.Substring(1));
            if (res)
                cond = line.Substring(1);
            return res;
        }

        public JxxOperator() : base() { }

        public JxxOperator(Operand op1, Operand op2, int Line)
            : base(op1, op2, Line)
        {
            CodeLine = CodeLine.Replace("cond", conditions[cond]);
        }

        protected override void initFormats()
        {
            RegistredFormats.Add(new Format(OperandType.Memory, OperandType.None, "0000 1111 1000 cond"));
        }
    }
}
