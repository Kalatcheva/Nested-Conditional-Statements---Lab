namespace invalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine((num >= 100 && num <= 200) || num == 0 ? string.Empty : "invalid");
        }
    }
}
