namespace CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayWeekName = Console.ReadLine();
            Console.WriteLine(dayWeekName.ToLower() switch
            {
                "monday"
                or "tuesday" => 12,
                "wednesday"
                or "thursday" => 14,
                "friday" => 12,
                "saturday"
                or "sunday" => 16,
                _ => "Error"
            });
        }
    }
}
