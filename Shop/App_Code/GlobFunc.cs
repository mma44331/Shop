using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop
{
    public class GlobFunc
    {
        public static string GetRandStr(int length)
        {
            string str = " abcdefghijklmnopqrstuvwxyz0123456789";
            string RetStr = "";
            int index;
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
              index=rnd.Next(str.Length);
                RetStr += str[index];
            }
            return RetStr;

        }
    }
}