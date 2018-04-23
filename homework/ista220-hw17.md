## Oscar Brown
## 4/15/2018
## Read chapter 17, pages 369 – 398 in the C# Step by Step book

1. What is a type parameter?
It's a placeholder

2. What does a type parameter do?
improves usability, type safety.

3. How many type parameters can a generic class have?
multiple. but mostly you just see one type parameter

4. What is the difference between a generic class and a generalized class?
generic calsses uses type parameters. generalized classes ares designed to take parameters that can be cast to different types.

5. What is a constraint? How do you specify a constraint?
A constraint is used to limit the type parameters of a generic class to those that iplement a particular set of interfaces and therefore provide the methods defied by those interfaces. 
Use a where.

6. What is a generic method? How do you define a generic method? pg 389
a method that is declared with type parameters. using the generic Swap<T> method 

7. What do we mean when we cay that a generic type interface is invariant?


8. What do we mean when we cay that a generic type interface is covariant?


9. Does covariance work with value types? Does it work with reference types?


10. What do we mean when we say that a generic type interface is contravariant?