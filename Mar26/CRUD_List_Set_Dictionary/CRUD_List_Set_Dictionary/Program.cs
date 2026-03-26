using System.Runtime.InteropServices;

namespace CRUD_List_Set_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //crud list
            List<int> listInt = new List<int>() { 1, 2, 3, 4, 5, 6 }; //create
            foreach(int a in listInt) //read
            {
                Console.WriteLine($"Reading List : {a}");
            }

            Console.WriteLine("Enter the index to update the list item");
            int.TryParse(Console.ReadLine(), out int UpdateIndex);
            Console.WriteLine("Enter the Number to update at the list");
            int.TryParse(Console.ReadLine(), out int UpdateNumber);
            if (UpdateIndex <= listInt.Count - 1) 
            {
                listInt[UpdateIndex] = UpdateNumber;
                Console.WriteLine($"Updated Number at Index:{UpdateIndex}");
            }
            else
            {
                Console.WriteLine("Index out of Range");
            }

            Console.WriteLine("Enter the index to remove the list item");
            int.TryParse(Console.ReadLine(), out int RemoveIndex);
            listInt.RemoveAt(RemoveIndex);
            Console.WriteLine($"Inder Number at Removed: {RemoveIndex}");

            Console.Write("Final list: ");
            foreach(int a in listInt)
            {
                Console.Write(a+" ");
            }
            Console.WriteLine();

            //crud set
            HashSet<int> setInt = new HashSet<int>() { 1, 2, 2, 3, 4, 5, 6, 7, 7 };
            //reading 
            Console.WriteLine("Printing set");
            foreach (int a in setInt) //read
            {
                Console.WriteLine($"Reading Set: {a}");
            }

            //updating a set 
            Console.Write("Enter the number to Add: ");
            int.TryParse(Console.ReadLine(), out int SetUpdateNumber);
            setInt.Add(SetUpdateNumber);

            //removing 
            Console.Write("Enter the number to Remove: ");
            int.TryParse(Console.ReadLine(), out int SetRemoveNumber);
            setInt.Remove(SetRemoveNumber);

            //final set 

            Console.Write("Final Set: ");
            foreach (int a in setInt) //read
            {
                Console.Write(a+" ");
            }
            Console.WriteLine();

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Sai");
            dict.Add(2, "Jhon");
            dict.Add(3, "Jacob");
            Console.WriteLine("Displaying dictionary");
            foreach(KeyValuePair<int,string>key in dict)
            {
                Console.WriteLine($"key: {key.Key}, Name: {key.Value}");
            }
            //adding new values to dict 
            Console.WriteLine("Enter a Name to Add");
            string newName = Console.ReadLine();
            dict.Add(dict.Count + 1 , newName);
            Console.WriteLine("Added a new Value");

            //updating value
            Console.WriteLine("Enter the update id: ");
            int.TryParse(Console.ReadLine(), out int updateId);
            if (dict.ContainsKey(updateId))
            {
                Console.WriteLine("Enter the Update Name: ");
                dict[updateId] = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Key does not exists");
            }

            //removing value
            Console.WriteLine("Enter the index to remove the Id");
            int.TryParse(Console.ReadLine(), out int removeId);
            if (dict.TryGetValue(removeId, out  string removedName))
            {
                dict.Remove(removeId);
                Console.WriteLine("Deleted Name: "+removedName);
            }
            else
            {
                Console.WriteLine("Key does not exists.");
            }
            //final dict 

            Console.WriteLine("Final Set ");

            foreach (KeyValuePair<int, string> key in dict)
            {
                Console.WriteLine($"key: {key.Key}, Name: {key.Value}");
            }
        }
    }
}
