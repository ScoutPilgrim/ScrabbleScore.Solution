using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
using System;
using System.Collections.Generic;

namespace ScrabbleScore.TestTools
{
  [TestClass]
  public class CheckScoreTest
  {
    [TestMethod]
    public void Constructor_Test()
    {
      string testString = "test";
      CheckScore testCheckScore = new CheckScore(testString);
      Assert.AreEqual(testString, testCheckScore.GetUserInput());
    }
    [TestMethod]
    public void CalculateScore_TestLow()
    {
      string testString = "test";
      CheckScore testCheckScore = new CheckScore(testString);
      testCheckScore.CalculateScore();
      Assert.AreEqual(4, testCheckScore.GetUserScore());
    }
    [TestMethod]
    public void CalculateScore_TestMid()
    {
      string testString = "quartz";
      CheckScore testCheckScore = new CheckScore(testString);
      testCheckScore.CalculateScore();
      Assert.AreEqual(24, testCheckScore.GetUserScore());
    }
    [TestMethod]
    public void CalculateScore_TestHigh()
    {
      string testString = "supercalifragilisticexpialidocious";
      CheckScore testCheckScore = new CheckScore(testString);
      testCheckScore.CalculateScore();
      Assert.AreEqual(56, testCheckScore.GetUserScore());
    }
    [TestMethod]
    public void CalculateScore_TestSpecialChar()
    {
      string testString = "!test!";
      CheckScore testCheckScore = new CheckScore(testString);
      testCheckScore.CalculateScore();
      Assert.AreEqual(4, testCheckScore.GetUserScore());
    }
  }
}
