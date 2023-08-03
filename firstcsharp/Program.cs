public class Program
{
    //Array it allows storing of multiple values in a variable

    int v = 56; //single value
    static int[] y = { 675, 6754, 90, 869, 674, 74, 867, 8, 1, 32, 4, 4, 5 }; //Array

    static string[] words = { "chalk", "biro", "house", "bin", "pencil", "board" };

    
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Welcome to c# class");

        foreach( int i in y)
        {
            Console.WriteLine(i);
        }

        foreach(string data in words)
        {
            Console.WriteLine(data);
        }

    }



}
