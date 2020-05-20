using ReversePolishNotation.Calculator.Common.Enums;
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
                { Operations.SUM, (e, s) => (s ?? 0.0) + e.Operands.Sum() },
                { Operations.SUB, (e, s) => (s ?? 0.0) - e.Operands[0] - e.Operands.Skip(1).Sum() },
                { Operations.MUL, (e, s) => (s ?? 1.0) * e.Operands.Aggregate((product, next) => product * next) },
                { Operations.DIV, (e, s) => s.HasValue ? (s.Value /e.Operands.Aggregate((product, next) => product / next)) : (e.Operands.Aggregate((product, next) => product / next)) },
                { Operations.SQUARE_ROOT,(e,s) => Math.Sqrt(e.Operands[0])},
                { Operations.SQUARE,(e,s) => Math.Pow(e.Operands[0],2)},
                { Operations.MODULUS,(e,s) => e.Operands.Aggregate((product, next) => product % next)},
                { Operations.FACTORIAL,(e,s) => Enumerable.Range(1, Convert.ToInt32(e.Operands[0])).Aggregate(1, (p, item) => p * item)}
            };
    }
}
