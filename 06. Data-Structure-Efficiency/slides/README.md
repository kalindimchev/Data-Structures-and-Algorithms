<!-- section start -->
<!-- attr: { class:'slide-title', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Data Structures Efficiency
##  Computational Complexity of FundamentalData Structures, Choosing a Data Structure

<img class="slide-image" src="imgs/pic.png" style="width:80%; top:10%; left:10%" />

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Table of Contents
* Fundamental Data Structures – Comparison
  * Arrays
  * Lists
  * Trees
  * Hash-Tables
  * Sets
  * Bags
* Choosing Proper Data Structure

<img class="slide-image" src="imgs/pic.png" style="width:80%; top:10%; left:10%" />

<!-- section start -->
<!-- attr: { class:'slide-section', showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Comparing Data Structures
##  Time Complexity of Basic Operations

<img class="slide-image" src="imgs/pic.png" style="width:80%; top:10%; left:10%" />

<!-- attr: { showInPresentation:true, style:'' } -->
# Data Structures Efficiency

<!-- attr: { showInPresentation:true, style:'' } -->
# Data Structures Efficiency (2)

<!-- attr: { showInPresentation:true, style:'' } -->
# Choosing Data Structure
* Arrays (`T[]`)
  * Use when fixed number of elements should be processed by index
* Resizable array lists (`List<T>`)
  * Use when elements should be added and processed by index
* Linked lists (`LinkedList<T>`)
  * Use when elements should be added at the both sides of the list
  * Otherwise use resizable array list (`List<T>`)

<!-- attr: { showInPresentation:true, style:'' } -->
# Choosing Data Structure (2)
* Stacks (`Stack<T>`)
  * Use to implement LIFO (last-in-first-out) behavior
  * `List<T>` could also work well
* Queues (`Queue<T>`)
  * Use to implement FIFO (first-in-first-out) behavior
  * `LinkedList<T>` could also work well
* Hash table based dictionary (`Dictionary<K,T>`)
  * Use when key-value pairs should be added fast and searched fast by key
  * Elements in a hash table have no particular order

<!-- attr: { showInPresentation:true, style:'' } -->
# Choosing Data Structure (3)
* Balanced search tree based dictionary (`SortedDictionary<K,T>`)
  * Use when key-value pairs should be added fast, searched fast by key and enumerated sorted by key
* Hash table based set (`HashSet<T>`)
  * Use to keep a group of unique values, to add and check belonging to the set fast
  * Elements are in no particular order
* Search tree based set (`SortedSet<T>`)
  * Use to keep a group of ordered unique values

<!-- attr: { showInPresentation:true, style:'' } -->
# Summary
* `Algorithm complexity` is rough estimation of the number of steps performed by given computation
  * Complexity can be logarithmic, linear, n log n, square, cubic, exponential, etc.
  * Allows to estimating the speed of given code before its execution
* Different data structures have different efficiency on different operations
  * The fastest add / find / delete structure is the hash table – `O(1)` for all these operations

<!-- attr: { showInPresentation:true, hasScriptWrapper:true, style:'' } -->
# Data Structures Efficiency
* http://academy.telerik.com

<img class="slide-image" src="imgs/pic.png" style="width:80%; top:10%; left:10%" />

<!-- attr: { showInPresentation:true, style:'' } -->
# Exercises
* A text file `students.txt` holds information about students and their courses in the following format:
* 	Using `SortedDictionary<K,T>` print the courses in alphabetical order and for each of them prints the students ordered by family and then by name:

```cs
Kiril  | Ivanov   | C#
Stefka | Nikolova | SQL
Stela  | Mineva   | Java
Milena | Petrova  | C#
Ivan   | Grigorov | C#
Ivan   | Kolev    | SQL
```

```cs
C#: Ivan Grigorov, Kiril Ivanov, Milena Petrova
Java: Stela Mineva
SQL: Ivan Kolev, Stefka Nikolova
```

<!-- attr: { showInPresentation:true, style:'' } -->
# Exercises (2)
* A large trade company has millions of articles, each described by barcode, vendor, title and price. Implement a data structure to store them that allows fast retrieval of all articles in given price range [x…y]. Hint: use `OrderedMultiDictionary<K,T>` from Wintellect's Power Collections for .NET. 
* Implement a class `BiDictionary<K1,K2,T>` that allows adding triples `{key1,` `key2,` `value}` and fast search by `key1`, `key2` or by both `key1` and `key2`. Note: multiple values can be stored for given key.

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

<img class="slide-image" src="imgs/pic.png" style="width:80%; top:10%; left:10%" />

