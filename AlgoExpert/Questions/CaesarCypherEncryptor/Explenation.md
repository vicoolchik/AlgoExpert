# AlgoExpert - Caesar Cipher Encryptor Solution

This code provides an implementation of a Caesar Cipher, a simple encryption technique where each letter in a string is shifted by a certain number of positions in the alphabet. If the shift causes the position to go beyond the alphabet, it wraps around back to the start of the alphabet.

## `CaesarCypherEncryptor`

### Description
The `CaesarCypherEncryptor` method encrypts a given string using the Caesar Cipher. It shifts each letter in the string by the specified key (number of positions). The method handles wrapping around the alphabet when the shifted value exceeds 'z'.

### Time and Space Complexity
- **Time Complexity:** O(n) - The algorithm iterates through each character in the input string once, where `n` is the length of the string.
- **Space Complexity:** O(n) - The algorithm creates a list to store the encrypted characters, which requires space proportional to the length of the string.

### How It Works
1. **Normalize the Key:**
   - The `key` is normalized using the modulus operation (`key % 26`) to ensure that the key is always within the range of 0 to 25. This is because shifting by 26 or more is equivalent to a full cycle through the alphabet, so it has no effect.

2. **Iterate Through Each Character:**
   - For each character in the string, the method calls `GetNewLetter` to calculate the encrypted letter by shifting its ASCII value according to the normalized key.

3. **Handle Character Wrapping:**
   - If the new letter code exceeds the ASCII value of 'z' (`122`), the method wraps the value around to the beginning of the alphabet by subtracting the ASCII value of 'a' (`96`) and taking the modulus of the result.

4. **Build the Encrypted String:**
   - The encrypted characters are stored in a list, which is later converted back to a string and returned as the result.

### Example Walkthrough

Given the input:
- **String:** `"xyz"`
- **Key:** `2`

**Step 1:** Normalize the key:
- `newKey = 2 % 26 = 2`

**Step 2:** Encrypt each letter:
- `'x'` is shifted by 2: `'x'` -> `'z'`
- `'y'` is shifted by 2: `'y'` -> `'a'` (wraps around)
- `'z'` is shifted by 2: `'z'` -> `'b'` (wraps around)

**Result:** The encrypted string is `"zab"`.

### Pros
- **Efficiency:** The algorithm runs in linear time, making it efficient even for long strings.
- **Simple Implementation:** The use of ASCII values and modulus ensures that the character shifts and wrapping are handled cleanly and concisely.
- **Handles Wrapping:** The algorithm correctly handles cases where the shift goes beyond 'z' by wrapping back to 'a'.

### Cons
- **Case-Sensitivity:** The current implementation only works for lowercase letters. If uppercase letters or non-alphabetic characters need to be handled, additional logic would be required.
- **No Special Character Handling:** This implementation assumes the input string consists solely of lowercase letters. If you need to handle spaces, punctuation, or numbers, those cases would need to be explicitly handled.

### `GetNewLetter` Method
The `GetNewLetter` method is responsible for shifting a single character by the specified key and ensuring that the result wraps around the alphabet if necessary.

- **Input:** A letter (char) and a key (int).
- **Output:** A new letter (char) that represents the original letter shifted by the key.

### Conclusion

The `CaesarCypherEncryptor` method provides an efficient and simple solution for encrypting a string using the Caesar Cipher technique. The algorithm handles wrapping around the alphabet and ensures that the encryption process works as expected for lowercase letters. If more features are required, such as case insensitivity or handling special characters, the solution can be extended.
