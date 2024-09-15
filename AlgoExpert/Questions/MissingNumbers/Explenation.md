# AlgoExpert - Missing Numbers Solution

This code provides a solution to the "Missing Numbers" problem, where the task is to find two missing numbers from an array that contains `n` unique integers from `1` to `n+2`. The array is guaranteed to contain exactly two missing numbers. The method uses a hash set to track the numbers present in the array and then checks which numbers between `1` and `n+2` are missing.

## `MissingNumbers`

### Description
The `MissingNumbers` method takes an array of integers and returns the two missing numbers from the range `1` to `n+2`. The input array contains `n` numbers, and the missing numbers can be efficiently determined by using a hash set to track the presence of each number.

### Time and Space Complexity
- **Time Complexity:** O(n) - The method makes two passes through the array: one to build the hash set and one to check for missing numbers.
- **Space Complexity:** O(n) - The method uses a hash set and a list to store the elements and missing numbers, respectively.

### How It Works

1. **Build Hash Set:**
   - The method iterates through the input array and adds each element to a hash set. The hash set allows for efficient lookup operations when checking if a number is missing.

2. **Check for Missing Numbers:**
   - After building the hash set, the method checks for numbers between `1` and `n+2` (inclusive) that are not present in the hash set. Since the array is missing exactly two numbers, the method identifies and stores these two missing numbers.

3. **Return the Missing Numbers:**
   - The method returns the missing numbers as an array.

### Example Walkthrough

Given the input:
- **Array:** `[1, 2, 3, 4, 6, 7, 8]`

**Step 1:** Build the hash set:
- Hash set: `{1, 2, 3, 4, 6, 7, 8}`

**Step 2:** Check for missing numbers:
- The numbers in the range `1` to `9` (since the length of the array is `7`, and `n+2 = 9`) are checked against the hash set.
- Missing numbers: `5` and `9` (since these are not present in the hash set).

**Result:** The method returns `[5, 9]`.

### Pros
- **Efficiency:** The method runs in O(n) time by leveraging the power of hash sets for quick lookups and avoids the need for nested loops.
- **Scalable:** The method is scalable for larger arrays due to its linear time complexity.

### Cons
- **Additional Space:** The use of a hash set and list for storing the elements requires O(n) additional space, which may be a limitation for very large arrays.

### Edge Cases
- **Consecutive Missing Numbers:** If the two missing numbers are consecutive (e.g., `[4, 5]`), the method correctly identifies them.
- **Missing at the Extremes:** If the smallest or largest numbers in the range are missing (e.g., `[1, 9]`), the method handles this scenario without issue.

### Alternative Approaches
- **Mathematical Approach:** Another approach would be to use a sum-based method:
  1. Calculate the expected sum of numbers from `1` to `n+2`.
  2. Subtract the actual sum of the numbers in the array from the expected sum to get the sum of the two missing numbers.
  3. Use a similar approach with the sum of squares to solve for the two individual missing numbers. However, this approach requires more complicated calculations and has similar time complexity but avoids the use of extra space.

## Conclusion

The `MissingNumbers` method efficiently solves the problem of finding two missing numbers from a sequence using a hash set. With O(n) time complexity and O(n) space complexity, the solution is both optimal and easy to understand. It ensures that the missing numbers are identified by checking which numbers are not present in the hash set, making it a reliable approach for this type of problem.
