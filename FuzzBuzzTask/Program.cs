using FizzBuzzTask;

FizzBuzzDetector detector = new();

string input = "Mary had a little lamb Little lamb, little lamb Mary had a little lamb It's fleece was white as snow";

Result result = detector.GetOverlappings(input);

Console.WriteLine("Original: " + input);
Console.WriteLine("Modified: " + result.ModifiedString);
Console.WriteLine("Fizz count: " + result.FizzCount);
Console.WriteLine("Buzz count: " + result.BuzzCount);
Console.WriteLine("FizzBuzz count: " + result.FizzBuzzCount);
