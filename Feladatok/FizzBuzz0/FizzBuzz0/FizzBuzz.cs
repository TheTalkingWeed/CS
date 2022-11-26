namespace FizzBuzz0;

public class FizzBuzz
{

    private int range;

    public FizzBuzz(int n)
    {
        range = n;
    }

    public void Start()
    {
        string output;
        for (int i = 1; i <= this.range; i++)
        {
            output = i % 3 == 0 && i % 5 == 0
                ? "fizz buzz" : i % 3 == 0
                ? "fizz" : i % 5 == 0
                ? "buzz" : i.ToString();
            
            Console.Out.WriteLine(output);
                
        }
    }
}