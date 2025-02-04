using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя первое число
        Console.Write("Введите первое число: ");
        string input1 = Console.ReadLine();
        int number1 = Convert.ToInt32(input1);

        // Запрашиваем у пользователя второе число
        Console.Write("Введите второе число: ");
        string input2 = Console.ReadLine();
        int number2 = Convert.ToInt32(input2);

        // Складываем два числа
        int sum = number1 + number2;

        // Выводим результат
        Console.WriteLine($"Сумма {number1} и {number2} равна {sum}");
    }
}

