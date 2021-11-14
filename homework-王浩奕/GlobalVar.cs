using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic; //list命名空間
using System.Collections;//arraylist命名空間
namespace WindowsFormsApp1
{
    class GlobalVar
    {
        public static string date;
        //public static string student104, student105;
        //全域變數 Global Variable
        public static List<string> listClass = 
            new List<string>();
        public static List<string> listRestaurant= 
            new List<string>();
        public static List<ArrayList> listOrderItem =
            new List<ArrayList>();
        public static string idn;
        
    }
}