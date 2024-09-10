# AlgoExpert - Longest Peak Solution

This code provides a solution to the "Longest Peak" problem, where the task is to find the length of the longest peak in a given array. A "peak" is defined as a sequence of consecutive integers that strictly increase until they reach a maximum, and then strictly decrease after that.

## `LongestPeak`

### Description
The `LongestPeak` method finds the longest peak in an array of integers and returns its length. The approach is efficient, making a single pass through the array, and it uses constant space.

### Time and Space Complexity
- **Time Complexity:** O(n) - The method makes a single pass through the array, where `n` is the length of the array.
- **Space Complexity:** O(1) - The space complexity is constant since the method only uses a few variables to track indices and peak lengths.

### How It Works
1. **Initialize Variables:**
   - `longestPeakLength`: Stores the length of the longest peak found so far.
   - `i`: A pointer that starts at the second element (index 1) of the array, since peaks cannot start or end at the edges.

2. **Identify Peaks:**
   - The method looks for a "peak" by checking if the current element (`array[i]`) is greater than both its neighbors (`array[i-1]` and `array[i+1]`).
   - If no peak is found, the pointer `i` is simply incremented.

3. **Expand to Left and Right:**
   - Once a peak is found, the method expands left and right from the peak to find the full extent of the peak.
   - **Left Expansion:** Starting from `i-1`, the method moves left as long as the current element is strictly greater than the previous element.
   - **Right Expansion:** Starting from `i+1`, the method moves right as long as the current element is strictly greater than the next element.

4. **Calculate Peak Length:**
   - The length of the peak is calculated as `rightIdx - leftIdx - 1`, where `rightIdx` and `leftIdx` are the indices at the end of the left and right expansions.
   - If the current peak's length is greater than `longestPeakLength`, it is updated.

5. **Continue Traversal:**
   - The pointer `i` is moved to `rightIdx` to skip over the elements that were already processed as part of the current peak, and the process continues until the entire array has been traversed.

6. **Return Result:**
   - The method returns the length of the longest peak found.

### Example Walkthrough

Given the input:
- **Array:** `[1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3]`

**Step 1:** Initialize variables:
- `longestPeakLength = 0`
- `i = 1`

**Step 2:** Traverse the array:
- At `i = 5`, peak found at `10` (since `0 < 10 > 6`).
- Expand left to `0` and right to `-3`, peak length = 6 (`rightIdx = 10`, `leftIdx = 4`).
- Update `longestPeakLength = 6`.

**Step 3:** Continue traversal:
- No further peaks found longer than 6.

**Result:** The longest peak has a length of `6`.

### Pros
- **Efficiency:** The algorithm efficiently finds peaks and calculates their lengths in O(n) time.
- **Single Pass:** By using a single traversal of the array, the solution avoids unnecessary comparisons.

### Cons
- **Requires Strictly Increasing/Decreasing Peaks:** The algorithm only identifies peaks where there is a strict increase followed by a strict decrease.

### Conclusion

The `LongestPeak` method provides a simple and efficient solution for finding the longest peak in an array. By using a single-pass approach and constant space, the algorithm handles large arrays efficiently. The solution is suitable for cases where peaks need to be identified and their lengths calculated in an optimal manner.
