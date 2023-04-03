using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingApplication
{
      class DebuggingClass
    {

        public static void Main(string[] args)
        {
            string userResponse =Console.ReadLine();
             if (int.TryParse(userResponse,out int result))
            {

                Console.WriteLine("The entered value is a integer");

            }

             
        }
    }
}
