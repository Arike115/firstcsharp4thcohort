using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstcsharp.Topics
{
    public class Car 
    {
        //Generics

        public static bool Equalvalue<T>(T v1, T v2)
        {
            return v1.Equals(v2);
        }
        
    }

   

}
