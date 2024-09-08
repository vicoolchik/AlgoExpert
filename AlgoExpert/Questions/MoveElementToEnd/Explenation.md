# AlgoExpert - Move Element to End Solution

This code provides two solutions to the "Move Element to End" problem, where the task is to move all instances of a specified element in a list to the end, while preserving the relative order of the other elements. Both solutions aim to achieve the result with O(n) time complexity and O(1) space complexity, where `n` is the length of the list.

## `MoveElementToEnd`

### Description
The `MoveElementToEnd` method takes a list of integers and a target element (`toMove`). It moves all instances of the target element to the end of the list while keeping the order of the other elements intact. The solution uses a two-pointer technique to perform the task efficiently in a single pass through the list.

### Time and Space Complexity
- **Time Complexity:** O(n) - The algorithm iterates through the list with two pointers, where `n` is the number of elements in the list.
- **Space Complexity:** O(1) - The space complexity is constant since the list is modified in place and no extra space is required apart from a few variables.

### How It Works
1. **Initialize Two Pointers:**
   - The method uses two pointers: `i` starting at the beginning and `j` starting at the end of the list.
   
2. **Move Elements to the End:**
   - The method iterates over the list, moving `i` forward and `j` backward.
   - When the element at `j` equals `toMove`, the `j` pointer is decremented to skip it.
   - When the element at `i` equals `toMove` and `i < j`, the method swaps `array[i]` with `array[j]` and increments `i`.
   
3. **Return the List:**
   - The method continues this process until all instances of `toMove` are moved to the end of the list.

### Example Walkthrough

Given the input:
- **Array:** `[2, 1, 2, 2, 2, 3, 4, 2]`
- **Element to Move:** `2`

**Step 1:** Initialize `i = 0` and `j = 7`.

**Step 2:** Iterate through the array:
- At `i = 0` (`2`), swap with `j = 7` (`2`). No change, but decrement `j`.
- At `i = 1` (`1`), no swap needed, increment `i`.
- Continue until all `2`s are moved to the end.

**Result:** `[4, 1, 3, 2, 2, 2, 2, 2]`

### Pros
- **Efficiency:** The method runs in linear time and uses a two-pointer technique to minimize swaps.
- **In-Place:** The list is modified in place, requiring no additional memory allocation.

### Cons
- **Order of Elements:** This approach preserves the order of non-target elements but does not preserve the order of the `toMove` elements.

---

## `MoveElementToEnd2`

### Description
The `MoveElementToEnd2` method uses a simpler approach by iterating through the list, removing each occurrence of `toMove` as it is found, and appending it to the end of the list. This ensures that all `toMove` elements are moved to the end in a single pass.

### Time and Space Complexity
- **Time Complexity:** O(n) - The method performs a linear pass through the list, but each removal and addition operation involves shifting elements, so the performance might be slightly worse than `MoveElementToEnd` for large lists.
- **Space Complexity:** O(1) - The list is modified in place without requiring additional space.

### How It Works
1. **Iterate Over the List:**
   - The method iterates over the list and checks each element.
   - When the element equals `toMove`, it is removed from its current position and appended to the end of the list.
   - The loop ensures that only non-`toMove` elements are traversed after removal.

2. **Return the List:**
   - The list is returned after all `toMove` elements have been shifted to the end.

### Example Walkthrough

Given the input:
- **Array:** `[2, 1, 2, 2, 2, 3, 4, 2]`
- **Element to Move:** `2`

**Step 1:** Iterate through the array:
- At index `0`, `2` is removed and appended to the end.
- At index `1`, `1` is skipped.
- Continue until all `2`s are moved to the end.

**Result:** `[1, 3, 4, 2, 2, 2, 2, 2]`

### Pros
- **Simplicity:** The method is straightforward and easy to implement.
- **Maintains Relative Order:** The order of non-`toMove` elements is preserved.

### Cons
- **Efficiency:** The repeated removal and addition of elements can be inefficient due to internal list shifting, making this solution slightly slower for large lists.

---

## Conclusion

- **Best for Efficiency:** The `MoveElementToEnd` method using the two-pointer technique is more efficient in terms of performance, especially for large lists.
- **Best for Simplicity:** The `MoveElementToEnd2` method is simpler and easier to implement, but it may not be as efficient due to repeated element removals.

Both methods are useful depending on the requirements for performance or simplicity, but the two-pointer approach is generally recommended for larger datasets.
