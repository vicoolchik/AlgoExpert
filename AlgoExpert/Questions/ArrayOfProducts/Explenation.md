# AlgoExpert - Array of Products Solution

This code provides multiple solutions to the "Array of Products" problem, where the goal is to create an array such that each element in the new array is the product of all elements in the original array except for the element at the current index.

## `ArrayOfProducts`

### Description
The `ArrayOfProducts` method computes a new array where each element is the product of all the elements of the input array except for the element at the current index. The method solves this problem using two passes through the array—one to calculate the "left products" and another to calculate the "right products".

### Time and Space Complexity
- **Time Complexity:** O(n) - The method makes two passes through the array, where `n` is the length of the array.
- **Space Complexity:** O(n) - The method uses three arrays (`leftProducts`, `rightProducts`, and `products`), each of size `n`.

### How It Works
1. **Left Products:**
   - The `leftProducts` array is populated such that each element at index `i` contains the product of all elements to the left of `i` in the input array.
   
2. **Right Products:**
   - The `rightProducts` array is populated such that each element at index `i` contains the product of all elements to the right of `i` in the input array.

3. **Final Products:**
   - The final product at index `i` is the product of `leftProducts[i]` and `rightProducts[i]`.

### Example Walkthrough

Given the input:
- **Array:** `[5, 1, 4, 2]`

**Step 1:** Left Products:
- `leftProducts = [1, 5, 5, 20]`
  - `leftProducts[0] = 1` (no elements to the left).
  - `leftProducts[1] = 5` (product of elements to the left of 1).
  - `leftProducts[2] = 5 * 1 = 5` (product of elements to the left of 4).
  - `leftProducts[3] = 5 * 1 * 4 = 20` (product of elements to the left of 2).

**Step 2:** Right Products:
- `rightProducts = [8, 8, 2, 1]`
  - `rightProducts[3] = 1` (no elements to the right).
  - `rightProducts[2] = 2` (product of elements to the right of 4).
  - `rightProducts[1] = 4 * 2 = 8` (product of elements to the right of 1).
  - `rightProducts[0] = 1 * 4 * 2 = 8` (product of elements to the right of 5).

**Step 3:** Final Products:
- `products = [8, 40, 10, 20]`
  - `products[0] = leftProducts[0] * rightProducts[0] = 1 * 8 = 8`
  - `products[1] = leftProducts[1] * rightProducts[1] = 5 * 8 = 40`
  - `products[2] = leftProducts[2] * rightProducts[2] = 5 * 2 = 10`
  - `products[3] = leftProducts[3] * rightProducts[3] = 20 * 1 = 20`

**Result:** `[8, 40, 10, 20]`

### Pros
- **Efficiency:** The method runs in linear time and uses additional arrays for left and right products.
- **Clear Logic:** The two-pass approach is easy to understand and implement.

### Cons
- **Extra Space:** The solution requires extra space for the left and right product arrays.

---

## `ArrayOfProductsOptimized`

### Description
The `ArrayOfProductsOptimized` method improves on the first solution by eliminating the need for separate `leftProducts` and `rightProducts` arrays. Instead, the final product array is updated in two passes—first by calculating the left products and then by multiplying with the right products.

### Time and Space Complexity
- **Time Complexity:** O(n) - The method makes two passes through the array.
- **Space Complexity:** O(n) - Only the final `products` array of size `n` is used, reducing space usage compared to the previous solution.

### How It Works
1. **First Pass:** Calculate the left products and store them directly in the `products` array.
2. **Second Pass:** Multiply the current value in `products` with the right products as you iterate through the array from right to left.

### Example Walkthrough

Given the input:
- **Array:** `[5, 1, 4, 2]`

**Step 1:** First Pass (Left Products):
- `products = [1, 5, 5, 20]`

**Step 2:** Second Pass (Right Products):
- Multiply each element in `products` by the corresponding right product:
  - `products[3] = 20 * 1 = 20`
  - `products[2] = 5 * 2 = 10`
  - `products[1] = 5 * 8 = 40`
  - `products[0] = 1 * 8 = 8`

**Result:** `[8, 40, 10, 20]`

### Pros
- **Space-Efficient:** This version reduces the space complexity by avoiding extra arrays for left and right products.
- **Same Time Complexity:** It retains the O(n) time complexity.

---

## `ArrayOfProductsBruteForce`

### Description
The `ArrayOfProductsBruteForce` method uses a brute-force approach to calculate the product of all elements except the one at the current index. This is done by using nested loops.

### Time and Space Complexity
- **Time Complexity:** O(n^2) - The method uses two nested loops, where `n` is the length of the array.
- **Space Complexity:** O(n) - The space complexity is proportional to the final `products` array.

### How It Works
1. **Nested Loop:** For each element, iterate through the entire array to compute the product of all other elements.
2. **Store Results:** Store the result in the `products` array for each index.

### Pros
- **Simple to Implement:** The brute-force approach is easy to understand and implement.

### Cons
- **Inefficient:** The O(n^2) time complexity makes this approach impractical for large arrays.

---

## Conclusion

- **Best for Efficiency:** The `ArrayOfProductsOptimized` method provides the best trade-off between time and space efficiency, offering O(n) time and O(n) space complexity.
- **Best for Simplicity:** While the brute-force method is straightforward, it is inefficient for larger arrays. The optimized solution is preferable for real-world use cases where efficiency matters.
