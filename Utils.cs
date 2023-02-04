using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1___ArrayList
{
  public static class Utils
  {
    public static bool Any(this ArrayList arrayList, string text)
    {
      foreach (var item in arrayList)
        if (string.Equals(item,text))
          return true;

      return false;
    }

    public static int FindIndex(this ArrayList arrayList, string text)
    {
      int index = 0;
      foreach (var item in arrayList)
      {
        if (string.Equals(item, text))
          return index;

        index++;
      }

      return -1;
    }
  }
}
