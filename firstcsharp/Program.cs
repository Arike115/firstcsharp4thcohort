
public class Program
{
   static  int v = 90;
    static int i = 1;

    private static void Main(string[] args)
    {
        Add();
        Subtract(90, 5);
    }

    public static void Add ()
    {
        int x = v + i;
        
        Console.WriteLine(x);
    }

    public static int Subtract(int value1, int value2)
    {
       int result = value1 - value2;
        Console.WriteLine( result);
        return result;
    }



}
