# AlgoExpert - Merge Overlapping Intervals Solution

This code provides a solution to the "Merge Overlapping Intervals" problem, where the goal is to merge all overlapping intervals in a given set of intervals and return the merged intervals. The intervals are represented as pairs of integers, where each pair signifies the start and end of an interval.

## `MergeOverlappingIntervals`

### Description
The `MergeOverlappingIntervals` method merges all overlapping intervals from the input array. The intervals are first sorted based on their starting values, and then merged by iterating through the sorted intervals, ensuring that any overlapping intervals are combined.

### Time and Space Complexity
- **Time Complexity:** O(n log n) - The time complexity is dominated by the sorting step, where `n` is the number of intervals.
- **Space Complexity:** O(n) - The space complexity is proportional to the number of intervals since a new list is created to store the merged intervals.

### How It Works
1. **Sort the Intervals:**
   - The method begins by sorting the intervals based on their start values. Sorting ensures that intervals that overlap or are adjacent are located next to each other.

2. **Initialize the Merged List:**
   - The first interval is added to the merged list, and the merging process begins from there.

3. **Iterate Through the Intervals:**
   - The method iterates over the intervals, comparing each one to the current interval being tracked.
   - If the current interval's end value is greater than or equal to the next interval's start value, the intervals overlap and are merged.
   - If there is no overlap, the next interval becomes the new "current interval," and it is added to the merged list.

4. **Return the Merged Intervals:**
   - After all intervals have been processed, the method returns the list of merged intervals as an array.

### Example Walkthrough

Given the input:
- **Intervals:**
[ [1, 2], [6, 8], [3, 5], [4, 7], [9, 10] ]

**Step 1:** Sort the intervals:

**Step 2:** Initialize with the first interval:
- Current interval: `[1, 2]`
- Merged intervals: `[[1, 2]]`

**Step 3:** Iterate and merge:
- Compare `[3, 5]` with `[1, 2]`: No overlap, add `[3, 5]` to merged list.
- Compare `[4, 7]` with `[3, 5]`: Overlap exists, merge into `[3, 7]`.
- Compare `[6, 8]` with `[3, 7]`: Overlap exists, merge into `[3, 8]`.
- Compare `[9, 10]` with `[3, 8]`: No overlap, add `[9, 10]`.

**Result:** Merged intervals: `[[1, 2], [3, 8], [9, 10]]`

### Pros
- **Efficiency:** The solution efficiently merges overlapping intervals in O(n log n) time due to the sorting step, followed by a linear pass through the sorted intervals.
- **Clarity:** The process of sorting and then merging based on interval boundaries is straightforward and easy to understand.

### Cons
- **Sorting Overhead:** The O(n log n) time complexity comes from sorting, which may be inefficient for very large datasets, though it is the optimal approach for this problem.

### Edge Cases
- **Single Interval:** If there is only one interval, the method simply returns it as no merging is necessary.
- **Non-overlapping Intervals:** If no intervals overlap, the method returns the intervals as they are, after sorting.

## Conclusion

The `MergeOverlappingIntervals` method provides an efficient solution to the problem of merging overlapping intervals. By sorting the intervals first and then merging them in a single pass, the method ensures that overlapping intervals are correctly combined, while maintaining a time complexity of O(n log n).
