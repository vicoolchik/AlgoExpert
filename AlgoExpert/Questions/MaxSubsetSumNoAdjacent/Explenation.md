# AlgoExpert - Max Subset Sum No Adjacent Solution

This code provides a solution to the "Max Subset Sum No Adjacent" problem. The task is to find the maximum sum of non-adjacent elements in an array, meaning that if you choose one element, you cannot choose the elements immediately before or after it.

## `MaxSubsetSumNoAdjacent`

### Description
The `MaxSubsetSumNoAdjacent` method returns the maximum sum that can be obtained by summing non-adjacent elements from the given array. It uses dynamic programming to keep track of the best possible sum at each step, ensuring that the time complexity is linear and the space complexity is constant.

### Time and Space Complexity
- **Time Complexity:** O(n) - The method iterates through the array once, where `n` is the length of the array.
- **Space Complexity:** O(1) - The method uses constant space by storing only two variables (`first` and `second`) to keep track of the running maximum sums.

### How It Works

1. **Handle Edge Cases:**
   - If the array is empty, return `0` because there are no elements to sum.
   - If the array has only one element, return that element because it's the only possible sum.

2. **Dynamic Programming Approach:**
   - Initialize two variables, `second` and `first`, to store the best possible sums at previous steps:
     - `second`: Represents the maximum sum obtained up to the element two steps before the current element.
     - `first`: Represents the maximum sum obtained up to the element immediately before the current element.
   - For each element in the array (starting from the third element), calculate the maximum sum that can be obtained either by including the current element (i.e., `second + array[i]`) or excluding it (i.e., `first`).
   - Update `second` and `first` as you iterate through the array.

3. **Return the Result:**
   - At the end of the iteration, `first` contains the maximum sum of non-adjacent elements.

### Example Walkthrough

Given the input:
- **Array:** `[75, 105, 120, 75, 90, 135]`

**Step 1:** Handle edge cases:
- The array is not empty and has more than one element, so proceed.

**Step 2:** Initialize variables:
- `second = 75` (first element)
- `first = 105` (max of first two elements)

**Step 3:** Iterate through the array starting from index 2:
- **Index 2 (120):**
  - `current = Math.Max(105, 75 + 120) = 195`
  - Update: `second = 105`, `first = 195`
  
- **Index 3 (75):**
  - `current = Math.Max(195, 105 + 75) = 195`
  - Update: `second = 195`, `first = 195`
  
- **Index 4 (90):**
  - `current = Math.Max(195, 195 + 90) = 285`
  - Update: `second = 195`, `first = 285`
  
- **Index 5 (135):**
  - `current = Math.Max(285, 195 + 135) = 330`
  - Update: `second = 285`, `first = 330`

**Step 4:** Return the result:
- The maximum subset sum with no adjacent elements is `330`.

### Pros
- **Efficiency:** The method runs in O(n) time and uses O(1) space, making it suitable for large arrays.
- **Simplicity:** The approach is straightforward and avoids the need for additional arrays, making the code easy to follow and memory-efficient.

### Cons
- **Simple Constraints:** The method assumes that the input array contains valid integers. It does not handle situations where non-integer values are provided.

### Edge Cases
- **Empty Array:** The method correctly handles an empty array by returning `0`.
- **Single Element Array:** If the array contains only one element, the method returns that element as the maximum sum.

### Alternative Approaches
- **Recursive Approach:** One could solve this problem using recursion with memoization, but that would have a higher space complexity due to the recursive call stack.
- **Dynamic Programming with Array:** Instead of using two variables (`first` and `second`), a DP array could be used to store the results at each step, but that would use O(n) space.

## Conclusion

The `MaxSubsetSumNoAdjacent` method provides an efficient solution to the problem of finding the maximum sum of non-adjacent elements in an array. By using a dynamic programming approach with constant space, the method ensures optimal performance for large arrays while maintaining simplicity in implementation.
