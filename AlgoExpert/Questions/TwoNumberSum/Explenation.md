# AlgoExpert - Two Number Sum Solutions

This code provides three different solutions to the common "Two Number Sum" problem, where the objective is to find two numbers in an array that sum up to a specific target value. The three methods implemented are `TwoNumberSumHash`, `TwoNumberSumForLoop`, and `TwoNumberSumSort`. Below is a detailed description of each approach, including their advantages and disadvantages.

## `TwoNumberSumHash`

### Description
The `TwoNumberSumHash` method uses a hash set to efficiently find the pair of numbers that add up to the target sum. The idea is to iterate through the array and for each number, calculate the difference between the target sum and the current number. If this difference (or potential match) is already in the hash set, then the pair has been found. If not, the current number is added to the hash set.

### Time and Space Complexity
- **Time Complexity:** O(n) - The algorithm iterates through the array only once, making it linear in time.
- **Space Complexity:** O(n) - The hash set used to store the elements takes up linear space.

### Pros
- **Efficiency:** This method is very efficient with a time complexity of O(n).
- **Simplicity:** The logic is straightforward and easy to implement.

### Cons
- **Space Usage:** Requires additional space proportional to the size of the array, which might be a limitation for very large datasets.

## `TwoNumberSumForLoop`

### Description
The `TwoNumberSumForLoop` method uses a brute-force approach with two nested loops to find the pair of numbers that add up to the target sum. The outer loop picks one element, and the inner loop searches for the corresponding element that, when added to the first, equals the target sum.

### Time and Space Complexity
- **Time Complexity:** O(n^2) - The double loop results in a quadratic time complexity.
- **Space Complexity:** O(1) - This approach uses constant space as it doesn't require any additional data structures.

### Pros
- **No Extra Space:** This method does not require any additional memory, making it ideal when space is limited.

### Cons
- **Inefficiency:** The time complexity is quadratic, making it impractical for large datasets.
- **Performance:** Slower compared to the other methods due to the nested loops.

## `TwoNumberSumSort`

### Description
The `TwoNumberSumSort` method first sorts the array and then uses the two-pointer technique to find the pair of numbers that sum up to the target value. One pointer starts at the beginning (left) of the array and the other at the end (right). Depending on whether the current sum of the two pointers is less than, greater than, or equal to the target sum, the pointers are adjusted accordingly.

### Time and Space Complexity
- **Time Complexity:** O(n log n) - The sorting step dominates the time complexity.
- **Space Complexity:** O(1) - The two-pointer technique doesn't require additional space beyond the input array.

### Pros
- **Balanced Approach:** Offers a good balance between time and space complexity.
- **Efficient:** Although slower than `TwoNumberSumHash` for unsorted data, it's still quite efficient and avoids the space overhead.

### Cons
- **Sorting Overhead:** The need to sort the array can be a disadvantage, especially if the array is large and already partially sorted or if sorting is undesirable.
- **In-Place Modification:** The array is modified by sorting, which might not be acceptable in some contexts where the original order needs to be preserved.

## Conclusion

- **Best for Performance:** `TwoNumberSumHash` is the best choice when performance is the primary concern, and additional space usage is not an issue.
- **Best for Space Efficiency:** `TwoNumberSumForLoop` is ideal if you need to avoid extra space usage, but it comes with a performance cost.
- **Best for Balanced Use:** `TwoNumberSumSort` provides a good balance, especially useful when space efficiency is important and the array can be modified.

Each method has its own strengths and weaknesses, and the choice of which to use will depend on the specific constraints and requirements of your problem.
