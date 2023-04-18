namespace weekendOrWorkingDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayWeekName = Console.ReadLine();
            Console.WriteLine(dayWeekName.ToLower() switch
            {
                "monday" 
                or "tuesday" 
                or "wednesday"
                or "thursday" 
                or "friday" => "Working day",
                "saturday"
                or "sunday" => "Weekend",
                _ => "Error"
            });
        }
    }
}
