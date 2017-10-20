using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Models.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void CountMatches_WordDoesntMatch_NoMatch()
    {
        string testSentence = "dog";
        string testWord = "cat";
        int numExpectedMatches = 0;

        Assert.AreEqual(numExpectedMatches, WordCounter.CountMatches(testSentence, testWord));
    }
  }
}
