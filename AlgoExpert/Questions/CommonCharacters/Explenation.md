# AlgoExpert - Common Characters Solution

This code provides a solution to the problem of finding the common characters that appear in all strings from an array of strings. The method ensures that only characters that exist in every string are returned as part of the result.

## `CommonCharacters`

### Description
The `CommonCharacters` method takes an array of strings as input and returns an array of characters that are present in every string. The solution uses a dictionary to keep track of how many strings contain each character. After processing all strings, the characters that appear in all strings are returned.

### Time and Space Complexity
- **Time Complexity:** O(n * m) - The time complexity is proportional to `n * m`, where `n` is the number of strings and `m` is the length of the longest string. The algorithm iterates through each string and each character within the string.
- **Space Complexity:** O(c) - The space complexity is proportional to `c`, where `c` is the number of unique characters across all strings. This space is used by the dictionary `characterCounts` and the list `finalChars`.

### How It Works
1. **Initialize a Dictionary:**
   - A dictionary `characterCounts` is initialized to store the count of how many strings each character appears in.

2. **Iterate Through Each String:**
   - For each string in the array, a `HashSet` is used to keep track of the unique characters in that string. This ensures that characters are only counted once per string, even if they appear multiple times.

3. **Update the Character Count:**
   - For each unique character in the string, its count in `characterCounts` is incremented.

4. **Identify Common Characters:**
   - After processing all strings, the method iterates through `characterCounts` to find characters that have a count equal to the number of strings (`strings.Length`). These characters are the ones that appear in every string.

5. **Return the Result:**
   - The common characters are stored in a list `finalChars` and then converted to an array of strings for the final result.

### Example Walkthrough

Given the input:
- **Strings:** `["bella", "label", "roller"]`

**Step 1:** Process the first string `"bella"`:
- Unique characters: `{b, e, l, a}`
- `characterCounts`: `{'b': 1, 'e': 1, 'l': 1, 'a': 1}`

**Step 2:** Process the second string `"label"`:
- Unique characters: `{l, a, b, e}`
- `characterCounts`: `{'b': 2, 'e': 2, 'l': 2, 'a': 2}`

**Step 3:** Process the third string `"roller"`:
- Unique characters: `{r, o, l, e}`
- `characterCounts`: `{'b': 2, 'e': 3, 'l': 3, 'a': 2, 'r': 1, 'o': 1}`

**Step 4:** Identify common characters:
- The characters that appear in all three strings (`strings.Length = 3`) are `'e'` and `'l'`.

**Result:** The method returns `["e", "l"]`.

### Pros
- **Efficiency:** The solution uses a single pass through each string, making it efficient for moderate-sized datasets.
- **Handles Duplicates:** The use of a `HashSet` ensures that characters are only counted once per string, even if they appear multiple times.

### Cons
- **No Case Insensitivity:** The method is case-sensitive, meaning that `'A'` and `'a'` are treated as different characters. If case insensitivity is needed, additional preprocessing (like converting all characters to lowercase) would be required.
- **No Special Character Handling:** The method processes all characters, including special characters and punctuation. If special characters should be excluded, additional filtering would be necessary.

### Conclusion

The `CommonCharacters` method provides a robust solution for identifying characters that are common to all strings in an array. By using a dictionary and `HashSet`, the solution efficiently tracks character occurrences while ensuring that duplicates are handled correctly. It returns only those characters that appear in every string, making it a useful tool for solving problems involving common elements across multiple sets of data.
