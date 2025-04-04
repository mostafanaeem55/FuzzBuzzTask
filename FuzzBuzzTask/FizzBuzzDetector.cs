using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTask
{
    public class FizzBuzzDetector
    {
        public Result GetOverlappings(string input)
        {
            if (input == null)
            {
                return new Result("", 0, 0, 0);
            }

            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int fizzCount = 0;
            int buzzCount = 0;
            int fizzBuzzCount = 0;

            for (int i = 0; i < words.Length; i++)
            {
                if (!words[i].Any(char.IsLetterOrDigit))
                {
                    continue;
                }

                bool isDivisibleBy3 = (i + 1) % 3 == 0;
                bool isDivisibleBy5 = (i + 1) % 5 == 0;
                bool isDivisibleBy15 = (i + 1) % 15 == 0;

                if (isDivisibleBy15)
                {
                    words[i] = "FizzBuzz";
                    fizzBuzzCount++;
                }
                else if (isDivisibleBy3)
                {
                    words[i] = "Fizz";
                    fizzCount++;
                }
                else if (isDivisibleBy5)
                {
                    words[i] = "Buzz";
                    buzzCount++;
                }
            }

            string result = string.Join(" ", words);
            return new Result(result, fizzCount, buzzCount, fizzBuzzCount);
        }
    }
}
    

