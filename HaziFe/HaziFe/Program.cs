using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace HaziFe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>(PhyUtils.Ranger(1000));
            int sum = 0;
            var numbers = lista.Where(x => x % 3 == 0 || x % 5 == 0);
            foreach (int i in numbers)
            {
                sum += i;
            }

            Console.Out.WriteLine(sum);
            Console.Out.WriteLine(PhyUtils.ReverseInt(321));
        }
    }
    
}