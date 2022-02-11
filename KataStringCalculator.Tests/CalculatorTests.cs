using NUnit.Framework;

namespace KataStringCalculator.Tests
{
    public class Tests
    {
        private ICalculator _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Calculator();
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase("1", ExpectedResult = 1)]
        [TestCase("1,2", ExpectedResult = 3)]
        public int Add_Tests(string input) => _sut.Add(input);
    }
}