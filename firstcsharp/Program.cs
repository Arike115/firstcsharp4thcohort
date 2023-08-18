using firstcsharp.Topics;
using System.Collections;

public class Program
{
    //linq language integrated query
    //query syntax or query expression
    //method syntax or method extension syntax or fluent syntax
    //filtering ====> where and offtype
    //projection ====> select anf select many

    private static void Main(string[] args) //method or behaviour or logic or function
    {
        IList<Student> students = new List<Student>()
        {
            new Student() {Id = 1, Name = "John", Age = 15},
            new Student() {Id = 1, Name = "Austin", Age = 18 },
            new Student() {Id = 1, Name = "Victor", Age = 19},
            new Student() {Id = 1, Name = "Ben", Age = 23},
            new Student() {Id = 1, Name = "Ruth", Age = 7},
        };

        //query
        var tenager = from s in students
                      where s.Age > 7 
                      select s;
        //method syntax
        var tenag = students.Where(s => s.Age > 7);

        foreach (var student in tenag.ToList())
        {
            Console.WriteLine(student.Name);
        }

        Console.WriteLine("**********");

        IList values = new ArrayList();
        values.Add(0);
        values.Add("data");
        values.Add("numbers");
        values.Add(2);

        var stringresult = from s in values.OfType<string>()
                           select s;

        foreach(var res in stringresult.ToList())
        {
            Console.WriteLine(res);
        }
        Console.WriteLine("**********");
        var stringint = from s in values.OfType<int>()
                           select s;

        foreach (var re in stringint.ToList())
        {
            Console.WriteLine(re);
        }

        Console.WriteLine("**********");
        List<string> words = new List<string>() { "data", "result", "recharge" };
        var result =  words.SelectMany(s => s);
        foreach(var v in result)
        {
            Console.WriteLine(v);
        }

    }


}