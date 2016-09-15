using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodProblem5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be doubled:");
            
            //using method "Double"
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("= "+Double(num));
        }


        //method to double an int
        static int Double(int number)
        {
            int doubled = number * 2;
            return doubled;
        }
    }
}
