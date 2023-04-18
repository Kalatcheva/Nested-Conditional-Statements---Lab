namespace dayOfWeek;

internal class Program
{
    static void Main(string[] args)
    {

        int dayNum = int.Parse(Console.ReadLine());
        Console.WriteLine(dayNum switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Error"
        });

    }
}
