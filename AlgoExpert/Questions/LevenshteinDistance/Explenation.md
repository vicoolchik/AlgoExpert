# AlgoExpert - Levenshtein Distance Solution

This code provides a solution to the **Levenshtein Distance** problem, which is a classic dynamic programming problem. The task is to calculate the minimum number of single-character edits (insertions, deletions, or substitutions) required to change one string into another.

## `LevenshteinDistance`

### Description
The `LevenshteinDistance` method computes the minimum number of edits (insertions, deletions, or substitutions) required to convert one string into another. The method uses a dynamic programming matrix (`edits`) to keep track of the minimum number of edits needed to transform substrings of the two given strings.

### Time and Space Complexity
- **Time Complexity:** O(nm), where `n` is the length of `str1` and `m` is the length of `str2`. This is because the method iterates over every character in both strings.
- **Space Complexity:** O(nm) due to the two-dimensional matrix used to store the results of the subproblems.

### How It Works

1. **Initialize the DP Matrix:**
   - A two-dimensional array (`edits`) is initialized where `edits[i][j]` represents the minimum number of edits required to convert the first `i` characters of `str2` into the first `j` characters of `str1`.
   - The first row and column are initialized to represent the case where one string is empty and the other contains characters that must be inserted or deleted.

2. **Fill the Matrix:**
   - For each pair of characters from the two strings (`str1` and `str2`), if the characters are the same, no edit is needed, and the value is copied from the diagonal element (`edits[i-1][j-1]`).
   - If the characters are different, the value is the minimum of:
     - Insertion (`edits[i][j-1] + 1`)
     - Deletion (`edits[i-1][j] + 1`)
     - Substitution (`edits[i-1][j-1] + 1`)

3. **Return the Result:**
   - After processing the matrix, the value at `edits[str2.Length][str1.Length]` gives the minimum number of edits needed to transform `str1` into `str2`.

### Example Walkthrough

Given the input:
- **String 1 (str1):** `"abc"`
- **String 2 (str2):** `"yabd"`

**Step 1:** Initialize the matrix:
   ""  a   b   c
"" [0, 1, 2, 3]
 y [1, 1, 2, 3]
 a [2, 1, 2, 3]
 b [3, 2, 1, 2]
 d [4, 3, 2, 2]


**Step 2:** Fill the matrix:

**Result:** The minimum number of edits required to transform `"abc"` into `"yabd"` is `2`.

### `LevenshteinDistanceBetterSpace`

The `LevenshteinDistanceBetterSpace` method is a space-optimized version of the previous solution. Instead of using a two-dimensional matrix, it uses two arrays (`evenEdits` and `oddEdits`) to store only the current and previous rows of the DP matrix. This reduces the space complexity from O(nm) to O(min(n, m)).

### Time and Space Complexity
- **Time Complexity:** O(nm), where `n` is the length of the shorter string and `m` is the length of the longer string.
- **Space Complexity:** O(min(n, m)) due to the use of two arrays to store the current and previous rows of the matrix.

### How It Works

1. **Choose the Shorter String:**
   - To minimize space, the method selects the shorter string (`small`) and the longer string (`big`) so that only the current and previous rows need to be stored.

2. **Use Two Arrays:**
   - Two arrays (`evenEdits` and `oddEdits`) are used to represent the current and previous rows of the DP matrix. The arrays are updated alternately as the method iterates through the characters of the two strings.

3. **Return the Result:**
   - After processing all characters, the last value in the arrays gives the minimum number of edits required to transform one string into the other.

### Pros
- **Efficiency:** Both methods run in O(nm) time, making them suitable for reasonably large strings.
- **Space Optimization:** The `LevenshteinDistanceBetterSpace` method reduces the space complexity significantly by using two arrays instead of a full matrix.

### Cons
- **Not the Most Optimized:** Although efficient, there are faster algorithms (e.g., using the Wagner-Fischer algorithm) that can be used for specific applications where speed is critical.
  
### Edge Cases
- **Empty Strings:** If either string is empty, the method correctly returns the length of the other string as the number of insertions or deletions required.
- **Identical Strings:** If both strings are identical, the method correctly returns `0`.

### Alternative Approaches
- **Recursive Solution:** The problem can be solved recursively, but it would have exponential time complexity without memoization.
- **Iterative with Backtracking:** After calculating the matrix, you could backtrack to find the actual sequence of insertions, deletions, and substitutions needed to transform one string into the other.

## Conclusion

The `LevenshteinDistance` methods efficiently compute the minimum number of edits needed to transform one string into another using dynamic programming. The space-optimized version further improves the solution by reducing memory usage while maintaining the same time complexity. These methods are ideal for use cases like spell checking, DNA sequence alignment, and text comparison.
