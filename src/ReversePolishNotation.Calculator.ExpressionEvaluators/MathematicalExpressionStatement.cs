using ReversePolishNotation.Calculator.Utiles;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ReversePolishNotation.Calculator.ExpressionEvaluators
{
    public struct MathematicalExpressionStatement
    {
        public List<MathematicalExpression> Expressions { get; set; }

        public MathematicalExpressionStatement(string input)
        {
            var matches = Regex.Matches(input, MathematicalExpression.MatchString);
            Expressions = new List<MathematicalExpression>(matches.Count);
            foreach (Match match in matches)
            {
                Expressions.Add(MathematicalExpression.FromMatch(match));
            }
        }
    }
}
