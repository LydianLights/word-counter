using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
  public static class MatchFinder
  {
      public static int CountMatches(string testSentence, string inputWord)
      {
          if (inputWord.Contains(" "))
          {
              throw new ArgumentException("Only single-word searches are allowed.");
          }
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
          bool equalButCapitalized = (CapitalizeFirstNonPunctuationCharacter(word1) == CapitalizeFirstNonPunctuationCharacter(word2));
          bool equalButAllCaps = (word1.ToUpper() == word2 || word2.ToUpper() == word1);

          return equalButCapitalized || equalButAllCaps;
      }

      private static string CapitalizeFirstNonPunctuationCharacter(string word)
      {
          int indexToCapitalize = 0;
          while (indexToCapitalize < word.Length - 1 && !char.IsLetterOrDigit(word[indexToCapitalize]))
          {
              indexToCapitalize++;
          }
          if (indexToCapitalize >= word.Length)
          {
              return word;
          }
          char[] characters = word.ToCharArray();
          characters[indexToCapitalize] = char.ToLower(characters[indexToCapitalize]);
          return new String(characters);
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
