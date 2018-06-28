using System;
using System.Collections.Generic;
using NumberWordsDictionary.Models;

namespace NumberWords.Models
{
  public class Word
  {
    private string _word;
    private int _number;


    public Word()
    {
      _word = "";
      _number = 0;
    }

    public Word(int number)
    {
      _word = "";
      _number = number;
    }

    public void SetWord(string word)
    {
      _word = word;
    }

    public void SetNumber(int number)
    {
      _number = number;
    }

    public string Convert(int number)
    {
      string returnValue = "Existence is Futile";
      switch(number)
      {
        case int n when (n < 20 && n >=0):
          returnValue = NumberDictionary.GetValue(number);
        break;
        case int n when (n < 1000 && n >=0):
          int offsetFirst = (int)(number/100);
          int offsetThird = number - (offsetFirst*100);
          returnValue = NumberDictionary.GetValue(offsetFirst)+" "+ NumberDictionary.GetValue(100)+"-"+NumberDictionary.GetValue(offsetThird);
        break;
      }
      return returnValue;
    }

    public void Clear()
    {
      _word = "";
      _number = 0;
    }
    //Check if Unit Test setup correctly
    public bool Default()
    {
      return true;
    }
  }
}
