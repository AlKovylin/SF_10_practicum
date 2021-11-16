namespace SF_10_practicum
{
    class Program
    {
        static ILogger logger;

        static void Main(string[] args)
        {
            logger = new Logger();
            Calculator calculator = new Calculator(logger);

            calculator.Pusk();
        }  
    }
}