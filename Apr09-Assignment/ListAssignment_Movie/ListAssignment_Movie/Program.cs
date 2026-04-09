namespace ListAssignment_Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> moviesList = new List<Movie>();
            Console.WriteLine("Welcome to the Movie Story Developed by Saiteja");
            while (true)
            {
                Console.WriteLine("Please Enter Your Choice\n1. Add new Movie\n2. Display All Movies\n3. Find Movie by ID\n4. Remove Movie by ID\n5. Clear All Movies\n6. Exit");
                int.TryParse(Console.ReadLine(), out int choice);
                switch (choice)
                {
                    case 1:
                        if(moviesList.Count == 5)
                        {
                            Console.WriteLine("\nCannot Add Any Movie Due to Full Size\n");
                            break;
                        }
                        AddMovieTOList(moviesList);
                        break;
                    case 2:
                        Console.WriteLine("\nDisplaying All Movies\n");
                        foreach(var movie in moviesList)
                        {
                            movie.Display();
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.Write("Enter the Id to Find the Movie: ");
                        int.TryParse(Console.ReadLine(), out int FindId);
                        var FindMovie = moviesList.Find(m => m.Id == FindId);
                        if(FindMovie is not null)
                        {
                            FindMovie.Display();
                        }
                        else
                        {
                            Console.WriteLine($"\nCannot Find A Movie With this id: {FindId}\n");
                        }
                        break;
                    case 4:
                        Console.Write("\nEnter the Id of Movie to Remove: \n");
                        int.TryParse(Console.ReadLine(), out int RemoveId);
                        Movie m = moviesList.Find((m) => m.Id == RemoveId);
                        if(m is not null)
                        {
                            moviesList.Remove(m);
                            Console.WriteLine("\nMovie Removed For Data\n");
                        }
                        else
                        {
                            Console.WriteLine($"\nCannot Find A Movie With this id: {RemoveId}\n");
                        }
                        break;
                    case 5:
                        moviesList.Clear();
                        Console.WriteLine("\nData Cleared\n");
                        break;
                    case 6:
                        Console.WriteLine("\nThank you for Watching the Movies\n");
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice\n");
                        break;
                }
            }
            
        }

        static void AddMovieTOList(List<Movie> moviesList)
        {
            while (moviesList.Count < 5)
            {
                Console.WriteLine("Please Enter the Details of the Movie: ");
                Console.WriteLine("Enter Name to Add a Movie");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Id of the Movie");
                int.TryParse(Console.ReadLine(), out int id);
                Console.WriteLine("Enter the Year Of Release");
                int.TryParse(Console.ReadLine(), out int year);
                Console.WriteLine("Enter the Genre");
                string genre = Console.ReadLine();

                moviesList.Add(new Movie(name = name, id = id, year = year, genre = genre));
            }

        }
    }
}
