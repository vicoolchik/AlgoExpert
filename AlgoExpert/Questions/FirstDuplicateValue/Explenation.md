# AlgoExpert - First Duplicate Value Solution

This code provides a solution to the "First Duplicate Value" problem, where the task is to find the first integer in an array that appears more than once. The goal is to solve the problem with O(n) time complexity and O(1) space complexity by modifying the input array.

## `FirstDuplicateValue`

### Description
The `FirstDuplicateValue` method finds the first integer that appears more than once in the input array. The method uses a clever technique of marking elements in the array by negating the values at specific indices, allowing it to track duplicates without using extra space.

### Time and Space Complexity
- **Time Complexity:** O(n) - The method makes a single pass through the array, where `n` is the length of the array.
- **Space Complexity:** O(1) - The method modifies the input array in place, so no extra space is used apart from a few variables.

### How It Works
1. **Marking Indices:**
   - The input array contains integers between `1` and `n`, where `n` is the length of the array.
   - As the method iterates over the array, it takes the absolute value of each element to determine which index in the array corresponds to that element.
   
2. **Negate the Value:**
   - For each element `array[i]`, the method checks the value at index `array[absValue - 1]` (where `absValue` is the absolute value of `array[i]`).
   - If the value at this index is negative, it means the corresponding element has already been visited, indicating a duplicate. The method returns this element as the first duplicate.
   - If the value is positive, the method negates the value to mark it as visited.

3. **Return Result:**
   - If no duplicates are found after the full iteration, the method returns `-1`.

# Example Walkthrough with Array Output

Given the input:
- **Array:** `[2, 1, 5, 2, 3, 3, 4]`

**Step 1:** Start at index 0:
- Element = `2`, check `array[2 - 1] = array[1] = 1` (positive), mark it by negating: `array[1] = -1`.
- **Array after Step 1:** `[2, -1, 5, 2, 3, 3, 4]`

**Step 2:** Move to index 1:
- Element = `1`, check `array[1 - 1] = array[0] = 2` (positive), mark it by negating: `array[0] = -2`.
- **Array after Step 2:** `[-2, -1, 5, 2, 3, 3, 4]`

**Step 3:** Move to index 2:
- Element = `5`, check `array[5 - 1] = array[4] = 3` (positive), mark it by negating: `array[4] = -3`.
- **Array after Step 3:** `[-2, -1, 5, 2, -3, 3, 4]`

**Step 4:** Move to index 3:
- Element = `2`, check `array[2 - 1] = array[1] = -1` (already negative), this means `2` is a duplicate.
- **Array after Step 4:** `[-2, -1, 5, 2, -3, 3, 4]`

At this point, the first duplicate value `2` is identified, and the method returns `2`.
### Pros
- **Efficiency:** The method efficiently finds the first duplicate in linear time and uses constant space by modifying the input array.
- **No Extra Data Structures:** Unlike other approaches that might use hash sets or dictionaries, this method achieves O(1) space complexity by leveraging the input array.

### Cons
- **Modifies Input Array:** The method modifies the input array in place, which might not be suitable if the array needs to remain unchanged. A copy of the array would be needed if immutability is required.

### Edge Cases
- **No Duplicates:** If the array has no duplicates, the method returns `-1`.
- **Single Element or Empty Array:** The method handles arrays with one or no elements by returning `-1` immediately.

## Conclusion

The `FirstDuplicateValue` method provides an efficient and space-optimized solution to the problem of finding the first duplicate value in an array. By using the input array to track visited elements, the method avoids the need for additional space while maintaining linear time complexity, making it ideal for large datasets where memory constraints are important.
