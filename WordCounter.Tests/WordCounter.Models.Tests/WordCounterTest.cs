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
    public void CountMatches_TestIsSingleWordAndInputDoesntMatch_NoMatch()
    {
        string testSentence = "dog";
        string inputWord = "cat";
        int numExpectedMatches = 0;

        Assert.AreEqual(numExpectedMatches, WordCounter.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_TestIsSingleWordAndInputDoesMatch_NumMatches()
    {
        string testSentence = "cat";
        string inputWord = "cat";
        int numExpectedMatches = 1;

        Assert.AreEqual(numExpectedMatches, WordCounter.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputPartiallyContainedInTest_NumMatches()
    {
        string testSentence = "apple";
        string inputWord = "a";
        int numExpectedMatches = 0;

        Assert.AreEqual(numExpectedMatches, WordCounter.CountMatches(testSentence, inputWord));
    }
  }
}
