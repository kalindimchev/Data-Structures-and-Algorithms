<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Trees and Traversals
- Trees, Tre-Like Structures, Binary Search Trees,Balanced Trees, Tree Traversals, DFS and BFS
- Data Structures and Algorithms
- Telerik Software Academy
- http://academy.telerik.com 


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Table of Contents
- Tree-like Data Structures
- Trees and Related Terminology
- Implementing Trees
- Traversing Trees
- DFS and BFS Traversals
- Balanced Search Trees
- Balanced Trees in .NET
- 2


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Tree-like Data Structures
- Trees, Balanced Trees, Graphs, Networks


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Tree-like Data Structures
- Tree-like data structures are:
- Branched recursive data structures
- Consisting of nodes
- Each node connected to other nodes
- Examples of tree-like structures
- Trees: binary, balanced, ordered, etc.
- Graphs: directed / undirected, weighted, etc.
- Networks
- 4


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Tree-like Data Structures
- 5
- Project Manager
- Team Leader
- De-signer
- QA Team Leader
- Developer 1
- Developer 2
- Tester 1
- Developer 3
- Tester 2
- Tree
- Graph
- 7
- 19
- 21
- 14
- 1
- 12
- 31
- 4
- 11
- 2
- 3
- 6
- 1
- 4
- 5
- 5 (20)
- 5 (10)
- 15 (15)
- 15 (30)
- 5 (5)
- 20(20)
- 10 (40)
- Network


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Trees and Related Terminology
- Node, Edge, Root, Children, Parent, Leaf, Binary Search Tree, Balanced Tree


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Trees
- Tree data structure – terminology
- Node, edge, root, child, children, siblings, parent, ancestor, descendant, predecessor, successor, internal node, leaf, depth, height, subtree
- Height = 3
- Depth 0
- Depth 1
- Depth 2
- 17
- 15
- 14
- 9
- 6
- 5
- 8
- 7


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Binary Trees
- Binary trees: the most widespread form
- Each node has at most 2 children
- 10
- 17
- 15
- 9
- 6
- 5
- 8
- Root node
- Left subtree
- Right child
- Right child
- Left child
- 8


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Binary Search Trees
- Binary search trees are ordered
- For each node x in the tree
- All the elements of the left subtree of x are ≤ x
- All the elements of the right subtree of x are > x
- Binary search trees can be balanced
- Balanced trees have height of ~ log(x)
- Balanced trees have for each node nearly equal number of nodes in its subtrees
- 9


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Binary Search Trees (2)
- Example of balanced binary search tree
- If the tree is balanced, add / search / delete operations take approximately log(n) steps
- 17
- 19
- 9
- 6
- 12
- 25
- 10


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Implementing Trees
- Recursive Tree Data Structure


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Recursive Tree Definition
- The recursive definition for tree data structure:
- A single node is tree
- Tree nodes can have zero or multiple children that are also trees
- Tree node definition in C#
- 12
- public class TreeNode<T>
- {
-   private T value;
-   private List<TreeNode<T>> children;
-   …
- }
- The value contained in the node
- List of child nodes, which are of the same type


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# TreeNode<int> Structure
- 13
- 7
- children
- 19
- children
- 21
- children
- 14
- children
- TreeNode<int>
- 1
- children
- 12
- children
- 31
- children
- 23
- children
- 6
- children
- int value
- List<TreeNode<int>> children


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Implementing TreeNode<T>
- 14
- public TreeNode(T value)
- {
-   this.value = value;
-   this.children = new List<TreeNode<T>>();
- }
- public T Value
- {
-   get { return this.value; }
-   set { this.value = value; }
- }
- public void AddChild(TreeNode<T> child)
- {
-   child.hasParent = true;
-   this.children.Add(child);
- }
- public TreeNode<T> GetChild(int index)
- {
-   return this.children[index];
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# The class Tree<T> keeps tree's root node
- Implementing Tree<T>
- 15
- public class Tree<T>
- {
-   private TreeNode<T> root;
-   public Tree(T value, params Tree<T>[] children) :    this(value)
-   {
-     foreach (Tree<T> child in children)
-     {
-       this.root.AddChild(child.root);
-     }
-   }
-   public TreeNode<T> Root
-   {
-     get {  return this.root; }
-   }
- }
- Flexible constructor for building trees


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Building a Tree
- 16
- Tree<int> tree =
-    new Tree<int>(7,
-       new Tree<int>(19,
-          new Tree<int>(1),
-          new Tree<int>(12),
-          new Tree<int>(31)),
-       new Tree<int>(21),
-       new Tree<int>(14,
-          new Tree<int>(23),
-          new Tree<int>(6))
- );
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12
- Constructing a tree by nested constructors:


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Tree Traversals
- DFS and BFS Traversals


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Tree Traversal Algorithms
- Traversing a tree means to visit each of its nodes exactly one in particular order
- Many traversal algorithms are known
- Depth-First Search (DFS)
- Visit node's successors first
- Usually implemented by recursion
- Breadth-First Search (BFS)
- Nearest nodes visited first
- Implemented by a queue
- 18


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Depth-First Search first visits all descendants of given node recursively, finally visits the node itself
- DFS algorithm pseudo code
- Depth-First  Search (DFS)
- DFS(node)
- {
-   for each child c of node
-     DFS(c);
-   print the current node;
- }
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12
- 1
- 2
- 3
- 4
- 5
- 8
- 6
- 7
- 9
- 19


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 1)
- Stack: 7
- Output: (empty)
- 20
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 2)
- Stack: 7, 19
- Output: (empty)
- 21
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 3)
- Stack: 7, 19, 1
- Output: (empty)
- 22
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 4)
- Stack: 7, 19
- Output: 1
- 23
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 5)
- Stack: 7, 19, 12
- Output: 1
- 24
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 6)
- Stack: 7, 19
- Output: 1, 12
- 25
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 7)
- Stack: 7, 19, 31
- Output: 1, 12
- 26
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 8)
- Stack: 7, 19
- Output: 1, 12, 31
- 27
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 9)
- Stack: 7
- Output: 1, 12, 31, 19
- 28
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 10)
- Stack: 7, 21
- Output: 1, 12, 31, 19
- 29
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 11)
- Stack: 7
- Output: 1, 12, 31, 19, 21
- 30
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 12)
- Stack: 7, 14
- Output: 1, 12, 31, 19, 21
- 31
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 13)
- Stack: 7, 14, 23
- Output: 1, 12, 31, 19, 21
- 32
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 14)
- Stack: 7, 14
- Output: 1, 12, 31, 19, 21, 23
- 33
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 15)
- Stack: 7, 14, 6
- Output: 1, 12, 31, 19, 21, 23
- 34
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 16)
- Stack: 7, 14
- Output: 1, 12, 31, 19, 21, 23, 6
- 35
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 17)
- Stack: 7
- Output: 1, 12, 31, 19, 21, 23, 6, 14
- 36
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# DFS in Action (Step 18)
- Stack: (empty)
- Output: 1, 12, 31, 19, 21, 23, 6, 14, 7
- 37
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12
- Traversal finished


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Breadth-First Search first visits the neighbor nodes, later their neighbors, etc.
- BFS algorithm pseudo code
- Breadth-First  Search (BFS)
- BFS(node)
- {
-   queue  node
-   while queue not empty
-     v  queue
-     print v
-     for each child c of v
-       queue  c
- }
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12
- 5
- 6
- 7
- 2
- 3
- 4
- 8
- 9
- 1
- 38


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 1)
- Queue: 7
- Output: 7
- 39
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 2)
- Queue: 7, 19
- Output: 7
- 40
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 3)
- Queue: 7, 19, 21
- Output: 7
- 41
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 4)
- Queue: 7, 19, 21, 14
- Output: 7
- 42
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 5)
- Queue: 7, 19, 21, 14
- Output: 7, 19
- 43
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 6)
- Queue: 7, 19, 21, 14, 1
- Output: 7, 19
- 44
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 7)
- Queue: 7, 19, 21, 14, 1, 12
- Output: 7, 19
- 45
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 8)
- Queue: 7, 19, 21, 14, 1, 12, 31
- Output: 7, 19
- 46
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 9)
- Queue: 7, 19, 21, 14, 1, 12, 31
- Output: 7, 19, 21
- 47
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 10)
- Queue: 7, 19, 21, 14, 1, 12, 31
- Output: 7, 19, 21, 14
- 48
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 11)
- Queue: 7, 19, 21, 14, 1, 12, 31, 23
- Output: 7, 19, 21, 14
- 49
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 12)
- Queue: 7, 19, 21, 14, 1, 12, 31, 23, 6
- Output: 7, 19, 21, 14
- 50
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 13)
- Queue: 7, 19, 21, 14, 1, 12, 31, 23, 6
- Output: 7, 19, 21, 14, 1
- 51
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 14)
- Queue: 7, 19, 21, 14, 1, 12, 31, 23, 6
- Output: 7, 19, 21, 14, 1, 12
- 52
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 15)
- Queue: 7, 19, 21, 14, 1, 12, 31, 23, 6
- Output: 7, 19, 21, 14, 1, 12, 31
- 53
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 16)
- Queue: 7, 19, 21, 14, 1, 12, 31, 23, 6
- Output: 7, 19, 21, 14, 1, 12, 31, 23
- 54
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 16)
- Queue: 7, 19, 21, 14, 1, 12, 31, 23, 6
- Output: 7, 19, 21, 14, 1, 12, 31, 23, 6
- 55
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# BFS in Action (Step 17)
- Queue: 7, 19, 21, 14, 1, 12, 31, 23, 6
- Output: 7, 19, 21, 14, 1, 12, 31, 23, 6
- 56
- 7
- 14
- 19
- 23
- 6
- 21
- 31
- 1
- 12
- The queue is empty  stop


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Binary Trees DFS Traversals
- DFS traversal of binary trees can be done in pre-order, in-order and post-order
- Pre-order: root, left, right  17, 9, 6, 12, 19, 25
- In-order: left, root, right  6, 9, 12, 17, 19, 25 
- Post-order: left, right, root  6, 12, 9, 25, 19, 17
- 17
- 19
- 9
- 6
- 12
- 25
- 57


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Iterative DFS and BFS
- What will happen if in the Breadth-First Search (BFS) algorithm a stack is used instead of queue?
- An iterative Depth-First Search (DFS) – in-order
- 58
- BFS(node)
- {
-   queue  node
-   while queue not empty
-     v  queue
-     print v
-     for each child c of v
-       queue  c
- }
- DFS(node)
- {
-   stack  node
-   while stack not empty
-     v  stack
-     print v
-     for each child c of v
-       stack  c
- }


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Trees and Traversals
- Live Demo


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Balanced Search Trees
- AVL Trees, B-Trees, Red-Black Trees, AA-Trees


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Balanced Binary Search Trees
- Ordered Binary Trees (Binary Search Trees)
- For each node x the left subtree has values ≤ x and the right subtree has values > x
- Balanced Trees
- For each node its subtrees contain nearly equal number of nodes  nearly the same height
- Balanced Binary Search Trees
- Ordered binary search trees that have height of log2(n) where n is the number of their nodes
- Searching costs about log2(n) comparisons
- 61


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Balanced BinarySearch Tree – Example
- 62
- 33
- 18
- 15
- 24
- 3
- 17
- 20
- 29
- 54
- 42
- 60
- 37
- 43
- 59
- 85


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Balanced Binary Search Trees
- Balanced binary search trees are hard to implement
- Rebalancing the tree after insert / delete is complex
- Well known implementations of balanced binary search trees
- AVL trees – ideally balanced, very complex
- Red-black trees – roughly balanced, more simple
- AA-Trees – relatively simple to implement
- Find / insert / delete operations need log(n) steps
- 63


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# B-Trees
- B-trees are generalization of the concept of ordered binary search trees
- B-tree of order d has between d and 2*d keys in a node and between d+1 and 2*d+1 child nodes
- The keys in each node are ordered increasingly
- All keys in a child node have values between their left and right parent keys
- If the b-tree is balanced, its search / insert / add operations take about log(n) steps
- B-trees can be efficiently stored on the disk
- 64


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# B-Tree of order 2 (also known as 2-3-4-tree):
- B-Tree – Example
- 65
- 17
- 21
- 7
- 11
- 18
- 20
- 26
- 31
- 2
- 4
- 5
- 6
- 8
- 9
- 12
- 16
- 22
- 23
- 25
- 27
- 29
- 30
- 32
- 35


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Balanced Trees in .NET
- .NET Framework has several built-in implementations of balanced search trees:
- SortedDictionary<K,V>
- Red-black tree based map of key-value pairs
- OrderedSet<T>
- Red-black tree based set of elements
- External libraries like "Wintellect Power Collections for .NET" are more flexible
- http://powercollections.codeplex.com 
- 66


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Summary
- Trees are recursive data structure – node with set of children which are also nodes
- Binary Search Trees are ordered binary trees
- Balanced trees have weight of log(n)
- Graphs are sets of nodes with many-to-many relationship between them
- Can be directed/undirected, weighted / unweighted, connected / not connected, etc.
- Tree / graph traversals can be done by Depth-First Search (DFS) and Breadth-First Search (BFS)
- 67


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Trees and Traversals
- http://academy.telerik.com


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Exercises
- You are given a tree of N nodes represented as a set of N-1 pairs of nodes (parent node, child node), each in the range (0..N-1). Example:
- 69
- 7
- 2 4
- 3 2
- 5 0
- 3 5
- 5 6
- 5 1
- 3
- 2
- 0
- 1
- 4
- 5
- 6
- Write a program to read the tree and find:
- the root node
- all leaf nodes
- all middle nodes
- the longest path in the tree
- * all paths in the tree with given sum S of their nodes
- * all subtrees with given sum S of their nodes


<!-- attr: { id:'', class:'', showInPresentation:true, hasScriptWrapper:true, style:'font-size:1em' } -->
# Exercises (2)
- Write a program to traverse the directory C:\WINDOWS and all its subdirectories recursively and to display all files matching the mask *.exe. Use the class System.IO.Directory.
- Define classes File { string name, int size } and Folder { string name, File[] files, Folder[] childFolders } and using them build a tree keeping all files and folders on the hard drive starting from C:\WINDOWS. Implement a method that calculates the sum of the file sizes in given subtree of the tree and test it accordingly. Use recursive DFS traversal.
- 70


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


