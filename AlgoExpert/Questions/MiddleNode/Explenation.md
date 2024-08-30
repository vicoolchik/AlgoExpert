# AlgoExpert - Middle Node Solution

This code provides a solution to the problem of finding the middle node in a singly linked list. The task is to identify and return the middle node of the linked list. If the list has an even number of nodes, the second of the two middle nodes should be returned.

## `MiddleNode`

### Description
The `MiddleNode` method determines the middle node of a linked list by first calculating the total length of the list and then iterating through the list again to locate the middle node. This approach involves two passes through the list: one to calculate its length and another to find the middle node.

### Time and Space Complexity
- **Time Complexity:** O(n) - The method makes two passes through the linked list, where `n` is the number of nodes.
- **Space Complexity:** O(1) - The method uses a constant amount of extra space, as it only requires a few integer variables and pointers.

### How It Works
1. **Calculate Length:** The method starts by traversing the linked list from the head to the end to determine its total length. This is done using a `currentNode` pointer and a `length` counter.

2. **Find Middle Node:** 
   - Once the total length is known, the middle index is calculated as `length / 2`.
   - The method then iterates through the list a second time to reach the middle node. The middle node is found by advancing the `middleNode` pointer from the head until the middle index is reached.

3. **Return Middle Node:** After locating the middle node, it is returned as the result.

### Example Walkthrough

Given the following linked list:
- `0 -> 1 -> 2 -> 3 -> 4 -> 5 -> 6`

**Step 1:** Calculate the length:
- The method traverses the list and determines the length is 7.

**Step 2:** Find the middle node:
- The middle index is calculated as `7 / 2 = 3`.
- The method then traverses the list again until it reaches the 3rd index (0-based), which corresponds to the node with value `3`.

**Step 3:** Return the middle node:
- The method returns the node with value `3`.

### Pros
- **Simplicity:** The method is easy to understand and implement, making it a good choice for beginners.
- **Deterministic Approach:** The two-pass approach guarantees that the correct middle node is found.

### Cons
- **Efficiency:** The method requires two passes through the linked list, which is not as efficient as it could be. There is a more optimal one-pass solution using the "fast and slow pointer" technique.


### Conclusion
The `MiddleNode` method provides a straightforward solution for finding the middle node in a linked list using a two-pass approach. While simple and easy to understand, this method can be improved using a fast and slow pointer technique to achieve the same result more efficiently in one pass.