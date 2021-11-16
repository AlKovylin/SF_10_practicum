using System;

namespace SF_10_practicum
{
    public class Calculator : ISum
    {
        ILogger logger { get; }

        public Calculator(ILogger logger)
        {
            this.logger = logger;
        }

        public float Sum(float x, float y)
        {
            return x + y;
        }

        public void Pusk()
        {

            logger.Event("\tПРОГРАММА СЛОЖЕНИЯ ДВУХ ЧИСЕЛ\n");

            while (true)
            {
                float x = GetNum("\nВведите первое число: ");
                float y = GetNum("Введите второе число: ");

                float result = Sum(x, y);

                logger.Event($"\n{x} + {y} = {result}\n");

                if (!ReadKey())
                    break;
            }
        }
             
        private float GetNum(string message)
        {
            try
            {
                bool isValid = false;
                while (!isValid)
                {
                    logger.Event(message);
                    string input = Console.ReadLine();
                    isValid = float.TryParse(input, out float number);
                    if (isValid)
                        return number;

                    logger.Error("Введено некорректное значение. Повторите ввод.\n");
                }
                return -1;
            }
            catch (Exception ex)
            {
                logger.Error("Ошибка." + ex.Message);
                return 0;
            }
        }

        private bool ReadKey()
        {
            try
            {
                bool YorN = false;
                bool isValid = false;

                logger.Event("\nПродолжить? (Y/N): ");

                while (!isValid)
                {
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "Y":
                            YorN = true;
                            isValid = true;
                            break;
                        case "N":
                            YorN = false;
                            isValid = true;
                            break;
                        default:
                            logger.Error("Команда не зарегистрирована. Вводите только Y/N: ");
                            break;
                    }
                }
                return YorN;
            }
            catch (Exception ex)
            {
                logger.Error("Ошибка." + ex.Message);
                return false;
            }
        }
    }
}