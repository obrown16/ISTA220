Oscar Brown
02/20/2018


Homework 01, ISTA-220
Chapter 01, C# Step by Step
Homework
Readings
Read chapter 1, pages 3 { 32 in the C# Step by Step book.
Discussion Questions

Answer the discussion questions in writing for chapter 1.
1. What is a console app?
Is the name of another class provided by the assemblies referenced by your application. It Provides method for displaying messages in the console window and reading input from the keyboard.an application that runs in a command prompt Pg 8

2. What does Main() (the main method) do in a console application?
Designates the program’s entry point. Should be defined in the manner specified in the Program class as static method; otherwise, the .NET Framework might not recognize it as the starting point for your application when you run it. 

3. What is the purpose of a namespace?
Helps solve name-clashing problems by creating a container for items such as classes. Ex. Create class named Greeting inside the namespace named TestHello by using namespace keyword: 

Namespace TestHello
{
Class Greeting
{
	Class Greeting
	{
	   …
	}
}

4. Describe specifically what using statements do.
interface provides the Dispose method, which should release the object's resources. In other words, the using statement tells .NET to release the object specified in the using block once it is no longer needed. The using statement is used to work with an object in C# that implements the IDisposable interface.(opening the package(namespace) and organizing on a shelf for easy access)

5. What is an assembly? A file that has a database of classes that is partitioned. Has DLL files in extension. (Block of compiled codes/ has all the ones and zeros)

6. What is the relationship between an assembly and a namespace? There is no relationship. An assembly can have a group of namespace. A namespace can have multiple assembly function.

7. What is a graphical app? An app with a user interface. Create a button and has a function.

8. What is the starting point in a graphical application? Pg 27 app.xaml

9. What does Build do? Compiles the C# code and turns it into an executable.

10. What does Debug do?  Shows any errors. Where and in what address space. Bug goes through the code line by line looking for error.