using System;

namespace SF_10_practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();

            Console.WriteLine("\tПРОГРАММА СЛОЖЕНИЯ ДВУХ ЧИСЕЛ");

            while (true)
            {
                float x = GetNum("\nВведите первое число: ");
                float y = GetNum("Введите второе число: ");

                float result = Calc.Sum(x, y);

                Console.WriteLine($"\n{x} + {y} = {result}\n");

                if (!ReadKey())
                    break;
            }
        }

        private static float GetNum(string message)
        {
            try
            {
                bool isValid = false;
                while (!isValid)
                {
                    Console.Write(message);
                    string input = Console.ReadLine();
                    isValid = float.TryParse(input, out float number);
                    if (isValid)
                        return number;

                    Console.WriteLine("Введено некорректное значение. Повторите ввод.");
                }
                return -1;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка ввода данных." + ex.Message);
            }
        }

        private static bool ReadKey()
        {
            try
            {
                bool YorN = false;
                bool isValid = false;

                Console.Write("Продолжить? (Y/N): ");

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
                            Console.Write("Команда не зарегистрирована. Вводите только Y/N: ");
                            break;
                    }
                }
                return YorN;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка ввода данных." + ex.Message);
            }
        }
    }
}
