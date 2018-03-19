## Oscar Brown
## 3/18/2018
## chapter 9, pages 201 – 219

1. Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols,
like Private, PFD, Corporal, or 1stLt, 2ndLt, Capt?
enum OfficerRanks { 2LT, 1LT, CPT, MAJ, LTC, COL, BG, MG, LG, GEN, GA}

2. Using the Ranks enum, assign a rank to yourself or a friend.
enum OfficerRanks { 2LT, 1LT, CPT, MAJ, LTC, COL, BG, MG, LG, GEN, GA}

OfficerRanks Oscar = OfficerRanks.CPT;
Console.WriteLine(Oscar);

3. Determine the numeric index of particular ranks, using the Ranks enum. 
enum OfficerRanks { 2LT, 1LT, CPT, MAJ, LTC, COL, BG, MG, LG, GEN, GA}

OfficerRanks Oscar = OfficerRanks.CPT;
Console.WriteLine((int)Oscar); // write 2

4. How do you select the type of an enum?
You select the type base on the amount of memory you need to use. ex. enum OfficerRanks : short { 2LT, 1LT, CPT, MAJ, LTC, COL, BG, MG, LG, GEN, GA}
Short takes up less memory then int. You would base the enumeration on any of the 8 types: byte, sbyte, short, ushort, int, uint, long, ulong.

5. Are structs stored on the stack or on the heap? What about enums?
Structs are stored on the stack. enums are stored in the stack.

6. Declare a struct named DOD with four branches.
Struct DoD
{
  private int Army, Marines, Navy, AirForce;
}

7. Why can’t you create a default constructor for a struct? pg 209
Reason is the compiler always generates a default constructor. However, the compiler generates the default constructor only if you don't write a constructor yourself.

8. What is CIL? What does the CLR do to the CIL?
Common Intermediate Language (CIL) is an object-oriented assembly language, and is entirely stack-based. Its bytecode is translated into native code or—most commonly—executed by a virtual machine. CIL was originally known as Microsoft Intermediate Language (MSIL) during the beta releases of the .NET languages.
The Common Language Runtime translates it into machine code and executes the CIL.
