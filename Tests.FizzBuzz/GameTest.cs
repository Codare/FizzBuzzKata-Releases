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
            var actual = FizzBuzzGameEngineReturnsEitherFizzOrBuzzForGivenIteration(iteration);

            //assert
            Assert.Equal(outcome, actual);
        }

        private static string FizzBuzzGameEngineReturnsEitherFizzOrBuzzForGivenIteration(int iteration)
        {
            return FizzBuzzGameEngine.IterationOfIs(iteration);
        }

        [Fact]
        public void FizzBuzzIterationOfZeroIsZero()
        {
            //act
            var actual = FizzBuzzGameEngineReturnsEitherFizzOrBuzzForGivenIteration(0);

            //assert
            Assert.Equal("0", actual);
        }

        [Fact]
        public void FizzBuzzIterationOfOneIsOne()
        {
            //act
            var actual = FizzBuzzGameEngineReturnsEitherFizzOrBuzzForGivenIteration(1);

            //assert
            Assert.Equal("1", actual);
        }

        [Fact]
        public void FizzBuzzIterationOfThreeIsFizz()
        {
            //act
            var actual = FizzBuzzGameEngineReturnsEitherFizzOrBuzzForGivenIteration(3);

            //assert
            Assert.Equal("Fizz", actual);
        }

        [Fact]
        public void FizzBuzzIterationOfFiveIsBuzz()
        {
            //act
            var actual = FizzBuzzGameEngineReturnsEitherFizzOrBuzzForGivenIteration(5);

            //assert
            Assert.Equal("Buzz", actual);
        }

        [Fact]
        public void FizzBuzzIterationOfFiftennIsFizzBuzz()
        {
            //act
            var actual = FizzBuzzGameEngineReturnsEitherFizzOrBuzzForGivenIteration(15);

            //assert
            Assert.Equal("FizzBuzz", actual);
        }
    }
}
