using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstcsharp.Topics
{
    public enum JobTypes
    { 
        Banker,
        Doctors,
        Lawyer,
        Engineers
    }

    public struct Types
    { 

    }


    public struct Car 
    {
        private int _carid; 
        private string _name;
        private Gender _gender;

        public int Carid 
        {
            get => _carid; 
            set => _carid = value; 
        }
        public string Name 
        { 
            get => _name; 
            set => _name = value;
        }
        public Gender Gender 
        { 
          get => _gender; 
          set => _gender = value; 
        }

        public Car(int id , string name, Gender gender) 
        { 
            _carid = id;
            _name = name;
            _gender = gender;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Car Id is ----- {0} and name is --- {1} the gender is {2} ", _carid, _name,_gender);
        }
    }

   

}
