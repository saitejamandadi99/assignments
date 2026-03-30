namespace Deligate_Assignment_Multicast
{
    internal class Program
    {
        public delegate void Notify(string msg);
        static void Main(string[] args)
        {
            Notify notify = new Notify(SendEmail);
            notify("this is email");
            Console.WriteLine("\n---Multicast---\n");
            notify += SendSMS;
            notify += SendWhatsApp;
            notify("Message Printing");

            Console.WriteLine("\n--Removing Multicast---\n");
            notify -= SendSMS;

            notify("Program");


        }

        static void SendEmail(string msg)
        {
            Console.WriteLine("Sending Email..."+msg);
        }

        static void SendSMS(string msg)
        {
            Console.WriteLine("Sending SMS..."+msg);
        }

        static void SendWhatsApp(string msg)
        {
            Console.WriteLine("Sending WhatsApp..."+msg);
        }
    }
}
