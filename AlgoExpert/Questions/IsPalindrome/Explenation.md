# AlgoExpert - Is Palindrome Solution

This code provides a solution to the problem of determining whether a given string is a palindrome. A palindrome is a word, phrase, number, or other sequence of characters that reads the same forward and backward, ignoring spaces, punctuation, and capitalization.

## `IsPalindrome`

### Description
The `IsPalindrome` method checks if a given string is a palindrome by comparing characters from both ends of the string and moving toward the center. If all corresponding characters from both sides match, the string is considered a palindrome.

### Time and Space Complexity
- **Time Complexity:** O(n) - The algorithm runs in linear time, where `n` is the length of the string. This is because it performs a single pass through half of the string, comparing characters from both ends.
- **Space Complexity:** O(1) - The space complexity is constant, as the algorithm uses only a few variables (`leftIdx` and `rightIdx`) to manage the two-pointer technique.

### How It Works
1. **Initialize Pointers:** The algorithm uses two pointers:
   - `leftIdx` starts at the beginning of the string (index `0`).
   - `rightIdx` starts at the end of the string (index `str.Length - 1`).

2. **Compare Characters:** The algorithm compares the characters at the `leftIdx` and `rightIdx` positions:
   - If the characters match, both pointers are moved toward the center (`leftIdx++` and `rightIdx--`).
   - If the characters do not match, the algorithm returns `false`, indicating that the string is not a palindrome.

3. **Continue Until Pointers Meet:** The process continues until the `leftIdx` pointer is greater than or equal to the `rightIdx` pointer, indicating that all corresponding characters have been compared.

4. **Return True:** If no mismatch is found, the algorithm returns `true`, indicating that the string is a palindrome.

### Example Walkthrough

Given the input string:
- **String:** `"abcdcba"`

**Step 1:** Compare the first and last characters:
- `'a'` == `'a'`, so move `leftIdx` to `1` and `rightIdx` to `5`.

**Step 2:** Compare the second and second-to-last characters:
- `'b'` == `'b'`, so move `leftIdx` to `2` and `rightIdx` to `4`.

**Step 3:** Compare the third and third-to-last characters:
- `'c'` == `'c'`, so move `leftIdx` to `3` and `rightIdx` to `3`.

**Step 4:** The pointers meet in the middle, and no mismatches are found. The string is a palindrome.

**Result:** The algorithm returns `true`.

### Pros
- **Efficiency:** The algorithm runs in linear time, making it very efficient for checking whether a string is a palindrome.
- **Simplicity:** The two-pointer technique makes the code simple and easy to understand.

### Cons
- **Case Sensitivity:** This implementation is case-sensitive, meaning it would treat `"A"` and `"a"` as different characters. If case insensitivity is required, you could normalize the case of the string before performing the check.
- **No Special Character Handling:** The algorithm does not ignore spaces, punctuation, or special characters. If such handling is needed, preprocessing would be required to remove or normalize those characters.

### Conclusion

The `IsPalindrome` method provides a simple and efficient way to determine whether a string is a palindrome using the two-pointer technique. It runs in linear time and uses constant space, making it suitable for large strings. Although the implementation is straightforward, additional preprocessing might be required for case insensitivity or to handle special characters.
