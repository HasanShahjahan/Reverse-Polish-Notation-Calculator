using ReversePolishNotation.Calculator.Common.EnumAbstration;

namespace ReversePolishNotation.Calculator.Common.Enums
{
    public sealed class Operations : StringEnum
    {
        public Operations(string value) : base(value)
        {
        }
        public const string SUM = "+";
        public const string SUB = "-";
        public const string MUL = "*";
        public const string DIV = "/";
        public const string SQUARE_ROOT = "√";
        public const string SQUARE = "s";
        public const string MODULUS = "%";
        public const string FACTORIAL = "!";
    }
}
