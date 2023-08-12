using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstcsharp.Topics
{

    #region arike'scode pls dont modify
   /// <summary>
   /// 
   /// </summary>
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Model { get; set; }

        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
         
        //Attributes
        [Obsolete("this class is outdated please make use of the Calculator(List<int> v1)")]
        public static int Calculator(int v1, int v2)
        {
            return v1 + v2;
        }

        public static int Calculator(List<int> v1)
        {
            var v2 = v1.Sum(x => x);
            return v2;
        }
    }
    #endregion



}
