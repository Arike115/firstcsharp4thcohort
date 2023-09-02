using firstcsharp.Topics;
using System;
using System.Collections;
using System.Net.WebSockets;
using System.Security.Cryptography;

public class Program
{

  
        //Thread
        //Task
        //Aysncronous function
        //await
        //async
        //task
    private static void Main(string[] args) //method or behaviour or logic or function
    {
        InfoMethod();
        Console.Read();
    }

    //static async void result()
    //{
    //    Task.Run(() =>
    //    {
    //        Calculate1();
    //    });
    //    Task.Run(() =>
    //    {
    //        Calculate2();
    //    });
    //    Task.Run(() =>
    //    {
    //        Calculate3();
    //    });
    //    await Data();

    //}

    //static int Calculate1()
    //{
    //    Thread.Sleep(3000);
    //    Console.WriteLine("calculating result 1");
    //    return 100;
    //}
    //static int Calculate2()
    //{
    //    Console.WriteLine("calculating result 2");
    //    return 200;
    //}
    //static int Calculate3()
    //{
    //    Console.WriteLine("calculating result 3");
    //    return 300;
    //}

    //static async Task Data() //asyncronous methos
    //{
    //    Console.WriteLine("result");
    //}

    public async static void InfoMethod()
    {
        Console.WriteLine("info method begins");
        Wait();
        Console.WriteLine("info method Ends.");
    }

    public async static Task Wait()
    {
      await Task.Delay(TimeSpan.FromSeconds(10));
        Console.WriteLine("Time completed");
    }



}