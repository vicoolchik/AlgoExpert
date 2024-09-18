# AlgoExpert - Binary Search Tree (BST) Solution

This code provides an implementation of a **Binary Search Tree (BST)**. A BST is a data structure that allows efficient searching, insertion, and deletion operations. This implementation includes methods for inserting values, checking for containment, deleting values, and traversing the tree in various orders.

## `BST` Class

### Description
The `BST` class represents the nodes and structure of a binary search tree. It supports the following operations:
1. **Insert**: Inserts a new value into the tree while maintaining the BST property.
2. **Contains**: Checks whether a value exists in the tree.
3. **Remove**: Removes a value from the tree while maintaining the BST property.
4. **Min**: Finds the minimum value in the tree.
5. **Max**: Finds the maximum value in the tree.
6. **InOrder, PreOrder, PostOrder**: Traverses the tree in different orders.

### Time and Space Complexity
- **Insert, Contains, Remove:**
  - **Average Case (Balanced Tree):** O(log n) time
  - **Worst Case (Unbalanced Tree):** O(n) time
  - **Space Complexity:** O(1) for all operations
- **Traversal Methods (InOrder, PreOrder, PostOrder):**
  - **Time Complexity:** O(n) for traversing all nodes
  - **Space Complexity:** O(n) due to recursion and result storage

### How It Works

#### 1. **Insert Operation:**
- **Description**: Adds a new node with the specified value into the tree.
- **Steps**:
  - Traverse the tree from the root to the appropriate position where the new value should be inserted (based on whether it’s less than or greater than the current node’s value).
  - Insert the value as a new leaf node.
  
#### 2. **Contains Operation:**
- **Description**: Checks if the tree contains the specified value.
- **Steps**:
  - Traverse the tree by comparing the value with the current node.
  - If the value is found, return `true`. If not, return `false` after traversing the tree.

#### 3. **Remove Operation:**
- **Description**: Removes a node with the specified value from the tree.
- **Steps**:
  - Find the node with the value.
  - If the node has two children, replace it with its successor (minimum value in the right subtree).
  - If the node has one or no children, replace it directly with its child (if any) or delete it.

#### 4. **Min and Max Operations:**
- **Description**: Finds the smallest and largest values in the tree, respectively.
- **Steps**:
  - The smallest value is found by traversing left from the root until no more left child exists.
  - The largest value is found by traversing right from the root until no more right child exists.

#### 5. **Tree Traversal Methods:**
- **InOrder Traversal**:
  - Traverses the left subtree, visits the current node, then traverses the right subtree.
  - **Result**: The nodes are visited in ascending order.

- **PreOrder Traversal**:
  - Visits the current node, traverses the left subtree, then traverses the right subtree.

- **PostOrder Traversal**:
  - Traverses the left subtree, traverses the right subtree, then visits the current node.

### Example Usage

```csharp
var bst = new BST(10);
bst.Insert(5).Insert(15).Insert(2).Insert(5).Insert(13).Insert(22).Insert(1).Insert(14);

Console.WriteLine("InOrder: " + string.Join(", ", bst.InOrder()));   // [1, 2, 5, 5, 10, 13, 14, 15, 22]
Console.WriteLine("PreOrder: " + string.Join(", ", bst.PreOrder())); // [10, 5, 2, 1, 5, 15, 13, 14, 22]
Console.WriteLine("PostOrder: " + string.Join(", ", bst.PostOrder())); // [1, 2, 5, 5, 14, 13, 22, 15, 10]

Console.WriteLine("Contains 5: " + bst.Contains(5));   // true
Console.WriteLine("Contains 22: " + bst.Contains(22)); // true

Console.WriteLine("Min: " + bst.Min()); // 1
Console.WriteLine("Max: " + bst.Max()); // 22

bst.Remove(10); // Remove the root
Console.WriteLine("InOrder after removal: " + string.Join(", ", bst.InOrder())); // [1, 2, 5, 5, 13, 14, 15, 22]
