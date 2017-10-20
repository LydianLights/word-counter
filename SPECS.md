# Word Counter Specs

_This app should allow a user to input a sentence and a word, and it should count the number of times the word appears in the sentence._

## Behaviors and Examples

---

If the user enters a single-word sentence that doesn't match their test word, it should count zero matches.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| dog | cat | 0 |

_This input-output pair checks a simple pair of words with no special casing or punctuation._

---

If the user enters a single-word sentence that does match their test word, it should count one match.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| cat | cat | 1 |

_This input-output pair checks a single word against an exact copy of itself._

---

If the user enters a single-word sentence and a word to check that is partially contained in that word, it should not count a match.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| apple | a | 0 |

_This input-output pair checks that even though one word might start with or contain the other, they are not the same word._

---

If the user enters an empty sentence, return zero matches;

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
|  | cat | 0 |

_This input-output pair checks for an empty sentence._

---

If the user enters an empty word to check, return zero matches;

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| cat |  | 0 |

_This input-output pair checks for an empty input word._

---

If the user enters an empty word to check and an empty sentence, return zero matches;

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
|  |  | 0 |

_This input-output pair checks for both an empty input word and empty sentence._

---

If the user enters a full sentence and a word not appearing in that sentence, it should count zero matches.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| the quick brown fox jumps over the lazy dog | cat | 0 |

_This input-output pair checks a simple sentence with no capitalization or punctuation._

---

If the user enters a full sentence and a word, it should count the amount of times the word appears in the sentence.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| buffalo buffalo buffalo buffalo buffalo buffalo buffalo bison | buffalo | 7 |

_This input-output pair checks a simple sentence with no capitalization or punctuation._

---

If a word in the sentence matches the input word but is capitalized, it should still count as a match.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| The quick brown fox jumps over the lazy dog. | the | 2 |

_This input-output pair checks that a capitalized first letter counts as a match_

---

If a word in the sentence matches the input word but is all-caps, it should still count as a match.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG. | fox | 1 |

_This input-output pair checks that an all-caps variation still counts as a match_

---

If a word in the sentence matches the input word but has capitalization differences that are not only the first letter or all-caps, then it should not count as a match.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| The quick BrOwN fox jumps over the lazy dog. | brown | 0 |

_This input-output pair checks that a strangely cased word counts as a different word._

---

If a word in the sentence matches the input word but the input word capitalized, it should still count as a match.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| The quick brown fox jumps over the lazy dog. | The | 2 |

_This input-output pair checks that a capitalized first letter counts as a match_

---

If a word in the sentence matches the input word but the input word is all-caps, it should still count as a match.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| The quick brown fox jumps over the lazy dog. | FOX | 1 |

_This input-output pair checks that an all-caps variation still counts as a match_

---

If a word in the sentence matches the input word but the input word has capitalization differences that are not only the first letter or all-caps, then it should not count as a match.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| The quick brown fox jumps over the lazy dog. | bRoWn | 0 |

_This input-output pair checks that a strangely cased word counts as a different word._

---

If a word in the sentence matches the input word but starts and/or ends with punctuation, it should still count as a match.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| The quick brown "dog" jumps over the lazy dog. | dog | 2 |

_This input-output pair checks that surrounding punctuation doesn't count towards the word itself._

---

If a word in the sentence matches the input word but starts and/or ends with punctuation, it should still follow the previous capitalization rules.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| The quick brown "Dog" jumps over the lazy dog. | dog | 2 |

_This input-output pair checks that surrounding punctuation doesn't break the first-letter capitalization checking._

---

If a word in the sentence matches the input word but has punctuation inside of it, it should not count as a match.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| The quick brown fox's jump went over the lazy dog. | foxs | 0 |

_This input-output pair checks that internal punctuation counts towards the word._

---

If a word in the sentence matches has punctuation inside of it and the input word matches part of the word, it doesn't count as a match.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| The quick brown fox's jump went over the lazy dog. | fox | 0 |

_This input-output pair checks that internal punctuation is not counted like a word boundary._

---

If a word in the sentence matches has punctuation inside of it and the input word matches the word including punctuation, it should count as a match.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| The quick brown fox's jump went over the lazy dog. | fox's | 1 |

_This input-output pair checks that internal punctuation counts towards the word._

---

If the input word has starting or ending punctuation, it should not match words in the sentence without that punctuation.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| The quick brown fox jumps over the lazy dog. | -fox- | 0 |

_This input-output pair checks that surrounding punctuation counts towards the definition of the input word._

---

If the input word has starting or ending punctuation, it should match words in the sentence with that punctuation.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| The quick brown -fox- jumps over the lazy dog. | -fox- | 1 |

_This input-output pair checks that surrounding punctuation counts towards the definition of the input word._

---

If the input word has starting or ending punctuation but the punctuation is different, it should not count a match.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| The quick brown ~fox~ jumps over the lazy dog. | -fox- | 1 |

_This input-output pair checks that different punctuation are treated differently._

---

If the input word has starting or ending punctuation, it should still follow the previous capitalization rules.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| The quick brown -fox- jumps over the lazy dog. | -Fox- | 1 |

_This input-output pair checks that surrounding punctuation doesn't break the capitalization checking._

---

If the input word is only punctuation, it should treat it like a "word" and find exact matches.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| The quick brown ---- jumps over the lazy dog. | ---- | 1 |

_This input-output pair checks for an exact punctuation match._

---

If the input word is only punctuation, it should only find exact matches.

| Input Sentence | Input Word | Output |
| :--- | :--- | :--- |
| The quick brown ---- jumps over the lazy dog. | - | 0 |

_This input-output pair checks for lack of an exact punctuation match._

---
