namespace FizzBuzz.GameEngine
{
    public static class FizzBuzzGameEngine
    {
        public static string IterationOfIs(int iteration)
        {
            var fizz = iteration % 3 == 0;
            var buzz = iteration % 5 == 0;

            if (iteration == 0)
            {
                return "0";
            }

            if (fizz && buzz)
            {
                return "FizzBuzz";
            }

            if (fizz)
            {
                return "Fizz";
            }

            if (buzz)
            {
                return "Buzz";
            }

            return iteration.ToString();
        }
    }
}
