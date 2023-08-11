using firstcsharp.Topics;


public class Program
{

    private static void Main(string[] args) //method or behaviour or logic or function
    {
       List<Car> carmodel = new List<Car>();
        carmodel.Add(new Car() { Id = 101, Name="Benz", Model=2017, Price = 2000000 });
        carmodel.Add(new Car() { Id = 102, Name = "Camry", Model = 2018, Price = 1000000 });
        carmodel.Add(new Car() { Id = 103, Name = "Peguot", Model = 2013, Price = 6700000 });
        carmodel.Add(new Car() { Id = 104, Name = "Toyota", Model = 2014, Price = 3000000 });
        carmodel.Add(new Car() { Id = 105, Name = "Bugatti", Model = 2022, Price = 5000000 });
        carmodel.Add(new Car() { Id = 106, Name = "Lexus", Model = 2012, Price = 2300000 });

        outdateddelgate outdated = new outdateddelgate(Carfiltering);
        Car.OldCars(carmodel,outdated);
        Console.WriteLine( "-----------");
        outdateddelgate outdateds = new outdateddelgate(Carfilter);
        Car.OldCars(carmodel, outdateds);

        Console.ReadKey();
    }

    public static bool Carfiltering(Car car)
    {
        if(car.Price < 2300000)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool Carfilter(Car car)
    {
        if (car.Id < 104)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


}