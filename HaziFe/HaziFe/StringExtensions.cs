using System;

namespace HaziFe
{
    public static class StringExtensions
    {
        public static int ToInt(this string str)
        {
            return int.Parse(str);
        }
        
        public static string Reverse(this string s )
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse( charArray );
            return new string( charArray );
        }
    }
}