<!-- section start -->

<!-- attr: {id: 'title', class: 'slide-title', hasScriptWrapper: true} -->

# Data Structures, Algorithms and Complexity
##  Overview of Data Structures and Basic Algorithms. Computational Complexity. Asymptotic Notation

<div class="signature">
    <p class="signature-course">Data Structures and Algorithms</p>
    <p class="signature-initiative">Telerik Software Academy</p>
    <a href="http://academy.telerik.com" class="signature-link">http://academy.telerik.com</a>
</div>

<!-- section start -->
<!-- attr: { id:'table-of-contents', class:'table-of-contents' } -->
# Table of Contents
- Data Structures Overview
  - Linear Structures
  - Trees
  - Hash Tables
  - Others
- Algorithms Overview
  - Sorting and Searching
  - Combinatorics
  - Dynamic Programming
  - Graphs
  - Others

<!-- attr: { showInPresentation:true } -->
<!-- # Table of Contents -->
- Algorithms Complexity
  - Time and Memory Complexity
  - Mean, Average and Worst Case
  - Asymptotic Notation `O(g)`

<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Data Structures
##  Introduction

<!-- attr: { hasScriptWrapper:true } -->
# What is a Data Structure?
<div style="border:1px solid #ace; padding:1% 3%">
  "In computer science, a `data structure` is a particular way of storing and organizing data in a computer so that it can be used efficiently."
  <div>-- Wikipedia</div>
</div>

- Examples of data structures:
  - `Person` structure (first name + last name + age)
  - Array of integers – `int[]`
  - List of strings – `List<string>`
  - Queue of people – `Queue<Person>`

<!-- attr: { style:'font-size:0.9em' } -->
# Why Are Data Structures So Important?
- `Data structures` and `algorithms` are the foundation of computer programming
- Algorithmic thinking, problem solving and data structures are vital for software engineers
- All .NET developers should know when to use `T[]`, `LinkedList<T>`, `List<T>`, `Stack<T>`, `Queue<T>`, `Dictionary<K,T>`, `HashSet<T>`, `SortedDictionary<K,T>` and `SortedSet<T>`
- `Computational complexity` is important for algorithm design and efficient programming

# Primitive Types and Collections
- Primitive data types
  - Numbers: `int`, `float`, `decimal`, …
  - Text data: `char`, `string`, …
- Simple structures
  - A group of fields stored together
  - E.g. `DateTime`, `Point`, `Rectangle`, …
- Collections
  - A set of elements (of the same type)
  - E.g. array, list, stack, tree, hash-table, …

# Abstract Data Types (ADT)
- `An Abstract Data Type (ADT)` is
  - A data type together with the operations, whose properties are specified independently of any particular implementation
  - ADT are set of definitions of operations
    - Like the interfaces in C#
- ADT can have multiple different `implementations`
  - Different implementations can have different efficiency, inner logic and resource needs

# Basic Data Structures
- Linear structures
  - Lists: fixed size and variable size
  - Stacks: LIFO (Last In First Out) structure
  - Queues: FIFO (First In First Out) structure
- Trees and tree-like structures
  - Binary, ordered search trees, balanced, etc.
- Dictionaries (maps)
  - Contain pairs (key, value)
  - Hash tables: use hash functions to search/insert

<!-- attr: { showInPresentation:true, style:'font-size:0.95em' } -->
<!-- # Basic Data Structures -->
- Sets and bags
  - Set – collection of unique elements
  - Bag – collection of non-unique elements
- Ordered sets, bags and dictionaries
- Priority queues / heaps
- Special tree structures
  - Suffix tree, interval tree, index tree, trie
- Graphs
  - Directed / undirected
  - Weighted / un-weighted
  - Connected / non-connected, …

<!-- section start -->
<!-- attr: { id:'algorithms', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# Algorithms
##  Introduction

<!-- attr: { hasScriptWrapper:true, style:'font-size:0.9em' } -->
# What is an Algorithm?
<div style="border:1px solid #ace; padding:1% 3%">
  "In mathematics and computer science, an algorithm is a step-by-step procedure for calculations. An algorithm is an effective method expressed as a finite list of well-defined instructions for calculating a function.”
  <div>-- Wikipedia</div>
</div>
- The term "algorithm" comes from the 
  - Derived from `Muḥammad Al-Khwārizmī`, a Persian mathematician and astronomer
    - An algorithm for solving quadratic equations

<!-- attr: { style:'font-size:0.95em' } -->
# Algorithms in Computer Science
- Algorithms are fundamental in programming
  - Imperative (traditional) programming means to `describe in formal` steps how to do something
  - Algorithm == sequence of operations (steps)
    - Can include branches (conditional blocks) and repeated logic (loops)
- Algorithmic thinking (mathematical thinking, logical thinking, engineering thinking)
  - Ability to decompose the problems into formal sequences of steps (algorithms)

<!-- attr: { hasScriptWrapper:true } -->
# Pseudocode and Flowcharts  
- Algorithms can be expressed in pseudocode, through flowcharts or program code

<div style="width:50%; font-size:0.8em">
```cs
BFS(node)
{
  queue <- node
  while queue not empty
    v <- queue
    print v
    for each child c of v
      queue <- c
}
```
Example of `pseudocode`
</div>
<img class="slide-image" src="imgs/bfs.png" style="width:40%; right:0; top:20%" />






<!-- section start -->
<!-- attr: { id:'', class:'slide-section', showInPresentation:true, hasScriptWrapper:true } -->
# 
##  

<!-- section start -->
<!-- attr: { id:'questions', class:'slide-section', showInPresentation:true } -->
<!-- # Questions
## Databases -->
[link to the forum]()
