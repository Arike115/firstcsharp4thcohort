using firstcsharp.Topics;


public class Program
{
    //lambda expression =>
    private static void Main(string[] args) //method or behaviour or logic or function
    {
       List<Car> carmodel = new List<Car>();
        carmodel.Add(new Car() { Id = 101, Name="Benz", Model=2017, Price = 2000000 });
        carmodel.Add(new Car() { Id = 102, Name = "Camry", Model = 2018, Price = 1000000 });
        carmodel.Add(new Car() { Id = 103, Name = "Peguot", Model = 2013, Price = 6700000 });
        carmodel.Add(new Car() { Id = 104, Name = "Toyota", Model = 2014, Price = 3000000 });
        carmodel.Add(new Car() { Id = 105, Name = "Bugatti", Model = 2022, Price = 5000000 });
        carmodel.Add(new Car() { Id = 106, Name = "Lexus", Model = 2012, Price = 2300000 });

        var result = carmodel.Select(x => new {model = x.Model, name = x.Name, carid = x.Id}).ToList();
        foreach(var item in result)
        {
            Console.WriteLine(item.name);
        }
        var s = carmodel.Sum(x => x.Price);
        Console.WriteLine(s);
        Console.ReadKey();
    }

   

}