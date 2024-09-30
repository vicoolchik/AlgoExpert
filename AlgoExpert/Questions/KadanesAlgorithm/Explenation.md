# AlgoExpert - Kadane's Algorithm Solution

This solution provides an implementation of **Kadane's Algorithm**, which is used to find the maximum sum of any contiguous subarray within a given array of integers. This is a well-known problem in dynamic programming and is solved in linear time using this algorithm.

## `KadanesAlgorithm`

### Description
The `KadanesAlgorithm` method finds the maximum sum of any contiguous subarray within an input array. It iterates through the array and at each step, it keeps track of the maximum subarray sum that ends at the current element and the overall maximum subarray sum found so far.

### Time and Space Complexity
- **Time Complexity:** O(n) - The method iterates through the array once, where `n` is the length of the array.
- **Space Complexity:** O(1) - The method uses constant space, as it only stores a few variables to track the current and maximum subarray sums.

### How It Works

1. **Initialize Variables:**
   - `maxEndingHere`: This variable stores the maximum sum of the subarray ending at the current element. It is initialized with the first element of the array.
   - `maxSoFar`: This variable stores the maximum subarray sum encountered so far. It is also initialized with the first element of the array.

2. **Iterate Through the Array:**
   - For each element in the array, compute the maximum subarray sum ending at that element by comparing the current element (`num`) with the sum of the current element and the previous subarray (`maxEndingHere + num`).
   - Update `maxSoFar` by comparing it with `maxEndingHere`. This ensures that `maxSoFar` always holds the largest subarray sum found.

3. **Return the Result:**
   - After iterating through the entire array, `maxSoFar` holds the maximum sum of any contiguous subarray.

### Example Walkthrough

Given the input:
- **Array:** `[3, 5, -9, 1, 3, -2, 3, 4, 7, 2, -9, 6, 3, 1, -5, 4]`

**Step 1:** Initialize:
- `maxEndingHere = 3`
- `maxSoFar = 3`

**Step 2:** Iterate through the array:
- **Index 1 (5):** `maxEndingHere = max(5, 3 + 5) = 8`, `maxSoFar = max(3, 8) = 8`
- **Index 2 (-9):** `maxEndingHere = max(-9, 8 + -9) = -1`, `maxSoFar = max(8, -1) = 8`
- **Index 3 (1):** `maxEndingHere = max(1, -1 + 1) = 1`, `maxSoFar = max(8, 1) = 8`
- **Index 4 (3):** `maxEndingHere = max(3, 1 + 3) = 4`, `maxSoFar = max(8, 4) = 8`
- Continue updating `maxEndingHere` and `maxSoFar` for the remaining elements.

**Final Result:** The maximum sum of a contiguous subarray is `19`, which is the sum of the subarray `[3, 4, 7, 2, -9, 6, 3, 1]`.

### Pros
- **Efficiency:** The method runs in O(n) time and uses O(1) space, making it highly efficient for large arrays.
- **Simplicity:** Kadane’s Algorithm is simple to implement, requiring only a single pass through the array.

### Cons
- **Single Solution:** Kadane's Algorithm only finds the maximum sum and not the subarray itself. Additional logic is needed to track the indices of the subarray.

### Edge Cases
- **All Negative Numbers:** If the array contains only negative numbers, the method will correctly return the largest negative number as the maximum sum.
- **Single Element Array:** If the array has only one element, the method will return that element as the maximum sum.

### Conclusion

The `KadanesAlgorithm` method provides an efficient solution to the problem of finding the maximum sum of a contiguous subarray in an array of integers. With its linear time complexity and constant space usage, Kadane’s Algorithm is optimal for this problem and is widely used in competitive programming and interview questions.