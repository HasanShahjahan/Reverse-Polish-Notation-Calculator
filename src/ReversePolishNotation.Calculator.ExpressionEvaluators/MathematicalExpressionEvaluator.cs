using ReversePolishNotation.Calculator.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReversePolishNotation.Calculator.ExpressionEvaluators
{
    public static class MathematicalExpressionEvaluator
    {
        public static Dictionary<char, MathematicalExpression.ExpressionEvaluator>
            ExpressionEvaluators =
            new Dictionary<char, MathematicalExpression.ExpressionEvaluator>
            {
                { '+', (e, s) => (s ?? 0.0) + e.Operands.Sum() },
                { '-', (e, s) => (s ?? 0.0) - e.Operands[0] - e.Operands.Skip(1).Sum() },
                { '*', (e, s) => (s ?? 1.0) * e.Operands.Aggregate((product, next) => product * next) },
                { '/', (e, s) => s.HasValue ? (s.Value /e.Operands.Aggregate((product, next) => product / next)) : (e.Operands.Aggregate((product, next) => product / next)) },
                { '√',(e,s) => Math.Sqrt(e.Operands[0])}
            };
    }
}
