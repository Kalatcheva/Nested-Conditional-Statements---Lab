namespace NumberRanges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num <= 100 && num >=-100 && num != 0 ? "Yes" : "No");
        }
    }
}
