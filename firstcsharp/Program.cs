using firstcsharp.Topics;
using System.Collections;
using System.Net.WebSockets;
using System.Security.Cryptography;

public class Program
{
    //Joining
    //Grouping
    //Ordering
    //Set Operation

    //Join
    //=> inner join ---- outer join
    //=> left join ------ left outer join
    //=> right join ----- right outer join
    //=> full join


    //Ordering 
    private static void Main(string[] args) //method or behaviour or logic or function
    {

        //Ordering
        //orderby
        //orderbydescending
        //thenby
        ////ThenByDescending
        //var emp = Employee.GetAllEmployees()
        //           .OrderByDescending(x => x.ID)
        //           .ThenByDescending(x => x.Name)
        //           .ToList();

        //foreach(var data in emp)
        //{
        //    Console.WriteLine("Name:---" + data.Name + ": Id:-----" + data.ID);
        //}

        //Grouping

        ////GroupBy
        ////query syntax
        //var info = (from std in Employee.GetAllEmployees()
        //            group std by std.DepartmentId);

        ////method syntax
        //var info2 = Employee.GetAllEmployees().GroupBy(x => x.DepartmentId);

        //foreach (var data in info)
        //{
        //    Console.WriteLine(data.Key + ":" + data.Count());
        //    foreach (var data2 in data)
        //    {
        //        Console.WriteLine("Name :" + data2.Name);
        //    }
        //}
        //Console.ReadKey();

        //set operator
        //Distinct
        //Except
        //intersect
        //union

        var datsource1 = new List<int> { 1, 2, 4, 5, 7, 8, 9, 9, 10, 10 };
        var datsource2 = new List<int> { 11, 45, 77, 10, 9, 12, 34, 0 };


        ////Distinct
        ////method syntax
        //var result = datsource1.Distinct().ToList();

        ////query syntax 
        //var result2 = (from num in datsource1 select num).Distinct();

        ////Except
        ////method syntax
        //var result = datsource2.Except(datsource1).ToList();

        ////Intersect
        ////method syntax
        //var result = datsource2.Intersect(datsource1).ToList();

        ////Union
        ////method syntax
        var result = datsource2.Union(datsource1).ToList();
        foreach (var data in result)
        {
            Console.WriteLine(data);
        }
        Console.ReadKey();

    }


}