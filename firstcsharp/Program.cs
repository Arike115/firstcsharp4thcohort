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

       //stack
       //lastinfirstout

        Stack<Car> stackcar = new Stack<Car>();
        stackcar.Push(car1);
        stackcar.Push(car2);
        stackcar.Push(car3);
        stackcar.Push(car4);
        stackcar.Push(car5);
        stackcar.Push(car6);

        var c1 = stackcar.Pop();
        Console.WriteLine(c1.Id + "  "+c1.Name);
        Console.WriteLine("item left in the stack" + stackcar.Count);

        var c2 = stackcar.Pop();
        Console.WriteLine(c2.Id + "  " + c2.Name);
        Console.WriteLine("item left in the stack" + stackcar.Count);

        var c3 = stackcar.Pop();
        Console.WriteLine(c3.Id + "  " + c3.Name);
        Console.WriteLine("item left in the stack" + stackcar.Count);

        var c4 = stackcar.Pop();
        Console.WriteLine(c4.Id + "  " + c4.Name);
        Console.WriteLine("item left in the stack" + stackcar.Count);

        var c5 = stackcar.Pop();
        Console.WriteLine(c5.Id + "  " + c5.Name);
        Console.WriteLine("item left in the stack" + stackcar.Count);

        var c6 = stackcar.Pop();
        Console.WriteLine(c6.Id + "  " + c6.Name);
        Console.WriteLine("item left in the stack" + stackcar.Count);



        //queue
        //firstin first out
        Queue<Car> queuecar = new Queue<Car>();
        queuecar.Enqueue(car1);
        queuecar.Enqueue(car2);
        queuecar.Enqueue(car3);
        queuecar.Enqueue(car4);
        queuecar.Enqueue(car5);
        queuecar.Enqueue(car6);

        Console.WriteLine("*******************");

        var q1 = queuecar.Dequeue();
        Console.WriteLine(q1.Id + "  " + q1.Name);
        Console.WriteLine("item left in the queue" + queuecar.Count);

        var q2 = queuecar.Dequeue();
        Console.WriteLine(q2.Id + "  " + q2.Name);
        Console.WriteLine("item left in the queue" + queuecar.Count);

        var q3 = queuecar.Dequeue();
        Console.WriteLine(q3.Id + "  " + q3.Name);
        Console.WriteLine("item left in the queue" + queuecar.Count);

        var q4 = queuecar.Dequeue();
        Console.WriteLine(q4.Id + "  " + q4.Name);
        Console.WriteLine("item left in the queue" + queuecar.Count);

        var q5 = queuecar.Dequeue();
        Console.WriteLine(q5.Id + "  " + q5.Name);
        Console.WriteLine("item left in the queue" + queuecar.Count);

        var q6 = queuecar.Dequeue();
        Console.WriteLine(q6.Id + "  " + q6.Name);
        Console.WriteLine("item left in the queue" + queuecar.Count);


        string[] result = { "lots", "data", "time", "date", "later" };

        Queue<string> queue = new Queue<string>();
        queue.Enqueue("lots");
        queue.Enqueue("date");
        queue.Enqueue("time");
        queue.Enqueue("later");
        queue.Enqueue("item");
        queue.Enqueue("result");

        foreach( var item in queue)
        {
            Console.WriteLine(item);
        }
    }

   

   

}