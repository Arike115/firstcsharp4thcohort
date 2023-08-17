using firstcsharp.Topics;

public delegate void Print(int value);
public class Program
{



    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args) //method or behaviour or logic or function
    {

        Car car1 = new Car() { Id = 201, Name = "Benz", Price = 50000, Model= 2035 };
        Car car2 = new Car() { Id = 202, Name = "Toyota", Price = 150000, Model = 2005 };
        Car car3 = new Car() { Id = 203, Name = "Mistubushi", Price = 100000, Model = 2095 };
        Car car4 = new Car() { Id = 204, Name = "Camry", Price = 50000, Model = 2003 };
        Car car5 = new Car() { Id = 205, Name = "Bugatti", Price = 500000, Model = 2025 };
        Car car6 = new Car() { Id = 206, Name = "Ferarri", Price = 450000, Model = 2030};

        Dictionary<int, Car> cardictionary = new Dictionary<int, Car>();
        cardictionary.Add(car1.Id, car1);
        cardictionary.Add(car2.Id, car2);
        cardictionary.Add(car3.Id, car3);
        cardictionary.Add(car4.Id, car4);
        cardictionary.Add(car5.Id, car5);
        cardictionary.Add(car6.Id, car6);
       

        foreach(KeyValuePair<int, Car> pair in cardictionary)
        {
            //Console.WriteLine("key" + pair.Key);
            var car = pair.Value;
            Console.WriteLine("Id = {0}, Name = {1}, Price = {2}, Model = {3}", car.Id, car.Name, car.Price, car.Model);
        }


    }

   

   

}