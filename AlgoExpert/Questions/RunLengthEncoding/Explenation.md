# AlgoExpert - Run-Length Encoding Solution

This code provides an implementation of the Run-Length Encoding (RLE) algorithm, a simple form of data compression where consecutive repeated characters are encoded as a count followed by the character itself.

## `RunLengthEncoding`

### Description
The `RunLengthEncoding` method compresses a string by counting consecutive characters and encoding them as a pair of the count and the character. It handles up to 9 consecutive characters at a time, even if the string contains more consecutive characters. This is because the RLE format typically uses a single digit to represent the run length.

### Time and Space Complexity
- **Time Complexity:** O(n) - The algorithm runs in linear time because it processes each character in the input string exactly once.
- **Space Complexity:** O(n) - The space complexity is linear, as the encoded string may have roughly the same length as the input string.

### How It Works
1. **Initialize Variables:**
   - `encodedChars`: A list to store the resulting run-length encoded characters.
   - `currentRunLength`: A variable to track the number of consecutive characters (initialized to 1 for the first character).

2. **Iterate Through the String:**
   - For each character in the string (starting from the second character), the algorithm compares it with the previous character:
     - If the current character is different from the previous one or the run length reaches 9, it adds the run length and the previous character to the `encodedChars` list and resets the run length to 1.
     - Otherwise, it increments the run length to account for consecutive occurrences of the same character.

3. **Handle Final Run:**
   - After iterating through the string, the algorithm adds the final run length and character to `encodedChars`.

4. **Return the Encoded String:**
   - The `encodedChars` list is converted to a string and returned as the result.

### Example Walkthrough

Given the input:
- **String:** `"AAAAAAAAAAAAABBCCCCDD"`

**Step 1:** Initialize:
- `encodedChars = []`
- `currentRunLength = 1`

**Step 2:** Iterate through the string:
- For the first 9 characters (`'A'`), the run length is 9.
  - Add `'9A'` to `encodedChars`.
- Continue counting the next 4 `'A'`, but as run length can only be 9, we start a new run.
  - Add `'4A'` to `encodedChars`.
- For 2 `'B'`, add `'2B'` to `encodedChars`.
- For 4 `'C'`, add `'4C'` to `encodedChars`.
- For 2 `'D'`, add `'2D'` to `encodedChars`.

**Final Result:** The encoded string is `"9A4A2B4C2D"`.

### Pros
- **Efficiency:** The algorithm runs in linear time, making it efficient for processing even large strings.
- **Compression:** This algorithm provides a simple and effective way to compress repetitive characters in a string.

### Cons
- **Handling Long Runs:** The algorithm limits run lengths to 9, which means that strings with more than 9 consecutive identical characters will be split into multiple runs (e.g., `"AAAAAAAAAAAAA"` becomes `"9A4A"`).

### Conclusion

The `RunLengthEncoding` method provides a straightforward and efficient solution to compress strings using run-length encoding. It compresses consecutive identical characters while ensuring that run lengths are capped at 9, making the algorithm robust for handling even long runs of characters. This method is well-suited for compressing repetitive data efficiently while maintaining simplicity.
