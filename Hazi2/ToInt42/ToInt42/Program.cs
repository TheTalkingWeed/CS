namespace ToInt42
{
    static class Program
    {
        public static void Main(string[] args)
        {
            string s = "42";
            int i = s.ToInt();
            Console.Out.WriteLine(i);
        }
        public static int ToInt(this string str)
        {
            return int.Parse(str);
        }
    }
}


