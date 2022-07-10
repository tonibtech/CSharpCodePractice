using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much money is in your account? ");
            double money = Int32.Parse(Console.ReadLine());
          

            if (money <= 25)
            {
                Console.WriteLine("Cook at home");
            }else
            {
                Console.WriteLine("Enjoy your UberEats");
            }

            Console.ReadLine();
        }

   
        
    }
}
