using System;
using System.Collections.Generic;

namespace NumberWordsDictionary.Models
{
  public class NumberDictionary
  {
    private static IDictionary<int,string> dict = new Dictionary<int, string>()
    {
      {0,""},{1,"One"},{2,"Two"},{3,"Three"},{4,"Four"},{5,"Five"},{6,"Six"},{7,"Seven"},
      {8,"Eight"},{9,"Nine"},{10,"Ten"},{11,"Eleven"},{12,"Twelve"},{13,"Thirteen"},{14,"Fourteen"},
      {15,"Fifteen"},{16,"Sixteen"},{17,"Seventeen"},{18,"Eighteen"},{19,"Nineteen"},{20,"Twenty"},
      {30,"Thirty"},{40,"Fourty"},{50,"Fifty"},{60,"Sixty"},{70,"Seventy"},{80,"Eighty"},{90,"Ninety"},{100,"Hundred"}
    };

    public static string GetValue(int i)
    {
      if(dict.ContainsKey(i))
      {
        return dict[i];
      }
      else
      {
        return "No Value Found";
      }
    }
  }

}
