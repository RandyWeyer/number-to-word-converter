using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using NumberWords.Models;
using System.Numerics;

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
    public void Return_GetString_True()
    {
      Word word = new Word();
      Assert.AreEqual("One",word.GetString(1));
    }
    [TestMethod]
    public void Return_GetString_19_True()
    {
      Word word = new Word();
      Assert.AreEqual("Nineteen",word.GetString(19));
    }
    [TestMethod]
    public void Return_GetString_neg_1_True()
    {
      Word word = new Word();
      Assert.AreEqual("One Quadrillion",word.GetString(1000000000000000));
    }
    [TestMethod]
    public void Return_GetString_101_True()
    {
      Word word = new Word();
      Assert.AreEqual("One Hundred One",word.GetString(101));
    }
    [TestMethod]
    public void Return_GetString_919_True()
    {
      Word word = new Word();
      Assert.AreEqual("Nine Hundred Nineteen",word.GetString(919));
    }
    [TestMethod]
    public void Return_GetString_920_True()
    {
      Word word = new Word();
      Assert.AreEqual("Nine Hundred Twenty",word.GetString(920));
    }
    [TestMethod]
    public void Return_GetString_921_True()
    {
      Word word = new Word();
      Assert.AreEqual("Nine Hundred Twenty One",word.GetString(921));
    }
    [TestMethod]
    public void Return_GetString_2921_True()
    {
      Word word = new Word();
      Assert.AreEqual("Two Thousand Nine Hundred Twenty One",word.GetString(2921));
    }
    [TestMethod]
    public void Return_GetString_8453_True()
    {
      Word word = new Word();
      Assert.AreEqual("Eight Thousand Four Hundred Fifty Three", word.GetString(8453));

    }
    [TestMethod]
    public void Return_GetString_315986_True()
    {
      Word word = new Word();
      Assert.AreEqual("Three Hundred Fifteen Thousand Nine Hundred Eighty Six", word.GetString(315986));
    }
    [TestMethod]
    public void Return_GetString_1315986_True()
    {
      Word word = new Word();
      Assert.AreEqual("One Million Three Hundred Fifteen Thousand Nine Hundred Eighty Six", word.GetString(1315986));
    }
    [TestMethod]
    public void Return_GetString_1000000_True()
    {
      Word word = new Word();
      Assert.AreEqual("One Million", word.GetString(1000000));
    }
    [TestMethod]
    public void Return_GetString_1001000_True()
    {
      Word word = new Word();
      Assert.AreEqual("One Million One Thousand", word.GetString(1001000));
    }
    [TestMethod]
    public void Return_GetString_10001001000_True()
    {
      Word word = new Word();
      Assert.AreEqual("Ten Billion One Million One Thousand", word.GetString(10001001000));
    }
    [TestMethod]
    public void Return_GetString_7897878979_True()
    {
      Word word = new Word();
      Assert.AreEqual("Seven Billion Eight Hundred Ninety Seven Million Eight Hundred Seventy Eight Thousand Nine Hundred Seventy Nine", word.GetString(7897878979));
    }
    [TestMethod]
    public void Return_GetString_1000000000000_True()
    {
      Word word = new Word();
      Assert.AreEqual("One Hundred Trillion One", word.GetString(100000000000001));
    }
    [TestMethod]
    public void Return_GetString_999999999999999_True()
    {
      Word word = new Word();
      Assert.AreEqual("Nine Hundred Ninety Nine Trillion Nine Hundred Ninety Nine Billion Nine Hundred Ninety Nine Million Nine Hundred Ninety Nine Thousand Nine Hundred Ninety Nine", word.GetString(999999999999999));
    }
    [TestMethod]
    public void Return_GetString_0_True()
    {
      Word word = new Word();
      Assert.AreEqual("Zero", word.GetString(0));
    }
    // [TestMethod]
    // public void Return_GetString_Yeah_True()
    // {
    //   Word word = new Word();
    //   word.SetNumber("1999999999999999999999999999");
    //   Assert.AreEqual("", word.GetString());
    // }
    // [TestMethod]
    // public void Return_GetString_Neg_1_True()
    // {
    //   Word word = new Word();
    //   word.SetNumber("-999999999999999999999999999");
    //   Assert.AreEqual("", word.GetString());
    // }
    [TestMethod]
    public void Return_GetString_Very_High_True()
    {
      Word word = new Word();
      BigInteger num = (BigInteger.Pow(10,65)*9);

      Assert.AreEqual("Nine Hundred Vigintillion", word.GetString(num));
    }
  }
}
