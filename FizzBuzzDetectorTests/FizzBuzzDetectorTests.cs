namespace FizzBuzzTask
{
    [TestClass]
    public class FizzBuzzDetectorTests
    {
        private readonly FizzBuzzDetector _detector = new();

        [TestMethod]
        public void TestBasicReplacement()
        {
            string input = "one two three four five six seven";
            Result result = _detector.GetOverlappings(input);

            Assert.AreEqual("one two Fizz four Buzz Fizz seven", result.ModifiedString);
            Assert.AreEqual(2, result.FizzCount);
            Assert.AreEqual(1, result.BuzzCount);
            Assert.AreEqual(0, result.FizzBuzzCount);
        }

        [TestMethod]
        public void TestWithPunctuation()
        {
            string input = "hello, world this is a test string";
            Result result = _detector.GetOverlappings(input);

            Assert.AreEqual("hello, world Fizz is Buzz Fizz string", result.ModifiedString);
            Assert.AreEqual(2, result.FizzCount);
            Assert.AreEqual(1, result.BuzzCount);
            Assert.AreEqual(0, result.FizzBuzzCount);
        }

        [TestMethod]
        public void TestFizzBuzzOverlap()
        {
            string input = "one two three four five six seven eight nine ten eleven twelve thirteen fourteen fifteen";
            Result result = _detector.GetOverlappings(input);

            Assert.AreEqual("one two Fizz four Buzz Fizz seven eight Fizz Buzz eleven Fizz thirteen fourteen FizzBuzz",
                result.ModifiedString);
            Assert.AreEqual(4, result.FizzCount);
            Assert.AreEqual(2, result.BuzzCount);
            Assert.AreEqual(1, result.FizzBuzzCount);
        }

        [TestMethod]
        public void TestMultipleLines()
        {
            string input = "Mary had a little lamb Little lamb, little lamb Mary had a little lamb It's fleece was white as snow";
            Result result = _detector.GetOverlappings(input);

            Assert.AreEqual("Mary had Fizz little Buzz Fizz lamb, little Fizz Buzz had Fizz little lamb FizzBuzz fleece was Fizz as Buzz",
                result.ModifiedString);
            Assert.AreEqual(5, result.FizzCount);
            Assert.AreEqual(3, result.BuzzCount);
            Assert.AreEqual(1, result.FizzBuzzCount);
        }

        [TestMethod]
        public void TestMultipleSpaces()
        {
            string input = "one   two  three   four    five  six   seven";
            Result result = _detector.GetOverlappings(input);

            Assert.AreEqual("one two Fizz four Buzz Fizz seven", result.ModifiedString);
            Assert.AreEqual(2, result.FizzCount);
            Assert.AreEqual(1, result.BuzzCount);
            Assert.AreEqual(0, result.FizzBuzzCount);
        }

        [TestMethod]
        public void TestNumbersAndWords()
        {
            string input = "start 123 now 456 works 789 great 000 end 999 here";
            Result result = _detector.GetOverlappings(input);

            Assert.AreEqual("start 123 Fizz 456 Buzz Fizz great 000 Fizz Buzz here", result.ModifiedString);
            Assert.AreEqual(3, result.FizzCount);
            Assert.AreEqual(2, result.BuzzCount);
            Assert.AreEqual(0, result.FizzBuzzCount);
        }
    }
}
