# AlgoExpert - Find Closest Value in BST Solutions

This code provides two different solutions to the problem of finding the closest value to a given target in a Binary Search Tree (BST). The BST is structured such that for any given node, values in its left subtree are less, and values in its right subtree are greater. The two methods implemented are `FindClosestValueInBst` and `FindClosestValueInBst1`. Below is a detailed description of each approach, including their advantages and disadvantages.

## `FindClosestValueInBst`

### Description
The `FindClosestValueInBst` method uses an iterative approach to traverse the BST and find the value closest to the target. Starting from the root, it compares the current node's value with the closest value found so far and updates the closest value if the current node's value is nearer to the target. The method continues traversing the tree either left or right depending on whether the target is less than or greater than the current node's value, respectively. The process repeats until the closest value is found or the tree traversal is complete.

### Time and Space Complexity
- **Average Time Complexity:** O(log(n)) - This occurs when the tree is balanced, leading to a logarithmic traversal time relative to the number of nodes, `n`.
- **Worst Time Complexity:** O(n) - In the case of an unbalanced tree (e.g., a skewed tree), the time complexity could degrade to linear.
- **Space Complexity:** O(1) - The method uses a constant amount of extra space, as it only requires a few variables to track the current node and the closest value.

### How It Works
1. **Initialization:** The method starts by setting `closestValue` to the root's value and `currentNode` to the root node.
2. **Tree Traversal:** A `while` loop is used to traverse the tree:
   - The difference between the target and the closest value is compared with the difference between the target and the current node's value.
   - If the current node's value is closer to the target, `closestValue` is updated.
   - Depending on the comparison between the target and the current node's value, the traversal continues left or right.
3. **Return Closest Value:** The traversal continues until the end of the tree is reached or an exact match is found. The method then returns the closest value found.

### Pros
- **Efficiency:** The iterative approach is space-efficient, using only a constant amount of memory.
- **Performance:** On average, the method performs well with logarithmic time complexity, making it suitable for large balanced BSTs.

### Cons
- **Worst-Case Performance:** In unbalanced trees, the time complexity could degrade to linear, making the method slower in those cases.

## `FindClosestValueInBst1`

### Description
The `FindClosestValueInBst1` method uses a recursive approach to achieve the same goal as the iterative method. It traverses the BST recursively, comparing each node's value with the target and updating the closest value found so far. The recursion continues down the tree until a leaf node is reached, after which the closest value is returned.

### Time and Space Complexity
- **Average Time Complexity:** O(log(n)) - Similar to the iterative approach, this occurs when the tree is balanced.
- **Worst Time Complexity:** O(n) - This could happen in unbalanced trees.
- **Space Complexity:** O(log(n)) - The space complexity is determined by the recursion stack, which in the average case corresponds to the height of the tree. In the worst case, it could degrade to O(n) in an unbalanced tree.

### How It Works
1. **Initial Call:** The method is first called with the root node and the target value.
2. **Recursive Comparison:** At each step, the method:
   - Compares the target with the current node's value to determine whether the closest value should be updated.
   - Recursively calls itself with either the left or right child, depending on the comparison between the target and the current node's value.
3. **Return Closest Value:** Once a leaf node is reached, the recursion unwinds, returning the closest value found.

### Pros
- **Clarity:** The recursive approach can be more intuitive and easier to follow for those familiar with recursion.
- **Direct Implementation:** Recursion allows for a more direct and natural expression of the tree traversal process.

### Cons
- **Space Usage:** The recursive method uses additional space proportional to the height of the tree due to the recursion stack, which could be a limitation in deeply nested trees.
- **Stack Overflow:** For very deep or unbalanced trees, there's a risk of stack overflow due to excessive recursion depth.

## Conclusion

- **Best for Space Efficiency:** `FindClosestValueInBst` is the better choice when space efficiency is crucial, as it uses an iterative approach with constant space complexity.
- **Best for Readability:** `FindClosestValueInBst1` may be preferable for those who favor recursion for its simplicity and natural fit for tree-based problems.

Both methods provide effective solutions for finding the closest value in a BST, with the choice between them largely depending on the specific needs of the application and developer preference.
