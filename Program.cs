namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа");
            Console.WriteLine("Первое число: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Второе число: ");
            string s2 = Console.ReadLine();

            int num1 = int.Parse(s1);
            int num2 = int.Parse(s2);

            do
            {
                Console.WriteLine("Какую операцию хотите сделать?");
                string order = Console.ReadLine();
                if (order == "Умножить")
                {
                    Console.WriteLine($"Результат сложения: {num1 * num2}");
                }
                else if (order == "Сложить")
                {
                    Console.WriteLine($"Результат сложения: {num1 + num2}");
                }
                else if (order == "Вычесть")
                {
                    Console.WriteLine($"Результат вычетания: {num1 - num2}");
                }
                else if (order == "Поделить")
                {
                    try
                    {
                        Console.WriteLine($"Результат делеия : {num1 / num2}");
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine($"Исключение: {error.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Капец");
                }
                Console.WriteLine("Хотите продолжить? Если да, введите 'да', если нет - 'нет'");
                string order_way = Console.ReadLine();
                
                if (order_way != "да"  & order_way != "нет")
                {
                    do
                    {
                        Console.WriteLine("Введите нужную команду");
                        order_way = Console.ReadLine();
                    }
                    while (order_way != "да" & order_way != "нет");
                }
                               
            } 
            while ( order != "нет" );

        }
    }
}