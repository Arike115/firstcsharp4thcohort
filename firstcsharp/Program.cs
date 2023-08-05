
public class Program
{
    //conditional branching ====> if else, switchcase
    //conditional looping =====> foreach, do, for, dowhile
    static int chat;
   static decimal v = 45.7m;
    static int h = 78;


    private static void Main(string[] args)
    {
        //if else
        Branching1();
        Branching2();

        int c;
        c = 13;
        h += c;


        //int c = Convert.ToInt32(v);
        //Console.WriteLine(c);
        //switch case

    }

    public static void Branching1()
    {
        string words = "Ade";

        if (words != "lame")
        {
            Console.WriteLine("correct");
        }
        else if (words == "Ad")
        {
            Console.WriteLine("matched");
        }
        else
        {
            Console.WriteLine("not correct");
        }

    }
    public static void Branching2()
    {
        Console.WriteLine("choose any car by inputing any number from 1-5");
        chat = int.Parse(Console.ReadLine());

        switch (chat)
        {

            case 1:
                Console.WriteLine("congrat you won Toyota Camry");
                break;
            case 2:
                Console.WriteLine("congrat you won Lexus 330");
                break;
            case 3:
                Console.WriteLine("congrat you won Honda");
                break;
            case 4:
                Console.WriteLine("congrat you won Benz");
                break;
            case 5:
                Console.WriteLine("congrat you won Mercedes");
                break;
            default:
                Console.WriteLine("oops you enter the wrong value");
                break;
        }
    }






}
