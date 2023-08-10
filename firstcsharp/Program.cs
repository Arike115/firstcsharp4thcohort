using firstcsharp.Topics;

public class Program
{

    private static void Main(string[] args) //method or behaviour or logic
    {
        Car c1 = new Car(10001, "BMW", Gender.Female);
        c1.PrintDetails();

        Car c2 = new Car();
        c2.Name = "Bugatti";
        c2.Carid = 10002;
        c2.Gender = Gender.Male;
        c2.PrintDetails();

        Car c3 = new Car
        {
            Carid = 10003,
            Name = "Toyota Camry",
            Gender = Gender.Unknown
        };
        c3.PrintDetails();


        int[] values = (int[])Enum.GetValues(typeof(Gender));
        foreach(int value in values)
        {
            Console.WriteLine(value);
        }

        string[] gender = Enum.GetNames(typeof(Gender));    

        foreach(string value in gender)
        {
            Console.WriteLine(value);
        }

    }

}