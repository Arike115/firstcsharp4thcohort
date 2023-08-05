
public class Program
{
    //conditional branching ====> if else, switchcase
    //conditional looping =====> foreach, while, for, dowhile
   

    private static void Main(string[] args)
    {
        //Foreach
        int[] numbers = { 67, 78, 80, 0, 83, 86, 1, 2, 3, 4, 5, 6, 7, 8, 9,10 };
        string words = "Photosynthesis";
        foreach(int i in numbers)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("*********************");
        //for

        for (int j= 0; j <= numbers.Length; j++)
        {
            Console.WriteLine(j);
        }
        Console.WriteLine("************");
        //while
        int x = 0;
        while(x <= words.Length)
        {
            Console.WriteLine(x);
            x++;
        }

        Console.WriteLine("**************");
        int v = 0;
        do
        {
            Console.WriteLine(x);
            x++;
        }
        while(x <= words.Length);
        
    }

   






}
