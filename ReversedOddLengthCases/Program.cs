using System;

namespace ReversedOddLengthCases
{
    class Program
    {
        // https://edabit.com/challenge/ny83khdmye4JsJRqS
        // SOLVED

        static void Main(string[] args)
        {
            var x = new Reverser("One two three four");
            Console.WriteLine(x.ParseSentence());
        }
    }
}
