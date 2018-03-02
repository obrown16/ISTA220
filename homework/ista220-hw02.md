Oscar Brown
02/20/2018

Homework 02, ISTA-220
Chapter 02, C# Step by Step
1 Homework
1.1 Readings
Read chapter 2, pages 33 { 58 in the C# Step by Step book.

Answer the discussion questions in writing for chapter 2.

1. What is a local variable? 
Local variables are uninitialized. Local variables are those variables declared within a method or other language element defined by a block. Blocks are language elements that denote the beginning and end of a C# language construct. In the case of methods, blocks denote the beginning and end of a method. 
-is a type of variable declared by local variable declaration at the beginning of a block the variable is intended to be local to. It can also occur in a for-statement, a switch-statement, a foreach statement, a 
using statement or a specific-catch statement or using statement.

2. What is a statement? A statement is a command that performs an action, such as calculating a value and storing the result or displaying a message to a user. Pg 33

3. What is an identifier? Are names that you use to identify the elements in your programs, such as namespaces classes, methods, and variables. Pg 34

4. What is a variable? A storage location that holds a value. Think of it as a box in a computer’s memory that holds temporary information. Pg 36

5. What is a method? A named sequence of statements. Main is an example of method. Pg 33 a method is a named location in memory that references a behavior (value = variable).

6. Are primitive types and value types the same thing? See page 177. A primitive type (e.g. int) can be mapped directly to a Base Class Library (BCL) type (e.g. System.Int32). no not the same. Primative type is a form of value type, which is not the same.

7. How are arithmetic operators and variable types related? Depends on the value type. Ex 2+2 4, L+L L

8. How do you turn an integer into a string?
Use the ToString method to turn an Integar into a string
string myString = myInt.ToString();

9. How do you turn a string into an integer?

You can convert a string to a number by using methods in the Convert class or by using the TryParse method found on the various numeric types (int, long, float, etc.). pg 75 tipIf you have a string, it is slightly more efficient and straightforward to call a TryParse method (for example, int.TryParse("11")). Using a Convert method is more useful for general objects that 
implement IConvertible.

10. What is the difference between precedence and associativity? Give an example where this makes a difference.Precedence rules specify priority of operators (which operators will be evaluated first, e.g. multiplication has higher precedence than addition, PEMDAS). 
The associativity rules tell how the operators of same precedence are grouped. Arithmetic operators are left-associative, but the assignment is right associative (e.g. a = b = c will be evaluated as b = c, a = b).
 What order right to left an operator will act. Ex (3+4)*5

The order is a result of applying the precedence and associativity rules and tells how the expression will be evaluated - which operators will be evaluated firs, which later, which at the end. The actual order can be changed by using braces (braces are also operator with the highest precedence).

11. What is the definite assignment rule?
Definite assignment is a rule simply stating that every variable must have a value before it's read from. The process of assigning a value to a variable for the first time is known as initialization. Once the initialization process has taken place, a variable is considered initialized. If the initialization process has not yet taken place, a variable is considered to be uninitialized. Initialization ensures that variables have valid values when expressions are evaluated. Uninitialized variables are unassigned variables. If a program attempts to read from an unassigned variable, the compiler will generate an error.

12. How are the prefix and postfix increment and decrement operators evaluated differently?
Prefix are before, postfix are after. Pg 55

13. What is string interpolation? string interpolation (or variable interpolation, variable substitution, or variable expansion) is the process of evaluating a string literal containing one or more placeholders, yielding a result in which the placeholders are replaced with their corresponding values. Pg 46

14. What does the var keyword do?
 Var can only be used when a local variable is declared and initialized in the same statement; the variable cannot be initialized to null, or to a method group or an anonymous function. var cannot be used on fields at class scope. Variables declared by using var cannot be used in the initialization expression.
