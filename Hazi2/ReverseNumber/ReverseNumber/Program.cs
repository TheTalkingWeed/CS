using System.Runtime.InteropServices;

namespace ReverseNumber
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Out.Write(IntRev(123));
        }
        
        public static int IntRev(int input)
        {
            int output=0;
            while (input>0) 
            {
                output = output*10 + input%10;
                input /= 10;
            }
            return output;
        }
        
    }
}

