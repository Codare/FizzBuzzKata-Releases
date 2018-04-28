namespace FizzBuzz.GameEngine
{
    public static class FizzBuzzGameEngine
    {
        private const string IsZeroResult = "0";
        private const string IsFizzResult = "Fizz";
        private const string IsBuzzResult = "Buzz";
        private const string IsFizzBuzzResult = "FizzBuzz";

        private static bool IsIterationFizz(int iteration)
        {
            return iteration % 3 == 0;
        }

        private static bool IsIterationBuzz(int iteration)
        {
            return iteration % 5 == 0;
        }

        private static bool IsIterationZero(int iteration)
        {
            return iteration == 0;
        }

        public static string IterationOfIs(int iteration)
        {
            var fizz = IsIterationFizz(iteration);
            var buzz = IsIterationBuzz(iteration);

            if (IsIterationZero(iteration))
            {
                return IsZeroResult;
            }

            if (fizz && buzz)
            {
                return IsFizzBuzzResult;
            }

            if (fizz)
            {
                return IsFizzResult;
            }

            return buzz ? IsBuzzResult : iteration.ToString();
        }
    }
}
