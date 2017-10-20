using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
  public static class WordCounter
  {
      public static int CountMatches(string testSentence, string inputWord)
      {
          if (inputWord == "")
          {
              return 0;
          }
          string[] testWords = testSentence.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
          int count = 0;
          foreach (string word in testWords)
          {
              if (WordsAreSame(word, inputWord))
              {
                  count++;
              }
              else
              {
                  string parsedWord = RemoveSurroundingPunctuation(word);
                  if (WordsAreSame(parsedWord, inputWord))
                  {
                      count++;
                  }
              }
          }
          return count;
      }

      private static bool WordsAreSame(string word1, string word2)
      {
          // Check capitalization of first non-punctuation character of each word
          // Word 1
          int word1FirstNonPunctuationIndex = 0;
          while (!char.IsLetterOrDigit(word1[word1FirstNonPunctuationIndex]))
          {
              word1FirstNonPunctuationIndex++;
          }
          char[] word1Letters = word1.ToCharArray();
          word1Letters[word1FirstNonPunctuationIndex] = char.ToLower(word1Letters[word1FirstNonPunctuationIndex]);

          // Word 2
          int word2FirstNonPunctuationIndex = 0;
          while (!char.IsLetterOrDigit(word2[word2FirstNonPunctuationIndex]))
          {
              word2FirstNonPunctuationIndex++;
          }
          char[] word2Letters = word2.ToCharArray();
          word2Letters[word2FirstNonPunctuationIndex] = char.ToLower(word2Letters[word2FirstNonPunctuationIndex]);


          bool equalButCapitalized = word1Letters.SequenceEqual(word2Letters);

          // Check if either word is all-caps variation of the other
          bool equalButAllCaps = (word1.ToUpper() == word2 || word2.ToUpper() == word1);

          return equalButCapitalized || equalButAllCaps;
      }

      private static string RemoveSurroundingPunctuation(string word)
      {
          List<char> characters = word.ToList();
          while (characters.Count > 0 && !char.IsLetterOrDigit(characters[0]))
          {
              characters.RemoveAt(0);
          }
          while (characters.Count > 0 && !char.IsLetterOrDigit(characters[characters.Count - 1]))
          {
              characters.RemoveAt(characters.Count - 1);
          }
          return new String(characters.ToArray());
      }
  }
}
