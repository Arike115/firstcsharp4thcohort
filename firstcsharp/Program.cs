using firstcsharp.Topics;
using System;
using System.Collections;
using System.Net.WebSockets;
using System.Security.Cryptography;

public delegate void MyDelegate(string msg); 
public class Program
{
   // public event MyDelegate Notify;  //event
    private static void Main(string[] args) //method or behaviour or logic or function
    {
        //set target method
        MyDelegate del = new MyDelegate(MethodA);

        MyDelegate dels = MethodA;

        //lambda expression
         MyDelegate deles = (string msg) => Console.WriteLine(msg); // anonymous method
        deles("hello people");

        Func<int, int, int, int> add = Student.Sum;
        var result = add(10, 78, 78);
        Console.WriteLine(result);

        Action<decimal> printresult = Print;
        printresult(89087);

        Predicate<string> isupper = CheckCharacter;
        var resultcheck = isupper("h");
        Console.WriteLine(resultcheck);

    }

    //target method
    static void MethodA(string msg)
    {
        Console.WriteLine(msg);
    }


    static void Print(decimal i)
    {
        Console.WriteLine(i);
    }

    static bool CheckCharacter(string str)
    {
        return str.Equals(str.ToUpper());
    }



}