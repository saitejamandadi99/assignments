namespace LinkedList_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(5);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            linkedList.AddFirst(10);
            

            while (true)
            {
                Console.WriteLine("Enter the choice to access features\n 1.Add\n 2.display\n 3.Search\n 4.Update\n 5.Delete\n 6.Quit");
                int.TryParse(Console.ReadLine(), out int choice);
                if(choice > 6)
                {
                    Console.WriteLine("Invalid Choice Try again");
                }
                else
                {
                    if (choice == 1)
                    {
                        //Add
                        Console.WriteLine("Enter a value to Add");
                        int.TryParse(Console.ReadLine(), out int AddValue);
                        linkedList.AddFirst(AddValue);
                        Console.WriteLine("Value Added");
                    }
                    else if (choice == 2)
                    {
                        //Display
                        Console.WriteLine("\n---Display----\n");
                        foreach (int item in linkedList)
                        {
                            Console.Write(item + "->");
                        }
                        Console.WriteLine();
                    }
                    else if (choice == 3)
                    {
                        //search value
                        Console.WriteLine("Enter the value to search : ");
                        int.TryParse(Console.ReadLine(), out int value);
                        Console.WriteLine("Value Found: " + linkedList.Contains(value));
                    }

                    else if(choice == 4)
                    {
                        //update value
                        Console.WriteLine("Enter a value to update it ");
                        int.TryParse(Console.ReadLine(), out int updateValue);
                        var value1 = linkedList.Find(updateValue);
                        if (value1 != null)
                        {
                            Console.WriteLine("Enter a value to update");
                            int.TryParse(Console.ReadLine(), out int newValue);
                            value1.Value = newValue;
                            Console.WriteLine("Value updated");
                        }
                        else
                        {
                            Console.WriteLine("Value not found");
                        }
                    }
                    else if(choice == 5)
                    {
                        //delete value
                        Console.WriteLine("Enter a value to remove");
                        int.TryParse(Console.ReadLine(), out int removeValue);
                        Console.WriteLine("Value removed: "+ linkedList.Remove(removeValue));
                    }

                    else
                    {
                        //quit
                        Console.WriteLine("Completed");
                        break;
                    }

                }
                

            }

            
            
        }
    }
}
