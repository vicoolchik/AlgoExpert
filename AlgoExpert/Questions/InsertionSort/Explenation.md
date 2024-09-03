# AlgoExpert - Insertion Sort Solution

This code provides an implementation of the Insertion Sort algorithm, a simple and intuitive comparison-based sorting algorithm. Insertion Sort builds the final sorted array one element at a time, by repeatedly taking the next element and inserting it into its correct position among the already sorted elements.

## `InsertionSort`

### Description
The `InsertionSort` method sorts an array of integers in ascending order using the Insertion Sort algorithm. The algorithm works by iterating through the array and progressively building a sorted section at the beginning of the array. For each element, the algorithm shifts elements in the sorted section to the right to make room for the current element to be placed in its correct position.

### Time and Space Complexity
- **Time Complexity:** O(n^2) - The time complexity is quadratic because, in the worst case, each element needs to be compared and possibly swapped with every other element before it in the sorted section.
- **Space Complexity:** O(1) - The space complexity is constant since the sorting is done in place without the need for additional memory allocation beyond a few variables.

### How It Works
1. **Iterate Through the Array:**
   - The algorithm starts from the second element (`i = 1`) and iterates through the array.
   - For each element at index `i`, the algorithm compares it to the elements before it in the sorted section of the array (i.e., elements from `0` to `i-1`).

2. **Insert the Element:**
   - The algorithm shifts the elements in the sorted section to the right until it finds the correct position for the current element.
   - The current element is then placed in its correct position, ensuring that the sorted section remains sorted.

3. **Continue Until Array is Sorted:**
   - The process continues until the entire array is sorted.

### Example Walkthrough

Given the following array:
- **Array:** `[8, 5, 2, 9, 5, 6, 3]`

**Step 1:** Start with the second element (`5`):
- Compare `5` with `8` and swap because `5 < 8`.
- Array becomes `[5, 8, 2, 9, 5, 6, 3]`.

**Step 2:** Move to the next element (`2`):
- Compare `2` with `8`, swap.
- Compare `2` with `5`, swap.
- Array becomes `[2, 5, 8, 9, 5, 6, 3]`.

**Step 3:** Continue for the remaining elements:
- Insert `9` (no swap needed).
- Insert `5` by shifting `9` and `8` to the right.
- Continue this process until the array is fully sorted.

**Final Result:**
- The array becomes `[2, 3, 5, 5, 6, 8, 9]`.

### Pros
- **Simplicity:** Insertion Sort is easy to understand and implement, making it a good choice for small datasets or nearly sorted data.
- **In-Place Sorting:** The algorithm sorts the array in place, requiring only constant extra space.
- **Efficient for Small or Nearly Sorted Arrays:** Insertion Sort can be more efficient than more complex algorithms like Quick Sort or Merge Sort for small arrays or arrays that are already mostly sorted.

### Cons
- **Inefficiency for Large Arrays:** The O(n^2) time complexity makes Insertion Sort impractical for large datasets, where more efficient algorithms like Quick Sort or Merge Sort would be preferred.
- **High Number of Comparisons and Swaps:** Insertion Sort involves many comparisons and swaps, particularly in the worst-case scenario (e.g., when the array is sorted in reverse order).

## Conclusion

The `InsertionSort` method provides a straightforward implementation of the Insertion Sort algorithm. While simple and effective for small or nearly sorted datasets, the quadratic time complexity limits its use for larger datasets. Insertion Sort is often favored for educational purposes due to its simplicity and ease of understanding.

This implementation sorts the array in place, ensuring that memory usage is minimized, and demonstrates the classic approach to building a sorted array one element at a time.
