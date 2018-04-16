## Oscar Brown
## 4/01/2018
## Read chapter 14, pages 305 – 328 in the C# Step by Step book

Answer the discussion questions in writing.
1. What is the difference between a managed resource and an unmanaged resource?
manage controled by CLR which handles the details. unmanaged the user can manipulate, and don't target the CLR directly.

2. When is memory for an object (reference type) allocated? When is the memory deallocated?
When you create variables and objects. value types are created on the stack, and reference types are allocated memory from the heap. When the reference count is 0 it is deallocated and cannot recover.

3. What is a destructor?
is a special method that the CLR calls after the reference to an object has disappeared. Reclaims

4. What is the difference in syntax between a constructor and a destructor?
Difference in syntax is a tilde (~) in front of the destructor.

5. Give some examples of scarce resources. Why would you want to manage scarce resources?
memory, database connections, or file handles ares scares resources. So your computer doesn't crash

6. What is exception-safe disposal?
When the disposal method is called even if there was an exception, and is used it in the finally block.

7. How do you think that the using statement works for resource management? Give an informal, English language, explanation of how it works.
disposes all resources inside the using block as soon as the using block ends. using syntax (pg 313)

8. What ill effects could result from attempting to dispose of a resource more than once?
An exceptions error

9. We will look at threads later in the term. For now, what is your understanding of how threads interact with resource management? A good guess is a siufficient answer to this question.


10. Why does the book recommend not attempting to force the garbage collector? Are their any exceptions to this recommendation?
Most don't know what the compiler is doing.
