# Trees
_Have you ever tried condensing your files into different folders to help organize them better? Your folders become the link to your files, and your folders are linked to your home section (disregarding other sections like downloads depending on what type of computer you've got). This is what trees are. A tree (your home section) with it's branches (folders, then even smaller branches in your files/other folders).

## Trees are Directed Graphs
_Graphs in computer science are 2 or more nodes (points) with connections. Like the intersection between streets, and the streets themselves are the path ways. Trees are directed graphs because they have a root (first/parent) node, and all the other nodes are directed out from that root._

## Roots and Parent/Child Relationships
_A great way to picture trees is as a parent/child relationship. The root is the first parent. Then the nodes/points connected to it are their children. Then the nodes connected to each child are their own children. Literally, a family tree. Similar to linked lists to in how every node's value has pointers. Although in this case their called root, left, and right pointers instead of head and tail._

## Binary, and Binary Search Trees
_A basic type of tree is a binary tree. Like the name, each parent has 2 children/nodes at most (1 to the left, and 1 to the right). A binary search tree adds rules to the order of the nodes. Comparing to the root, if a value is less than the root, then it goes to the left. If another value goes to the left, then it's compared against the other child, and the greater value becomes the right child node. Then this continues if the children nodes have their own child nodes. Any node that is left without children is called a leaf node._

[Binary Search Tree-Credit to https://visualgo.net/en/bst](binary-search-tree.png)

## Balancing Binary Search Trees
_So every tree has a height. The root is counted as 1, and then it's children add 1 to the height. Then if 1 of the children has a child node, that adds 1 more level to the height, and then that child has one, which now makes the height of that side higher than the rest of that tree's paths. This leads to an unbalance, and decreases the performance of using a tree (specifically binary search trees). There have been algorithms created to deal with this problem. One of them is called AVL (Adelson-Velskii and Landis) trees. Basically, if a child of the root has a child, then that child has a child, and that child has a child, the last 2 childs become sibling nodes to help correct the balance._ 

## Traversing a Tree
_In order to display the data in a tree, one has to traverse (travel) through it. You have to make recursive calls (whenever a function calls itself) to traverse through each node in the tree. You can see that the recursive calls are flipped when going forward, and going backwards through a tree._

```csharp
 private void TraverseForward(Node? node, List<int> values) {
        if (node is not null) {
            TraverseForward(node.Left, values);
            values.Add(node.Data);
            TraverseForward(node.Right, values);
        }
    }
 private void TraverseBackward(Node? node, List<int> values) {
        // flip from traverse forward function
        if (node is not null) {
            TraverseBackward(node.Right, values);
            values.Add(node.Data);
            TraverseBackward(node.Left, values);
        }
    }
```

## Real Life Uses
_Already mentioned, this is how a computer organizes it's files/folders (although not necessarily a binary tree). They can also be used for decision trees (organizing decisions based on their given weight value in a tree), sorting data in a hierarchal order, and the compilers that compile our code (in regards to syntax expressions). Even the way our code is organized with main, and then functions/classes as childs of main, with other functions within those as their own children._

## Efficiency
_Binary search trees are great for finding values in sorted lists/arrays because they search through the tree in O(log n) time, if the value is less than the root, that cuts the list in half, same if it's greater, and then it keeps the tree in half until it finds the value._

## Example Problem : Finding your ID
_Imagine your adding ids to a system, and you need to check if you added your own id. Binary Search Trees are very useful since they automatically sort values, and can search through for your ID in O(log n) time._

```csharp
BinarySearchTree tree = new BinarySearchTree();
// Insert ids
tree.Insert(138910);
tree.Insert(151590);
tree.Insert(112113);
tree.Insert(135533);
tree.Insert(135515);
tree.Insert(153515);

// Check for your id
tree.Contains(151590); // Should return true
```

## Problem to Solve : Find your Mom's Cell Phone
__Given the Node, and BST classes, and a list of numbers find the cellphone number you're looking for.__

_Compare the efficiency of using List.Contains vs Tree.Contains given a list of 7 digit phone numbers (minus the area codes because otherwise the phone numbers would be considered long data types instead of int) Check the list first, print the time elapsed, and then add the values in the list to the tree, and then search with the tree, print the tree to make sure you added it right, and print the time elapsed there._ 

- [224762901, 2151351359, 1515910101, 1395010959, 19015910010, 1059501001, 1091001010, 1019910590, 7581090100, 5510059819, 1910595018, 5910050111]



```csharp
// (c) BYU-Idaho
public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }
    public bool Contains(int value) {
        // value equals the root, so return true
        if (value == Data) {
            return true;
            // if value is less than data(the root), then left is not null, and check if left contains value
        } else if (value < Data) {
            return Left != null && Left.Contains(value);
            //Otherwise check the right side of the tree
        } else {
            return Right != null && Right.Contains(value);
        }
        // if value isn't in data, left, or right, then return false
        return false;
    }

    public int GetHeight()
    {
        // set up counters for each side of the tree
        int leftHeight = 0;
        int rightHeight = 0;
        // if left isn't null, set counter equal to recursive call for left
        if (Left != null)
        {
            leftHeight = Left.GetHeight();
        }
        // same for the right side
        if (Right != null)
        {
            rightHeight = Right.GetHeight();
        }
        
        // return whichever height is greater + 1 to account for the root
        return Math.Max(leftHeight, rightHeight) + 1;
        
    }
}
public class BinarySearchTree : IEnumerable<int> {
    private Node? _root;

    /// <summary>
    /// Insert a new node at the root of the tree.
    /// </summary>
    public void Insert(int value) {
        // Create new node
        Node newNode = new Node(value);
        // If the list is empty, then point root to the new node.
        if (_root is null)
        {
            _root = newNode;
        }
        // If the list is not empty, then only root will be affected.
        else
        {
            // if root doesn't contain value, insert
            if (!_root.Contains(value))
            {
                _root.Insert(value);
            }
        }
    }
}
/// <summary>
    /// Check to see if the tree contains a certain value
    /// </summary>
    /// <param name="value">The value to look for</param>
    /// <returns>true if found, otherwise false</returns>
    public bool Contains(int value)
    {
        // return false if root is null
        if (_root is null)
        {
            return false;
        }
        // return bool value
        return _root.Contains(value);
    }

    /// <summary>
    /// Yields all values in the tree
    /// </summary>
    IEnumerator IEnumerable.GetEnumerator() {
        // call the generic version of the method
        return GetEnumerator();
    }

    /// <summary>
    /// Iterate forward through the BST
    /// </summary>
    public IEnumerator<int> GetEnumerator() {
        var numbers = new List<int>();
        TraverseForward(_root, numbers);
        foreach (var number in numbers) {
            yield return number;
        }
    }
     private void TraverseForward(Node? node, List<int> values) {
        if (node is not null) {
            TraverseForward(node.Left, values);
            values.Add(node.Data);
            TraverseForward(node.Right, values);
        }
    }

    /// <summary>
    /// Iterate backward through the Linked List
    /// </summary>
    public IEnumerable Reverse() {
        var numbers = new List<int>();
        TraverseBackward(_root, numbers);
        foreach (var number in numbers) {
            yield return number;
        }
    }

    private void TraverseBackward(Node? node, List<int> values) {
        // flip from traverse forward function
        if (node is not null) {
            TraverseBackward(node.Right, values);
            values.Add(node.Data);
            TraverseBackward(node.Left, values);
        }
    }

    /// <summary>
    /// Get the height of the tree
    /// </summary>
    public int GetHeight() {
        if (_root is null)
            return 0;
        return _root.GetHeight();
    }

    public override string ToString() {
        return "<Bst>{" + string.Join(", ", this) + "}";
    }
```

_Should look something like this. Obviously, CPUs can vary on amount of time needed._
```csharp
List search: 00:00:00.0400240
<Bst>{595018, 1001010, 1090100, 1351359, 1750111, 1759819, 5010959, 5910101, 7629011, 9501001, 9910590, 15910010}
Tree Search: 00:00:00.0000440
```

[Problem Solution](/tree-problem-solution)

[Back to Welcome Page](/0-welcome.md)