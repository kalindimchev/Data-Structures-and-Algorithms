<!-- section start -->
<!-- attr: { class:'slide-title', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Sorting andSearching Algorithms
<div class="signature">
    <p class="signature-course">Data Structures and Algorithms</p>
    <p class="signature-initiative">Telerik Software Academy</p>
    <a href = "http://academy.telerik.com " class="signature-link">http://academy.telerik.com </a>
</div>


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Table of Contents
* Searching
  * Linear search
  * Binary search
  * Interpolation search
* Shuffling


<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Searching


<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Search Algorithm 
* An algorithm for finding an item with specified properties among a collection of items
* Different types of searching algorithms
  * For virtual search spaces
    * satisfy specific mathematical equations
    * try to exploit partial knowledge about structure
  * For sub-structures of a given structure
    * graph, a string, a finite group
  * Search for the max (min) of a function
  * etc.

<img class="slide-image" src="imgs/pic.png" style="width:80%; top:10%; left:10%" />

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Linear Search
* Method for finding a particular value in a list
  * Checking every one of the elements
  * One at a time in sequence
  * Until the desired one is found
* Worst and average performance: `O(n)`

```cs
 for each item in the list:
     if that item has the desired value,
         stop the search and return the item's location.
 return nothing.
```

<img class="slide-image" src="imgs/pic.png" style="width:80%; top:10%; left:10%" />

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Binary Search
* Finds the position of a specified value within a `sorted` data structure
* In each step, compare the input with the middle
  * The algorithm repeats its action to the left or right sub-structure
* Average performance: `O(log(n))`

<img class="slide-image" src="imgs/pic.png" style="width:80%; top:10%; left:10%" />

<!-- attr: { showInPresentation:true, style:'' } -->
# Recursive Binary Search

```cs
int binary_search(int A[], int key, int imin, int imax)
{
  if (imax < imin)
*      // set is empty, so return value showing not found
     return KEY_NOT_FOUND;
  else
  {
*      // calculate midpoint to cut set in half
     int imid = midpoint(imin, imax);
     if (A[imid] > key)
*         // key is in lower subset
        return binary_search(A, key, imin, imid-1);
     else if (A[imid] < key)
*         // key is in upper subset
        return binary_search(A, key, imid+1, imax);
     else
*         // key has been found
        return imid;
  }
}
```

<!-- attr: { showInPresentation:true, style:'' } -->
# Iterative Binary Search

```cs
int binary_search(int A[], int key, int imin, int imax)
{
*    // continue searching while [imin,imax] is not empty
   while (imax >= imin)
   {
*       /x calculate the midpoint for roughly equal partition x/
      int imid = midpoint(imin, imax);
*       // determine which subarray to search
      if (A[imid] < key)
*          // change min index to search upper subarray
         imin = imid + 1;
      else if (A[imid] > key)
*          // change max index to search lower subarray
         imax = imid - 1;
      else
*          // key found at index imid
         return imid;
  }
  return KEY_NOT_FOUND;
}
```

<!-- attr: { showInPresentation:true, style:'' } -->
# Interpolation Search
* An algorithm for searching for a given key value in an indexed array that has been ordered by the values of the key
  * Parallels how humans search through a telephone book
  * Calculates where in the remaining search space the sought item might be
    * Binary search always chooses the middle element
* Average case: `log(log(n))`, Worst case: `O(n)`
* http://youtube.com/watch?v=l1ed_bTv7Hw

<!-- attr: { showInPresentation:true, style:'' } -->
# Interpolation SearchSample Implementation

```cs
public int interpolationSearch(int[] sortedArray, int toFind){
*   // Returns index of toFind in sortedArray, or -1 if not found
  int low = 0;
  int high = sortedArray.length - 1;
  int mid;
  while(sortedArray[low] <= toFind && sortedArray[high] >= toFind) {
    mid = low + ((toFind - sortedArray[low]) x (high - low)) /
                (sortedArray[high] - sortedArray[low]);
*                 // out of range is possible here
    if (sortedArray[mid] < toFind)
      low = mid + 1;
    else if (sortedArray[mid] > toFind)
      high = mid - 1;
    else
      return mid;
  }
  if (sortedArray[low] == toFind) return low;
*   else return -1; // Not found
}
```

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Shuffling

<img class="slide-image" src="imgs/pic.png" style="width:80%; top:10%; left:10%" />

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Shuffling
* A procedure used to randomize the order of items in a collection
  * Generating random permutation
* http://en.wikipedia.org/wiki/Shuffling

<img class="slide-image" src="imgs/pic.png" style="width:80%; top:10%; left:10%" />

<!-- attr: { showInPresentation:true, style:'' } -->
# Fisher–Yates shuffle algorithm

```cs
public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
{
    var array = source.ToArray();
    var n = array.Length;
    for (var i = 0; i < n; i++)
    {
*         // Exchange a[i] with random element in a[i..n-1]
        int r = i + RandomProvider.Instance.Next(0, n - i);
        var temp = array[i];
        array[i] = array[r];
        array[r] = temp;
    }
    return array;
}
public static class RandomProvider
{
    private static Random Instance = new Random();
}
```

<!-- attr: { showInPresentation:true, style:'' } -->
# Sorting and Searching Algorithms
* http://academy.telerik.com