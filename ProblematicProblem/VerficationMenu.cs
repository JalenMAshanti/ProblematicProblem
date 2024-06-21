using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    public static class VerficationMenu
    {
        public static void GetUserData()
        {
            Console.Clear();
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            UserModel.Name = userName;

            Console.Clear();
            Console.Write("What is your age? ");
            int.TryParse(Console.ReadLine(), out int userAge);
            UserModel.Age = userAge;


        }
    }
}
