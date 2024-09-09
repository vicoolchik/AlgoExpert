# AlgoExpert - Is Monotonic Solution

This code provides a solution to the "Is Monotonic" problem, where the task is to determine whether an array is monotonic. An array is considered monotonic if it is either entirely non-increasing or non-decreasing.

## `IsMonotonic`

### Description
The `IsMonotonic` method checks if an array of integers is monotonic by comparing the direction of consecutive elements. The method works in a single pass through the array, making it efficient in terms of both time and space complexity.

### Time and Space Complexity
- **Time Complexity:** O(n) - The method makes a single pass through the array, where `n` is the length of the array.
- **Space Complexity:** O(1) - The method uses constant space, as it only requires a few variables to track the direction and differences between elements.

### How It Works
1. **Handle Edge Case:**
   - If the array contains fewer than 3 elements, it is considered monotonic by default, and the method returns `true`.

2. **Determine Initial Direction:**
   - The method calculates the initial direction by subtracting the first element from the second. The direction can be positive (increasing), negative (decreasing), or zero (equal).

3. **Traverse the Array:**
   - Starting from the third element, the method compares each pair of consecutive elements to check if the direction breaks (i.e., if the array switches from increasing to decreasing or vice versa).
   - If the direction is zero (i.e., the first two elements are equal), the method continues until it finds a non-zero direction.

4. **Check for Direction Break:**
   - The `breaksDirection` helper method determines if the current pair of elements breaks the expected direction. If it does, the array is not monotonic, and the method returns `false`.

5. **Return Result:**
   - If no direction break is found after checking all elements, the array is monotonic, and the method returns `true`.

### Example Walkthrough

Given the input:
- **Array:** `[1, 2, 3, 4, 5, 6, 7, 8, 9]`

**Step 1:** Handle edge case:
- The array has more than two elements, so proceed to the next step.

**Step 2:** Determine initial direction:
- `direction = array[1] - array[0] = 2 - 1 = 1` (increasing).

**Step 3:** Traverse the array:
- Compare each pair of elements:
  - `array[2] - array[1] = 3 - 2 = 1` (no direction break).
  - Continue comparing all elements in the array, and no direction break is found.

**Result:** The array is monotonic (increasing), so the method returns `true`.

### Pros
- **Efficiency:** The method runs in linear time and uses constant space, making it optimal for large arrays.
- **Handles All Cases:** The method handles arrays with fewer than 3 elements, arrays with all equal elements, and arrays with mixed increasing and decreasing values.

### Cons
- **Simple Logic for 1D Arrays:** The method is designed for simple 1D arrays. It won't work for more complex data structures or arrays with mixed data types.

---

## `breaksDirection`

### Description
The `breaksDirection` method checks if the direction of the array is broken by comparing two consecutive elements. If the array is expected to be increasing but the current element is smaller than the previous one, or if it's expected to be decreasing but the current element is larger, the method returns `true`.

### How It Works
1. **Calculate Difference:** The method calculates the difference between the current and previous elements.
2. **Check Direction:**
   - If the direction is positive (increasing), the method checks if the difference is negative (i.e., if the current element is smaller than the previous one).
   - If the direction is negative (decreasing), the method checks if the difference is positive.

### Example Walkthrough

For the array `[1, 2, 3, 4]` with a positive direction:
- Compare `2` and `1`: No direction break (positive difference).
- Compare `3` and `2`: No direction break.
- Compare `4` and `3`: No direction break.

For the array `[4, 3, 2, 1]` with a negative direction:
- Compare `3` and `4`: No direction break (negative difference).
- Continue comparing all elements, and no direction break is found.

---

## Conclusion

The `IsMonotonic` method provides an efficient and simple solution for checking whether an array is monotonic. Using a single pass through the array and tracking the direction of consecutive elements ensures that the solution is optimal in terms of both time and space complexity. The helper method `breaksDirection` allows for easy checking of direction breaks, making the code easy to read and maintain.