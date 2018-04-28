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

In later releases I will enhance the game engine by reducing the current cyclomatic complexity of the FizzBuzzGameEngine IterationOfIs public static method.  The current score of 6 is due to the number of if statements within a single function.

In order to reduce this number I am going to introduce some indirection to the code and convert the if statements and branching logic into methods with a single purpose this will do two things.  1) reduce the cyclomatic complexity of the code.  Allowing future developers to very quickly reason about what it is the methods within the class are doing and what it is they are responsible for.
