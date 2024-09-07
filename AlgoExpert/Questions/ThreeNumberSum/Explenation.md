# AlgoExpert - Three Number Sum Solution

This code provides multiple solutions to the "Three Number Sum" problem, where the goal is to find all unique triplets in an array that sum to a given target. The solutions include sorting and using a two-pointer technique, brute force, and a hash set approach.

## `ThreeNumberSum`

### Description
The `ThreeNumberSum` method finds all triplets of numbers in the array that add up to a given `targetSum`. The algorithm first sorts the array and then uses the two-pointer technique to efficiently search for triplets that meet the condition.

### Time and Space Complexity
- **Time Complexity:** O(n^2) - The array is sorted in O(n log n) time, and for each element, a two-pointer scan is performed, which takes O(n) time. Thus, the overall time complexity is O(n^2), where `n` is the length of the array.
- **Space Complexity:** O(n) - The space complexity is proportional to the length of the array due to the space needed for storing the triplets.

### How It Works
1. **Sort the Array:**
   - Sorting the array simplifies the search process by allowing us to use the two-pointer technique.
   
2. **Two-Pointer Search:**
   - For each element `i`, the method sets two pointers:
     - `left` starts just after `i`.
     - `right` starts at the end of the array.
   - The method calculates the sum of the triplet (`array[i] + array[left] + array[right]`). If the sum equals `targetSum`, the triplet is added to the result.
   - If the sum is less than `targetSum`, the left pointer is incremented to increase the sum.
   - If the sum is greater than `targetSum`, the right pointer is decremented to reduce the sum.

3. **Return the Triplets:**
   - The method returns a list of triplets that meet the condition.

### Example Walkthrough

Given the following input:
- **Array:** `[12, 3, 1, 2, -6, 5, -8, 6]`
- **Target Sum:** `0`

**Step 1:** Sort the array:
- Sorted array: `[-8, -6, 1, 2, 3, 5, 6, 12]`

**Step 2:** Iterate through the array:
- For `i = 0` (`-8`), use the two-pointer approach to find triplets:
  - `left = 1`, `right = 7` → `(-8) + (-6) + 12 = -2` (increase left)
  - `left = 2`, `right = 7` → `(-8) + 1 + 12 = 5` (decrease right)
  - Continue until triplet `[-8, 2, 6]` is found.
- Continue for other values of `i`.

**Result:** The triplets are `[[-8, 2, 6], [-8, 3, 5], [-6, 1, 5]]`.

### Pros
- **Efficiency:** The two-pointer technique significantly reduces the time complexity compared to the brute-force approach.
- **Sorted Approach:** Sorting the array helps in eliminating duplicate triplets and ensures an efficient search process.

### Cons
- **Requires Sorting:** Sorting the array adds O(n log n) time, which may not be ideal for scenarios where the array must remain unsorted.

---

## `ThreeNumberSumBruteForce`

### Description
The `ThreeNumberSumBruteForce` method uses a brute-force approach to find all triplets in the array that sum to the target. It checks every possible triplet combination.

### Time and Space Complexity
- **Time Complexity:** O(n^3) - The method iterates through the array with three nested loops, checking all possible combinations of three elements.
- **Space Complexity:** O(n) - The space complexity is proportional to the number of triplets found and stored.

### How It Works
1. **Three Nested Loops:**
   - The outer loop iterates over the first element (`i`), the middle loop iterates over the second element (`j`), and the inner loop iterates over the third element (`k`).
   
2. **Check Sum:**
   - For each combination of `i`, `j`, and `k`, the sum of `array[i] + array[j] + array[k]` is calculated. If the sum equals `targetSum`, the triplet is added to the result list.

### Pros
- **Straightforward:** The brute-force approach is simple and easy to understand.

### Cons
- **Inefficient:** The O(n^3) time complexity makes this method impractical for large arrays.

---

## `ThreeNumberSumHash`

### Description
The `ThreeNumberSumHash` method uses a hash set to reduce the number of iterations needed to find the triplets. It iterates through the array and for each element, looks for pairs that sum to the target.

### Time and Space Complexity
- **Time Complexity:** O(n^2) - The outer loop iterates through each element, and the inner loop checks pairs using a hash set.
- **Space Complexity:** O(n) - The space complexity is proportional to the number of elements in the array due to the hash set.

### How It Works
1. **Iterate Through the Array:**
   - For each element `i`, the method uses a hash set to track elements and looks for pairs that sum to `targetSum - array[i]`.
   
2. **Check for Triplets:**
   - For each element `j` after `i`, calculate the complement as `targetSum - array[i] - array[j]`. If the complement exists in the hash set, a valid triplet is found.
   - Add `array[j]` to the hash set.

### Pros
- **Hash Set Optimization:** Using a hash set reduces the time complexity compared to brute force, while still allowing for quick lookups.

### Cons
- **Extra Space:** The use of a hash set requires additional memory.

---

## Conclusion

- **Best for Efficiency:** The `ThreeNumberSum` method (using sorting and two pointers) offers the most balanced performance with O(n^2) time complexity and works well for most cases.
- **Best for Simplicity:** The brute-force method, `ThreeNumberSumBruteForce`, is easy to understand but inefficient for large arrays.
- **Alternative with Hash Set:** The `ThreeNumberSumHash` method provides a hash-based solution that reduces the number of checks, though it still has the same time complexity as the two-pointer approach.

In most cases, the two-pointer approach is the optimal solution for finding triplets that sum to a target.
