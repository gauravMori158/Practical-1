using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
      class CalculatorClass
    {

        public static void Main (String[] args)
        {
            //int num1, num2;
            Console.WriteLine("Enter First Number : ");
             int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter Second Number : ");
            int.TryParse(Console.ReadLine(), out int num2);

            Console.WriteLine("OUTPUT");
            Console.WriteLine($"{num1} + {num2} :" + (num1 + num2));
            Console.WriteLine($"{num1} - {num2} :" + (num1 - num2));
            Console.WriteLine($"{num1} + {num2} :" + (num1 * num2));
            Console.WriteLine($"{num1} / {num2} :" + (num1 / num2));



        }
    }
}
