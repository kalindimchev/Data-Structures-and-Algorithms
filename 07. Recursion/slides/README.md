<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Recursion
##  The Power of the Recursive Algorithms
* Data Structures and Algorithms
* Telerik Software Academy
* http://academy.telerik.com 

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Table of Contents
* What is Recursion?
* Calculating Factorial Recursively
* Generating All 0/1 Vectors Recursively
* Finding All Paths in a Labyrinth Recursively
* Recursion or Iteration?
  * Harmful Recursion
  * Optimizing Bad Recursion

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# What is Recursion?
* `Recursion` is when a methods calls itself
  * Very powerful technique for implementing combinatorial and other algorithms
* Recursion should have
  * `Direct` or `indirect` recursive call
    * The method calls itself directly
    * Оr through other methods
  * Exit criteria (`bottom`)
    * Prevents infinite recursion

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Recursive Factorial – Example
* Recursive definition of `n!` (`n factorial`):

```cs
n! = n x (n–1)! for n >= 0
0! = 1
```
  * 5! = 5 x 4! = 5 x 4 x 3 x 2 x 1 x 1 = 120
  * 4! = 4 x 3! = 4 x 3 x 2 x 1 x 1 = 24
  * 3! = 3 x 2! = 3 x 2 x 1 x 1 = 6
  * 2! = 2 x 1! = 2 x 1 x 1 = 2
  * 1! = 1 x 0! = 1 x 1 = 1
  * 0! = 1

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Recursive Factorial – Example
* Calculating factorial:
  * 0! = 1
  * n! = nx (n-1)!, n>0
* Don't try this at home!
  * Use iteration instead

```cs
static decimal Factorial(decimal num){    if (num == 0) 
        return 1;     else
        return num x Factorial(num - 1); } 
```
<div class="fragment balloon">The bottom of the recursion</div>
<div class="fragment balloon">Recursive call: the method calls itself</div>

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Recursive Factorial
##  [Demo]()

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Generating 0/1 Vectors
* How to generate all 8-bit vectors recursively?
    * 00000000
    * 00000001
    * ...
    * 01111111
    * 10000000
    * ...
    * 11111110
    * 11111111
* How to generate all n-bit vectors?

<!-- attr: { showInPresentation:true, style:'' } -->
# Generating 0/1 Vectors (2)
* Algorithm `Gen01(n)`: put 0 and 1 at the last position `n` and call `Gen01(n-1)` for the rest:
* Gen01(6):
* Gen01(5)
* Gen01(5)
* Gen01(5):
* Gen01(4)
* Gen01(4)

```cs
...
Gen01(-1) &rarr; Stop!
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Generating 0/1 Vectors (3)

```cs
static void Gen01(int index, int[] vector)
{
   if (index == -1)
      Print(vector);
   else
      for (int i=0; i<=1; i++)
      {
         vector[index] = i;
         Gen01(index-1, vector);
      }
}
static void Main()
{
   int size = 8;
   int[] vector = new int[size];
   Gen01(size-1, vector);
}
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Generating 0/1 Vectors
##  [Demo]()

<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Generating Combinations
##  Simple Recursive Algorithm

<!-- attr: { showInPresentation:true, style:'' } -->
# Generating Combinations
* Combinations are give the ways to select a subset of larger set of elements
  * Select `k` members from a set of `n` elements
  * Example: there are 10 ways to select 3 different elements from the set {4, 5, 6, 7, 8}:
  * (4, 5, 6)	(4, 5, 7)	(4, 5, 8)	(4, 6, 7)	(4, 6, 8)
  * (4, 7, 8)	(5, 6, 7)	(5, 6, 8)	(5, 7, 8)	(6, 7, 8)
* Combinations with and without repetitions can be easily generated with `recursion`

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Generating Combinations (2)
* Algorithm `GenCombs(k)`: put the numbers [1..n] at position `k` the and call `GenCombs(k+1)` recursively for the rest of the elements:
* GenCombs(0):
* GenCombs(1)

```cs
...
GenCombs(n) &rarr; Stop!
```
<div class="fragment balloon">Put all numbers in range [1..n] at position k</div>
* GenCombs(1):
* GenCombs(2)
<div class="fragment balloon">Put all numbers in range [1..n] at position k</div>

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Generating Combinations
##  [Demo]()

<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Backtracking
##  Solving Computational Problemsby Generating All Candidates

<!-- attr: { showInPresentation:true, style:'' } -->
# Backtracking
* What is `backtracking`?
  * Backtracking is a class of algorithms for finding all solutions to some computational problem
  * E.g. find all paths from Sofia to Varna
* How does backtracking work?
  * Usually implemented recursively
  * At each step we try all perspective possibilities to generate a solution
* Backtracking has exponential running time!

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# The 8 Queens Problem
* Write a program to find all possible placements of 8 queens on a chessboard
  * So that no two queens attack each other
  * http://en.wikipedia.org/wiki/Eight_queens_puzzle

<!-- attr: { showInPresentation:true, style:'' } -->
# Solving The 8 Queens Problem
* Backtracking algorithm for finding all solutions to the "8 Queens Puzzle"

```cs
static void PutQueens(int count)
{
  if (count > 8)
    PrintSolution();
  else
    for (row = 0; row < 8; row++)
      for (col = 0; col < 8; col++)
        if (CanPlaceQueen(row, col))
        {
          MarkAllAttackedPositions(row, cow);
          PutQueens(count + 1);
          UnmarkAllAttackedPositions(row, cow);
        }
}
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Finding All Paths in a Labyrinth
* We are given a labyrinth
  * Represented as matrix of cells of size M x N
  * Empty cells are passable, the others (x) are not
* We start from the top left corner and can move in the all 4 directions: left, right, up, down
* We need to find all paths to the bottom right corner
<div class="fragment balloon">Start position</div>
<div class="fragment balloon">End position</div>

<!-- attr: { showInPresentation:true, style:'' } -->
# Finding All Paths in a Labyrinth (2)
* There are 3 different paths from the top left corner to the bottom right corner:
* 1)
* 2)
* 3)

<!-- attr: { showInPresentation:true, style:'' } -->
# Finding All Paths in a Labyrinth (3)
* Suppose we have an algorithm `FindExit(x,y)` that finds and prints all paths to the exit (bottom right corner) starting from position `(x,y)`
* If `(x,y)` is not passable, no paths are found
* If `(x,y)` is already visited, no paths are found
* Otherwise:
  * Mark position `(x,y)` as visited (to avoid cycles)
  * Find recursively all paths to the exit from all neighbor cells: `(x-1,y)` ,` (x+1,y)` ,` (x,y+1)` ,` (x,y-1)`
  * Mark position `(x,y)` as free (can be visited again)

<!-- attr: { showInPresentation:true, style:'' } -->
# Find All Paths: Algorithm
* Representing the labyrinth as matrix of characters (in this example 5 rows and 7 columns):
  * Spaces ('` `') are passable cells
  * Asterisks ('`x`') are  not passable cells
  * The symbol '`e`' is the exit (can occur multiple times)

```cs
static char[,] lab = 
{
    {' ', ' ', ' ', 'x', ' ', ' ', ' '},
    {'x', 'x', ' ', 'x', ' ', 'x', ' '},
    {' ', ' ', ' ', ' ', ' ', ' ', ' '},
    {' ', 'x', 'x', 'x', 'x', 'x', ' '},
    {' ', ' ', ' ', ' ', ' ', ' ', 'е'},
};
```

<!-- attr: { showInPresentation:true, style:'' } -->
# Find All Paths: Algorithm (2)

```cs
static void FindExit(int row, int col)
{
    if ((col < 0) || (row < 0) || (col >= lab.GetLength(1))
        || (row >= lab.GetLength(0)))
    {
        // We are out of the labyrinth -> can't find a path
        return;
    }
    // Check if we have found the exit
    if (lab[row, col] == 'е') 
    {
        Console.WriteLine("Found the exit!");
    }
    if (lab[row, col] != ' ')
    {
        // The current cell is not free -> can't find a path
        return;
    }
(example continues)
```

<!-- attr: { showInPresentation:true, style:'' } -->
# Find All Paths: Algorithm (3)

```cs
    // Temporary mark the current cell as visited
    lab[row, col] = 's';
    // Invoke recursion to explore all possible directions
    FindExit(row, col-1); // left
    FindExit(row-1, col); // up
    FindExit(row, col+1); // right
    FindExit(row+1, col); // down
    // Mark back the current cell as free
    lab[row, col] = ' ';
}
static void Main()
{
    FindExit(0, 0);
}
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Find All Paths in a Labyrinth
##  [Demo]()

<!-- attr: { showInPresentation:true, style:'' } -->
# Find All Paths and Print Them
* How to print all paths found by our recursive algorithm?
  * Each move's direction can be stored in a list
  * Need to pass the movement direction at each recursive call (L, R, U, or D)
  * At the start of each recursive call the current direction is appended to the list
  * At the end of each recursive call the last direction is removed from the list

```cs
static List<char> path = new List<char>();
```

<!-- attr: { showInPresentation:true, style:'' } -->
# Find All Paths and Print Them (2)

```cs
static void FindPathToExit(int row, int col, char direction)
{
    ...
    // Append the current direction to the path
    path.Add(direction);
    if (lab[row, col] == 'е')
    {
        // The exit is found -> print the current path
    }
    ...
    // Recursively explore all possible directions
    FindPathToExit(row, col - 1, 'L'); // left
    FindPathToExit(row - 1, col, 'U'); // up
    FindPathToExit(row, col + 1, 'R'); // right
    FindPathToExit(row + 1, col, 'D'); // down
    ...
    // Remove the last direction from the path
    path.RemoveAt(path.Count-1);
}
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Find and Print All Paths in a Labyrinth
##  [Demo]()

<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Recursion or Iteration?
##  When to Use and When to Avoid Recursion?

<!-- attr: { showInPresentation:true, style:'' } -->
# Recursion Can be Harmful!
* When used incorrectly the recursion could take too much memory and computing power
* Example:

```cs
static decimal Fibonacci(int n)
{
    if ((n == 1) || (n == 2))
        return 1;
    else
        return Fibonacci(n - 1) + Fibonacci(n - 2);
}
static void Main()
{
    Console.WriteLine(Fibonacci(10)); // 89
    Console.WriteLine(Fibonacci(50)); // This will hang!
}
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Harmful Recursion
##  [Demo]()

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# How the Recursive Fibonacci Calculation Works?
* fib(n) makes about fib(n) recursive calls
* The same value is calculated many, many times!

<!-- attr: { showInPresentation:true, style:'' } -->
# Fast Recursive Fibonacci
* Each Fibonacci sequence member can be remembered once it is calculated
  * Can be returned directly when needed again

```cs
static decimal[] fib = new decimal[MAX_FIB];
static decimal Fibonacci(int n)
{
    if (fib[n] == 0)
    {
        // The value of fib[n] is still not calculated
        if ((n == 1) || (n == 2))
            fib[n] = 1;
        else
            fib[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    return fib[n];
}
```

<!-- attr: { class:'slide-section demo', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Fast Recursive Fibonacci
##  [Demo]()

<!-- attr: { showInPresentation:true, style:'' } -->
# When to Use Recursion?
* Avoid recursion when an obvious iterative algorithm exists
  * Examples: factorial, Fibonacci numbers
* Use recursion for combinatorial algorithm where at each step you need to recursively explore more than one possible continuation
  * Examples: permutations, all paths in labyrinth
  * If you have only one recursive call in the body of a recursive method, it can directly become iterative (like calculating factorial)

<!-- attr: { showInPresentation:true, style:'' } -->
# Summary
* Recursion means to call a method from itself
  * It should always have a bottom at which recursive calls stop
* Very powerful technique for implementing combinatorial algorithms
  * Examples: generating combinatorial configurations like permutations, combinations, variations, etc.
* Recursion can be harmful when not used correctly

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Recursion
* http://academy.telerik.com

<!-- attr: { showInPresentation:true, style:'' } -->
# Exercises
* Write a recursive program that simulates the execution of `n nested loops `from 1 to n. Examples:
  *                            1 1 1
  *                            1 1 2
  *                            1 1 3
  *          1 1               1 2 1
  * n=2  ->  1 2      n=3  ->  ...
  *          2 1               3 2 3
  *          2 2               3 3 1
  *                            3 3 2
  *                            3 3 3

<!-- attr: { showInPresentation:true, style:'' } -->
# Exercises (2)
* Write a recursive program for generating and printing all the `combinations with duplicates `of k elements from n-element set. Example:
  * 	n=3, k=2 &rarr; (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)
* Modify the previous program to `skip duplicates`:
    * n=4, k=2 &rarr; (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
* Write a recursive program for generating and printing all `permutations` of the numbers 1, 2, ..., n for given integer number n. Example:
* 	n=3 &rarr; {1, 2, 3}, {1, 3, 2}, {2, 1, 3},					{2, 3, 1}, {3, 1, 2},{3, 2, 1}

<!-- attr: { showInPresentation:true, style:'' } -->
# Exercises (3)
* Write a recursive program for generating and printing all ordered k-element subsets from n-element set (`variations Vkn`).
  * 	Example: n=3, k=2, set = {hi, a, b} =>
  * 	(hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
* Write a program for generating and printing `all subsets of k strings` from given set of strings.
  * 	Example: s = {test, rock, fun}, k=2
  * 	(test rock),  (test fun),  (rock fun)

<!-- attr: { showInPresentation:true, style:'' } -->
# Exercises (4)
* We are given a matrix of passable and non-passable cells. Write a recursive program for finding all paths between two cells in the matrix.
* Modify the above program to check whether a path exists between two cells without finding all possible paths. Test it over an empty 100 x 100 matrix.
* Write a recursive program to find the largest connected area of adjacent empty cells in a matrix.
* x We are given a matrix of passable and non-passable cells. Write a recursive program for finding all areas of passable cells in the matrix.

<!-- attr: { showInPresentation:true, style:'' } -->
# Exercises (5)
* x Write a program to generate all `permutations with repetitions `of given multi-set. For example the multi-set {1, 3, 5, 5} has the following 12 unique permutations:
    * { 1, 3, 5, 5 }	{ 1, 5, 3, 5 }
    * { 1, 5, 5, 3 }	{ 3, 1, 5, 5 }
    * { 3, 5, 1, 5 }	{ 3, 5, 5, 1 }
    * { 5, 1, 3, 5 }	{ 5, 1, 5, 3 }
    * { 5, 3, 1, 5 }	{ 5, 3, 5, 1 }
    * { 5, 5, 1, 3 }	{ 5, 5, 3, 1 }
  * Ensure your program efficiently avoids duplicated permutations. Test it with { 1, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }.

```cs
Hint: http://hardprogrammer.blogspot.com/2006/11/permutaciones-con-repeticin.html
```

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Exercises (6)
* x Write a recursive program to solve the "8 Queens Puzzle" with backtracking. Learn more at: http://en.wikipedia.org/wiki/Eight_queens_puzzle

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Free Trainings @ Telerik Academy
* C# Programming @ Telerik Academy
    * csharpfundamentals.telerik.com
  * Telerik Software Academy
    * academy.telerik.com
  * Telerik Academy @ Facebook
    * facebook.com/TelerikAcademy
  * Telerik Software Academy Forums
    * forums.academy.telerik.com

