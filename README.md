# FizzBuzzKata

Typically the interview test question is either:

a) Implement the code required without tests to drive the design.

b) The candidate can choose whether to write the code without tests or write the code in a test driven (triangulation driven nature).
such that the tests begin to start with known cases of 0 returns "0", triangulation would suggest that the developer continues to drive the development of the game in such a way as to increment the iterations by 1.  So the next test to write is for the value 1 and then 2.
However developers who begin to get comfortable with TDD can often skip ahead to more interesting edge cases or the next know area of value such as 3 in the simples rules of the game 3 returns "Fizz" and then 4 can be skipped out and we can jump straight to 5 which returns "Buzz" and so from 5 we might be confident in our test cases and look at 15 where we know that the output should be "FizzBuzz".

# Release 1.0 provides
The solution provided is providing an implementation that is just the right amount of sufficient code to achieve the typical requirements of the FizzBuzz Game interview test.

If the game was to receive further enhancements down the line, such as allowing the player to create their own numbers say [5 and 6] with a custom message when the player guesses the multiples of [5] and multiples of [6] such as [5 outputs "Bingo"] and [6 outputs "Buckaroo"].
Then the game engine class would begin to take on state and the first change would be to make the FizzBuzGameEngine class a non static class.

This would allow the client to create an instance of the game object.

# Release 1.1 provides
The code has been altered to allow that game engine class to ensure that the output of the game is declared within private constant string variables.

    private const string IsZeroResult = "0";
    private const string IsFizzResult = "Fizz";
    private const string IsBuzzResult = "Buzz";
    private const string IsFizzBuzzResult = "FizzBuzz";

The testing of the iterations i.e. [0..100] against the numbers 3 and 5 for "Fizz" and "Buzz" and "FizzBuzz" outputs have been extracted out of the public method "IterationOfIs" into their own seperate private methods.  

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
  
 The other modifications of not are to the public method "IterationOfIs":
 
       var fizz = IsIterationFizz(iteration);
       var buzz = IsIterationBuzz(iteration);
       
 By having these local variables evaluated at the beginning of the method I am able to use them in code as below:
 
            if (fizz && buzz)
            {
                return IsFizzBuzzResult;
            }

            if (fizz)
            {
                return IsFizzResult;
            }

            return buzz ? IsBuzzResult : iteration.ToString();

The ternary if statement allows me to use some syntactic sugar from the compiler to achieve a more terse if statement.

Note:  It is down to the software teams development style guide and or general guidelines as to whether or not the preference for the team is to include or exclude the opening and closing "{" brackets and or of which line they must appear on.
       
