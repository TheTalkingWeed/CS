using static System.Console;

namespace LessThan100
{
    class Program
    {
        public static void Main(string[] args)
        {
            Out.WriteLine(CiklusosMegoldas(1000));
            Out.WriteLine(LinQMegoldas(1000));
            
        }

        public static int CiklusosMegoldas(int n)
        {
            int res = 0;
            for (int i = 0; i < 1000; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    res += i;

            return res;
        }

        public static int LinQMegoldas(int n)
        {
            return Enumerable.Range(0,n).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
        }
    }
}