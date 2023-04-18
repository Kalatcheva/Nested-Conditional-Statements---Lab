namespace smallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());
            Console.WriteLine((city.ToLower() + "|" + product.ToLower()) switch
            {
                "sofia|coffee" => quantity * 0.5m,
                "sofia|water" => quantity * 0.8m,
                "sofia|juice" => quantity * 1.2m,
                "sofia|sweets" => quantity * 1.45m,
                "sofia|peanuts" => quantity * 1.6m,

                "plovdiv|coffee" => quantity * 0.4m,
                "plovdiv|water" => quantity * 0.7m,
                "plovdiv|juice" => quantity * 1.15m,
                "plovdiv|sweets" => quantity * 1.3m,
                "plovdiv|peanuts" => quantity * 1.5m,

                "varna|coffee" => quantity * 0.45m,
                "varna|water" => quantity * 0.7m,
                "varna|juice" => quantity * 1.1m,
                "varna|sweets" => quantity * 1.35m,
                "varna|peanuts" => quantity * 1.55m,
            });
        }
    }
}
