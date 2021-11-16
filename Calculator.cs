using System;

namespace SF_10_practicum
{
    class Calculator : ISum
    {
        Logger logger { get; set; }

        public Calculator(Logger logger)
        {
            this.logger = logger;
        }

        public float Sum(float x, float y)
        {
            return x + y;
        }

        public void Pusk()
        {

            logger.PrintMessage("\tПРОГРАММА СЛОЖЕНИЯ ДВУХ ЧИСЕЛ\n", Logger.typeMess.Norm);

            while (true)
            {
                float x = GetNum("\nВведите первое число: ");
                float y = GetNum("Введите второе число: ");

                float result = Sum(x, y);

                logger.PrintMessage($"\n{x} + {y} = {result}\n", Logger.typeMess.Norm);

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
                    logger.PrintMessage(message, Logger.typeMess.Norm);
                    string input = Console.ReadLine();
                    isValid = float.TryParse(input, out float number);
                    if (isValid)
                        return number;

                    logger.PrintMessage("Введено некорректное значение. Повторите ввод.\n", Logger.typeMess.Err);
                }
                return -1;
            }
            catch (Exception ex)
            {
                logger.PrintMessage("Ошибка." + ex.Message, Logger.typeMess.Err);
                return 0;
            }
        }

        private bool ReadKey()
        {
            try
            {
                bool YorN = false;
                bool isValid = false;

                logger.PrintMessage("\nПродолжить? (Y/N): ", Logger.typeMess.Norm);

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
                            logger.PrintMessage("Команда не зарегистрирована. Вводите только Y/N: ", Logger.typeMess.Err);
                            break;
                    }
                }
                return YorN;
            }
            catch (Exception ex)
            {
                logger.PrintMessage("Ошибка." + ex.Message, Logger.typeMess.Norm);
                return false;
            }
        }
    }
}