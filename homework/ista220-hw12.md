## Oscar Brown
## 3/19/2018
## Read chapter 12, pages 255 – 276 in the C# Step by Step book.

1. How does inheritance promote the principle of don’t repeat yourself (DRY)?
Instead of duplicating methods with the same functions to classes use inheritance which allows you to create a class that hold the same functionalities but you 
The second time you write identical code you stop and change it on the one method or sub procedure that you can call just once.

2. What is the syntax of a derived class that inherits from a base class?
class DerivedClass : BaseClass

3. Do all user defined types (classes and structs) inherit from some base class? If so, what is it?
Yes, System.Object

4. What happens if you do not have a default constructor in a base class when creating a derived class?
There will be a compile time error. You'd have a default constructor.

5. Can you assign a variable of a derived class to another variable of its base class? Why or why not?
Yes. 

6. Can you assign a variable of a derived class to another variable of a derived class of its base class?
Why or why not?

7. Can you assign a variable of a base class to another variable of a derived class? Why or why not?
To silence

8. Under what circumstances would you want to use the new keyword when defining a method in a
derived class? 

9. What is a virtual method? Why would you want to define a virtual method?
If you want to hide the way in which a method is implemented in a base class.

10. What does override do? Why does it do it?
Provide a new implementation of a base method. Override it because it performing

11. How do you define an extension type?
Define a static class to contain the extension method by using the 'this' keyword in front of the type. The class must be visible to client code.

12. Why do you define an extension type?
So that it applies to all the type variables within your code.