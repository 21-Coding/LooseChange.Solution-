using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CoinChecker.Models;

namespace CoinChecker.Tests
{
  [TestClass]
  public class CoinPurseTests
  {
    [TestMethod]
    public void MakeChange_MatchMoneyToNum_Int()
    {
      int input = 25;
      List<int> result = new List<int>() { 25 };
      CollectionAssert.AreEqual(result, CoinPurse.MakeChange(input));
    }

    [TestMethod]
    public void MakeChange_MatchMoneyToFive_Int()
    {
      int input = 5;
      List<int> result = new List<int>() { 5 };
      List<int> output = CoinPurse.MakeChange(input);

      CollectionAssert.AreEqual(result, output);
    }

    [TestMethod]
    public void MakeChange_MatchMoneyToNewNumber_Int()
    {
      int input = 58;
      List<int> result = new List<int>() { 25, 25, 5, 1, 1, 1 };
      List<int> output = CoinPurse.MakeChange(input);

      CollectionAssert.AreEqual(result, output);
    }
    [TestMethod]
    public void MakeChange_MatchMoneyToOneDollar_Int()
    {
      int input = 135;
      List<int> result = new List<int>() { 100, 25, 10 };
      List<int> output = CoinPurse.MakeChange(input);

      CollectionAssert.AreEqual(result, output);
    }
    [TestMethod]
    public void MakeChange_MatchMoneyToTwoFiveDollar_Int()
    {
      int input = 1027;
      List<int> result = new List<int>() { 500, 500, 25, 1, 1 };
      List<int> output = CoinPurse.MakeChange(input);

      CollectionAssert.AreEqual(result, output);
    }
  }
}