# AlgoExpert - Get Nth Fibonacci Solution

This code provides two different solutions to the problem of finding the Nth Fibonacci number. The Fibonacci sequence is a series of numbers where each number is the sum of the two preceding ones, typically starting with 0 and 1. The solutions implemented are `GetNthFib`, which uses a recursive approach, and `GetNthFib1`, which uses an iterative approach.

## `GetNthFib`

### Description
The `GetNthFib` method calculates the Nth Fibonacci number using a recursive approach. This method follows the straightforward definition of the Fibonacci sequence, where each term is the sum of the two preceding terms.

### Time and Space Complexity
- **Time Complexity:** O(2^n) - The time complexity is exponential because the method recalculates Fibonacci numbers multiple times due to overlapping subproblems.
- **Space Complexity:** O(n) - The space complexity is linear, as the recursion depth can go as deep as `n`.

### How It Works
1. **Base Cases:** 
   - If `n == 2`, the method returns `1` because the second Fibonacci number is `1`.
   - If `n == 1`, the method returns `0` because the first Fibonacci number is `0`.

2. **Recursive Case:** 
   - For any other value of `n`, the method recursively calculates `GetNthFib(n - 1) + GetNthFib(n - 2)`.

### Example Walkthrough
For `GetNthFib(6)`:
- The method computes `GetNthFib(5) + GetNthFib(4)`, where each of these calls further breaks down until the base cases are reached.
- This approach results in a lot of redundant calculations, leading to inefficiency.

### Pros
- **Clarity:** The recursive approach is easy to understand and directly follows the mathematical definition of Fibonacci numbers.

### Cons
- **Inefficiency:** The exponential time complexity makes this method impractical for large values of `n`.

## `GetNthFib1`

### Description
The `GetNthFib1` method calculates the Nth Fibonacci number using an iterative approach, which is much more efficient. It keeps track of the last two Fibonacci numbers and iteratively computes the next one until the Nth number is reached.

### Time and Space Complexity
- **Time Complexity:** O(n) - The time complexity is linear, as the method only requires a single pass through the sequence up to `n`.
- **Space Complexity:** O(1) - The space complexity is constant, as it only uses a fixed amount of space to store the last two Fibonacci numbers.

### How It Works
1. **Initialization:** The method starts by initializing an array `lastTwo` to store the first two Fibonacci numbers: `[0, 1]`.

2. **Iterative Calculation:** 
   - Starting from the third Fibonacci number, the method iteratively calculates the next Fibonacci number as the sum of the previous two.
   - It updates `lastTwo` after each iteration, ensuring that the latest two Fibonacci numbers are always available.

3. **Return Result:** 
   - After iterating until the Nth number, the method returns the appropriate value from `lastTwo`.

### Example Walkthrough
For `GetNthFib1(6)`:
- The method calculates the Fibonacci numbers iteratively: `0, 1, 1, 2, 3, 5`.
- The 6th Fibonacci number is `5`.

### Pros
- **Efficiency:** The method is both time and space-efficient, making it suitable for large values of `n`.
- **Simplicity:** Despite its efficiency, the iterative approach is straightforward and easy to implement.

### Cons
- **Less Intuitive:** For those familiar with the recursive definition of Fibonacci, the iterative approach might initially seem less intuitive.

## Conclusion

- **Best for Small `n`:** The `GetNthFib` method is easy to understand and sufficient for small values of `n`, but it becomes inefficient as `n` increases due to its exponential time complexity.
- **Best for Large `n`:** The `GetNthFib1` method is far more efficient and can handle large values of `n` with ease due to its linear time complexity and constant space usage.

In most practical scenarios, `GetNthFib1` is the preferred method due to its superior performance.
