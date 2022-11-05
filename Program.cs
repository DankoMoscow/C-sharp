namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа");
            Console.WriteLine("Первое число: ");
            string word1 = Console.ReadLine();
            if (double.TryParse(word1, out double num1) == false)
            {
                while (double.TryParse(word1, out  num1) != true)
                {
                    Console.WriteLine("Вы ввели не число, попробуйте заново");
                    word1 = Console.ReadLine();
                }
            }
            else
            {
                num1 = int.Parse(word1);              
            }

            Console.WriteLine("Второе число: ");
            string word2 = Console.ReadLine();
            if (double.TryParse(word2, out double num2) == false)
            {
                while (double.TryParse(word2, out num2) != true)
                {
                    Console.WriteLine("Вы ввели не число, попробуйте заново");
                    word2 = Console.ReadLine();
                }
            }
            else
            {
                num2 = int.Parse(word2);
            }

            Console.WriteLine("Какую операцию хотите сделать?");
            string order = Console.ReadLine();
            do
            {
                if (order == "Умножить" | order == "умножить")
                {
                    double res = multFunction(num1, num2);
                    printFunction(res);
                }
                else if (order == "Сложить" | order == "сложить")
                {
                    double res = plusFunction(num1, num2);
                    printFunction(res);
                }
                else if (order == "Вычесть" | order == "вычесть")
                {
                    double res = minusFunction(num1, num2);
                    printFunction(res);
                }
                else if (order == "Поделить" | order == "поделить")
                {
                    if (num2 == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
                    }
                    else 
                    {
                        double res = divideFunction(num1, num2);
                        printFunction(res);
                    }
                }
                else
                {
                    Console.WriteLine("Капец");
                }
                Console.WriteLine("Хотите продолжить? Если да, введите 'да', если нет - 'нет'");
                order = Console.ReadLine();

                if (order != "да" & order != "нет")
                {
                    do
                    {
                        Console.WriteLine("Введите нужную команду");
                        order = Console.ReadLine();
                    }
                    while (order != "да" & order != "нет");
                }
                else if (order == "да")
                {
                    Console.WriteLine("Какую операцию хотите сделать?");
                    order = Console.ReadLine();
                }
                else if (order == "нет")
                {      
                    Console.WriteLine("До свидания, dungeon master!");
                    continue;
                }
            }
            while (order != "нет");
        }
        static double plusFunction(double n1, double n2)
        {
            double res = n1 + n2;
            return res;
        }
        static double minusFunction(double n1, double n2)
        {
            double res = n1 - n2;
            return res;
        }
        static double multFunction(double n1, double n2)
        {
            double res = n1 * n2;
            return res;
        }
        static double divideFunction(double n1, double n2)
        {
            double res = n1 / n2;
            return res;
        }
        static void printFunction(double res)
        {
            Console.WriteLine($"Ваш ответ: {res}");
        }
    }
}