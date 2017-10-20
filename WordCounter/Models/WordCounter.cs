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
              string wordToTest = RemovePunctuation(word);
              if (WordsAreSame(wordToTest, inputWord))
              {
                  count++;
              }
          }
          return count;
      }

      private static bool WordsAreSame(string word1, string word2)
      {
          char[] word1Letters = word1.ToCharArray();
          word1Letters[0] = char.ToLower(word1Letters[0]);
          char[] word2Letters = word2.ToCharArray();
          word2Letters[0] = char.ToLower(word2Letters[0]);

          bool equalButCapitalized = word1Letters.SequenceEqual(word2Letters);
          bool equalButAllCaps = (word1.ToUpper() == word2 || word2.ToUpper() == word1);

          return equalButCapitalized || equalButAllCaps;
      }

      private static string RemovePunctuation(string word)
      {
          char[] characters = word.ToCharArray();
          string output = "";
          foreach (char c in characters)
          {
              if (char.IsLetterOrDigit(c))
              {
                  output += c;
              }
          }
          return output;
      }
  }
}
