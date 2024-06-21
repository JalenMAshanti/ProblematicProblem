using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    public class ApplicationManager
    {
        public void RunApplication()
        {
            bool cont = true;
            Random rng = new Random();

            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? true/false: ");
            bool.TryParse(Console.ReadLine(), out cont);

            if (cont)
            {

                VerficationMenu.GetUserData();
            }
            else
            {
                Console.Write("Good-Bye!");
                Environment.Exit(0);
            }

            
            
                
            Console.WriteLine("");
            Console.Write("Would you like to see the current list of activities? true/false: ");
            bool.TryParse(Console.ReadLine(), out bool seeList);

            if (seeList)
            {

                Activities.ViewList();

                Console.WriteLine("");
                Console.Write("Would you like to add any activities before we generate one? true/false: ");
                bool.TryParse(Console.ReadLine(), out bool addToList);
                Console.WriteLine();

                while (addToList)
                {

                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();
                    Activities.activitiesList.Add(userAddition);

                    Activities.ViewList();

                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? true/false: ");
                    bool.TryParse(Console.ReadLine(), out addToList);
                }

            }

            do
            { 
                Helpers.LoadingScreen();
                var activity = Activities.GenerateRandomActivity();

                Console.WriteLine("");
                Console.Write($"Ah got it! {UserModel.Name}, your random activity is: {activity}! do you want to grab another activity? True/False: ");
                Console.WriteLine();
                bool.TryParse(Console.ReadLine(), out cont);


            } while (cont); 

            Console.Clear();
            Console.WriteLine("Good-bye!");
        }
    }
}
