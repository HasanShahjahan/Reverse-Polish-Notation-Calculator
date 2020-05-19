using System;

namespace ReversePolishNotation.Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var interativeSession = new CommandLineInterface();
            interativeSession.Begin();
        }
    }
}
