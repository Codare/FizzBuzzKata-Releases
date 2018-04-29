using System.Collections.Generic;
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

        public static IEnumerable<object[]> GetFizzBuzzIterationTestCases()
        {
            var fizzBuzzIterationTestCases = new List<(string expectedOutput, int iteration)>
            {
                ("0",0),
                ("1",1),
                ("2",2),
                ("Fizz",3),
                ("4",4),
                ("Buzz",5),
                ("Fizz",6),
                ("7",7),
                ("8",8),
                ("Fizz",9),
                ("Buzz",10),
                ("11",11),
                ("Fizz",12),
                ("13",13),
                ("14",14),
                ("FizzBuzz",15),
                ("16",16),
                ("17",17),
                ("Fizz",18),
                ("19",19),
                ("Buzz",20),
                ("Fizz",21),
                ("22",22),
                ("23",23),
                ("Fizz",24),
                ("Buzz",25),
                ("26",26),
                ("Fizz",27),
                ("28",28),
                ("29",29),
                ("FizzBuzz",30),
                ("31",31),
                ("32",32),
                ("Fizz",33),
                ("34",34),
                ("Buzz",35),
                ("Fizz",36),
                ("37",37),
                ("38",38),
                ("Fizz",39),
                ("Buzz",40),
                ("41",41),
                ("Fizz",42),
                ("43",43),
                ("44",44),
                ("FizzBuzz",45),
                ("46",46),
                ("47",47),
                ("Fizz",48),
                ("49",49),
                ("Buzz",50),
                ("Fizz",51),
                ("52",52),
                ("53",53),
                ("Fizz",54),
                ("Buzz",55),
                ("56",56),
                ("Fizz",57),
                ("58",58),
                ("59",59),
                ("FizzBuzz",60),
                ("61",61),
                ("62",62),
                ("Fizz",63),
                ("64",64),
                ("Buzz",65),
                ("Fizz",66),
                ("67",67),
                ("68",68),
                ("Fizz",69),
                ("Buzz",70),
                ("71",71),
                ("Fizz",72),
                ("73",73),
                ("74",74),
                ("FizzBuzz",75),
                ("76",76),
                ("77",77),
                ("Fizz",78),
                ("79",79),
                ("Buzz",80),
                ("Fizz",81),
                ("82",82),
                ("83",83),
                ("Fizz",84),
                ("Buzz",85),
                ("86",86),
                ("Fizz",87),
                ("88",88),
                ("89",89),
                ("FizzBuzz",90),
                ("91",91),
                ("92",92),
                ("Fizz",93),
                ("94",94),
                ("Buzz",95),
                ("Fizz",96),
                ("97",97),
                ("98",98),
                ("Fizz",99),
                ("Buzz",100),
            };

            foreach (var fizzBuzzIterationTestCase in fizzBuzzIterationTestCases)
            {
                yield return new object[] { fizzBuzzIterationTestCase.expectedOutput, fizzBuzzIterationTestCase.iteration };
            }
        }

        //There are pros and cons towards using MemberData as the input for a Theory of unit tests.
        //It is possible if an external source of known inputs and outputs can be obtained.
        [Theory]
        [MemberData(nameof(GetFizzBuzzIterationTestCases))]
        public void FizzBuzzIterationOfTests(string outcome, int iteration)
        {
            _output.WriteLine($"outcome: {outcome} | iteration: {iteration}");

            //act
            var actual = FizzBuzzGameEngineReturnsTheCorrectOutputForGivenIterationInput(iteration);

            //assert
            Assert.Equal(outcome, actual);
        }

        private static string FizzBuzzGameEngineReturnsTheCorrectOutputForGivenIterationInput(int iteration)
        {
            return FizzBuzzGameEngine.IterationOfIs(iteration);
        }

        //[Fact]
        //public void FizzBuzzIterationOfZeroIsZero()
        //{
        //    //act
        //    var actual = FizzBuzzGameEngineReturnsTheCorrectOutputForGivenIterationInput(0);

        //    //assert
        //    Assert.Equal("0", actual);
        //}

        //[Fact]
        //public void FizzBuzzIterationOfOneIsOne()
        //{
        //    //act
        //    var actual = FizzBuzzGameEngineReturnsTheCorrectOutputForGivenIterationInput(1);

        //    //assert
        //    Assert.Equal("1", actual);
        //}

        //[Fact]
        //public void FizzBuzzIterationOfThreeIsFizz()
        //{
        //    //act
        //    var actual = FizzBuzzGameEngineReturnsTheCorrectOutputForGivenIterationInput(3);

        //    //assert
        //    Assert.Equal("Fizz", actual);
        //}

        //[Fact]
        //public void FizzBuzzIterationOfFiveIsBuzz()
        //{
        //    //act
        //    var actual = FizzBuzzGameEngineReturnsTheCorrectOutputForGivenIterationInput(5);

        //    //assert
        //    Assert.Equal("Buzz", actual);
        //}

        //[Fact]
        //public void FizzBuzzIterationOfFiftennIsFizzBuzz()
        //{
        //    //act
        //    var actual = FizzBuzzGameEngineReturnsTheCorrectOutputForGivenIterationInput(15);

        //    //assert
        //    Assert.Equal("FizzBuzz", actual);
        //}
    }
}
