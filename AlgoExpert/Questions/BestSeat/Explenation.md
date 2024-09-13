# AlgoExpert - Best Seat Solution

This code provides a solution to the "Best Seat" problem, where the task is to find the best seat in a row of seats, represented by an array. The array contains `1`s (occupied seats) and `0`s (empty seats). The goal is to find the seat that is located in the middle of the longest sequence of consecutive empty seats.

## `BestSeat`

### Description
The `BestSeat` method scans through the row of seats and finds the seat that is in the middle of the largest block of consecutive empty seats. The method iterates over the array and tracks the start and end of empty seat blocks. It then calculates the middle seat of the largest block of consecutive empty seats.

### Time and Space Complexity
- **Time Complexity:** O(n) - The method makes a single pass through the array of seats, where `n` is the length of the array.
- **Space Complexity:** O(1) - The method uses a constant amount of extra space, making it space-efficient.

### How It Works

1. **Initialize Variables:**
   - `bestSeat`: Stores the index of the best seat found so far, initialized to `-1` to indicate that no seat has been found yet.
   - `bestDistance`: Stores the length of the longest sequence of consecutive empty seats found so far, initialized to `0`.
   - `left`: A pointer that tracks the start of a sequence of empty seats.

2. **Scan the Array:**
   - The method iterates through the array using two pointers:
     - `left`: Marks the start of an empty seat block.
     - `right`: Moves forward to find the end of the block of consecutive empty seats.

3. **Track Empty Seat Blocks:**
   - For each block of empty seats found (from `left` to `right`), the method calculates the number of available seats (`availableSeats = right - left - 1`).
   - If this block is the largest block of empty seats found so far, the middle seat of this block is updated as the best seat (`bestSeat = (left + right) / 2`).

4. **Update and Return Best Seat:**
   - The method continues to scan through the array until it has processed all seat blocks.
   - After the entire array is scanned, the method returns the index of the best seat found.

### Example Walkthrough

Given the input:
- **Array:** `[1, 0, 1, 0, 0, 0, 1]`

**Step 1:** Start scanning from index 0 (`left = 0`):
- The seat at index 0 is occupied (`1`), so move `right` to the next seat.

**Step 2:** Move to index 1 (`left = 1`):
- The seat at index 1 is empty (`0`), so move `right` until you find an occupied seat.
- At index 2, the seat is occupied (`1`).
- Calculate the number of available seats between `left` and `right`: `right - left - 1 = 1`.
- Update `bestSeat = (1 + 2) / 2 = 1`.

**Step 3:** Move to index 3 (`left = 3`):
- The seat at index 3 is empty (`0`), so move `right` until you find an occupied seat.
- At index 6, the seat is occupied (`1`).
- Calculate the number of available seats: `right - left - 1 = 3`.
- Since this is a larger block of empty seats, update `bestSeat = (3 + 6) / 2 = 4`.

**Result:** The best seat is at index `4`.

### Pros
- **Efficiency:** The method runs in linear time and uses constant space, making it highly efficient for large seat arrays.
- **Simple Logic:** The use of two pointers makes the implementation straightforward and easy to follow.

### Cons
- **Symmetry Handling:** If multiple blocks of empty seats have the same size, the method always picks the first block, which may not always be the most desirable seat.

### Edge Cases
- **No Empty Seats:** If the array has no empty seats (`0`s), the method returns `-1` since no seat is available.
- **All Empty Seats:** If the array consists only of empty seats, the method returns the seat in the middle of the entire array.
- **Single Seat:** If the array contains only one seat, the method correctly returns `-1` if that seat is occupied.

## Conclusion

The `BestSeat` method provides an efficient solution to the problem of finding the best seat in a row. By scanning the array using two pointers and calculating the middle of empty seat blocks, the method ensures optimal seat selection in O(n) time with O(1) space complexity.
