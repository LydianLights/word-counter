using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public static class WordCounter
  {
      public static int CountMatches(string testSentence, string word)
      {
          int count = 0;
          if (testSentence == word)
          {
              count = 1;
          }
          return count;
      }
  }
}
