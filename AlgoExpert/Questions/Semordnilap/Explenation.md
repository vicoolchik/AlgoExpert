# AlgoExpert - Semordnilap Solution

This code provides a solution to the "Semordnilap" problem, where the goal is to find pairs of words from an array that are semordnilaps. A semordnilap is a word that forms another word when spelled backward (similar to palindromes but with two distinct words).

## `Semordnilap`

### Description
The `Semordnilap` method takes an array of words as input and returns a list of word pairs where each pair consists of two words that are semordnilaps of each other. The method achieves this by reversing each word in the array and checking if the reversed word exists in the set of words.

### Time and Space Complexity
- **Time Complexity:** O(n * m) - The time complexity is proportional to `n`, the number of words in the input array, and `m`, the average length of each word. The `Reverse()` operation takes O(m) time for each word, and searching in a hash set takes O(1) on average, so overall the time complexity is O(n * m).
- **Space Complexity:** O(n) - The space complexity is proportional to the number of words (`n`) in the input array because all words are stored in a hash set.

### How It Works
1. **Store Words in a HashSet:**
   - The method first stores all the words from the input array into a hash set (`wordSet`). This allows for quick lookups of reversed words in O(1) time on average.

2. **Check for Semordnilaps:**
   - For each word in the array, the method reverses the word and checks if the reversed word exists in the `wordSet`.
   - If a match is found and the word is not a palindrome (i.e., the word is not equal to its reverse), the word and its reversed counterpart are added as a semordnilap pair to the result list.
   - Both words (the original and the reversed word) are then removed from the set to avoid duplicate pairs.

3. **Return the Result:**
   - The method returns a list of lists where each sublist contains two words that are semordnilaps of each other.

### Example Walkthrough

Given the input:
- **Words:** `["dog", "god", "cat", "tac"]`

**Step 1:** Store words in the hash set:
- `wordSet`: `{ "dog", "god", "cat", "tac" }`

**Step 2:** Check for semordnilaps:
- For "dog", reverse is "god". Since "god" is in `wordSet` and "dog" is not equal to "god", add `["dog", "god"]` to the result and remove both "dog" and "god" from the set.
- For "cat", reverse is "tac". Since "tac" is in `wordSet` and "cat" is not equal to "tac", add `["cat", "tac"]` to the result and remove both "cat" and "tac" from the set.

**Step 3:** Return the result:
- Result: `[["dog", "god"], ["cat", "tac"]]`

### Pros
- **Efficiency:** Using a hash set ensures O(1) average time complexity for checking if a reversed word exists, making the solution efficient even for larger datasets.
- **Handles Non-Palindrome Reversals:** The solution correctly filters out palindromes by ensuring the word is not equal to its reverse before adding it to the result list.

### Cons
- **No Case Handling:** The method assumes case-sensitive words. If case insensitivity is required, additional logic (such as converting all words to lowercase) would need to be added.
- **No Special Character Handling:** The method assumes words consist of only alphabetic characters. If special characters or spaces are included in the words, they would be reversed as well, which might lead to unexpected results.

### Conclusion

The `Semordnilap` method provides an efficient and straightforward way to find pairs of semordnilap words from an array. By using a hash set for quick lookups and reversing each word, the method ensures that semordnilap pairs are identified in O(n * m) time, making it suitable for moderate-sized datasets. This solution can be extended to handle case insensitivity or special character filtering if needed.
