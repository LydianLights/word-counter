using System;
using System.Collections.Generic;

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

      private static bool WordsAreSame(string testWord, string inputWord)
      {
          return testWord == inputWord;
      }
  }
}
