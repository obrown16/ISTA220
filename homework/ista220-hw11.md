## Oscar Brown
## 3/19/2018
## Read chapter 11, pages 243 – 254 in the C# Step by Step book.

## Answer the discussion questions in writing.

1. How do you define a method that takes an arbitrary number of arguments?
use the params keyword: void Method(params int[] a)

2. How do you call a method that takes an arbitrary number of arguments?
 You just use the method. Insert any number of arguments into the parenthesis: Method(a,b,c,...,n);
 
3. Why can’t you use an array to pass an arbitrary number of arguments to a method?
You can. The params keyword doesn't work on multidimensional arrays and that is what you would make.

4. How many parameters can a method have?
Depends on the method which has to have a specific number of arguments. A method can have as many parameters as needed for the method.

5. Do parameter arguments have to have the same type?
No they don't. 

6. What is the difference between a method that takes a parameter argument and one that takes optional
arguments?
If you use optional you are limited to amount of parameter you wrote that method for.

7. How do you define a method that takes different (and arbitrary) types of arguments?
with Method(object[])
