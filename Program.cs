namespace SF_10_practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            Calculator calculator = new Calculator(logger);

            calculator.Pusk();
        }  
    }
}