using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstcsharp.Topics
{
    public class Car 
    {
        public static string[] words = {"Benz","Camry","Ford","Bugatti"};
        public string word;
        public int Numbers;

        public Car( string word, int numbers) //Constructor
        { 
            this.word = word;
            this.Numbers = numbers;
        }

            

        public static void CarName()
        {
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }

        public void Recharge() //non-static method or instance method 
        {
            Console.WriteLine("my name is {0}, i am {1} years old", word, Numbers);
        }
    }

   

}
