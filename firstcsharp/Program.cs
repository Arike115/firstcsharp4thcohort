public class Program
{
    //Datatypes
    //Integer,  int
    //string
    //Boolean, bool
    //float
    //double
    //char
    //decimal


    //interger int
    //int y; // declaration 
    //y = 345; // initialize

    static int numbers = 5756;
    static int x = 56;//declaration + initialization
    static int y = numbers + x;

    //string
    string word = "Shelf";
   static string value = "Joe";
   static bool IsActive = true;

    //floats
    float value2 = 24.35f;
    //double
    double value3 = 67946000473;
    //decimal
    decimal value4 = 363256.52m;



    
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Welcome to c# class");
        Console.WriteLine("your height is" + y + "cm");
        Console.WriteLine("your Name is " + value);
        Console.WriteLine("Are you active for your coding" + IsActive);

    }



}
