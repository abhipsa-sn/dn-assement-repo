namespace FinancialForecasting
{
    class Program
    {
        static double FutureValue(double amount, double rate, int years)
        {
            if (years == 0)
                return amount;

            return FutureValue(amount, rate, years - 1) * (1 + rate);
        }

        static void Main(string[] args)
        {
            Console.Write("Enter initial investment: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter annual growth rate (e.g. 0.08 for 8%): ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number of years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n===== Financial Forecast =====");
            for (int i = 1; i <= years; i++)
            {
                double value = FutureValue(principal, rate, i);
                Console.WriteLine($"Year {i}: {value:F2}");
            }

            Console.WriteLine($"\nFinal value after {years} years: {FutureValue(principal, rate, years):F2}");
            Console.ReadKey();
        }
    }
}
