namespace PlanetEnumeration
{
    internal class Program
    {
        enum Planet
        {
            Earth = 100,
            Mars = 38,
            Jupiter = 234
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight");
            int.TryParse(Console.ReadLine(), out int weight);

            foreach(Planet planet in Enum.GetValues(typeof(Planet)))
            {
                int gravity = (int)planet;
                float planetgravity = gravity / 100f;
                float PlanetWeight = planetgravity * weight;
                Console.WriteLine($"Person of weight {weight}kg is {PlanetWeight}kg on planet {planet} ");
            }
        }
    }
}
