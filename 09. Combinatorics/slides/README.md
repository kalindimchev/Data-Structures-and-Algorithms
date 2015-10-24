<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Combinatorics
- Brief Overview of Combinations, Permutations and Binary Vectors
- Data Structures and Algorithms
- Telerik Software Academy
- http://academy.telerik.com 


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Table of Contents
- Definitions in Combinatorics
- Permutations
- Combinations
- Pascal's Triangle
- Binary Vectors
- Resources
- 2


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Definitions in Combinatorics


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Combinatorics
- Combinatorics is a branch of mathematics
- Concerning the study of finite or countable discrete structures
- Combinatorial problems arise inmany areas of pure mathematics
- Notably in algebra, probabilitytheory, topology, geometry,physics, chemistry, biology, etc.


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Combinations
- "My fruit salad is a combination of grapes, strawberries and bananas" 
- We don't care what orderthe fruits are in
- "bananas, grapesand strawberries" or"grapes, bananas andstrawberries"  it isthe same salad
- If the order doesn't matter, it is a combination
- 5


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Permutations / Variations
- "The combination to the safe is 4385".
- Now we do care about the order
- "8453" would not work,nor would "4538"
- It has to be exactly 4-3-8-5
- If the order does matter it is a permutation / variation
- A permutation / variation is an ordered Combination
- Easy to remember: "Permutation ... Position"
- 6


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Factorial
- The factorial function (!) just means to multiply a series of descending natural numbers
- n! = n × (n-1)!
- 1! = 1, 0! = 1
- 4! = 4 × 3 × 2 × 1 = 24
- 7! = 7 × 6 × 5 × 4 × 3 × 2 × 1 = 5040
- 7


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Factorial - Source code
- Factorial – iterative
- static long Factorial(int n)
- {
-     long result = 1;
-     for(int i = 2; i <= n; i++)
-         result = result * i;
-     return result;
- }
- Factorial – recursive
- static long Factorial(int n)
- {
-     if (n == 0) return 1;
-     return Factorial(n - 1) * n;
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Variations


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Variations
- Variations (with repetitions)
- Easiest to calculate
- When you have n things tochoose from ... you haven choices each time!
- When choosing k of them,the variations are:
- n × n × ... × n (k times)
- 	       nk
- 10


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Variations (2)
- Example: in the lock below, there are 10 numbers to choose from (0, 1, … 9) and you choose 3 of them:
- 10 × 10 × 10 (3 times) = 103 = 1 000 variations
- All variations from (0, 0, 0) to (9, 9, 9) 
- 11


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Generating Variations
- static void Main()
- {
-   GenerateVariations(0);
- }
- static void GenerateVariations(int index)
- {
-   if (index >= k)
-     Print(arr);
-   else
-     for (int i = 0; i < n; i++)
-     {
-       arr[index] = i;
-       GenerateVariations(index + 1);
-     }
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Variations with Repetitions
- Live Demo


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Variations without Repetition
- Suppose we have 16 billiard balls
- But maybe you don't want to choose them all, just 3 of them, so that would be only
- 16 × 15 × 14 = 3360
- There are 3360 different ways that 3 pool balls could be selected out of 16 balls
- 16! / 13! = 16 × 15 × 14
-       
-  
- 14
- where n is the number of things to choose from, and you choose k of them(No repetition, order matters) 


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Variations without Repetition
- Example: 
- How many words of 2 different letters can you make with 4 letters { a, b, c, d }?
- How to generate variationswithout repetitions?
- The same way like variations with repetitions
- Just use each element at most once
- 15
- ab, ac, ad, ba, bc, bd, ca, cb, cd, da, db, dc


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Generating Variationswithout Repetitions
- static void GenerateVariationsNoReps(int index)
- {
-   if (index >= k)
-     PrintVariations();
-   else
-     for (int i = 0; i < n; i++)
-       if (!used[i])
-       {
-         used[i] = true;
-         arr[index] = i;
-         GenerateVariationsNoReps(index + 1);
-         used[i] = false;
-       }
- }
- GenerateVariationsNoReps(0);


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Variations without Repetitions
- Live Demo


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Permutations


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Permutations
- Less number of available choices each time
- What order could16 pool balls be in?
- After choosing, ball 9we can't choose the same ball again
- First choice  = 16 possibilities
- Second choice = 15 possibilities, etc., etc.
- Total permutations:
- 16 × 15 × 14 ×...× 2 × 1 = 16! = 20 922 789 888 000
- 19


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Generating Permutations
- static void Perm<T>(T[] arr, int k)
- {
-   if (k >= arr.Length)
-     Print(arr);
-   else
-   {
-     Perm(arr, k + 1);
-     for (int i = k + 1; i < arr.Length; i++)
-     {
-       Swap(ref arr[k], ref arr[i]);
-       Perm(arr, k + 1);
-       Swap(ref arr[k], ref arr[i]);
-     }
-   }
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Generating Permutations
- Live Demo


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Permutations with Repetitions
- We have a set of elements, with repetitions
- E. g. set = { 3, 5, 1, 5, 5 }
- We want to generate all unique permutations (without duplicates):
- { 1, 3, 5, 5, 5 }   { 1, 5, 3, 5, 5 }   { 1, 5, 5, 3, 5 }   { 1, 5, 5, 5, 3 }
- { 3, 1, 5, 5, 5 }   { 3, 5, 1, 5, 5 }   { 3, 5, 5, 1, 5 }   { 3, 5, 5, 5, 1 }
- { 5, 1, 3, 5, 5 }   { 5, 1, 5, 3, 5 }   { 5, 1, 5, 5, 3 }   { 5, 3, 1, 5, 5 }
- { 5, 3, 5, 1, 5 }   { 5, 3, 5, 5, 1 }   { 5, 5, 1, 3, 5 }   { 5, 5, 1, 5, 3 }
- { 5, 5, 3, 1, 5 }   { 5, 5, 3, 5, 1 }   { 5, 5, 5, 1, 3 }   { 5, 5, 5, 3, 1 }
- We want to efficiently avoid the repeating ones, i.e. to work fast for { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5}
- 22


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Generating Permutationswith Repetitions
- var arr = new int[] { 3, 5, 1, 5, 5 };
- Array.Sort(arr);
- PermuteRep(arr, 0, arr.Length);
- static void PermuteRep(int[] arr, int start, int n)
- {
-   Print(arr);
-   for (int left = n - 2; left >= start; left--)
-   {
-     for (int right = left + 1; right < n; right++)
-       if (arr[left] != arr[right])
-       {
-         Swap(ref arr[left], ref arr[right]);
-         PermuteRep(arr, left + 1, n);
-       }
-     var firstElement = arr[left];
-     for (int i = left; i < n - 1; i++)
-       arr[i] = arr[i + 1];
-     arr[n - 1] = firstElement;
-   }
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Generating Permutationswith Repetitions
- Live Demo


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Combinations


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Combinations
- Order does not matter!
- Two types of combinations:
- Repetition is allowed
- Coins in your pocket
- 5,5,20,20,20,10,10
- No repetition
- Lottery numbers
- TOTO 6/49, 6/42, 5/35
- 2,14,15,27,30,33
- 26


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Combinations without Repetition
- Back to the 3 of 16 billiard balls
- Many comb. will be the same
- We don't care about the order
- Permutations w/o repetitionsreduced by how many ways the objects could be in order:
- This is how lotteries work (TOTO 6/49)
- Often called "n choose k" (Google it!)
- 27
- Order does
- matter
- Order doesn't matter
- 1 2 31 3 22 1 32 3 13 1 23 2 1
- 1 2 3
-  


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# 28
- Generate Combinationswithout Repetitions
- static void Main()
- {
-   Comb(0, 0);
- }
- static void Comb(int index, int start)
- {
-   if (index >= k)
-     PrintCombinations();
-   else
-     for (int i = start; i < n; i++)
-     {
-       arr[index] = i;
-       Comb(index + 1, i + 1);
-     }
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Combinationswithout Repetitions
- Live Demo


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Pascal's Triangle
- The Pascal's triangle shows you how many combinations of objects withoutrepetition are possible
- Go down to row "n" (the top row is 0)
- Move along "k" places
- The value there is your answer
- Build the triangle: start with "1" atthe top, then continue placingnumbers below it in a triangular pattern
- 30
-  


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Pascal's Triangle's (2)
- The triangle is symmetrical
- Numbers on the left side haveidentical matching numbers onthe right side, like a mirror image
- Diagonals:
- First diagonal – only “1”s
- Second diagonal – 1, 2, 3, etc.
- Third diagonal – triangular numbers
- Horizontal sums: powers of 2
- 31


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Binomial Coefficients
- Calculate using recursion:
- static decimal Binom(int n, int k) 
- {  if (k > n) return 0;
-    else if (0 == k || k == n) return 1;
-    else return Binom(n-1, k-1) + Binom(n-1, k);
- }
-  
- Calculate using dynamic programming:
- decimal m[MAX], i, j;
- for (i = 0; i <= n; i++) {
-    m[i] = 1;
-    if (i > 1) {
-       if (k < i - 1) j = k; else j = i - 1;
-       for (; j >= 1; j--) m[j] += m[j - 1];
-    }
- } // The answer is in m[k]


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Combinations with Repetition
- Ice-cream example
- 5 flavors of ice-cream: banana,chocolate, lemon, strawberry and vanilla
- 3 scoops
- How many combinations will there be?
- Let's use letters for the flavors: {b, c, l, s, v}
- {c, c, c} (3 scoops of chocolate)
- {b, l, v} (one each of banana, lemon and vanilla)
- {b, v, v} (one of banana, two of vanilla)
- 33


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Combinations with Repetition
- Ice-cream example
- n=5 things to choose from, choose k=3 of them
- Order does not matter, and we can repeat
- Think about the ice cream being in boxes
- arrow means move, circle means scoop
- {c, c, c} (3 scoops of chocolate)
- {b, l, v} (banana, lemon, vanilla)
- {b, v, v} (banana, two of vanilla)
- 34


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Combinations with Repetition
- We have a simpler problem to solve
- How many different ways can you arrange arrows and circles?
- 3 circles (3 scoops) and 4 arrows (we need to move 4 times to go from the 1st to 5th container)
- There are k + (n-1) positions, and we want to choose k of them to have circles
- 35
-  


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# 36
- Generate Combinationswith Repetitions
- static void Main()
- {
-   Comb(0, 0);
- }
- static void CombReps(int index, int start)
- {
-   if (index >= k)
-     PrintVariations();
-   else
-     for (int i = start; i < n; i++)
-     {
-       arr[index] = i;
-       CombReps(index + 1, i);
-     }
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Generating Combinationswith Repetitions
- Live Demo


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Combinatorial Formulas
- Calculating the number of permutations, variations, combinations
- Use the well known formulas:
- 38
- Source: http://users.telenet.be/vdmoortel/dirk/Maths/PermVarComb.html


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Binary Vectors


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Binary Vectors
- Some problems can be reformulated in terms of binary vectors – (1, 0, 1, 1, 1, 0, …)
- Combinatorial properties of binary vectors:
- Number of binary vectors of length n: 2n.
- Number of binary vectors of length n and with k `1` is C(n, k) (we choose k positions for n `1`)


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Gray Code
- Gray code (a.k.a. reflectedbinary code) is a binary numeralsystem where two successivevalues differ by only one bit
- 41
- Gray code by bit width
- 2-bit
- 4-bit
- 00011110
- 0000000100110010011001110101010011001101111111101010101110011000
- 3-bit
- 000001011010110111101100
- Decimal
- Gray
- Binary
- 0
- 000
- 000
- 1
- 001
- 001
- 2
- 011
- 010
- 3
- 010
- 011
- 4
- 110
- 100
- 5
- 111
- 101
- 6
- 101
- 110
- 7
- 100
- 111


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Gray Code – Source Code 
- static int n = 4, a[1000], i;
- static void Print()
- {  for (i = n; i >= 1; i--) Console.Write("{0} ", a[i]);
-    Console.WriteLine();
- }
- static void Backgray(int k)
- {  if (0 == k) { Print(); return; }
-    a[k] = 1;  Forwgray(k - 1);
-    a[k] = 0;  Backgray(k - 1);
- }
- static void Forwgray(int k)
- {  if (0 == k) { Print(); return; }
-    a[k] = 0;  Forwgray(k - 1);
-    a[k] = 1;  Backgray(k - 1);
- }
- static int Main() { Forwgray(n); return 0; }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Gray Code
- Live Demo


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Resources
- Video lectures (in Bulgarian)
- http://cs.maycamp.com/?page_id=685
- http://cs.maycamp.com/?page_id=760
- http://cs.maycamp.com/?page_id=764
- TopCoder article: http://goo.gl/bN9RL
- http://en.wikipedia.org/wiki/Permutation
- http://en.wikipedia.org/wiki/Combination
- Book: http://goo.gl/Z2Knl
- Nakov’s book: Programming = ++Algorithms;
- 44


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Combinatorics
- http://algoacademy.telerik.com


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Exercises
- Solve 2 problems by choice from Algo Academy (October 2012 – Combinatorics): http://academy.telerik.com/algoacademy/season-2012-2013/training-27-28-Oct-2012-combinatorics
- You may test your solutions in BG Coder: http://bgcoder.com/Contest/Practice/59
- 46


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Free Trainings @ Telerik Academy
- C# Programming @ Telerik Academy
- csharpfundamentals.telerik.com
- Telerik Software Academy
- academy.telerik.com
- Telerik Academy @ Facebook
- facebook.com/TelerikAcademy
- Telerik Software Academy Forums
- forums.academy.telerik.com


