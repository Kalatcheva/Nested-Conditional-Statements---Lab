namespace Commisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            decimal money = decimal.Parse(Console.ReadLine());

            decimal commisions = (city.ToLower() + "|" +
                (money < 0 ? "?" :
                    money <= 500 ?
                        "s" : money <= 1000 ?
                            "m" : money <= 10000 ?
                                "l" : "xl")) switch
            {

                "sofia|s" => money * 0.05m,
                "sofia|m" => money * 0.07m,
                "sofia|l" => money * 0.08m,
                "sofia|xl" => money * 0.12m,

                "varna|s" => money * 0.045m,
                "varna|m" => money * 0.075m,
                "varna|l" => money * 0.1m,
                "varna|xl" => money * 0.13m,

                "plovdiv|s" => money * 0.055m,
                "plovdiv|m" => money * 0.08m,
                "plovdiv|l" => money * 0.12m,
                "plovdiv|xl" => money * 0.145m,

                _ => -1m

            };

            Console.WriteLine(commisions >= 0 ? commisions.ToString("f2") : "error");
        }
    }
}
