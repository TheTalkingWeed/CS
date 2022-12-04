namespace Texas_Ranger;

class Program
{
    public static void Main(string[] args)
    {
        Console.Out.WriteLine(String.Join(" ",PyUtils.range(0, 5)));
        Console.Out.WriteLine(String.Join(" ",PyUtils.range(3, 7)));   
        Console.Out.WriteLine(String.Join(" ",PyUtils.range(3, 4)));   
        Console.Out.WriteLine(String.Join(" ",PyUtils.range(3, 3)));
        Console.Out.WriteLine(String.Join(" ",PyUtils.range(10)));
        Console.Out.WriteLine(String.Join(" ",PyUtils.range(1)));    
        Console.Out.WriteLine(String.Join(" ",PyUtils.range(0)));    
        Console.Out.WriteLine(String.Join(" ",PyUtils.range(-4)));
        Console.Out.WriteLine(String.Join(" ",PyUtils.range(4, 20, 2)));
        Console.Out.WriteLine(String.Join(" ",PyUtils.range(4, 10, 1)));    
        Console.Out.WriteLine(String.Join(" ",PyUtils.range(10, 4, 1)));        
    }
}

