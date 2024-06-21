using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    public  class Helpers
    {
        public static void LoadingScreen() 
        {
            Console.Clear();
            Console.Write("Connecting to the database");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(". ");
                Thread.Sleep(500);
            }

            Console.WriteLine();
            Console.Write("Choosing your random activity");

            for (int i = 0; i < 9; i++)
            {
                Console.Write(". ");
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }
    }
}
