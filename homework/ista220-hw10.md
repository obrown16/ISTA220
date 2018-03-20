## Oscar Brown
## 3/19/2018
## chapter 10, pages 221 – 242

1. What does an array look like in memory?
An array lives in a contiguous block of memory and are accessed by using an index, unlike field of structure or class, which are accessed by name.

2. Where is memory allocated to hold an array, on the stack or on the heap?
Memory is allocated on the HEAP. On the stack is a memory address also known as a reference that refers to a pointer on the heap where the array is.

3. Where is memory allocated to hold an array reference, on the stack or on the heap?
STACK

4. Can an array hold values of different types? This is a trick question, the answer is, “It depends.”
Book says no. But yes, because it depends on how memory is allocated. Depends on if the type is numeric or a bool.

5. Describe the syntax of the condition or a for each loop.
The keyword type in. first is iteration variable, in which goes before each, last is the array.

6. How do you make a deep copy of a array?
Create a new array instance of the same type and the same length as the array you are copying. Then you copy the data from the original array element to the new array.

7. What is the difference between a multi-dimensional array and an array of arrays?
multi-dimensional is like a table. Array of Arrays list of arrays sometimes of different sizes.

8. How do you “flatten” a multidimensional array? In other words, take something that looks like a
matrix

   1 2 3
[  4 5 6  ]
   7 8 9

   and turn it into an array [1, 2, 3, 4, 5, 6, 7, 8, 9]?
   
   for (int i = 0; i < 3; i++)
     for(int j = 0; j< 3, j++)
	 
	 arr2 [(i * 3) + j] = arr [i,j]
   

