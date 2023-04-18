namespace WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            string dayName = Console.ReadLine();
            Console.WriteLine(num < 10 || num > 18 || dayName.ToLower() == "sunday" ? "closed" : "open");

        }
    }
}
