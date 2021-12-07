using System;
using System.Collections.Generic;

namespace HaziFe
{
    public class PhyUtils
    {
        public static List<int> Ranger(int also, int felso, int lepeskoz)
        {
            List<int> output = new List<int>();

            for (int i = also; i < felso; i+=lepeskoz)
            {
                output.Add(i);
            }
            
            
            return output;
        }

       public static List<int> Ranger(int also,int felso)
        {
            return Ranger(also, felso, 1);
        }

        public static List<int> Ranger(int felso)
        {
            return Ranger(0, felso, 1);
        }

        public static int ReverseInt(int a)
        {
            return a.ToString().Reverse().ToInt();
        }
    }
}