using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstcsharp.Topics
{
    public delegate bool outdateddelgate(Car car);
    public class Car
    {
       //Delegate 
       //is a type safe function pointer

        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Model { get; set; }

    }

   

}
