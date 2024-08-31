# AlgoExpert - Binary Search Solution

This code provides two implementations of the Binary Search algorithm, which is an efficient method for finding a target value within a sorted array. The algorithm works by repeatedly dividing the search interval in half until the target value is found or the interval is empty.

## `BinarySearch`

### Description
The `BinarySearch` method implements the Binary Search algorithm using a recursive approach. It takes a sorted array and a target value as input and returns the index of the target value in the array. If the target value is not found, the method returns `-1`.

### Time and Space Complexity
- **Time Complexity:** O(log(n)) - The time complexity is logarithmic because the search space is halved with each recursive call.
- **Space Complexity:** O(log(n)) - The space complexity is also logarithmic due to the recursion stack.

### How It Works
1. **Initial Call:** The `BinarySearch` method is first called with the entire array (`left = 0` and `right = array.Length - 1`).

2. **Base Case:** If the left index exceeds the right index, the target is not in the array, and the method returns `-1`.

3. **Calculate Middle:** The middle index of the current search interval is calculated as `(left + right) / 2`.

4. **Compare Values:**
   - If the target is equal to the middle value, the method returns the middle index.
   - If the target is less than the middle value, the method searches the left half of the array by calling itself recursively with `right = middle - 1`.
   - If the target is greater than the middle value, the method searches the right half of the array by calling itself recursively with `left = middle + 1`.

### Example Walkthrough

Given the following array and target:
- **Array:** `[0, 1, 21, 33, 45, 45, 61, 71, 72, 73]`
- **Target:** `33`

**Step 1:** Initial call with `left = 0`, `right = 9`.

**Step 2:** Calculate middle index: `middle = (0 + 9) / 2 = 4`.

**Step 3:** Compare middle value (`45`) with target (`33`):
- Target is less than middle value, so search the left half (`right = 3`).

**Step 4:** New middle index: `middle = (0 + 3) / 2 = 1`.

**Step 5:** Compare middle value (`1`) with target (`33`):
- Target is greater than middle value, so search the right half (`left = 2`).

**Step 6:** New middle index: `middle = (2 + 3) / 2 = 2`.

**Step 7:** Compare middle value (`21`) with target (`33`):
- Target is greater than middle value, so search the right half (`left = 3`).

**Step 8:** New middle index: `middle = 3`.

**Step 9:** Compare middle value (`33`) with target (`33`):
- Target matches the middle value, return index `3`.

### Pros
- **Clarity:** The recursive approach is easy to understand and follows the natural divide-and-conquer strategy.
- **Deterministic:** The method guarantees a logarithmic time complexity for searching a sorted array.

### Cons
- **Recursion Depth:** For very large arrays, the recursion depth might be a concern, although this is generally not an issue with typical data sizes.

## `BinarySearch1`

### Description
The `BinarySearch1` method is an iterative implementation of the Binary Search algorithm. It operates similarly to the recursive version but uses a loop to avoid the overhead of recursion.

### Time and Space Complexity
- **Time Complexity:** O(log(n)) - The time complexity is logarithmic, similar to the recursive approach.
- **Space Complexity:** O(1) - The space complexity is constant since no additional space is required beyond a few variables.

### How It Works
1. **Initialize Pointers:** The method initializes `left` and `right` pointers to the beginning and end of the array, respectively.

2. **Loop Until Target is Found or Interval is Empty:**
   - Calculate the middle index.
   - If the target matches the middle value, return the middle index.
   - If the target is less than the middle value, adjust the `right` pointer to `middle - 1`.
   - If the target is greater than the middle value, adjust the `left` pointer to `middle + 1`.

3. **Return `-1` if Not Found:** If the loop exits without finding the target, the method returns `-1`.

### Example Walkthrough
The example walkthrough is identical to the recursive method but implemented using a loop instead of recursion.

### Pros
- **Efficiency:** The iterative approach avoids the potential overhead and stack space usage associated with recursion.
- **Simplicity:** The iterative method is straightforward and avoids the complexity of recursion.

### Cons
- **Less Intuitive:** Some may find the iterative approach less intuitive compared to the recursive method, especially for those accustomed to thinking in terms of divide-and-conquer.

## Conclusion

- **Recursive Approach:** Best suited for scenarios where recursion is preferred or when learning the basics of binary search.
- **Iterative Approach:** Recommended for production code due to its constant space complexity and avoidance of recursion overhead.

Both methods effectively solve the binary search problem with logarithmic time complexity, making them ideal for searching in large, sorted arrays.
