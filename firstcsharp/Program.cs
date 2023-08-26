using firstcsharp.Topics;
using System;
using System.Collections;
using System.Net.WebSockets;
using System.Security.Cryptography;

public class Program
{
    //Joining
    //Convertion method
    //Element operators
    //Aggregate 
    //quantifiers

    //Join
    //=> inner join ---- outer join
    //=> left join ------ left outer join
    //=> right join ----- right outer join
    //=> full join


    //Ordering 
    private static void Main(string[] args) //method or behaviour or logic or function
    {

        ////innerjoin
        ////query syntax

        //var employee = from s in Employee.GetAllEmployees()
        //               join c in Department.GetAllDepartments()
        //               on s.DepartmentId equals c.Id
        //               select new 
        //               { 
        //                   StaffId = s.Id, 
        //                   StaffName = s.Name,
        //                   DepartmentName = c.Name
        //               };

        ////method syntax
        //var emp = Employee.GetAllEmployees()
        //           .Join(Department.GetAllDepartments(),
        //           s => s.DepartmentId,
        //           c => c.Id,
        //           (s, c) => new 
        //           {
        //               StaffId = s.Id,
        //               StaffName = s.Name,
        //               DepartmentName = c.Name
        //           });


        //foreach (var item in emp)
        //{
        //    Console.WriteLine("StaffId : {0} ----- staffName: {1} ----- deptName : {2}", item.StaffId,item.StaffName, item.DepartmentName);
        //}

        ////Group Join
        ////query syntax
        //var groupdata = from c in Department.GetAllDepartments()
        //                join s in Employee.GetAllEmployees()
        //                on c.Id equals s.DepartmentId into groupinfo
        //                select new 
        //                {
        //                    DepartmentName = c.Name,
        //                    staffs = groupinfo
        //                };

        ////method syntax
        //var groupinfos = Department.GetAllDepartments()
        //                .GroupJoin(Employee.GetAllEmployees(),
        //                c => c.Id,
        //                s => s.DepartmentId,
        //                (cl, groupda) => new 
        //                {
        //                    DepartmentName = cl.Name,
        //                    staffs = groupda
        //                });


        //foreach (var std in groupdata)
        //{
        //    Console.WriteLine($"---------{std.DepartmentName}, -------{std.staffs.Count()}");
        //    foreach(var std2 in std.staffs)
        //    {
        //        Console.WriteLine("Employee: {0} ---- DeptId: {1}", std2.Name, std2.DepartmentId);
        //    }
        //}


        ////LeftJoin
        //var employee = from s in Employee.GetAllEmployees() //left
        //              join c in Department.GetAllDepartments() //right
        //              on s.DepartmentId equals c.Id into groupdata
        //              from gc in groupdata.DefaultIfEmpty()
        //              select new
        //              {
        //                  StaffName = s.Name,
        //                  DepartmentName = gc == null ? "N/A" : gc.Name,
        //              };

        ////method syntax
        //var empdata = Employee.GetAllEmployees()
        //           .GroupJoin(Department.GetAllDepartments(),
        //           s => s.DepartmentId,
        //           c => c.Id,
        //           (sls, cls) => new { sls, cls }).SelectMany
        //           (x => x.cls.DefaultIfEmpty(),
        //           (st, cl) => new 
        //           {
        //               StaffName = st.sls.Name,
        //               DepartmentName = cl == null ? "N/A" : cl.Name,
        //           });

        //foreach (var item in empdata)
        //{
        //    Console.WriteLine("staffName: {0} ----- deptName : {1}", item.StaffName, item.DepartmentName);
        //}


        var info = Employee.GetAllEmployees();
        var result =  info.Min( x  => x.Id );
        Console.WriteLine( "Minvalue : {0}",result );
        var result2 = info.Max( x => x.Id );
        Console.WriteLine("MaxValue : {0}",result2 );
        var result3 = info.Sum( x => x.Id );
        Console.WriteLine("sumValue : {0}", result3);
        var result4 = info.Count();
        Console.WriteLine("countValue : {0}", result4);
        var result5 = info.Average(x => x.DepartmentId);
        Console.WriteLine("averageValue : {0}", result5);
    }


}