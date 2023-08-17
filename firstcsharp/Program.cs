using firstcsharp.Topics;
using static System.Runtime.InteropServices.JavaScript.JSType;

public delegate void Print(int value);
public class Program
{
    //Icollection,Ilist
    //dictionary
    //list,stack,qeue and set

    private static void Main(string[] args) //method or behaviour or logic or function
    {
        Car car1 = new Car()
        {
            Id = 101,
            Name = "Honda",
            Price = 5000000,
            Model = 2015,
        };

        Car car2 = new Car()
        {
            Id = 102,
            Name = "Benz",
            Price = 6000000,
            Model = 2018,
        };

        Car car3 = new Car()
        {
            Id = 103,
            Name = "Toyota",
            Price = 2000000,
            Model = 2001,
        };

        Car car4 = new Car()
        {
            Id = 104,
            Name = "Camry",
            Price = 1500000,
            Model = 2011,
        };

        Car car5 = new Car()
        {
            Id = 105,
            Name = "Bugatti",
            Price = 2500000,
            Model = 2015,
        };

        List<Car> cars = new List<Car>(3);
        cars.Add(car1);
        cars.Add(car2);
        cars.Add(car3);
        cars.Add(car4);

        //Car liscar = cars[3];
        foreach(var liscar in cars)
        {
            Console.WriteLine("Id = {0},Name={1},Price ={2},Model={3}", liscar.Id, liscar.Name, liscar.Price, liscar.Model);
        }
        Console.WriteLine("************");
        Car c = cars.Find(x => x.Price <3000000);
        Console.WriteLine("Id = {0},Name={1},Price ={2},Model={3}", c.Id, c.Name, c.Price, c.Model);





        //List<string> list = new List<string>();
        //list.Add("Chalk");
        //list.Add("Tyron");
        //list.Add("Clone");
        //list.Add("Reserve");
        //list.Add("Allign");
        //list.Add("Disregard");

        //collectiondisplay(list);
        //ilistdisplay(list); 
        //listdisplay(list);

    }

    //public static void collectiondisplay(ICollection<string> mylist)
    //{
    //    mylist.Add("charge");
    //    foreach (string item in mylist)
    //    {
    //        Console.WriteLine("the icollection elemets are as follows:" + item);
    //    }
    //}
    //public static void ilistdisplay(IList<string> mylist)
    //{
    //    mylist.Add("data");
    //    foreach (string item in mylist)
    //    {
    //        Console.WriteLine("the ilist elemets are as follows:" + item);
    //    }
    //}
    //public static void listdisplay(List<string> mylist)
    //{
    //    mylist.Sort();
    //    foreach (string item in mylist)
    //    {
    //        Console.WriteLine("the list elemets are as follows:" + item);
    //    }
    //}




}