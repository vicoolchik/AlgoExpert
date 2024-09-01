# AlgoExpert - Find Three Largest Numbers Solution

This code provides a solution to the problem of finding the three largest numbers in an unsorted array. The method `FindThreeLargestNumbers` efficiently identifies and returns the three largest numbers in the array, sorted in ascending order.

## `FindThreeLargestNumbers`

### Description
The `FindThreeLargestNumbers` method iterates through the input array and updates an array of the three largest numbers found so far. This method ensures that the array always contains the three largest numbers in ascending order.

### Time and Space Complexity
- **Time Complexity:** O(n) - The method iterates through the array once, where `n` is the length of the array.
- **Space Complexity:** O(1) - The method uses a fixed amount of additional space to store the three largest numbers.

### How It Works
1. **Initialize Array for Three Largest Numbers:**
   - The method initializes an array `threeLargest` with three values set to `int.MinValue`. This array will store the three largest numbers found during the iteration.

2. **Iterate Through the Input Array:**
   - For each number in the input array, the `UpdateLargest` method is called to check if the current number is larger than any of the three largest numbers stored in `threeLargest`.

3. **Update the Array:**
   - The `UpdateLargest` method compares the current number with the three largest numbers:
     - If the current number is larger than the third-largest number, it is inserted into the third position, shifting the other numbers as necessary.
     - If the current number is not larger than the third-largest but is larger than the second-largest, it is inserted into the second position.
     - If it is only larger than the first-largest, it is inserted into the first position.

4. **Return the Result:**
   - After iterating through the input array, the `threeLargest` array will contain the three largest numbers in ascending order, which is then returned.

### Example Walkthrough

Given the following array:
- **Array:** `[141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7]`

**Step 1:** Initialize `threeLargest`:
- `threeLargest = [int.MinValue, int.MinValue, int.MinValue]`

**Step 2:** Iterate through the array:
- Process `141`: `threeLargest = [int.MinValue, int.MinValue, 141]`
- Process `1`: `threeLargest = [int.MinValue, 1, 141]`
- Process `17`: `threeLargest = [1, 17, 141]`
- Process `-7`, `-17`, `-27`: No change, as these values are not larger than any in `threeLargest`.
- Process `18`: `threeLargest = [17, 18, 141]`
- Process `541`: `threeLargest = [18, 141, 541]`
- Process `8`, `7`, `7`: No change.

**Step 3:** Return the result:
- The three largest numbers are `[18, 141, 541]`.

### Pros
- **Efficiency:** The method efficiently identifies the three largest numbers in a single pass through the array, making it suitable for large datasets.
- **Simplicity:** The logic is straightforward, with clear steps for updating the three largest numbers.

### Cons
- **Limited to Three Numbers:** This method is specifically designed to find exactly three largest numbers. It would need modification to find a different number of largest elements.

## `UpdateLargest` and `ShiftAndUpdate`

### `UpdateLargest`
- This helper method determines where the current number fits within the `threeLargest` array by comparing it with the existing largest numbers.

### `ShiftAndUpdate`
- This method shifts the numbers in the `threeLargest` array to the left to make room for the new number, ensuring that the array remains sorted in ascending order.

### Conclusion

The `FindThreeLargestNumbers` method is an effective solution for identifying the three largest numbers in an array. It operates in linear time with constant space, making it highly efficient for large inputs. The combination of simplicity and efficiency makes this approach well-suited for applications where finding the largest elements in a dataset is required.