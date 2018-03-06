Oscar Brown
03/03/2018

Read Chapter 5, pages 107 - 125 in the C# step by step book.

Discussion Questions:

1. An compound assignment operator is combining arithmetic operator with an assignment operator to perform tasks in a shorthand manner. (pg 107-108)
ex. answer = 42. to assign add value of 42 to answer += 42
ex. 2 Can also be used on strings
String name = "Oscar";
String greeting = "Hello"
greeting += name;
Console.WriteLine.(greeting);

2. All compound assignment operators: 1)variable *= number;2) variable /= number;3) variable %= number;4) variable += number;5) variable -= number; (pg 108)

3. a) two ways to increment a numeric variable by 5 is: 
count += 5;
or 
count = count + 5

b) Two ways to decrement a numeric variable by 50:
count -= 50
or
Count = count - 50; (pg 108)

4. The while loop runs as long as some condition is true. (pg 108/114)
ex. While statement structure:
Initialization
While (booleanExpression)
Statement
{
Statement
update control
}

5. If you don't change the loop variable in the body of while loop block the loop will run forever.

6. The for loop statement has 3 parts. You can omit any of the 3 parts of the for statement. If you omit all 3, the statement will run forever. Initializer, test, updater.
7. You can use the do while loop to ensure the loop runs at least once. (Do stuff while (false);
8. The break statement can be used to jump out of a switch statement and also to jump out of the an iteration statement (break out of a loop--> loop exits immediately and execution continues at the first statment following the loop).
ex. iteration statement
int i = 0;
while (true)
{
Console.WriteLine(i);
i++;
if (i < 10)
    continue;
else
    break;
}
9. The continue statement causes the program to perform the next iteration of loop immediately (after reevaluating the Boolean expression). Skips the rest of the code. (Reference ex. on answer 8) (pg 116-117)