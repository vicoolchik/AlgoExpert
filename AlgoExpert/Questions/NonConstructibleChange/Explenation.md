# AlgoExpert - Non-Constructible Change Solution

This code provides a solution to the "Non-Constructible Change" problem, where the objective is to determine the minimum amount of change (in cents) that cannot be created with a given set of coins. The method implemented is efficient and leverages sorting and a greedy algorithm to achieve the result. Below is a detailed description of the solution, including its advantages and disadvantages.

## `NonConstructibleChange`

### Description
The `NonConstructibleChange` method calculates the smallest amount of change that cannot be formed using the coins provided in the input array. The approach relies on sorting the coins and then iterating through them while keeping track of the current change that can be constructed. If a coin is encountered that is larger than the smallest non-constructible change, the method returns that value as the result.

### Time and Space Complexity
- **Time Complexity:** O(n log n) - The dominant factor in the time complexity is the sorting of the array, which takes O(n log n) time, where `n` is the number of coins.
- **Space Complexity:** O(1) - The method uses a constant amount of extra space, as it only requires a few integer variables to track the current state.

### How It Works
1. **Sort the Coins:** The input array of coins is sorted in ascending order. Sorting is crucial as it allows for a greedy approach, where we can check the smallest change that cannot be constructed sequentially.
   
2. **Initialize Tracking Variable:** A variable `currentChangeCreated` is initialized to 0, representing the highest amount of change that can be constructed with the coins encountered so far.

3. **Iterate Through the Coins:** The method iterates through each coin in the sorted array:
   - If the current coin is greater than `currentChangeCreated + 1`, it means there is a gap, and the smallest non-constructible change is `currentChangeCreated + 1`. The method then returns this value.
   - If the current coin can be added to `currentChangeCreated` without creating a gap, `currentChangeCreated` is updated by adding the value of the current coin.

4. **Return the Result:** If all coins are processed without finding a gap, the smallest non-constructible change is `currentChangeCreated + 1`, which is returned as the result.

### Pros
- **Efficiency:** The method is efficient, particularly in terms of space, as it only requires constant space aside from the input array.
- **Simplicity:** The logic is straightforward and easy to follow, making the code easy to maintain and understand.

### Cons
- **Sorting Overhead:** While the time complexity is acceptable for most applications, the sorting step introduces additional computational overhead, which might be a concern for very large datasets.
- **Edge Cases:** The method assumes that the input array is non-empty. Special handling may be required for edge cases, such as an empty array, to prevent errors.

## Conclusion

The `NonConstructibleChange` method provides a clear and efficient solution to the problem of determining the smallest non-constructible change. By leveraging sorting and a greedy algorithm, the solution ensures that the result is obtained in O(n log n) time with minimal space usage. This method is suitable for a wide range of applications where determining the smallest amount of non-constructible change is necessary.

Its combination of simplicity and efficiency makes it a robust solution for this type of problem.
