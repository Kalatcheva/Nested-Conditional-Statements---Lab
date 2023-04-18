namespace personalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            Console.WriteLine((gender.ToLower() + (age >= 16 ? "+" : "-"))  switch
            {
                "m+" => "Mr.",
                "m-" => "Master",
                "f-" => "Miss",
                "f+" => "Ms."
            });
        }
    }
}
