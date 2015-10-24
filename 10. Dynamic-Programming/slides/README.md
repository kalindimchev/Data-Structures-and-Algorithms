<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Dynamic Programming
- Brief Introduction in Problem Solving using Dynamic Programming and Memoization
- Telerik Software Academy
- http://academy.telerik.com
- Data Structures & Algorithms


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Table of Contents
- Minimum and Maximum
- Divide-and-Conquer
- Dynamic ProgrammingConcepts
- Fibonacci Numbers
- Longest IncreasingSubsequence
- Longest CommonSubsequence
- 2


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Minimum and Maximum


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Minimum and Maximum
- The minimum of a set of N elements
- The first element in list of elements ordered in incremental order (index = 1)
- The maximum of a set of N elements
- The last element in list of elements ordered in incremental order (index = N)
- The median is the “halfway point” of the set
- When N is odd, index = (N+1) / 2 = unique value
- When N is even, index = (n+1)/2 (lower median) or index = (n+1)/2  (upper median)


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Finding Min and Max Element
- Minimum element
- Maximum element
- 5
- int FindMin(int[] arr)
- {
-     int min = arr[0];
-     for (int i = 1; i < arr.Length; i++)
-         if (arr[i] < min) min = arr[i];
-     return min;
- }
- int FindMax(int arr[])
- {
-     int max = arr[0];
-     for (int i = 1; i < arr.Length; i++)
-         if (arr[i] > max) max = arr[i];
-     return max;
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Divide-and-Conquer


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Divide-and-Conquer
- Divide: If the input size is too large to deal with in a straightforward manner
- Divide the problem into two or more disjoint subproblems
- Conquer: conquer recursively to solve the subproblems
- Combine: Take the solutions to the subproblems and "merge" these solutions into a solution for the original problem


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Divide-and-Conquer Example
- MergeSort
- The subproblemsare independent,all different
- 8
- void MergeSort(int[] arr, int left, int right)
- {
-   if (right > left)
-   {
-     int mid = (right + left) / 2;
-     MergeSort(arr, left, mid);
-     MergeSort(arr, (mid+1), right);
-     Merge(arr, left, (mid+1), right);
-   }
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Divide-and-Conquer Algorithms
- Binary search
- Closest pair in 2D geometry
- Quick sort
- Merging arrays
- Merge sort
- Finding majorant
- Tower of Hanoi
- Fast multiplication
- Strassen’s Matrix Multiplication
- 9


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Dynamic Programming


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Dynamic Programming
- How dynamic programming (DP) works?
- Approach to solve problems
- Store partial solutions of the smaller problems
- Usually they are solved bottom-up
- Steps to designing a DP algorithm:
- Characterize optimal substructure
- Recursively define the value of an optimal solution
- Compute the value bottom up
- (if needed) Construct an optimal solution
- 11


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Elements of DP
- DP has the following characteristics
- Simple subproblems
- We break the original problem to smaller sub-problems that have the same structure
- Optimal substructure of the problems 
- The optimal solution to the problem contains within optimal solutions to its sub-problems
- Overlapping sub-problems 
- There exist some places where we solve the same sub-problem more than once
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Common Characteristics
- The problem can be divided into levels with a decision required at each level
- Each level has a number of states associated with it
- The decision at one level transforms one state into a state in the next level
- Given the current state, the optimal decision for each of the remaining states does not depend on the previous states or decisions
- 13


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Difference between DPand Divide-and-Conquer
- Using Divide-and-Conquer to solve problems (that can be solved using DP) is inefficient
- Because the same common sub-problems have to be solved many times
- DP will solve each of them once and their answers are stored in a table for future use
- Technique known as “memoization”
- 14


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Fibonacci Numbers
- From "divide and conquer" to dynamic programming


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Fibonacci sequence
- The Fibonacci numbers are the numbers in the following integer sequence:
- 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, …
- The first two numbers are 0 and 1
- Each subsequent number is the sum of the previous two numbers
- In mathematical terms:
- Fn = Fn-1 + Fn-2
- F0 = 0, F1 = 1


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Divide and Conquer Approach
- How can we find the nth Fibonacci number using recursion (“divide and conquer”)
- Directly applying the recurrence formula
- 17
- decimal Fibonacci(int n)
- {
-     if (n == 0) return 0;
-     if (n == 1) return 1;
-     return Fibonacci(n - 1) + Fibonacci(n - 2);
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Fibonacci and Memoization
- We can save the results from each function call
- Every time when we call the function we check if the value is already calculated
- This saves a lot of useless calculations!
- http://en.wikipedia.org/wiki/Memoization
- 18
- decimal Fibonacci(int n)
- {   if (memo[n] != 0) return memo[n];
-    if (n == 0) return 0;
-    if (n == 1) return 1;
-    memo[n] = Fibonacci(n - 1) + Fibonacci(n - 2);
-    return memo[n];
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Fibonacci and DP
- How to find the nth Fibonacci number using the dynamic programming approach?
- We can start solving the Fibonacci problem from bottom-up calculating partial solutions
- We know the answer for the 0th and the 1st number of the Fibonacci sequence
- And we know the formula to calculate each of the next numbers (Fi = Fi-1 + Fi-2)
- 19
- 0
- 1
- 0
- 1
- 2
- 1
- 3
- 2
- 4
- 3
- 5
- 5
- 6
- 8
- ...
- ...
- ith
- Fi-1 + Fi-2
- nth
- ...
- ...
- ...


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Compare Fibonacci Solutions
- Recurrent solution
- Complexity: ~ O(1.6n)
- DP or memoization solution
- Complexity: ~ O(n)
- Dynamic programming solutions is way faster than the recurrent solution
- If we want to find the 36th Fibonacci number:
- Recurrent solution takes ~48 315 633 steps
- Dynamic programming solution takes ~36 steps
- 20


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Moving Problem


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Moving Problem
- In many DP problems there is a moving object with some restrictions
- For example - in how many ways you can reach from topleft corner of a grid to thebottom right
- You can move only right and down
- Some cells are unreachable
- 22


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Subset Sum Problem


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Subset Sum Problems
- Given a set of integers, is there a non-empty subset whose sum is zero?
- Given a set of integers and an integer S, does any non-empty subset sum to S?
- Given a set of integers,find all possible sums
- Can you equally separatethe value of coins?


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Subset Sum Problem
- Solving the subset sum problem:
- numbers = { 3, 5, -1, 4, 2 }, sum = 6
- start with possible = { 0 }
- Step 1: obtain all possible sums of { 3 }
- possible = { 0 } ∪ { 0+3 } = { 0, 3 }
- Step 2: obtain all possible sums of { 3, 5 }
- possible = { 0, 3 } ∪ { 0+5, 3+5 } = { 0, 3, 5, 8 } 
- Step 3: obtain all possible sums of { 3, 5, -1 }
- possible = { 0, 3, 5, 8 } ∪ { 0-1, 3-1, 5-1, 8-1 } ={ -1, 0, 2, 3, 4, 5, 7, 8 }
- …
- 25


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Subset Sum Problem – C++
- for(int i = 0; i < N; i++)
- {
-    int newminpos = minpos, newmaxpos = maxpos;
-    int newpossible[OFFSET + OFFSET] = { 0 };
-    for(int j = maxpos; j >= minpos; j--) // j = one possible sum
-    {
-       if (possible[j+OFFSET]) newpossible[j+nums[i]+OFFSET] = 1;
-       if (j+nums[i] > newmaxpos) newmaxpos = j+nums[i];
-       if (j+nums[i] < newminpos) newminpos = j+nums[i];
-    }
-    minpos = newminpos;
-    maxpos = newmaxpos;
-    for(int j = maxpos; j >= minpos; j--)
-       if (newpossible[j+OFFSET] == 1)
-          possible[j+OFFSET] = 1;
-    if (nums[i] > maxpos) maxpos = nums[i];
-    if (nums[i] < minpos) minpos = nums[i];
-    possible[nums[i]+OFFSET] = 1;
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Subset Sum Problem – Answer
- int S = 5;
- if (possible[0+OFFSET]) cout << "Sum 0 is possible" << endl;
- else cout << "Sum 0 is not possible" << endl;
- if (possible[S+OFFSET]) cout << "Sum " << S << " is possible" << endl;
- else cout << "Sum " << S << " is not possible" << endl;
- cout << "Possible sums:";
- for(int i = minpos; i <= maxpos; i++)
- {
-     if (possible[i+OFFSET] == 1) cout << " " << i;
- }
- 27


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Longest Increasing Subsequence
- 28


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Longest Increasing Subsequence
- Find a subsequence of a given sequence in which the subsequence elements are in sorted order, lowest to highest, and in which the subsequence is as long as possible
- This subsequence is not necessarily contiguous, or unique
- The longest increasing subsequence problem is solvable in time O(n log n)
- We will review one simple DP algorithm with complexity O(n * n)


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# LIS – C++ Solution
- L[0] = 1; P[0] = -1;for (int i = 1; i < N; i++)
- {
-     L[i] = 1;
-     P[i] = -1;
-     for (int j = i - 1; j >= 0; j--)
-     {
-         if (L[j] + 1 > L[i] && S[j] < S[i])
-         {
-             L[i] = L[j] + 1;
-             P[i] = j;
-         }
-     }
-     if (L[i] > maxLength)
-     {
-         bestEnd = i;
-         maxLength = L[i];
-     }}
- i = 
- 0
- 1
- 2
- 3
- 4
- 5
- 6
- 7
- 8
- Sequence Si = 
- 2
- 4
- 3
- 5
- 1
- 7
- 6
- 9
- 8
- Length Li = 
- 1
- 2
- 2
- 3
- 1
- 4
- 4
- 5
- 5
- Predecessor Pi = 
- -1
- 1
- 0
- 2
- -1
- 3
- 3
- 6
- 6


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# LIS – Restore the Sequence
- cout << "Max length: " << maxLength << endl;
- cout << "Sequence end index: " << bestEnd << endl;
- cout << "Longest subsequence:";
- int ind = bestEnd;
- while(ind != -1)
- {
-     cout << " " << S[ind];
-     ind = P[ind];
- }
- cout << endl;
- i = 
- 0
- 1
- 2
- 3
- 4
- 5
- 6
- 7
- 8
- Sequence Si = 
- 2
- 4
- 3
- 5
- 1
- 7
- 6
- 9
- 8
- Length Li = 
- 1
- 2
- 2
- 3
- 1
- 4
- 4
- 5
- 5
- Predecessor Pi = 
- -1
- 1
- 0
- 2
- -1
- 3
- 3
- 6
- 6


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Longest Common Subsequence 
- Recursive and DP Approach


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Longest Common Subsequence
- Given two sequences x[1 . . m] and y[1 . . n], find a longest common subsequence (LCS) to them both
- For example if we have x = "ABCBDAB" andy = "BDCABA" their longest common subsequence will be "BCBA"


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# LCS – Recursive Approach
- S1 = GCCCTAGCG, S2 = GCGCAATG 
- Let C1 = the right-most character of S1
- Let C2 = the right-most character of S2
- Let S1' = S1 with C1 "chopped-off"
- Let S2' = S2 with C2 "chopped-off"
- There are three recursive subproblems:
- L1 = LCS(S1', S2) 
- L2 = LCS(S1, S2') 
- L3 = LCS(S1', S2')
- 34


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# LCS – Recursive Approach (2)
- The solution to the original problem is whichever of these is the longest:
- L1
- L2
- If C1 is not equal to C2, then L3
- If C1 equals C2, then L3 appended with C1
- This recursive solution requires multiple computations of the same sub-problems
- This recursive solution can be replaced with DP
- 35


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Initial LCS table
- To compute the LCS efficiently using dynamic programming we start by constructing a table in which we build up partial results
- 36


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Initial LCS table (2)
- We'll fill up the table from top to bottom, and from left to right
- Each cell = the length of an LCS of the two string prefixes up to that row and column
- Each cell will contain a solution to a sub-problem of theoriginal problem
- S1 = GCCCTAGCG
- S2 = GCGCAATG
- 37


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# LCS table – base cases filled in
- Each empty string has nothing in common with any other string, therefor the 0-length strings will have values 0 in the LCS table
- 38
- for (i=0; i<=n; i++){
-     c[i][0] = 0;}
- for (i=0; i<=m; i++){
-     c[0][i] = 0;}


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# LCS – C++ Code Solution
- int LCS(string X, string Y){
-     int m = X.length();    int n = Y.length();    for (int i = 1; i <= m; i++)    {
-         for (int j = 1; j <= n; j++)
-         {
-             if (X[i-1] == Y[j-1])            {
-                 c[i][j] = c[i-1][j-1] + 1;
-             }
-             else            {
-                 c[i][j] = max(c[i][j-1], c[i-1][j]);            }
-         }    }    return c[m][n];
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# LCS – Reconstruct the Answer
- void printLCS(int i,int j)
- {
-     if (i==0 || j==0) return;
-     if (X[i-1] == Y[j-1])
-     {
-        printLCS(i-1, j-1);
-        cout << X[i-1];
-     }
-     else if (c[i][j] == c[i-1][j])
-     {
-         printLCS(i-1, j);
-     }
-     else
-     {
-         printLCS(i, j-1);
-     }
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DP Applications
- Areas
- Bioinformatics
- Control theory
- Information theory
- Operations research
- Computer science: 
- Theory
- Graphics
- AI
- 41


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Some Famous Dynamic Programming Algorithms
- Integer Knapsack Problem
- Unix diff for comparing two files
- Bellman–Ford algorithm for finding the shortest distance in a graph
- Floyd's All-Pairs shortest path algorithm
- Cocke-Kasami-Younger for parsing context free grammars
- en.wikipedia.org/wiki/Dynamic_programming#Algorithms_that_use_dynamic_programming
- 42


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Summary
- Divide-and-conquer method for algorithm design
- Dynamic programming is a way of improving on inefficient divide-and-conquer algorithms
- Dynamic programming is applicable when the sub-problems are dependent, that is, when sub-problems share sub-sub-problem
- Recurrent functions can be solved efficiently
- Longest increasing subsequence and Longest common subsequence problems can be solved efficiently using dynamic programming approach
- 43


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Dynamic Programming
- http://academy.telerik.com


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Homework
- Write a program based on dynamic programming to solve the "Knapsack Problem": you are given N products, each has weight Wi and costs Ci and a knapsack of capacity M and you want to put inside a subset of the products with highest cost and weight ≤ M. The numbers N, M, Wi and Ci are integers in the range [1..500]. Example: M=10 kg, N=6, products:
- beer – weight=3, cost=2
- vodka – weight=8, cost=12
- cheese – weight=4, cost=5
- nuts – weight=1, cost=4
- ham – weight=2, cost=3
- whiskey – weight=8, cost=13
- 45
- Optimal solution:
- nuts + whiskey
- weight = 9
- cost = 17


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Homework (2)
- Write a program to calculate the "Minimum Edit Distance" (MED) between two words. MED(x, y) is the minimal sum of costs of edit operations used to transform x to y. Sample costs are given below:
- cost (replace a letter) = 1
- cost (delete a letter) = 0.9
- cost (insert a letter) = 0.8
- Example: x = "developer", y = "enveloped"  cost = 2.7 
- delete ‘d’:  "developer"  "eveloper", cost = 0.9
- insert ‘n’:  "eveloper"  "enveloper", cost = 0.8
- replace ‘r’  ‘d’:  "enveloper"  "enveloped", cost = 1
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


