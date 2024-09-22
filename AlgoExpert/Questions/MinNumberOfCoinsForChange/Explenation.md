# AlgoExpert - Min Number of Coins for Change Solution

This solution provides a way to solve the **Minimum Number of Coins for Change** problem. The goal is to determine the fewest number of coins needed to make a target amount, using a given set of coin denominations. The solution efficiently calculates the minimum number of coins through dynamic programming.

## `MinNumberOfCoinsForChange` Function

### Description
The `MinNumberOfCoinsForChange` function takes two inputs: 
- `n`: the target amount of money.
- `denoms`: an array of available coin denominations.

The function returns the minimum number of coins needed to make the exact target amount. If it's impossible to make the target amount with the given coins, the function returns `-1`.

### Time and Space Complexity
- **Time Complexity**: O(nd), where `n` is the target amount, and `d` is the number of coin denominations.
- **Space Complexity**: O(n), as it uses a one-dimensional array to store the minimum number of coins required for each amount from 0 to `n`.

### How It Works

#### 1. **Initial Setup**:
   - Create an array `numOfCoins` to store the minimum number of coins needed to make each amount up to `n`.
   - Initialize `numOfCoins[0]` to 0 (since no coins are needed to make 0), and set all other values to infinity (or a very large number) to represent an initially unreachable state.

#### 2. **Loop Through Denominations**:
   - For each denomination in the `denoms` array, loop through the amounts from 1 to `n`. 
   - For each amount, check if the denomination can be used to reach that amount. If so, update the minimum number of coins required by considering whether using this denomination reduces the total number of coins.

#### 3. **Final Result**:
   - After processing all denominations, the function checks if the target amount `n` is reachable by checking the value at `numOfCoins[n]`. If it's still infinity, return `-1` (meaning it's impossible to make the amount). Otherwise, return the value at `numOfCoins[n]`, which represents the minimum number of coins needed.

### Example Usage

Given the following denominations and target amount:

- **Denominations**: {1, 2, 4}
- **Target Amount**: 6

The minimum number of coins needed to make 6 is `2`, using coins {2, 4}. 

This example demonstrates the efficiency of the solution in finding the optimal way to make the target amount using the fewest coins.