using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using NumberWords.Models;

namespace NumberWords.Tests
{
  [TestClass]
  public class NumberWords
  {
    private bool test = false;

    [TestInitialize]
    public void TestInit()
    {
      test = true;
    }
    [TestMethod]
    public void Return_True()
    {
      Word word = new Word();
      Assert.AreEqual(test,word.Default());
    }
    [TestMethod]
    public void Return_Convert_True()
    {
      Word word = new Word();
      Assert.AreEqual("One",word.Convert(1));
    }
    [TestMethod]
    public void Return_Convert_19_True()
    {
      Word word = new Word();
      Assert.AreEqual("Nineteen",word.Convert(19));
    }
    [TestMethod]
    public void Return_Convert_neg_1_True()
    {
      Word word = new Word();
      Assert.AreEqual("Existence is Futile",word.Convert(-1));
    }
    [TestMethod]
    public void Return_Convert_101_True()
    {
      Word word = new Word();
      Assert.AreEqual("One Hundred-One",word.Convert(101));
    }
    [TestMethod]
    public void Return_Convert_919_True()
    {
      Word word = new Word();
      Assert.AreEqual("Nine Hundred-Nineteen",word.Convert(919));
    }
  }
}
