# For Loops
For loop has similar functionality as while loop but with different syntax. for loops are preferred when the number of times loop statements are to be executed is known beforehand. The loop variable initialization, condition to be tested, and increment/decrement of the loop variable is done in one line in for loop thereby providing a shorter, easy to debug structure of looping.

To see code source click [here](https://github.com/Thesnowmanndev/CSharp-Education/blob/main/CSharp-Mastercourse/Applications/Console%20Applications/App%2012%20-%20For%20Loops/ForLoops/Program.cs).

## Flowchart

![flow](https://media.geeksforgeeks.org/wp-content/cdn-uploads/loops.png)

1. **Initialization of loop variable:** The expression / variable controlling the loop is initialized here. It is the starting point of for loop. An already declared variable can be used or a variable can be declared, local to loop only.
2. **Testing Condition:** The testing condition to execute statements of loop. It is used for testing the exit condition for a loop. It must return a boolean value true or false. When the condition became false the control will be out from the loop and for loop ends.
3. **Increment / Decrement:** The loop variable is incremented/decremented according to the requirement and the control then shifts to the testing condition again. Note: Initialization part is evaluated only once when the for loop starts.

See more: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement