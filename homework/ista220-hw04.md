
Oscar Brown
02/27/2018

Read chapter 4, pages 87 – 105 in the C# Step by Step book.
Discussion Questions
Answer the discussion questions in writing for chapter 4.

1. What are all possible values of a Boolean expression? pg 87
always evaluates to true or false. 

2. List eight Boolean operators. pg 88 Only 
== equal to, != Not equal to, < less than, <= Less than or equal to, > Greater than, >= Greater than or equal to, && and ||

3. What are the difference in how short circuiting works for && and ||? pg 90
The difference is if the left operand of the && operator evaluates false then entire expression must be considered to false. If left operand of || is true then entire expression must be true and entire expression is considered true and is executed.
 
4. Look at the list of operators. What operator has the highest precedence? Which has the lowest? pg 90-90 Highest is primary ()/++/--, lowest is assignment =

5. In an if or else construction using multiple lines of code, what effect does the use of curly braces have?
Creates a block which executes only the one line. If there is only one statement to execute after if condition then using curly braces or not doesn't make it different. Without curly braces only first statement consider in scope so statement after if condition will get executed even if there is no curly braces. But it is Highly Recommended to use curly braces. Because if the user (or someone else) ever expands the statement it will be required.

6. In a switch statement, what happens if you omit break?

execution will “fall through” to the code inside the case 2 statement
