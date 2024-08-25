# AlgoExpert - Branch Sums Solutions

This code provides two different solutions to the problem of calculating the branch sums in a binary tree. A branch sum is defined as the sum of all values along a path from the root node to any leaf node. The two methods implemented are `BranchSums` using recursion and `CalculateBranchSumsWithStack` using an iterative approach with a stack. Below is a detailed description of each approach, including their advantages and disadvantages.

## `BranchSums`

### Description
The `BranchSums` method computes the sum of each branch in the binary tree using a recursive approach. It starts from the root and recursively traverses down each branch, accumulating the sum of node values until a leaf node is reached. The accumulated sum is then added to a list that stores the sums for all branches.

### Time and Space Complexity
- **Time Complexity:** O(n) - The method visits every node in the tree exactly once, where `n` is the total number of nodes in the tree.
- **Space Complexity:** O(n) - The space complexity is primarily due to the recursion stack, which can go as deep as the height of the tree. In the worst case of a skewed tree, this could be as large as `n`.

### How It Works
1. **Initialization:** The method `BranchSums` initializes an empty list `sums` to store the branch sums and calls the helper method `CalculateBranchSums` with the root node.
   
2. **Recursive Traversal:** The `CalculateBranchSums` method recursively traverses the tree:
   - It adds the current node's value to the running sum.
   - If the node is a leaf (both left and right children are null), the running sum is added to the list `sums`.
   - Otherwise, it recursively calls itself for both the left and right children of the current node.

3. **Result:** After the entire tree is traversed, the list `sums` contains the sum of all branches and is returned.

### Pros
- **Clarity:** The recursive approach is intuitive and easy to understand, especially for problems related to tree traversal.
- **Direct Implementation:** The method closely mirrors the conceptual approach of summing values along each branch.

### Cons
- **Space Usage:** The recursive approach uses additional space due to the recursion stack, which can be a concern for very deep trees.

## `CalculateBranchSumsWithStack`

### Description
The `CalculateBranchSumsWithStack` method provides an iterative alternative to the recursive approach. It uses a stack to simulate the depth-first traversal of the tree, computing the branch sums iteratively. This approach avoids the potential issue of stack overflow in cases of very deep recursion.

### Time and Space Complexity
- **Time Complexity:** O(n) - The method processes each node in the tree once, ensuring linear time complexity.
- **Space Complexity:** O(n) - The space complexity is due to the stack used to simulate recursion. In the worst case, the stack could hold all nodes in the longest branch, which is at most `n` nodes.

### How It Works
1. **Initialization:** The method initializes a stack that stores tuples of the current node and its corresponding running sum. The root node and an initial running sum of 0 are pushed onto the stack.

2. **Iterative Traversal:** The method enters a loop that continues until the stack is empty:
   - It pops the top element from the stack, which gives the current node and the running sum up to that node.
   - The current node's value is added to the running sum.
   - If the node is a leaf, the running sum is added to the list `sums`.
   - If the node has children, they are pushed onto the stack with their corresponding running sums.

3. **Result:** The method continues until all nodes are processed, and the list `sums` containing all branch sums is returned.

### Pros
- **Avoids Recursion Limits:** This method is safer for very deep trees as it avoids the limitations of the call stack in recursion.
- **Iterative Approach:** Some developers may find the iterative approach easier to manage, especially in environments where recursion depth is limited.

### Cons
- **Complexity:** The iterative approach, while avoiding recursion issues, can be more complex and less intuitive compared to the recursive approach.

## Conclusion

- **Best for Simplicity:** The `BranchSums` method using recursion is generally more straightforward and easier to understand. It is ideal for most scenarios unless you are dealing with extremely deep trees.
- **Best for Large Depth Trees:** The `CalculateBranchSumsWithStack` method is preferable when working with very large or deep trees where stack overflow could be a concern. It provides a robust solution without the risks associated with deep recursion.

Both methods efficiently calculate the branch sums in a binary tree, with the choice between them depending on the specific needs of your application.
