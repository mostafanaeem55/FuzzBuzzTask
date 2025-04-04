using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTask
{
    public class Result(string modifiedString, int fizzCount, int buzzCount, int fizzBuzzCount)
    {
        public string ModifiedString { get; } = modifiedString;
        public int FizzCount { get; } = fizzCount;
        public int BuzzCount { get; } = buzzCount;
        public int FizzBuzzCount { get; } = fizzBuzzCount;
    }
}
