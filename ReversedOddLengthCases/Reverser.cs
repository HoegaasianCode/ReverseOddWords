using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedOddLengthCases
{
    public class Reverser
    {
        private readonly string _string;

        public Reverser(string @string)
        {
            _string = @string;
        }

        public string ParseSentence()
        {
            string[] words = _string.Split(" ");
            var sb = new StringBuilder();
            foreach(var word in words)
            {
                if (word.Length % 2 == 0)
                {
                    sb.Append(word);
                    sb.Append(' ');
                }
                else
                {
                    sb.Append(word.Reverse().ToArray());
                    sb.Append(' ');
                }
            }
            return sb.ToString();
        }
    }
}
