using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ReversePolishNotation.Calculator.Utiles
{
    public struct MathematicalExpression
    {
        public const string MatchString = @"(\d*\.?\d*\s+)+(\D)\s*";

        public delegate double ExpressionEvaluator(MathematicalExpression e, double? s);

        public List<double> Operands { get; set; }

        public string Operator { get; set; }

        public MathematicalExpression(string op, IEnumerable<double> operands)
        {
            Operands = new List<double>(operands);
            Operator = op;
        }

        public MathematicalExpression(string op, params double[] operands) : this(op, operands as IEnumerable<double>)
        {
            
        }

        public static MathematicalExpression FromMatch(Match match)
        {
            var operands = new List<double>(match.Groups[1].Captures.Count);
            foreach (Capture capture in match.Groups[1].Captures)
            {
                if (double.TryParse(capture.Value, out double operand))
                {
                    operands.Add(operand);
                }
                else
                {
                    throw new FormatException(
                        $"Operand at position {capture.Index} is not" +
                        $" within the limits of a double-precision" +
                        $" floating point number or is formatted" +
                        $" incorrectly.");
                }
            }

            return new MathematicalExpression(Convert.ToString(match.Groups.Values.Last().Value[0]), operands);
        }

        public static MathematicalExpression FromString(string input)
        {
            return FromMatch(Regex.Match(input, MatchString));
        }
    }
}
