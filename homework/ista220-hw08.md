## Oscar Brown
## 3/12/2018
## Chapter 8, pages 177 – 199 

1. What is the difference between deep copy and shallow copy? 
deep Would have to copy the binary behind the actual code. Shallow is when you copy the reference or memory address instead of the value.

2. What is the value of a reference after you declare and initialize it?
What you initialized it to. An address pointing to a location in memory.

3. How do you declare a value type?
Assign it a primitive data type. 

4. How do you declare a reference type?
Create a new instance of the object. Use the keyword new as a constructor.

5. Does C# allow you to assign NULL to a value type?
No, null is not a value type.

6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?
No, you cannot assign a nullable variable to an ordinary value type variable. A nullable variable may contain null which would give you a compile error.
 
7. What is the difference between the stack and the heap?
Stack is reference type. Heap is value type. Stack organized memory and Heap is unorganized memory.

8. What does it mean when we say that all classes are specialized types?
Classes can refer to any kind of reference type.

9. What does ref do?
Ref passes the referenced data in two way to the actual reference point and back.

10. What does out do?
Out only send the data from the end point back to the reference point and discards initial data sent from the reference point.

11. Describe boxing and unboxing in your own words.
When an object refers to a variable. boxing converting a primitive datatype on the stack to a reference data type on heap. Unboxing converting it back to a location on the stack.

12. What does cast do?
Attempt to convert one datatype to another. cast an int as a float but you can't change a float 10.0 and change to an int.



