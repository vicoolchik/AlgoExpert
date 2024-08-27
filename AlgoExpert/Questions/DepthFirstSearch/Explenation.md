# AlgoExpert - Depth First Search (DFS) Solution

This code provides a solution to the Depth First Search (DFS) traversal problem on a graph represented as a tree structure. The DFS algorithm explores as far as possible along each branch before backing up, making it ideal for tasks such as searching for all nodes or paths in a graph. The solution is implemented within the `Node` class, which represents a node in the graph.

## `DepthFirstSearch`

### Description
The `DepthFirstSearch` method is a recursive implementation of the DFS algorithm. Starting from the current node (root in this case), the method explores each child node in a depth-first manner. The traversal visits each node, adding its name to a list that is returned at the end of the traversal.

### Time and Space Complexity
- **Time Complexity:** O(v + e) - The time complexity is linear relative to the number of vertices (`v`) and edges (`e`) in the graph. The algorithm visits each node and edge exactly once.
- **Space Complexity:** O(v) - The space complexity is proportional to the number of vertices (`v`), primarily due to the recursive call stack and the list used to store the traversal result.

### How It Works
1. **Initialization:** The DFS traversal is initiated by calling `DepthFirstSearch` on the root node, with an empty list passed as the argument to store the traversal result.

2. **Recursive Traversal:** 
   - The method first adds the current node's name to the list.
   - It then recursively calls `DepthFirstSearch` on each child node in the `children` list.
   - This continues until all nodes reachable from the root have been visited.

3. **Return Result:** Once all nodes have been visited, the list containing the node names in DFS order is returned.

### Example Walkthrough


- The `DepthFirstSearch` method starts at node "A".
- It first visits "A", then goes deeper to "B", and continues until all children of "B" are explored.
- After visiting "B", it moves on to the next child of "A" ("C") and so on.
- The order of traversal for the above graph would be: `["A", "B", "E", "F", "C", "G", "D", "H", "I", "J"]`.

### Pros
- **Clarity:** The recursive implementation is straightforward and mirrors the depth-first traversal conceptually, making it easy to understand.
- **Simplicity:** The code is concise and leverages recursion to handle the traversal, eliminating the need for an explicit stack management.

### Cons
- **Stack Overflow Risk:** In languages like C#, deep recursion can lead to stack overflow if the graph is very large or deeply nested. Iterative DFS implementations using an explicit stack can mitigate this risk.

## `AddChild`

### Description
The `AddChild` method allows for the construction of the graph by adding child nodes to a given node. It returns the current node, enabling method chaining to build the graph structure in a concise manner.

### Example Usage
- `graph.AddChild("B").AddChild("E").AddChild("F");`
  - This adds children "B", "E", and "F" to node "A".

### Pros
- **Fluent Interface:** The method chaining enabled by `AddChild` makes the graph construction more readable and concise.

## Conclusion

The `DepthFirstSearch` method provides an effective and intuitive way to perform DFS traversal on a tree-like graph. The recursive approach is easy to implement and understand, making it a solid choice for small to medium-sized graphs. However, for very large graphs, an iterative approach might be more suitable to avoid the potential for stack overflow.

The overall design, with a simple node structure and the ability to add children fluently, makes this implementation both functional and easy to use for various DFS-related tasks.

