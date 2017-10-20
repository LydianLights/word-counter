using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
  public static class WordCounter
  {
      public static int CountMatches(string testSentence, string inputWord)
      {
          string[] testWords = testSentence.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
          int count = 0;
          foreach (string word in testWords)
          {
              if (WordsAreSame(word, inputWord))
              {
                  count++;
              }
          }
          return count;
      }

      private static bool WordsAreSame(string word1, string word2)
      {
          char[] word1Arr = word1.ToCharArray();
          word1Arr[0] = char.ToLower(word1Arr[0]);
          char[] word2Arr = word2.ToCharArray();
          word2Arr[0] = char.ToLower(word2Arr[0]);

          return word1Arr.SequenceEqual(word2Arr);
      }
  }
}
