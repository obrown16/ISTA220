## Oscar Brown
## 4/01/2018
## Read chapter 13, pages 277 – 293 in the C# Step by Step book.

1. What is an interface as the term is used on object-oriented programming?
A collection of objects and methods. Specifies the methods and properties that a class that inherits from the interface must provide. It is actually a concept of abstraction and encapsulation. For a given "box", it declares the "inputs" and "outputs" of that box. In the world of software, that usually means the operations that can be invoked on the box (along with arguments) and in some cases the return types of these operations.

2. How do you define an interface?
Write interface, give it a name, and give it a method with implementation. a contract/aggreement between 2 people providing a specific services and has specified functionalities. 


3. Can an interface have variables, fields, or properties?
No, an interface cannot contain any data. You cannot add fields (not even private ones to an interface).

4. How do you define a method in an interface? 
You'd use a semicolon 

5. Can you instantiate an object through an interface? Why or why not?
Yes. you use dependency injection which means you remove the hard coded dependancy and replace it with an interface.

6. Using the new keyword, can you declare a reference to an interface?
Yes

7. Can an object inherit from multiple interfaces? Can a class implement multiple interfaces? If so, how
can it do so? C# doesn't have multiple inheritance but you do have multiple interfaces. Yes a class ca implement mulitple interfaces


8. What does it mean to explicitely implement an interface?
means to clearly specify which interface a method belongs to when you implement it.

9. What are the restrictions on interfaces? pg 284
Since an inerface never contains any implementation. You are not allowed to declare fields in an interface, define any constructors, define a destructor, specify an access modifier for any method, nest any types inside the interface and not allowed to inherit from a structure  or a class.

10. What is the difference between an abstract class and an interface?
An interface is not a class. The main difference between them is that a class can implement more than one interface but can only inherit from one abstract class. 

11. What is an abstract method?
An abstract method is a method that is declared, but contains no implementation. Abstract classes may not be instantiated, and require subclasses to provide implementations for the abstract methods.

12. What is an sealed class?
Using the sealed keyword to prevent a class from being used as a base class if you decide that it should not. Cannot be inherited from.

13. What is an sealed method?
Is the last implementation of a method. Using the sealed keyword to declare that an individual method in an unsealed class is sealed. This means that a derived class cannot override this method.