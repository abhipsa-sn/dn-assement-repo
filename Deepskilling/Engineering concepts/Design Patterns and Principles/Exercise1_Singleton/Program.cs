namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("Application started");
            logger2.Log("Processing order #101");

            Console.WriteLine("Same instance: " + (logger1 == logger2));
        }
    }
}
