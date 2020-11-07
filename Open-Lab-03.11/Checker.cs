using System;
using System.Linq;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            return str == new string(str.Reverse().ToArray());
        } 
    }
}
