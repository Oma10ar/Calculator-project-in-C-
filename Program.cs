using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
namespace Calculator_Project
{
    public   class Setting
    {
        public static int DayNumber
        {
           get
            {
                return DateTime.Today.Day;
            }
        
        }  
        public static string DayName
        {
            get
            {
                return DateTime.Today.DayOfWeek.ToString();
            }
        }
        private Setting()
        {

        }
    }
   

    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine( Setting.DayNumber);
            Console.WriteLine( Setting.DayName);
        }
    }
}

