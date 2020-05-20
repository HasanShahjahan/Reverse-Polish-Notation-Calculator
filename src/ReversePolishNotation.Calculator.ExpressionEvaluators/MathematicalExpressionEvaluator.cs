using ReversePolishNotation.Calculator.Utiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReversePolishNotation.Calculator.ExpressionEvaluators
{
    public static class MathematicalExpressionEvaluator
    {
        public static Dictionary<string, MathematicalExpression.ExpressionEvaluator>
            ExpressionEvaluators =
            new Dictionary<string, MathematicalExpression.ExpressionEvaluator>
            {
                { "+", (e, s) => (s ?? 0.0) + e.Operands.Sum() },
                { "-", (e, s) => (s ?? 0.0) - e.Operands[0] - e.Operands.Skip(1).Sum() },
                { "*", (e, s) => (s ?? 1.0) * e.Operands.Aggregate((product, next) => product * next) },
                { "/", (e, s) => s.HasValue ? (s.Value /e.Operands.Aggregate((product, next) => product / next)) : (e.Operands.Aggregate((product, next) => product / next)) },
                { "√",(e,s) => Math.Sqrt(e.Operands[0])},
                { "s",(e,s) => Math.Pow(e.Operands[0],2)},
                { "%",(e,s) => e.Operands.Aggregate((product, next) => product % next)},
                { "!",(e,s) => Enumerable.Range(1, Convert.ToInt32(e.Operands[0])).Aggregate(1, (p, item) => p * item)}
            };
    }
}
