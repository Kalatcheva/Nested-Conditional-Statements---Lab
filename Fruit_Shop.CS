namespace fruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());

            decimal price = ((new string[] { "monday", "tuesday", "wednesday", "thursday",
            "friday" }.Contains(dayOfWeek.ToLower()) ? "w" : new string[] { "saturday", "sunday" }.Contains(dayOfWeek.ToLower()) ? "s" : "?") + "|" + product.ToLower()) switch
            {

                "w|banana" => 2.5m,
                "w|apple" => 1.2m,
                "w|orange" => 0.85m,
                "w|grapefruit" => 1.45m,
                "w|kiwi" => 2.7m,
                "w|pineapple" => 5.5m,
                "w|grapes" => 3.85m,

                "s|banana" => 2.7m,
                "s|apple" => 1.25m,
                "s|orange" => 0.9m,
                "s|grapefruit" => 1.6m,
                "s|kiwi" => 3,
                "s|pineapple" => 5.6m,
                "s|grapes" => 4.2m,

                _ => -1

            };

            Console.WriteLine(price >=0 ? (price * quantity).ToString("f2") : "error");
        }
    }
}
