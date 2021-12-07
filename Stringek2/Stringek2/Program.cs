using System;
using static System.Console;

namespace Stringek2
{
    class Sztringek2
    {
        
        private static string Verbing(string s)
        {
            if (s.Length >= 3)
            {
                if (s.Substring(s.Length-3)=="ing")
                {
                  return  s=s+"ly";
                }
                s = s + "ing";
                return s;
            }
            
        

            return s;
        }

        private static string NotBad(string s)
        {
            int x = s.IndexOf("not", StringComparison.Ordinal);
            int y = s.IndexOf("bad", StringComparison.Ordinal);

            if (x<y)
            {
                y += 3;
                return s.Replace(s[x..y],"good");
            }

            return s;

        }

        // G. front_back
        // Egy sztringet osszunk két részre, s a két részt nevezzük
        // a sztring elejének és végének. Ha a sztring hossza páros, akkor
        // a két rész hossza azonos. Ha a hossz páratlan, akkor az eleje
        // legyen egy karakterrel hosszabb mint a vége.
        // Például 'abcde' esetén a két rész: 'abc' és 'de'.
        // Két adott sztring (a és b) esetén adjunk vissza egy sztringet, mely
        // a következőképpen épül fel:
        // a-eleje + b-eleje + a-vége + b-vége
        // Például ha a = 'abcd' és b = 'xy', akkor az eredmény 'abxcdy' legyen.
        private static string FrontBack(string a, string b)
        {
            if (a.Length % 2 ==0 && b.Length % 2 == 0)
            {
                return a.Substring(0,a.Length / 2) + b.Substring(0,b.Length / 2)+a.Substring(a.Length/2)+b.Substring(b.Length/2);
            }

            if (a.Length % 2 == 1 && b.Length % 2 == 0)
            {
                return a.Substring(0,a.Length / 2+1) + b.Substring(0,b.Length / 2)+a.Substring(a.Length/2+1)+b.Substring(b.Length/2);    
            }

            if (a.Length % 2 == 0 && b.Length % 2 == 1)
            {
                return a.Substring(0,a.Length / 2) + b.Substring(0,b.Length / 2+1)+a.Substring(a.Length/2)+b.Substring(b.Length/2+1);
            }

            if (a.Length % 2 == 1 && b.Length % 2 == 1)
            {return a.Substring(0,a.Length / 2+1) + b.Substring(0,b.Length / 2+1)+a.Substring(a.Length/2+1)+b.Substring(b.Length/2+1);
            }

            return "";
        }

        private static void Test(string got, string expected)
        {
            var prefix = (got == expected ? " OK " : "  X ");
            WriteLine($"{prefix} got: {got}; expected: {expected}");
        }

        public static void Main(string[] args)
        {
            WriteLine("verbing");
            Test(Verbing("hail"), "hailing");
            Test(Verbing("swiming"), "swimingly");
            Test(Verbing("do"), "do");

            WriteLine();
            WriteLine("not_bad");
            Test(NotBad("This movie is not so bad"), "This movie is good");
            Test(NotBad("This dinner is not that bad!"), "This dinner is good!");
            Test(NotBad("This tea is not hot"), "This tea is not hot");
            Test(NotBad("It's bad yet not"), "It's bad yet not");

            WriteLine();
            WriteLine("front_back");
            Test(FrontBack("abcd", "xy"), "abxcdy");
            Test(FrontBack("abcde", "xyz"), "abcxydez");
            Test(FrontBack("Kitten", "Donut"), "KitDontenut");
        }
    }
}
