<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Sorting andSearching Algorithms
- Data Structures and Algorithms
- Telerik Software Academy
- http://academy.telerik.com 


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Table of Contents
- Sorting
- Sorting and classification
- Review of the most popularsorting algorithms
- Searching
- Linear search
- Binary search
- Interpolation search
- Shuffling
- 2


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Sorting


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# What is a Sorting Algorithm?
- Sorting algorithm
- An algorithm that puts elements of a list in a certain order (most common lexicographically)
- More formally:
- The output is in some (non-decreasing) order
- The output is a permutation of the input
- Efficient sorting is important for
- Producing human-readable output
- Canonicalizing data
- Optimizing the use of other algorithms
- Sorting presents many important techniques
- 4


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Sorting algorithms are often classified by
- Computational complexity
- worst, average and best behavior
- Memory usage
- Recursive or non-recursive
- Stability
- Whether or not they are a comparison sort
- General method
- insertion, exchange (bubble sort and quicksort), selection (heapsort), merging, serial or parallel…
- 5
- Classification


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Stability of Sorting
- Stable sorting algorithms
- Maintain the relative orderof records with equal values
- If two items compare asequal, then their relativeorder will be preserved
- When sorting only part ofthe data is examinedwhen determining thesort order
- 6


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Selection sort
- Very simple and very inefficient algorithm
- Best, worst and average case: n2
- Memory: 1 (constant, only for the min element)
- Stable: No
- Method: Selection
- http://en.wikipedia.org/wiki/Selection_sort
- 7
- for (j = 0; j < n-1; j++) {
-     /* find the min element in the unsorted a[j .. n-1] */
-     iMin = j;
-     for ( i = j+1; i < n; i++) {
-         if (a[i] < a[iMin]) iMin = i;
-     }
-     if (iMin != j) swap(a[j], a[iMin]);
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Bubble sort
- Repeatedly stepping through the list, comparing each pair of adjacent items and swap them if they are in the wrong order
- Best case: n, worst and average case: n2
- Memory: 1, Stable: Yes, Method: Exchanging
- http://en.wikipedia.org/wiki/Bubble_sort
- 8


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Insertion sort
- Builds the final sorted array one item at a time
- Best case: n, worst and average case: n2
- Memory: 1, Stable: Yes, Method: Insertion
- http://en.wikipedia.org/wiki/Insertion_sort
- 9
- for i ← 1 to i ← length(A)-1
- {
-   valueToInsert ← A[i]
-   holePos ← i
-   while holePos > 0 and valueToInsert < A[holePos - 1]
-   { 
-     A[holePos] ← A[holePos - 1] // shift the larger value up
-     holePos ← holePos - 1       // move the hole position down
-   }
-   A[holePos] ← valueToInsert
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Quicksort
- First divides a large list into two smaller sub-lists then recursively sort the sub-lists
- Best and average case: n*log(n), worst: n2
- Memory: log(n) stack space
- Stable: Depends
- Method: Partitioning
- http://en.wikipedia.org/wiki/Quicksort
- 10
- Stable implementation


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Merge Sort
- Conceptually, a merge sort works as follows
- Divide the unsorted list into n sublists, each containing 1 element (list of 1 element is sorted)
- Repeatedly merge sublists to produce new sublists until there is only 1 sublist remaining
- Best, average and worst case: n*log(n)
- Memory: Depends; worst case is n
- Stable: Yes; Method: Merging
- Highly parallelizable (up to O(log(n)) using the Three Hungarian's Algorithm
- http://en.wikipedia.org/wiki/Merge_sort
- 11


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Merge Sort Pseudocode
- 12
- function merge_sort(list m)
-     // if list size is 0 (empty) or 1, consider it sorted
-     // (using less than or equal prevents infinite recursion for a zero length m)
-     if length(m) <= 1
-         return m
-     // else list size is > 1, so split the list into two sublists
-     var list left, right
-     var integer middle = length(m) / 2
-     for each x in m before middle
-          add x to left
-     for each x in m after or equal middle
-          add x to right
-     // recursively call merge_sort() to further split each sublist
-     // until sublist size is 1
-     left = merge_sort(left)
-     right = merge_sort(right)
-     // merge the sublists returned from prior calls to merge_sort()
-     // and return the resulting merged sublist
-     return merge(left, right)


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Merge Sort Pseudocode (2)
- 13
- function merge(left, right)
-     var list result
-     while length(left) > 0 or length(right) > 0
-         if length(left) > 0 and length(right) > 0
-             if first(left) <= first(right)
-                 append first(left) to result
-                 left = rest(left)
-             else
-                 append first(right) to result
-                 right = rest(right)
-         else if length(left) > 0
-             append first(left) to result
-             left = rest(left)
-         else if length(right) > 0
-             append first(right) to result
-             right = rest(right)
-     end while
-     return result


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Heap
- Specialized tree-based data structure that satisfies the heap property:
- Parent nodes are always greater (less) than or equal to the children
- No implied orderingbetween siblings or cousins
- en.wikipedia.org/wiki/Heap_(data_structure)
- 14
- find-min
- Θ(1)
- delete-min
- Θ(log n)
- insert
- Θ(log n)
- decrease-key
- Θ(log n)
- merge
- Θ(n)


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Heapsort
- Can be divided into two parts
- In the first step, a heap is built out of the data
- A sorted array is created by repeatedly removing the largest element from the heap
- Best, average and worst case: n*log(n)
- Memory: Constant - O(1)
- Stable: No
- Method: Selection
- http://en.wikipedia.org/wiki/Heapsort
- 15


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Counting sort
- Algorithm for sorting a collection of objects according to keys that are small integers
- Not a comparison sort
- Average case: n + r
- Worst case: n + r
- r is the range of numbers to be sorted
- Stable: Yes
- Memory: n + r
- http://en.wikipedia.org/wiki/Counting_sort
- 16


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Bucket sort
- Partitioning an array into a number of buckets
- Each bucket is then sorted individually
- Not a comparison sort
- Average case: n + k
- k = the number of buckets
- Worst case: n2 * k
- Stable: Yes
- Memory: n * k
- http://en.wikipedia.org/wiki/Bucket_sort
- 17


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Comparison of Sorting Algorithms
- There are hundreds of sorting algorithms
- 18
- Name
- Best
- Average
- Worst
- Memory
- Stable
- Method
- Selection sort
- n2
- n2
- n2
- 1
- No
- Selection
- Bubble sort
- n
- n2
- n2
- 1
- Yes
- Exchanging
- Insertion sort
- n
- n2
- n2
- 1
- Yes
- Insertion
- Quicksort
- n*log(n)
- n*log(n)
- n2
- log(n)
- Depends
- Partitioning
- Merge sort
- n*log(n)
- n*log(n)
- n*log(n)
- Depends worst case is n
- Yes
- Merging
- Heapsort
- n*log(n)
- n*log(n)
- n*log(n)
- 1
- No
- Selection
- Bogosort
- n
- n*n!
- n*n!
- 1
- No
- Luck
- …
- …
- …
- …
- …
- …
- …


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Searching


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Search Algorithm 
- An algorithm for finding an item with specified properties among a collection of items
- Different types of searching algorithms
- For virtual search spaces
- satisfy specific mathematical equations
- try to exploit partial knowledge about structure
- For sub-structures of a given structure
- graph, a string, a finite group
- Search for the max (min) of a function
- etc.
- 20


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Linear Search
- Method for finding a particular value in a list
- Checking every one of the elements
- One at a time in sequence
- Until the desired one is found
- Worst and average performance: O(n)
- 21
-  for each item in the list:
-      if that item has the desired value,
-          stop the search and return the item's location.
-  return nothing.


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Binary Search
- Finds the position of a specified value within a sorted data structure
- In each step, compare the input with the middle
- The algorithm repeats its action to the left or right sub-structure
- Average performance: O(log(n))
- 22


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Recursive Binary Search
- 23
- int binary_search(int A[], int key, int imin, int imax)
- {
-   if (imax < imin)
-      // set is empty, so return value showing not found
-      return KEY_NOT_FOUND;
-   else
-   {
-      // calculate midpoint to cut set in half
-      int imid = midpoint(imin, imax);
-      if (A[imid] > key)
-         // key is in lower subset
-         return binary_search(A, key, imin, imid-1);
-      else if (A[imid] < key)
-         // key is in upper subset
-         return binary_search(A, key, imid+1, imax);
-      else
-         // key has been found
-         return imid;
-   }
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Iterative Binary Search
- 24
- int binary_search(int A[], int key, int imin, int imax)
- {
-    // continue searching while [imin,imax] is not empty
-    while (imax >= imin)
-    {
-       /* calculate the midpoint for roughly equal partition */
-       int imid = midpoint(imin, imax);
-       // determine which subarray to search
-       if (A[imid] < key)
-          // change min index to search upper subarray
-          imin = imid + 1;
-       else if (A[imid] > key)
-          // change max index to search lower subarray
-          imax = imid - 1;
-       else
-          // key found at index imid
-          return imid;
-   }
-   return KEY_NOT_FOUND;
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Interpolation Search
- An algorithm for searching for a given key value in an indexed array that has been ordered by the values of the key
- Parallels how humans search through a telephone book
- Calculates where in the remaining search space the sought item might be
- Binary search always chooses the middle element
- Average case: log(log(n)), Worst case: O(n)
- http://youtube.com/watch?v=l1ed_bTv7Hw
- 25


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Interpolation SearchSample Implementation
- 26
- public int interpolationSearch(int[] sortedArray, int toFind){
-   // Returns index of toFind in sortedArray, or -1 if not found
-   int low = 0;
-   int high = sortedArray.length - 1;
-   int mid;
-   while(sortedArray[low] <= toFind && sortedArray[high] >= toFind) {
-     mid = low + ((toFind - sortedArray[low]) * (high - low)) /
-                 (sortedArray[high] - sortedArray[low]);
-                 // out of range is possible here
-     if (sortedArray[mid] < toFind)
-       low = mid + 1;
-     else if (sortedArray[mid] > toFind)
-       high = mid - 1;
-     else
-       return mid;
-   }
-   if (sortedArray[low] == toFind) return low;
-   else return -1; // Not found
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Shuffling


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Shuffling
- A procedure used to randomize the order of items in a collection
- Generating random permutation
- http://en.wikipedia.org/wiki/Shuffling
- 28


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Fisher–Yates shuffle algorithm
- 29
- public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
- {
-     var array = source.ToArray();
-     var n = array.Length;
-     for (var i = 0; i < n; i++)
-     {
-         // Exchange a[i] with random element in a[i..n-1]
-         int r = i + RandomProvider.Instance.Next(0, n - i);
-         var temp = array[i];
-         array[i] = array[r];
-         array[r] = temp;
-     }
-     return array;
- }
- public static class RandomProvider
- {
-     private static Random Instance = new Random();
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Sorting and Searching Algorithms
- http://academy.telerik.com


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Homework
- Open Sorting-and-Searching-Algorithms-Homework.zip and:
- Implement SelectionSorter.Sort() method using selection sort algorithm
- Implement Quicksorter.Sort() method using quicksort algorithm
- Implement MergeSorter.Sort() method using merge sort algorithm
- Implement SortableCollection.LinearSearch() method using linear search
- Don’t use built-in search methods. Write your own.
- 31


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Homework (2)
- Implement SortableCollection.BinarySearch() method using binary search algorithm
- Implement SortableCollection.Shuffle() method using shuffle algorithm of your choice
- Document what is the complexity of the algorithm
- * Unit test sorting algorithms
- SelectionSorter.Sort()
- Quicksorter.Sort()
- MergeSorter.Sort()
- * Unit test searching algorithms
- SortableCollection.LinearSearch()
- SortableCollection.BinarySearch()
- 32


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
- 33


