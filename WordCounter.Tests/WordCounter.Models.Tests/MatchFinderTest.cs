using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Models.Tests
{
  [TestClass]
  public class MatchFinderTest
  {
    [TestMethod]
    public void CountMatches_TestIsSingleWordAndInputDoesntMatch_NoMatches()
    {
        string testSentence = "dog";
        string inputWord = "cat";
        int numExpectedMatches = 0;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_TestIsSingleWordAndInputDoesMatch_NumMatches()
    {
        string testSentence = "cat";
        string inputWord = "cat";
        int numExpectedMatches = 1;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputPartiallyContainedInTest_NumMatches()
    {
        string testSentence = "apple";
        string inputWord = "a";
        int numExpectedMatches = 0;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_TestIsEmpty_NoMatches()
    {
        string testSentence = "";
        string inputWord = "cat";
        int numExpectedMatches = 0;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputIsEmpty_NoMatches()
    {
        string testSentence = "cat";
        string inputWord = "";
        int numExpectedMatches = 0;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_TestIsEmptyAndInputIsEmpty_NoMatches()
    {
        string testSentence = "";
        string inputWord = "";
        int numExpectedMatches = 0;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputIsNotInTest_NoMatches()
    {
        string testSentence = "the quick brown fox jumps over the lazy dog";
        string inputWord = "cat";
        int numExpectedMatches = 0;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputIsInTest_NumMatches()
    {
        string testSentence = "buffalo buffalo buffalo buffalo buffalo buffalo buffalo bison";
        string inputWord = "buffalo";
        int numExpectedMatches = 7;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputIsInTestButTestIsCapitalized_NumMatches()
    {
        string testSentence = "The quick brown fox jumps over the lazy dog.";
        string inputWord = "the";
        int numExpectedMatches = 2;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputIsInTestButTestIsALLCAPS_NumMatches()
    {
        string testSentence = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.";
        string inputWord = "fox";
        int numExpectedMatches = 1;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputIsInTestButTestIsDifferentCasing_NoMatches()
    {
        string testSentence = "The quick BrOwN fox jumps over the lazy dog.";
        string inputWord = "brown";
        int numExpectedMatches = 0;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputIsInTestButInputIsCapitalized_NumMatches()
    {
        string testSentence = "The quick brown fox jumps over the lazy dog.";
        string inputWord = "The";
        int numExpectedMatches = 2;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputIsInTestButInputIsALLCAPS_NumMatches()
    {
        string testSentence = "The quick brown fox jumps over the lazy dog.";
        string inputWord = "FOX";
        int numExpectedMatches = 1;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputIsInTestButInputIsDifferentCasing_NoMatches()
    {
        string testSentence = "The quick brown fox jumps over the lazy dog.";
        string inputWord = "bRoWn";
        int numExpectedMatches = 0;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_TestHasMatchWithLeadingOrTrailingPunctuation_NumMatches()
    {
        string testSentence = "The quick brown \"dog\" jumps over the lazy dog.";
        string inputWord = "dog";
        int numExpectedMatches = 2;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_TestHasMatchWithCapitalizationAndLeadingOrTrailingPunctuation_NumMatches()
    {
        string testSentence = "The quick brown \"Dog\" jumps over the lazy dog.";
        string inputWord = "dog";
        int numExpectedMatches = 2;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_TestHasInternalPunctuationAndInputDoesnt_NumMatches()
    {
        string testSentence = "The quick brown fox's jump went over the lazy dog.";
        string inputWord = "foxs";
        int numExpectedMatches = 0;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_TestHasInternalPunctuationAndInputPartiallyMatches_NumMatches()
    {
        string testSentence = "The quick brown fox's jump went over the lazy dog.";
        string inputWord = "fox";
        int numExpectedMatches = 0;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_TestHasInternalPunctuationAndInputMatches_NumMatches()
    {
        string testSentence = "The quick brown fox's jump went over the lazy dog.";
        string inputWord = "fox's";
        int numExpectedMatches = 1;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputHasSurroundingPunctuationButTestDoesnt_NoMatches()
    {
        string testSentence = "The quick brown fox jumps over the lazy dog.";
        string inputWord = "-fox-";
        int numExpectedMatches = 0;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputAndTestHaveSurroundingPunctuation_NumMatches()
    {
        string testSentence = "The quick brown -fox- jumps over the lazy dog.";
        string inputWord = "-fox-";
        int numExpectedMatches = 1;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputAndTestHaveDifferentSurroundingPunctuation_NoMatches()
    {
        string testSentence = "The quick brown ~fox~ jumps over the lazy dog.";
        string inputWord = "-fox-";
        int numExpectedMatches = 0;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputAndTestHaveSurroundingPunctuationAndInputHasCapitalization_NumMatches()
    {
        string testSentence = "The quick brown -fox- jumps over the lazy dog.";
        string inputWord = "-Fox-";
        int numExpectedMatches = 1;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputIsOnlyPunctuationAndTestHasExactMatch_NumMatches()
    {
        string testSentence = "The quick brown ---- jumps over the lazy dog.";
        string inputWord = "----";
        int numExpectedMatches = 1;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
    [TestMethod]
    public void CountMatches_InputIsOnlyPunctuationAndTestHasNoExactMatch_NumMatches()
    {
        string testSentence = "The quick brown ---- jumps over the lazy dog.";
        string inputWord = "-";
        int numExpectedMatches = 0;

        Assert.AreEqual(numExpectedMatches, MatchFinder.CountMatches(testSentence, inputWord));
    }
  }
}
