using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstcsharp.Topics
{
    abstract class AbstractData : Modules, IModule, IModuleList
    {
        int v = 56;
        public string name { get;set; }

        public void GetModuledetails()
        {
            Console.WriteLine("Hello abstract");
        }

        public void GetModulelist()
        {
            Console.WriteLine("nice meeting you");
        }

        public void result()
        {

        }
    }

   public interface IModule 
    {
        void GetModuledetails();
    }

   public interface IModuleList
    {
        void GetModulelist();
    }

}
