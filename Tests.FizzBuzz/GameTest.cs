using FizzBuzz.GameEngine;
using Xunit;
using Xunit.Abstractions;

namespace Tests.FizzBuzz
{
    public class GameTest
    {
        private readonly ITestOutputHelper _output;

        public GameTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("Fizz", 3)]
        [InlineData("Buzz", 5)]
        [InlineData("FizzBuzz", 15)]
        public void FizzBuzzIterationOfTests(string outcome, int iteration)
        {
            _output.WriteLine($"outcome: {outcome} | iteration: {iteration}");

            //act
            var actual = FizzBuzzGameEngine.IterationOfIs(iteration);

            //assert
            Assert.Equal(outcome, actual);
        }

        [Fact]
        public void FizzBuzzIterationOfZeroIsZero()
        {
            //act
            var actual = FizzBuzzGameEngine.IterationOfIs(0);

            //assert
            Assert.Equal("0", actual);
        }

        [Fact]
        public void FizzBuzzIterationOfOneIsOne()
        {
            //act
            var actual = FizzBuzzGameEngine.IterationOfIs(1);

            //assert
            Assert.Equal("1", actual);
        }

        [Fact]
        public void FizzBuzzIterationOfThreeIsFizz()
        {
            //act
            var actual = FizzBuzzGameEngine.IterationOfIs(3);

            //assert
            Assert.Equal("Fizz", actual);
        }

        [Fact]
        public void FizzBuzzIterationOfFiveIsBuzz()
        {
            //act
            var actual = FizzBuzzGameEngine.IterationOfIs(5);

            //assert
            Assert.Equal("Buzz", actual);
        }

        [Fact]
        public void FizzBuzzIterationOfFiftennIsFizzBuzz()
        {
            //act
            var actual = FizzBuzzGameEngine.IterationOfIs(15);

            //assert
            Assert.Equal("FizzBuzz", actual);
        }
    }
}
