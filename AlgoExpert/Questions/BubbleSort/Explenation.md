# AlgoExpert - Bubble Sort Solution

This code provides an implementation of the Bubble Sort algorithm, which is a simple comparison-based sorting algorithm. Bubble Sort repeatedly steps through the list, compares adjacent elements, and swaps them if they are in the wrong order. The process is repeated until the list is sorted.

## `BubbleSort`

### Description
The `BubbleSort` method sorts an array of integers in ascending order using the Bubble Sort algorithm. The algorithm works by repeatedly passing through the array, comparing adjacent elements, and swapping them if they are out of order. This process "bubbles" the largest unsorted element to its correct position in each pass.

### Time and Space Complexity
- **Time Complexity:** O(n^2) - The time complexity is quadratic because, in the worst case, the algorithm needs to compare each pair of elements multiple times. Specifically, for each element, it may need to make a full pass through the rest of the list, resulting in `n * (n - 1) / 2` comparisons.
- **Space Complexity:** O(1) - The space complexity is constant, as the sorting is done in place with no need for additional memory allocation beyond a few variables.

### How It Works
1. **Initialize Variables:**
   - `isSorted` is a boolean flag that indicates whether the array is sorted.
   - `counter` tracks the number of passes through the array, which is used to optimize the algorithm by ignoring the already sorted elements at the end of the list.

2. **Iterative Sorting:**
   - The algorithm runs in a loop until `isSorted` remains `true` after a complete pass through the array.
   - For each pass, the algorithm compares adjacent elements and swaps them if they are in the wrong order.
   - If any swaps are made during the pass, `isSorted` is set to `false`, indicating that another pass is needed.

3. **Optimization with `counter`:**
   - After each pass, `counter` is incremented, which reduces the range of the array that needs to be checked on subsequent passes. This is because the largest unsorted element is guaranteed to be in its correct position after each pass.

### Example Walkthrough

Given the following array:
- **Array:** `[8, 5, 2, 9, 5, 6, 3]`

**Step 1:** Initial pass:
- Compare `8` and `5`: Swap to get `[5, 8, 2, 9, 5, 6, 3]`
- Compare `8` and `2`: Swap to get `[5, 2, 8, 9, 5, 6, 3]`
- Continue comparisons and swaps until the largest element `9` is at the end.

**Step 2:** Second pass:
- Start again from the beginning but ignore the last element `9`.
- Continue swapping until the next largest element is correctly positioned.

**Step 3:** Continue passes:
- The process repeats until the array is fully sorted.

**Final Result:**
- The array becomes `[2, 3, 5, 5, 6, 8, 9]`.

### Pros
- **Simplicity:** Bubble Sort is easy to understand and implement, making it a good choice for teaching sorting algorithms.
- **In-Place Sorting:** The algorithm sorts the array in place, requiring only constant additional space.

### Cons
- **Inefficiency:** The time complexity of O(n^2) makes Bubble Sort impractical for large datasets. Other sorting algorithms like Quick Sort or Merge Sort are more efficient for larger arrays.
- **Redundant Comparisons:** Even when the array is nearly sorted, Bubble Sort may still make unnecessary comparisons and swaps.

## Conclusion

The `BubbleSort` method provides a straightforward implementation of the Bubble Sort algorithm. While simple and easy to understand, the algorithm is not efficient for large datasets due to its quadratic time complexity. However, it remains a useful teaching tool and can be effective for small arrays or datasets that are already mostly sorted.

This implementation also includes an optimization that reduces the number of comparisons as the largest elements are correctly positioned at the end of the array in each pass.
