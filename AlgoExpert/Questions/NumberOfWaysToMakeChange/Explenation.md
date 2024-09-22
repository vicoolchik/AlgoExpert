# AlgoExpert - Number of Ways to Make Change Solution

This solution addresses the **Number of Ways to Make Change** problem. The goal is to calculate how many distinct ways you can make a specific amount of money using a set of coin denominations.

## `NumberOfWaysToMakeChange` Function

### Description
The `NumberOfWaysToMakeChange` function takes two inputs:
- `n`: the target amount of money.
- `denoms`: an array of available coin denominations.

The function returns the number of ways you can use the provided coin denominations to make the target amount.

### Time and Space Complexity
- **Time Complexity**: O(nd), where `n` is the target amount and `d` is the number of coin denominations.
- **Space Complexity**: O(n), since it uses a one-dimensional array to store the number of ways to make each amount up to `n`.

### How It Works

#### 1. **Initial Setup**:
   - Create an array `ways` where each index `i` represents the number of ways to make the amount `i`.
   - Set `ways[0]` to 1 because there is exactly one way to make the amount 0 (by not using any coins).
   - Initialize all other entries in `ways` to 0, as initially, we assume there are no ways to make any other amounts.

#### 2. **Loop Through Denominations**:
   - For each denomination in the `denoms` array, loop through all amounts from 1 to `n`.
   - For each amount, check if the current denomination can contribute to the amount. If so, add the number of ways to make the remaining amount (`amount - denom`) to the current amount's entry in the `ways` array.
   - This ensures that all combinations of the current denomination with previously considered denominations are accounted for.

#### 3. **Final Result**:
   - After processing all denominations, the function returns the value at `ways[n]`, which represents the number of ways to make the target amount using the given denominations.

### Example Usage


- **Denominations**: {1, 5}
- **Target Amount**: 6

The function calculates that there are `2` ways to make the amount 6:
1. Using six 1-coin denominations.
2. Using one 5-coin denomination and one 1-coin denomination.

This example demonstrates the dynamic programming approach to finding all possible combinations of coins that can sum up to the target amount.