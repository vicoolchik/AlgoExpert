# AlgoExpert - Product Sum Solution

This code provides a solution to the "Product Sum" problem, where the task is to calculate the sum of a "special" array. A "special" array is a non-empty array that can contain either integers or other "special" arrays. The product sum of such an array is the sum of its elements, where each element that is itself a "special" array is multiplied by its depth level in the main array.

## `ProductSum`

### Description
The `ProductSum` method calculates the product sum of a given "special" array. The method handles both integers and nested arrays, recursively calculating the sum while accounting for the depth of each nested array.

### Time and Space Complexity
- **Time Complexity:** O(n) - The time complexity is linear, where `n` is the total number of elements in the array, including all elements within nested arrays.
- **Space Complexity:** O(d) - The space complexity is proportional to the depth `d` of the nested arrays due to the recursion stack.

### How It Works
1. **Recursive Calculation:**
   - The `ProductSum` method is first called with the input array and an initial multiplier of `1`.
   - For each element in the array:
     - If the element is a list (i.e., another "special" array), the method calls itself recursively, increasing the multiplier by `1` to account for the depth.
     - If the element is an integer, it is added to the current sum.
   - The method returns the sum multiplied by the current depth multiplier.

2. **Handling Nested Arrays:**
   - The recursion allows the method to handle arrays of arbitrary depth. Each level of depth increases the multiplier, which is then applied to the sum of that particular nested array.

### Example Walkthrough

Given the following "special" array:
- `[5, 2, [7, -1], 3, [6, [-13, 8], 4]]`

**Step 1:** Start at depth 1:
- Sum = `5 + 2 + (ProductSum([7, -1], 2)) + 3 + (ProductSum([6, [-13, 8], 4], 2))`

**Step 2:** Resolve first nested array `[7, -1]` at depth 2:
- Sum = `7 + (-1) = 6`
- ProductSum for this array = `6 * 2 = 12`

**Step 3:** Resolve second nested array `[6, [-13, 8], 4]` at depth 2:
- Sum = `6 + (ProductSum([-13, 8], 3)) + 4`
- Resolve `[[-13, 8]]` at depth 3:
  - Sum = `-13 + 8 = -5`
  - ProductSum for this array = `-5 * 3 = -15`
- ProductSum for `[6, [-13, 8], 4]` = `(6 + (-15) + 4) * 2 = (-5) * 2 = -10`

**Step 4:** Combine all results:
- Total Product Sum = `5 + 2 + 12 + 3 + -10 = 12`

**Result:** The method returns `12`.

### Pros
- **Efficiency:** The method is efficient with a linear time complexity, ensuring it scales well with the size of the input.
- **Handles Nested Arrays:** The recursive approach naturally handles nested arrays of arbitrary depth, making it flexible for complex structures.

### Cons
- **Recursion Depth:** The method uses recursion, which could lead to stack overflow for extremely deep nested arrays. However, this is usually not an issue in most practical cases.

## Conclusion

The `ProductSum` method provides a robust solution for calculating the product sum of a "special" array. By using a recursive approach, it efficiently handles arrays of any depth, ensuring that each nested array is correctly weighted according to its depth level.

This method is both flexible and efficient, making it a reliable choice for problems involving nested structures where depth needs to be accounted for in the calculation.
