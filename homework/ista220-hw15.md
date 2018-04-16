## Oscar Brown
## 4/01/2018
## Read chapter 15, pages 329 – 352 in the C# Step by Step book.

1. What is the difference between a property and a field?
Fields are ordinary member variables or member instances of a class. Properties are an abstraction to get and set their values. Properties are also called accessors because they offer a way to change and retrieve a field if you expose a field in the class as private
Property looks like a field.

2. What is the difference between a property and a method?
methods represent actions and properties represent data

3. What is your understanding of encapsulation?
 object's ability to hide data and behavior that are not necessary to its user. 
 ex. car encapsulates certain behaviors. User don't really need to know how it works, just how to use it.
 
4. Some languages are case insensitive, that is, an ‘a” and an “A” are considered to be the same letter.
C# is case sensitive. What implications does this have regarding the naming of variables, methods,
and other identifiers? Do you think that the difference in case in the initial character of two different
identifiers is sufficient to distinguish them¿


5. Give an example that is not in the book of an instance where you might want to use a read-only
property. Give an example not in the book of an instance where you might want to use s write-only
property. 
A business method that increments count.

6. Can you think of a reason why you might ever want to make getters and setters private? Give an
example. Also, make a case why getters and setters should never be private. Can only be usable within the class.
Should never be private because it should allows you to make changes in order to use app in the same way you would.

7. What are restrictions on the use of properties?pg 336
You can assign a value through a property of a structure or class only after the structure or class has been initialized. You can't use a property as a fref or an out argument to a method. A property cannot contain other methods, fields, or properties. The get and set accessors cannot take any parameters.

8. What is an object initializer? What is the syntax for an object initializer?
Object initializers allow you to assign values to the fields or properties at the time of creating an object without invoking a constructor.
Student std = new Student() { StudentID = 1, 
                                      StudentName = "Bill", 
                                      Age = 20, 
                                      Address = "New York"   
                                    };