namespace LessThan1000LinQ
{
    class Program
    {
        public static void Main(string[] args)
        {
            int megoldas = Enumerable.Range(0, 1000).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
            Console.Out.WriteLine(megoldas);
            
        }
        
    }
}