# AlgoExpert - Evaluate Expression Tree Solution

This code provides a solution to the problem of evaluating an expression tree. An expression tree is a binary tree where each internal node represents an operator (`+`, `-`, `*`, `/`), and each leaf node represents an operand (a non-negative integer). The goal is to evaluate the expression represented by the tree and return the result. The method implemented here is `EvaluateExpressionTree`, which uses a recursive approach to evaluate the expression tree. Below is a detailed description of the solution, including its advantages and disadvantages.

## `EvaluateExpressionTree`

### Description
The `EvaluateExpressionTree` method computes the result of an arithmetic expression represented by a binary tree. The tree's internal nodes contain negative values that correspond to specific operators (`-1` for addition, `-2` for subtraction, `-3` for multiplication, and `-4` for division). The leaf nodes contain non-negative integers, which are the operands of the expression.

### Time and Space Complexity
- **Time Complexity:** O(n) - The method visits every node in the tree exactly once, where `n` is the total number of nodes in the tree.
- **Space Complexity:** O(h) - The space complexity is primarily due to the recursion stack, which can go as deep as the height of the tree, `h`. In the worst case of a skewed tree, this could be as large as `n`.

### How It Works
1. **Initialization:** The method `EvaluateExpressionTree` calls the helper method `CalculateExpressionTree` with the root node to start the evaluation process.

2. **Recursive Evaluation:** The `CalculateExpressionTree` method evaluates the tree recursively:
   - **Base Case:** If the current node's value is non-negative (indicating a leaf node), it directly returns the node's value.
   - **Recursive Case:** If the current node represents an operator (indicated by a negative value), the method recursively evaluates the left and right subtrees to obtain their respective values.
   - The method then applies the operator at the current node to the results of the left and right subtrees.

3. **Operator Handling:** The operators are encoded as specific negative values:
   - `-1` corresponds to addition (`+`)
   - `-2` corresponds to subtraction (`-`)
   - `-3` corresponds to multiplication (`*`)
   - `-4` corresponds to division (`/`)
   - The method performs the appropriate arithmetic operation based on the value of the current node.

4. **Return Result:** The method returns the final result after evaluating the entire expression tree.

### Pros
- **Clarity:** The recursive approach is intuitive and closely mirrors the process of evaluating a mathematical expression.
- **Direct Implementation:** The method directly handles each type of operation with simple condition checks, making it easy to extend if additional operators are needed.

### Cons
- **Space Usage:** The recursive approach uses additional space due to the recursion stack, which can be a concern for very deep trees.
- **Limited Operator Set:** The method is currently limited to four basic arithmetic operations. Extending it to support more operators would require additional conditions.
