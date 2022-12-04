
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

namespace ListComp
{
    class Program
    {
        public static void Main(string[] args)
        {

            // elso   
            string[] stringList = { "auto", "villamos", "metro" };
            List<string> newStringList = new List<string>(stringList.Select(s => s.ToUpper() + "!"));
            Console.Out.WriteLine("Elso feladat");
            Console.Out.WriteLine(String.Join(", ", newStringList) + "\n");

            // masidok  
            string[] nevek = { "aladar", "bela", "cecil" };
            List<string> newNevek = new List<string>(nevek.Select(s => char.ToUpper(s[0]) + s.Substring(1)));
            Console.Out.WriteLine("Masodik feladat");
            Console.Out.WriteLine(String.Join(", ", newNevek) + "\n");

            // harmadik
            List<int> zeros = new List<int>(Enumerable.Range(0, 10).Select(n => n - n));
            Console.Out.WriteLine("Harmadik feladat");
            Console.Out.WriteLine(String.Join(", ", zeros) + "\n");

            //negyedik
            List<int> numList = new List<int>(Enumerable.Range(1, 10).Select(n => n * 2));
            Console.Out.WriteLine("Negyedik feladat");
            Console.Out.WriteLine(String.Join(", ", numList) + "\n");

            // otodik
            string[] numsAsString = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            List<int> numbers = new List<int>(numsAsString.Select(n => int.Parse(n)));
            Console.Out.WriteLine("Otodik feladat");
            Console.Out.WriteLine(String.Join(", ", numbers) + "\n");

            //hatodik
            string stringOfNumbers = "1234567";
            List<int> numbersAsInt = new List<int>(stringOfNumbers.ToCharArray().Select(n => int.Parse(n.ToString())));
            Console.Out.WriteLine("Hatidok feladat");
            Console.Out.WriteLine(String.Join(", ", numbersAsInt) + "\n");

            //hetedik
            string sentence = "The quick brown fox jumps over the lazy dog";
            List<int> wordsLength = new List<int>(sentence.Split(" ").Select(n => n.Length));
            Console.Out.WriteLine("Hetedik feladat");
            Console.Out.WriteLine(String.Join(", ", wordsLength) + "\n");

            //nyolcadik
            string sentence2 = "python is an awesome language";
            List<char> firstChars = new List<char>(sentence2.Split(" ").Select(n => n[0]));
            Console.Out.WriteLine("Nyolcadik feladat");
            Console.Out.WriteLine(String.Join(", ", firstChars) + "\n");

            //kilencedik
            List<Tuple<string, int>> result = new List<Tuple<string, int>>(sentence.Split(" ").Select(n => Tuple.Create(n, n.Length)));
            Console.Out.WriteLine("Kilencedik");
            Console.Out.Write(String.Join(", ", result) + "\n");

            // tizedik
            List<int> lessThanTen = new List<int>(Enumerable.Range(0, 9).Where(n => n % 2 == 0));
            Console.Out.WriteLine("Tizedik feladat");
            Console.Out.WriteLine(String.Join(", ", lessThanTen) + "\n");

            //tizenegyedik
            List<int> twenty = new List<int>(Enumerable.Range(0, 20).Select(n => n * n).Where(x => x % 2 == 0));
            Console.Out.WriteLine("Tizenegyedik feladat");
            Console.Out.WriteLine(String.Join(", ", twenty) + "\n");

            //tizenkettedik
            List<int> twenty2 = new List<int>(Enumerable.Range(0, 20).Select(n => n * n).Where(x => x % 2 == 0)
                .Where(n => n.ToString()[n.ToString().Length - 1] == '4'));
            Console.Out.WriteLine("Tizenkettedik feladat");
            Console.Out.WriteLine(String.Join(", ", twenty2) + "\n");

            //tizenharom
            string abc = String.Join("", Enumerable.Range(0, 26).Select(n => (char)(n + 65)));
            Console.Out.WriteLine("Tizenharmadik feladat");
            Console.Out.WriteLine(abc + "\n");

            //tizennegyeik
            string[] withWhiteSpace = { " apple ", " banana ", " kiwi" };
            List<string> result2 = new List<string>(withWhiteSpace.Select(n => n.Trim()));
            Console.Out.WriteLine("Tizennegyeik feladat");
            Console.Out.WriteLine(String.Join(", ", result2) + "\n");

            //tizenotodik
            int[] numbers2 = { 1, 0, 1, 1, 0, 1, 0, 0 };
            string result3 = String.Join("",numbers2);
            Console.Out.WriteLine("Tizenotodik feladat");
            Console.Out.WriteLine(result3 + "\n");
            

        }
    }
}

