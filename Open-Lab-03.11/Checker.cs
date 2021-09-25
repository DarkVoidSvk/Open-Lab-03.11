using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        static string Reverse_String(string To_Be_Reversed)
        {
            char[] characters = To_Be_Reversed.ToCharArray();
            Array.Reverse(characters);
            return new string(characters);
        }


        public bool IsPalindrome(string str)
        {
            if (str == Reverse_String(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
    }
}
