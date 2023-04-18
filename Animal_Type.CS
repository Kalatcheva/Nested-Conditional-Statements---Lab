namespace AnimalType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animalName = Console.ReadLine();
            Console.WriteLine(animalName.ToLower() switch
            {
                "dog" => "mammal",
                "crocodile"
                or "tortoise"
                or "snake" => "reptile",
                _ => "unknown"
            });
        }
    }
}
