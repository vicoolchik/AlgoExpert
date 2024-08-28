# AlgoExpert - Tandem Bicycle Solution

This code provides a solution to the "Tandem Bicycle" problem, where the task is to pair up cyclists from two groups (red shirts and blue shirts) and calculate the maximum or minimum possible total speed of the tandem bicycles. The solution is implemented in the `TandemBicycle` method, which takes in the speeds of the two groups and a boolean flag indicating whether to maximize or minimize the total speed.

## `TandemBicycle`

### Description
The `TandemBicycle` method computes the total speed of all tandem bicycles based on the pairing strategy. The method allows for two possible outcomes:
- **Fastest:** Maximizes the total speed by pairing the fastest possible cyclists from each group.
- **Slowest:** Minimizes the total speed by pairing the cyclists in a way that reduces the overall speed.

### Time and Space Complexity
- **Time Complexity:** O(n log n) - The dominant factor in the time complexity is the sorting step, where `n` is the number of cyclists in each group.
- **Space Complexity:** O(1) - The method uses a constant amount of extra space, as it only requires a few integer variables for calculations.

### How It Works
1. **Sort the Speeds:** The speed arrays for both the red shirt group and the blue shirt group are sorted in ascending order. This sorting helps in making optimal pairings based on the desired outcome.

2. **Determine Pairing Strategy:**
   - If the `fastest` flag is set to `true`, the method will attempt to maximize the total speed by pairing the fastest cyclists from one group with the slowest cyclists from the other group.
   - If the `fastest` flag is set to `false`, the method will pair cyclists in a way that minimizes the total speed by pairing cyclists with similar speeds.

3. **Calculate Total Speed:** The method calculates the total speed by iterating through the cyclist pairs:
   - The method compares the speeds of the cyclists in the two groups, ensuring that the higher speed from each pair is used.
   - The total speed is accumulated and returned as the result.

### Example Walkthrough

Given the following cyclist speeds:
- **Red Shirt Speeds:** `[5, 5, 3, 9, 2]`
- **Blue Shirt Speeds:** `[3, 6, 7, 2, 1]`

**Step 1:** Sort the speeds:
- **Sorted Red Shirt Speeds:** `[2, 3, 5, 5, 9]`
- **Sorted Blue Shirt Speeds:** `[1, 2, 3, 6, 7]`

**Step 2:** Determine Pairing Strategy:
- If `fastest` is `true`, pair the fastest from one group with the slowest from the other:
  - Pair 1: `(9, 1)` → 9
  - Pair 2: `(5, 2)` → 5
  - Pair 3: `(5, 3)` → 5
  - Pair 4: `(3, 6)` → 6
  - Pair 5: `(2, 7)` → 7

- Total Speed (fastest): `9 + 5 + 5 + 6 + 7 = 32`

**Step 3:** Return Result:
- The method returns `32` for the fastest pairing strategy.

### Pros
- **Efficiency:** The method efficiently calculates the total speed with a time complexity of O(n log n), making it suitable for large inputs.
- **Flexibility:** The method can handle both maximizing and minimizing strategies based on the `fastest` flag, providing flexibility for different scenarios.

### Cons
- **Sorting Overhead:** The sorting step introduces computational overhead, which is necessary but might not be ideal for very large datasets where sorting is a bottleneck.

## Conclusion

The `TandemBicycle` method provides a robust and efficient solution for calculating the total speed of tandem bicycles based on different pairing strategies. By sorting the cyclist speeds and comparing them in an optimal manner, the method ensures that the desired outcome—whether maximum or minimum total speed—is achieved. This solution is both flexible and easy to understand, making it a reliable choice for problems involving optimal pairings.

The overall design, with the ability to toggle between maximizing and minimizing total speed, adds versatility to this implementation.
