# AlgoExpert - First Non-Repeating Character Solution

This code provides a solution to the problem of finding the first non-repeating character in a given string. The goal is to identify the first character that appears only once in the string and return its index. If there is no such character, the function returns `-1`.

## `FirstNonRepeatingCharacter`

### Description
The `FirstNonRepeatingCharacter` method determines the index of the first non-repeating character in a string. It does this by first counting the frequency of each character and then iterating through the string again to find the first character with a count of 1.

### Time and Space Complexity
- **Time Complexity:** O(n) - The time complexity is linear because the algorithm makes two passes over the string, where `n` is the length of the string.
- **Space Complexity:** O(1) - The space complexity is considered constant in terms of the number of unique characters (assuming the alphabet is fixed, such as English alphabet letters). The space required for the dictionary depends on the number of distinct characters in the string, but this is still bounded by a constant factor for typical character sets.

### How It Works
1. **Count Character Frequencies:**
   - The method first initializes a dictionary (`characterFrequencies`) to store the count of each character in the string.
   - It iterates through the string, and for each character, it increments its count in the dictionary.

2. **Find the First Non-Repeating Character:**
   - After building the frequency dictionary, the method makes a second pass through the string.
   - For each character, it checks the dictionary to see if its count is 1. If it finds such a character, it returns the index of that character.
   - If no such character is found, the method returns `-1`.

### Example Walkthrough

Given the input:
- **String:** `"abcdcaf"`

**Step 1:** Count character frequencies:
- The dictionary `characterFrequencies` is populated as:
  - `{ 'a': 2, 'b': 1, 'c': 2, 'd': 1, 'f': 1 }`

**Step 2:** Find the first non-repeating character:
- Start from index `0`:
  - 'a' → frequency = 2 (skip)
  - 'b' → frequency = 1 (return index 1)

**Result:** The first non-repeating character is 'b', and its index is `1`.

### Pros
- **Efficiency:** The algorithm is efficient, requiring only two passes through the string, making it suitable for large strings.
- **Handles Any Characters:** The method works with any characters (letters, numbers, symbols, etc.), making it versatile.

### Cons
- **Case Sensitivity:** The method is case-sensitive, meaning it treats uppercase and lowercase letters as distinct characters. If case insensitivity is required, additional preprocessing would be needed (e.g., converting the string to lowercase).
- **No Edge Case Handling for Empty Strings:** The method assumes the input string is non-empty. If an empty string is passed, it will behave correctly by returning `-1`, but no explicit check for this case is implemented.

### Possible Extensions
1. **Case Insensitivity:** You could modify the method to handle case insensitivity by converting all characters to lowercase (or uppercase) before processing.
2. **Edge Case Handling:** You could add an explicit check for an empty string at the start and return `-1` immediately if the string is empty.

## Conclusion

The `FirstNonRepeatingCharacter` method provides an efficient solution to find the index of the first non-repeating character in a string. By using a dictionary to count character frequencies and then checking those frequencies in a second pass, the algorithm guarantees linear time complexity while maintaining constant space usage for typical character sets.
