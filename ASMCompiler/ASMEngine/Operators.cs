using OperatorsLib.ArifmeticCMDs;
using OperatorsLib.ConditionCMDs;
using OperatorsLib.ControlCMDs;
using OperatorsLib.InterruptsCMDs;
using OperatorsLib.LogicCMDs;
using OperatorsLib.MovingCMDs;

namespace ASMEngine
{
    public class Operators
    {
        public static readonly List<Operator> DataBase = InitDataBase();
        private static readonly List<Operand> RegistredOperands = RegisterOperands();

        private static List<Operator> InitDataBase() => new List<Operator>
            {
                new ADDOperator(),
                new SUBOperator(),
                new INCOperator(),
                new DECOperator(),
                new CMPOperator(),
                new NEGOperator(),
                new MULOperator(),
                new IMULOperator(),
                new DIVOperator(),
                new IDIVOperator(),
                new CBWOperator(),
                new INTOperator(),
                new MOVOperator(),
                new LEAOperator(),
                new PUSHOperator(),
                new POPOperator(),
                new XCHGOperator(),
                new LOOPOperator(),
                new JMPOperator(),
                new RETOperator(),
                new JxxOperator(),
                new ANDOperator(),
                new SHLOperator(),
                new SAROperator(),
                new XOROperator(),
                new OROperator(),
                new CLDOperator(),
                new STOSBOperator()
            };

        private static List<Operand> RegisterOperands() => new List<Operand>
            {
                new Register(),
                new Constant(),
                new SegmentRegister(),
                new Address()
            };

        internal static bool IsOperator(string line)
        {
            line = line.ToUpper();
            return DataBase.Any(x => x.TryToCreate(line));
        }

        internal static Operator ParseOperator(string line, AddressTable table, int LineNumber)
        {
            string[] parts = line.Split(new char[2] { ' ', ',' }, 3);


            foreach (Operator x in DataBase)
            {
                if (x.TryToCreate(parts[0].ToUpper()))
                {

                    if (parts.Length == 1)
                        return ZeroOperandOperator(x, LineNumber);

                    if (parts.Length == 2)
                        return OneOperandOperator(x, LineNumber, parts[1]);

                    if (parts.Length == 3)
                        return TwoOperandOperator(x, table, LineNumber, parts[1], parts[2]);
                }
            }
            throw CompileError.NoOpertor(LineNumber);
        }

        private static Operator ZeroOperandOperator(Operator x, int LineNumber) 
        {
            return (Operator)Activator.CreateInstance(x.GetType(), new NullOperand(""), new NullOperand(""), LineNumber);
        }

        private static Operator OneOperandOperator(Operator x, int LineNumber, string operand) 
        {
            Operand first = null;
            foreach (Operand y in RegistredOperands)
            {
                if (y.TryToCreate(operand))
                {
                    if (y is Constant)
                        first = (Operand)Activator.CreateInstance(y.GetType(), operand, 1);
                    else
                        first = (Operand)Activator.CreateInstance(y.GetType(), operand);
                    break;
                }
            }
            if (first == null)
                throw CompileError.WrongOperatorFormat("First operand of one-operand operator is invalid", LineNumber);
            return (Operator)Activator.CreateInstance(x.GetType(), first, new NullOperand(""), LineNumber);
        }

        private static Operator TwoOperandOperator(Operator x, AddressTable table, int LineNumber, string operand1, string operand2)
        {
            Operand first = null;
            Operand second = null;
            foreach (Operand y in RegistredOperands)
            {
                if (y.TryToCreate(operand1))
                {
                    if (y is Constant)
                        first = (Operand)Activator.CreateInstance(y.GetType(), operand1.ToUpper(), 1);
                    else
                        first = (Operand)Activator.CreateInstance(y.GetType(), operand1);
                    break;
                }
            }
            foreach (Operand y in RegistredOperands)
            {
                if (y.TryToCreate(operand2))
                {
                    if (y is Constant)
                    {
                        if (first.w == "w")
                            first.w = "1";
                        second = (Operand)Activator.CreateInstance(y.GetType(), operand2, 1 + int.Parse(first.w));
                    }
                    else
                    {
                        if (y is Register)
                            second = new Register(operand2, !(first is Register || first is SegmentRegister));
                        else
                            second = (Operand)Activator.CreateInstance(y.GetType(), operand2);
                    }
                    break;
                }
            }
            if (first == null)
                throw CompileError.WrongOperatorFormat("First operand of two-operand operator is invalid", LineNumber);
            if (second == null)
                throw CompileError.WrongOperatorFormat("Second operand of two-operand operator is invalid", LineNumber);
            if (first is Address)
                table.Add((first as Address).var);
            if (second is Address)
                table.Add((second as Address).var);
            return (Operator)Activator.CreateInstance(x.GetType(), first, second, LineNumber);
        }
    }
}
