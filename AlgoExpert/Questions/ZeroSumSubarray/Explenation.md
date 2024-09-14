# AlgoExpert - Zero Sum Subarray Solution

This code provides a solution to the "Zero Sum Subarray" problem, where the task is to determine whether there exists a contiguous subarray within a given array that sums to zero. The solution uses a hash set to track cumulative sums, which allows for efficient detection of a zero-sum subarray.

## `ZeroSumSubarray`

### Description
The `ZeroSumSubarray` method checks if there is a subarray in the given array that sums to zero. By using a cumulative sum approach and a hash set, the method can determine in O(n) time whether such a subarray exists.

### Time and Space Complexity
- **Time Complexity:** O(n) - The method iterates through the array once, where `n` is the length of the array.
- **Space Complexity:** O(n) - The hash set is used to store cumulative sums, and in the worst case, it can store up to `n` sums.

### How It Works

1. **Cumulative Sum:**
   - As the method iterates through the array, it maintains a running cumulative sum of the elements encountered so far.
   - If at any point the cumulative sum becomes zero, or if the cumulative sum has been seen before in the hash set, a zero-sum subarray exists.

2. **Hash Set for Tracking Sums:**
   - The hash set stores all cumulative sums seen during the iteration.
   - If a cumulative sum is repeated, it means that the elements between the first occurrence of the sum and the current index form a subarray that sums to zero.

3. **Early Exit on Zero-Sum Detection:**
   - The method returns `true` immediately if a zero-sum subarray is found.
   - If no such subarray is detected after iterating through the array, the method returns `false`.

### Example Walkthrough

Given the input:
- **Array:** `[1, 2, 3, 4, -4, 6]`

**Step 1:** Initialize:
- `sum = 0`
- `hashSet = {}`

**Step 2:** Iterate through the array:

- Add `1` to `sum` → `sum = 1`. Add `1` to `hashSet`.
- Add `2` to `sum` → `sum = 3`. Add `3` to `hashSet`.
- Add `3` to `sum` → `sum = 6`. Add `6` to `hashSet`.
- Add `4` to `sum` → `sum = 10`. Add `10` to `hashSet`.
- Add `-4` to `sum` → `sum = 6`. Since `6` is already in `hashSet`, this indicates a zero-sum subarray exists between the previous occurrence of `sum = 6` and the current element.

**Result:** The method returns `true` because a zero-sum subarray is detected.

### Pros
- **Efficiency:** The method runs in O(n) time and uses a hash set to efficiently track cumulative sums, ensuring that the solution works well even for large arrays.
- **Early Termination:** The method exits early if a zero-sum subarray is detected, making it even faster in some cases.

### Cons
- **Additional Space:** The hash set requires O(n) space, which could be a limitation for extremely large arrays.

### Edge Cases
- **Empty Array:** If the array is empty, the method will return `false`, as there are no elements to form a subarray.
- **Array of All Positive Numbers:** The method will return `false` since there cannot be a zero-sum subarray with only positive numbers.
- **Array Contains Zero:** If the array contains `0` as an element, the method will immediately return `true` since a subarray containing just `0` sums to zero.

## Conclusion

The `ZeroSumSubarray` method provides an efficient solution to the problem of detecting a subarray that sums to zero. By utilizing a hash set to store cumulative sums, the method avoids the need for nested loops and ensures O(n) time complexity, making it optimal for large datasets.