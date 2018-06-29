using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloJenkins
{
   public class Program
    {
      public  static void Main(string[] args)
        {

            Console.WriteLine(createMessage());


        }


        public static string createMessage()
        {
            return "Hello Jenkins..hope it's working !!";
        }
    }
}
