using System.ComponentModel.DataAnnotations;

namespace Pig_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            int turns = 0;
            Random rand = new Random();
            while (points < 20)
            {
                Console.WriteLine("Hold or Roll? Enter 1 to Hold and Enter 2 to Roll");
                int.TryParse(Console.ReadLine(), out int choice);
                if (choice == 1)
                {
                    Console.WriteLine("\nChoose to hold the points");
                    Console.WriteLine($"\nPoints : {points}");
                    break;
                }
                if (choice > 2)
                {
                    Console.WriteLine("\nINvalid choice");
                    continue;
                }
                int value = rand.Next(1, 7);
                if (value == 1)
                {
                    Console.WriteLine("\nGot 1! Game Completed Lost All points");
                    points = 0;
                    break;
                }
                else
                {
                    Console.WriteLine($"\nRolled the dice:{value}");
                    points += value;
                    if (points > 20) points = 20;
                    Console.WriteLine($"Total Points: {points}");
                }
            }
            Console.WriteLine($"Game Completed ! Total Points Scored is {points}");
        }
    }
}
