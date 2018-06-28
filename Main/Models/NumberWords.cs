using System;
using System.Collections.Generic;
using NumberWordsDictionary.Models;
using System.Numerics;

namespace NumberWords.Models
{
  public class Word
  {
    //private string _word;
    private BigInteger _number;
    private bool isPositive;


    public Word()
    {
      //_word = "";
      _number = 0;
      isPositive = true;
    }

    public Word(BigInteger number)
    {
      //_word = "";
      isPositive = true;
      _number = number;
      if(_number < 0)
      {
        isPositive = false;
      }
      _number = BigInteger.Abs(_number);
    }

    public void SetNumber(string number)
    {
      _number = BigInteger.Parse(number);
      if(_number < 0)
      {
        isPositive = false;
      }
      _number = BigInteger.Abs(_number);
    }

    private string Convert(BigInteger number)
    {
      BigInteger offsetFirst, offsetThird, offsetFourth;
      string end = "";
      string space = " ";
      string returnValue = "Error: Out of Bounds";
      switch(number)
      {
        case BigInteger n when (n >=0 && n < 20):
          returnValue = NumberDictionary.GetValue(number);
        break;
        case BigInteger n when (n >=0 && n < 1000):
          offsetFirst = (BigInteger)(number/100);
          offsetThird = number%100;
          offsetFourth = 0;
          if(offsetThird > 19)
          {
            //Need more logic if number is greater than 19
            offsetFourth = offsetThird%10;
            offsetThird -= offsetFourth;
            end = NumberDictionary.GetValue(offsetThird);
            if(offsetFourth > 0)
            {
              end = end+" "+NumberDictionary.GetValue(offsetFourth);
            }
          }
          else
          {
            end = Convert(offsetThird);
            if(offsetThird == 0)
            {
              space = "";
            }
          }
          returnValue = NumberDictionary.GetValue(offsetFirst)+" Hundred"+space+end;
        break;
        case BigInteger n when (n >=0 && n < GetPow(6)):
        returnValue = Seperator(3,number,"Thousand");
        break;
        case BigInteger n when (n >=0 && n < GetPow(9)):
        returnValue = Seperator(6,number,"Million");
        break;
        case BigInteger n when (n >=0 && n < GetPow(12)):
        returnValue = Seperator(9,number,"Billion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(15)):
        returnValue = Seperator(12,number,"Trillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(18)):
        returnValue = Seperator(15,number,"Quadrillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(21)):
        returnValue = Seperator(18,number,"Quintillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(24)):
        returnValue = Seperator(21,number,"Sextillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(27)):
        returnValue = Seperator(24,number,"Septillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(30)):
        returnValue = Seperator(27,number,"Octillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(33)):
        returnValue = Seperator(30,number,"Nonillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(36)):
        returnValue = Seperator(33,number,"Decillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(39)):
        returnValue = Seperator(36,number,"Undecillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(42)):
        returnValue = Seperator(39,number,"Duodecillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(45)):
        returnValue = Seperator(42,number,"Tredecillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(48)):
        returnValue = Seperator(45,number,"Quattuordecillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(51)):
        returnValue = Seperator(48,number,"Quindecillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(54)):
        returnValue = Seperator(51,number,"Sexdecillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(57)):
        returnValue = Seperator(54,number,"Septendecillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(60)):
        returnValue = Seperator(57,number,"Octodecillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(63)):
        returnValue = Seperator(60,number,"Novemdecillion");
        break;
        case BigInteger n when (n >=0 && n < GetPow(66)):
        returnValue = Seperator(63,number,"Vigintillion");
        break;
      }
      return returnValue;
    }

    public string GetString(BigInteger number)
    {
      _number = number;
      if(_number < 0)
      {
        isPositive = false;
      }
      _number = BigInteger.Abs(_number);
      return GetString();
    }

    public string GetString()
    {
      string returnValue = Convert(_number);
      if(returnValue == "")
      {
        returnValue = "Zero";
      }
      if(!isPositive)
      {
        returnValue = "Negative "+returnValue;
      }
      return returnValue;
    }

    private string Seperator(int seperationPoint, BigInteger number, string name)
    {
      string space = " ";
      BigInteger offsetFirst = (BigInteger)(number/GetPow(seperationPoint));
      BigInteger offsetSecond = number%GetPow(seperationPoint);
      string end = Convert(offsetSecond);
      if(offsetSecond == 0)
      {
        space = "";
      }
      return Convert(offsetFirst)+" "+name+space+end;
    }

    private BigInteger GetPow(int num)
    {
      return BigInteger.Pow(10,num);
    }

    public void Clear()
    {
      //_word = "";
      _number = 0;
    }
    //Check if Unit Test setup correctly
    public bool Default()
    {
      return true;
    }
  }
}
