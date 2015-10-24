<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Advanced Data Structures
- Wintellect Power Collections, C5 Collections


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Table of Contents
- Standard .NET Data Structures
- Special .NET Collections
- Wintellect Power Collections
- Installation
- Power Collection Classes
- Implementing Priority Queue
- C5 Collections
- Other Advanced Data Structures
- Suffix trees, interval trees, ropes, tries, etc.


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Standard .NETData Structures
- Built-In .NET Data Structure Implementations


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# .NET Data Structures
- Linear structures
- Lists: List<T>, LinkedList<T>
- Stacks: Stack<T>
- Queues: Queue<T>
- Dictionaries (maps)
- Dictionary<K,V>, SortedDictionary<K,V>
- No standard multi-dictionary .NET class
- Balanced search tree structures
- SortedSet<T>, SortedDictionary<K,V>


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# .NET Data Structures (2)
- Sets and bags
- Sets – HashSet<T>, SortedSet<T>
- Bag – no standard .NET class
- Ordered sets, bags and dictionaries
- Priority queues / heaps  no
- Special tree structures  no
- Suffix tree, interval tree, index tree, trie
- Graphs  no
- Directed / undirected, weighted /un-weighted, connected/ non-connected, …
- 5


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# .NET Generic Collections
- 6


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# .NET Untyped Collections
- 7


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Special .NET Collections
- Collection<T>
- Inheritable IList<T>, virtual Add() / Remove()
- ObservableCollection<T>
- Event CollectionChanged
- IReadOnlyCollection<T>
- Supports only Count and GetEnumerator()
- IReadOnlyList<T>
- Supports only Count, [] and GetEnumerator()
- Concurrent collections (thread-safe)
- BlockingCollection<T>, ConcurrentBag<T>, …
- 8


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Special .NET Collections
- Live Demo


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Wintellect Power Collections
- Open Source C# Implementation of All Major Data Structures: Lists, Sets, Bags, Dictionaries, etc.


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Wintellect Power Collections
- Wintellect Power Collections is powerful open-source data structure library
- Download: http://powercollections.codeplex.com
- Installing Power Collections in Visual Studio
- Use NuGet package manager
- 11


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Power Collections Classes
- Bag<T>
- A bag (multi-set) based on hash-table
- Unordered collection (with duplicates)
- Add / Find / Remove work in time O(1)
- T should provide Equals() and GetHashCode()
- OrderedBag<T>
- A bag (multi-set) based on balanced search tree
- Add / Find / Remove work in time O(log(N))
- T should implement IComparable<T>
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Power Collections Classes (2)
- Set<T>
- A set based on hash-table (no duplicates)
- Add / Find / Remove work in time O(1)
- Like .NET’s HashSet<T>
- OrderedSet<T>
- A set based on balanced search tree (red-black)
- Add / Find / Remove work in time O(log(N))
- Like .NET’s SortedSet<T>
- Provides fast .Range(from, to) operation
- 13


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Power Collections Classes (3)
- MultiDictionary<TKey, TValue>
- A dictionary (map) implemented by hash-table
- Allows duplicates (configurable)
- Add / Find / Remove work in time O(1)
- Like Dictionary<TKey, List<TValue>>
- OrderedDictionary<TKey, TValue> / OrderedMultiDictionary<TKey, TValue>
- A dictionary based on balanced search tree
- Add / Find / Remove work in time O(log(N))
- Provides fast .Range(from, to) operation
- 14


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Power Collections Classes (4)
- Deque<T>
- Double-ended queue (deque)
- BigList<T>
- Editable sequence of indexed items
- Like List<T> but provides
- Fast Insert / Delete operations (at any position)
- Fast Copy / Concat / Sub-range operations
- Implemented by the data structure "Rope"
- Special kind of balanced binary tree: http://en.wikipedia.org/wiki/Rope_(data_structure)
- 15


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Live Demo
- Wintellect Power Collections


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Priority Queue
- What is a "priority queue"?
- Data structure to efficiently support finding the item with the highest priority
- Like a queue, but with priorities
-  The basic operations
- Enqueue(T element)
- Dequeue()  T
- There is no build-in priority queue in .NET
- See the data structure "binary heap"
- Can be implemented also by OrderedBag<T>


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Priority Queue Implementation
- class PriorityQueue<T> where T : IComparable<T>
- {
-    private OrderedBag<T> queue;
-    public int Count 
-    {
-       get { return this.queue.Count; }
-    }
-    public PriorityQueue()
-    {
-       this.queue = new OrderedBag<T>();   
-    }
-    public void Enqueue(T element)
-    {
-       this.queue.Add(element);
-    }
-    public T Dequeue()
-    {
-       return this.queue.RemoveFirst();
-    }
- }
- 18


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Priority Queue
- Live Demo


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Advanced Data Structures
- Suffix Trees, Interval Trees, Tries, Ropes, Heaps, …


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Advanced Data Structures
- Suffix tree (position tree)
- Represents the suffixes of given string
- Used to implement fast search in string
- Trie (prefix tree)
- Special tree structure used for fastmulti-pattern matching
- Rope
- Balanced tree structure for indexeditems with fast inserts / delete
- Allows fast string edit operations
- 21


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Advanced Data Structures (2)
- Interval tree
- Keeps intervals [a…b] in ordered balanced tree
- Allows to efficiently find all intervals that overlap with any given interval or point
- Binary heap, Fibonacci heap
- Special tree-like data structures toefficiently implement a priority queue
- Index trees
- Used to keep sorted indices of database records
- B-tree, B+ tree, T-tree
- 22


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# C5 Collections
- Open Source Generic Collection Library for C#


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# C5 Collections
- What are "C5 Collections"?
- C5 Generic Collection Library for C# and CLI
- Open-Source Data Structures Library for .NET
- http://www.itu.dk/research/c5/
- Have solid documentation (book) – http://www.itu.dk/research/c5/latest/ITU-TR-2006-76.pdf
- The C5 library defines its own interfaces like IEnumerable<T>, IIndexed<T>, IIndexedSorted<T>, etc.
- 24


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# C5 Collection Classes
- 25


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# C5 Collection Classes
- Classical collection classes
- ArrayList<T>, LinkedList<T>, CircularQueue<T>, HashSet<T>, TreeSet<T>, HashBag<T>, TreeBag<T>
- HashedArrayList<T>
- Combination of indexed list + hash-table
- Fast Add / Find / indexer []  O(1)
- IntervalHeap<T>
- Efficient double-ended priority queue
- 26


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Advanced Data Structures
- http://academy.telerik.com


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Exercises
- Implement a class PriorityQueue<T> based on the data structure "binary heap".
- Write a program to read a large collection of products (name + price) and efficiently find the first 20 products in the price range [a…b]. Test for 500 000 products and 10 000 price searches.
- Hint: you may use OrderedBag<T> and sub-ranges.
- Write a program that finds a set of words (e.g. 1000 words) in a large text (e.g. 100 MB text file). Print how many times each word occurs in the text.
- Hint: you may find a C# trie in Internet.


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


