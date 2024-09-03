# AlgoExpert - Selection Sort Solution

This code provides an implementation of the Selection Sort algorithm, which is a simple comparison-based sorting algorithm. Selection Sort repeatedly finds the minimum element from the unsorted portion of the array and swaps it with the first unsorted element, progressively sorting the array in place.

## `SelectionSort`

### Description
The `SelectionSort` method sorts an array of integers in ascending order using the Selection Sort algorithm. The algorithm works by dividing the array into a sorted and an unsorted section. It then repeatedly selects the smallest element from the unsorted section and swaps it with the leftmost unsorted element, moving the boundary between the sorted and unsorted sections one step to the right.

### Time and Space Complexity
- **Time Complexity:** O(n^2) - The time complexity is quadratic because, for each element, the algorithm scans the remaining unsorted elements to find the minimum. This requires `(n-1) + (n-2) + ... + 1 = n*(n-1)/2` comparisons.
- **Space Complexity:** O(1) - The space complexity is constant since the sorting is done in place without the need for additional memory allocation beyond a few variables.

### How It Works
1. **Iterate Through the Array:**
   - The algorithm starts from the first element (`i = 0`) and iterates through the array.
   - For each position `i`, the algorithm assumes the element at `i` is the smallest in the unsorted section.

2. **Find the Minimum:**
   - The algorithm scans the unsorted section of the array (from `i + 1` to the end) to find the smallest element.
   - If a smaller element is found, its index is recorded as `smallestIndex`.

3. **Swap the Elements:**
   - After scanning the unsorted section, if a smaller element than `array[i]` is found, the algorithm swaps the elements at index `i` and `smallestIndex`.

4. **Continue Until Array is Sorted:**
   - The process continues until the entire array is sorted.

### Example Walkthrough

Given the following array:
- **Array:** `[8, 5, 2, 9, 5, 6, 3]`

**Step 1:** Start with the first element (`8`):
- Find the smallest element in the array `[5, 2, 9, 5, 6, 3]`.
- The smallest element is `2`, so swap `2` with `8`.
- Array becomes `[2, 5, 8, 9, 5, 6, 3]`.

**Step 2:** Move to the next element (`5`):
- Find the smallest element in the array `[8, 9, 5, 6, 3]`.
- The smallest element is `3`, so swap `3` with `5`.
- Array becomes `[2, 3, 8, 9, 5, 6, 5]`.

**Step 3:** Continue for the remaining elements:
- Swap `5` with the next smallest element, and so on.

**Final Result:**
- The array becomes `[2, 3, 5, 5, 6, 8, 9]`.

### Pros
- **Simplicity:** Selection Sort is easy to understand and implement, making it a good choice for educational purposes.
- **In-Place Sorting:** The algorithm sorts the array in place, requiring only constant extra space.

### Cons
- **Inefficiency:** The O(n^2) time complexity makes Selection Sort impractical for large datasets. More efficient algorithms like Quick Sort or Merge Sort are generally preferred.
- **Not Stable:** Selection Sort is not stable, meaning it does not necessarily preserve the relative order of elements with equal values. Stability might be important in certain scenarios.

## Conclusion

The `SelectionSort` method provides a straightforward implementation of the Selection Sort algorithm. While it is simple and intuitive, its quadratic time complexity makes it less suitable for large datasets. However, it remains a valuable algorithm for small arrays or when memory usage is a concern.

This implementation sorts the array in place, ensuring minimal memory usage, and demonstrates the classic approach of iteratively selecting and placing the smallest element from the unsorted portion of the array.
