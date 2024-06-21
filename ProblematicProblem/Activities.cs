using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblematicProblem
{
    public class Activities
    {
       public static List<string> activitiesList = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        public static void ViewList() 
        {
            Console.Clear();
            foreach (string activity in activitiesList)
            {
                
                Console.WriteLine("");
                Console.WriteLine($"{activity}");
                Thread.Sleep(250);
            }
        }

        public static string GenerateRandomActivity() 
        {
            Random rng = new Random();
            int randomNumber = rng.Next(0, Activities.activitiesList.Count);
            string randomActivity = Activities.activitiesList[randomNumber];


            if (UserModel.Age < 21 && randomActivity == "Wine Tasting")
            {
                Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                Console.WriteLine("Pick something else!");
                Activities.activitiesList.Remove(randomActivity);

            }
            randomNumber = rng.Next(0, Activities.activitiesList.Count);
            randomActivity = Activities.activitiesList[randomNumber];   
            
            return randomActivity;

        }
    }
}
