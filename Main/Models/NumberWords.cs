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
      int offsetFirst, offsetSecond, offsetThird, offsetFourth;
      string end = "";
      string returnValue = "Existence is Futile";
      switch(number)
      {
        case int n when (n >=0 && n < 20):
          returnValue = NumberDictionary.GetValue(number);
        break;
        case int n when (n >=0 && n < 1000):
          offsetFirst = (int)(number/100);
          offsetThird = number%100;
          offsetFourth = 0;
          if(offsetThird > 19)
          {
            //Need more logic if number is greater than 19
            offsetFourth = offsetThird%10;
            offsetThird -= offsetFourth;
            end = " "+NumberDictionary.GetValue(offsetThird);
            if(offsetFourth > 0)
            {
              end = end+" "+NumberDictionary.GetValue(offsetFourth);
            }
          }
          else
          {
            end = " "+NumberDictionary.GetValue(offsetThird);
          }
          Console.WriteLine("Offset 3: "+offsetThird);
          Console.WriteLine("Offset 4: "+offsetFourth);
          returnValue = NumberDictionary.GetValue(offsetFirst)+" Hundred"+end;
        break;
        case int n when (n >=0 && n < 10000):
          offsetFirst = (int)(number/1000);
          offsetSecond = number%1000;
          end = Convert(offsetSecond);
          returnValue = end;
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
