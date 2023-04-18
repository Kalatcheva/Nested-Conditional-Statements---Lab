namespace fruitOrVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string plantName = Console.ReadLine();
            Console.WriteLine(plantName.ToLower() switch
            {
                "banana"
                or "apple"
                or "kiwi"
                or "cherry"
                or "grapes"
                or "lemon" => "fruit",
                "tomato"
                or "cucumber"
                or "pepper"
                or "carrot" => "vegetable",
                _ => "unknown"
            });

        }
    }
}
