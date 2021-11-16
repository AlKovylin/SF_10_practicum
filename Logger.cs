using System;

namespace SF_10_practicum
{
    class Logger
    {
        public enum typeMess
        {
            Err,
            Norm
        }

        public void PrintMessage(string message, typeMess type)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            if (type == typeMess.Err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(message);
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.Write(message);
            }
        }
    }
}