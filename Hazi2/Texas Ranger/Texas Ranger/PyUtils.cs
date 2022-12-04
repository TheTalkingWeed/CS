namespace Texas_Ranger;

public class PyUtils
{
    public static List<int> range(int start,int end,int step)
    {
        List<int> res = new List<int>();
        
        for(int i = start; i < end;i += step) res.Add(i);
        return res;
    }
    public static List<int> range(int start, int end)
    {
        
        return range(start,end,1);
    }
    
    public static List<int> range(int end)
    {
        return range(0, end);
    }
    
   
    
    
}