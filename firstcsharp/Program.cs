
public class Program
{

    //operators

    //arithmetic operators +,-,*,/,%
    //logical operators &&,||,!,&,|
    //assignment operators =,+=,-=,*=,/=, <<
    //relations operators > greater than,< lessser than,==,!=,>=,<=


    // arithmetic operator

    static decimal v = 90; //field
    static decimal x = 90;
    static decimal r = x += v;
    static decimal n = x -= v;
    static decimal o = x /= v;
    static decimal a = x *= v;

    int two = 10;
    int one = 16;
   
   

    static string words = "Bookshop";
    static string values = "calculator";
    static string result = "Bookshop";

   

 

    private static void Main(string[] args)
    {
        Console.WriteLine(r);
        Console.WriteLine(n);
        Console.WriteLine(o);
        Console.WriteLine(a);
        Console.WriteLine("******************");

        if(v >= x )
        {
            Console.WriteLine(" yes they match");
        }
        else
        {
            Console.WriteLine("they dont match");
        }
        if(v <= x)
        {
            Console.WriteLine("they are correct");
        }
        else
        {
            Console.WriteLine("they are not correct");
        }


    }



}
