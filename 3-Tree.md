# Trees
_Have you ever tried condensing your files into different folders to help organize them better? Your folders become the link to your files, and your folders are linked to your home section (disregarding other sections like downloads depending on what type of computer you've got). This is what trees are. A tree (your home section) with it's branches (folders, then even smaller branches in your files/other folders).

## Trees are Directed Graphs
_Graphs in computer science are 2 or more nodes (points) with connections. Like the intersection between streets, and the streets themselves are the path ways. Trees are directed graphs because they have a root (first/parent) node, and all the other nodes are directed out from that root._

## Roots and Parent/Child Relationships
_A great way to picture trees is as a parent/child relationship. The root is the first parent. Then the nodes/points connected to it are their children. Then the nodes connected to each child are their own children. Literally, a family tree_

## Binary, and Binary Search Trees
_A basic type of tree is a binary tree. Like the name, each parent has 2 children/nodes at most (1 to the left, and 1 to the right). A binary search tree adds rules to the order of the nodes. Comparing to the root, if a value is less than the root, then it goes to the left. If another value goes to the left, then it's compared against the other child, and the greater value becomes the right child node. Then this continues if the children nodes have their own child nodes. Any node that is left without children is called a leaf node._

[Binary Search Tree-Credit to https://visualgo.net/en/bst](binary-search-tree.png)

## Balancing Binary Search Trees
_So every tree has a height. The root is counted as 1, and then it's children add 1 to the height. Then if 1 of the children has a child node, that adds 1 more level to the height, and then that child has one, which now makes the height of that side higher than the rest of that tree's paths. This leads to an unbalance, and decreases the performance of using a tree (specifically binary search trees). There have been algorithms created to deal with this problem. One of them is called AVL (Adelson-Velskii and Landis) trees. Basically, if a child of the root has a child, then that child has a child, and that child has a child, the last 2 childs become sibling nodes to help correct the balance._ 

## Traversing a Tree
_In order to display the data in a tree, one has to traverse (travel) through it. There are different ways of doing it, but we will focus on going in order from smallest to largest._


## Real Life Uses
_Already mentioned, this is how a computer organizes it's files/folders (although not necessarily a binary tree). They can also be used for decision trees (organizing decisions based on their given weight value in a tree), sorting data in a hierarchal order, and the compilers that compile our code (in regards to syntax expressions). Even the way our code is organized with main, and then functions/classes as childs of main, with other functions within those as their own children._

## Efficiency
_Binary search trees can become very complicated, and balancing them even moreso. It's important to understand when using a BST would be useful, and when it's too much of a hassle (especially with large datasets). In basic _
## Example Problem : Creating a BST algorithm

```csharp
Node node = new Node();
```

## Problem to Solve : 

[Back to Welcome Page](/0-welcome.md)