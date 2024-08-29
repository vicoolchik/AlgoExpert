# AlgoExpert - Remove Duplicates from Linked List Solution

This code provides a solution to the problem of removing duplicate values from a sorted linked list. The goal is to ensure that each value in the linked list appears only once, and all duplicates are removed. The solution is implemented in the `RemoveDuplicatesFromLinkedList` method, which operates in linear time with constant space.

## `RemoveDuplicatesFromLinkedList`

### Description
The `RemoveDuplicatesFromLinkedList` method iterates through the linked list and removes consecutive duplicate nodes, ensuring that each value appears only once. It modifies the list in place, which means no additional space is needed beyond a few pointers.

### Time and Space Complexity
- **Time Complexity:** O(n) - The method traverses each node of the linked list exactly once, where `n` is the number of nodes in the list.
- **Space Complexity:** O(1) - The method uses a constant amount of extra space, as it only requires a few pointers to manage the traversal and modification of the list.

### How It Works
1. **Initialize Pointers:** The method starts by setting a pointer to the head of the linked list (`currentNode`). This pointer is used to traverse the list.

2. **Iterate Through the List:** 
   - For each node, the method checks if the next node has the same value as the current node.
   - If a duplicate is found, the method skips over all duplicate nodes by adjusting the `next` pointer of the current node to point to the first non-duplicate node.
   - The traversal continues with the updated `next` pointer.

3. **Modify the List In-Place:** The list is modified in place by updating pointers, meaning no additional linked list is created. The method returns the head of the modified linked list, which no longer contains duplicates.

### Example Walkthrough

Given the following linked list:
- `0 -> 1 -> 2 -> 2 -> 3 -> 4 -> 4 -> 5 -> 6`

**Step 1:** Initialize the pointer at the head (`0`).

**Step 2:** Traverse the list:
- Compare `0` with `1` (no duplicates).
- Compare `1` with `2` (no duplicates).
- Compare `2` with the next `2` (duplicates found).
  - Skip the duplicate `2` and update the `next` pointer to point to `3`.
- Continue with `3`, `4` (finds duplicates), `5`, `6`.

**Step 3:** Return the modified list:
- Resulting linked list: `0 -> 1 -> 2 -> 3 -> 4 -> 5 -> 6`

### Pros
- **Efficiency:** The method is both time and space-efficient, making it suitable for large linked lists.
- **In-Place Modification:** By modifying the list in place, the method avoids unnecessary memory usage, which is crucial in environments with limited resources.

### Cons
- **Assumes a Sorted List:** This method assumes that the linked list is sorted. If the list is not sorted, the method would not correctly remove all duplicates.

## `LinkedList` Class

### Description
The `LinkedList` class is a simple implementation of a singly linked list. It provides basic functionality, including the ability to add new nodes.

### Methods
- **Constructor:** Initializes a new node with a given value.
- **Add Method:** Adds a new node to the end of the linked list. It iterates through the list until it finds the last node, then appends the new node.

### Example Usage
```csharp
var linkedList = new LinkedList(0);
linkedList.Add(1);
linkedList.Add(2);
linkedList.Add(2);
This creates a linked list 0 -> 1 -> 2 -> 2
```

### Conclusion
The `RemoveDuplicatesFromLinkedList` method provides an effective solution for removing duplicates from a sorted linked list. Its linear time complexity and constant space usage make it a reliable choice for handling large datasets. The method is designed to work efficiently in-place, ensuring that memory usage is kept to a minimum.

The `LinkedList` class , while simple, supports the necessary operations for this problem, making it easy to test and verify the solution.