using System;

Console.WriteLine("Здравствуйте! Добро пожаловать в новоиспечённый калькулятор. Нажмите Enter, чтобы продолжить");
Console.ReadLine();
double firstValue, secondValue;
string operation;
int operationConvert;

while (true)
{
    Console.Clear();
    Console.WriteLine("Выберите действие: ");
    Console.WriteLine("1.Сложить 2 числа\n2.Вычесть первое из второго\n3.Перемножить два числа\n4.Разделить первое на второе\n5.Возвести в степень N первое число\n6.Найти квадратный корень из числа\n7.Найти 1 процент от числа\n8.Найти факториал из числа\n9.Выйти из программы");
    operation = Console.ReadLine();
    switch (operation)
    {
        case "1":
            Console.WriteLine("Введите 1-ое число - ");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите 2-ое число - ");
            secondValue = double.Parse(Console.ReadLine());

            Console.Write("Результат: ");
            Console.WriteLine(firstValue + secondValue);
            break;
        case "2":
            Console.WriteLine("Введите 1-ое число - ");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите 2-ое число - ");
            secondValue = double.Parse(Console.ReadLine());

            Console.Write("Результат: ");
            Console.WriteLine(secondValue - firstValue);
            break;
        case "3":
            Console.WriteLine("Введите 1-ое число - ");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите 2-ое число - ");
            secondValue = double.Parse(Console.ReadLine());

            Console.Write("Результат: ");
            Console.WriteLine(secondValue * firstValue);
            break;
        case "4":
            Console.WriteLine("Введите 1-ое число - ");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите 2-ое число - ");
            secondValue = double.Parse(Console.ReadLine());

            Console.Write("Результат: ");
            if (secondValue == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(firstValue / secondValue);
            }
            break;
        case "5":
            Console.WriteLine("Введите число, которое хотите возвести в степень - ");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите степень, в которую хотите возвести число - ");
            secondValue = double.Parse(Console.ReadLine());

            if (secondValue < 0)
            {
                double znamenatel = 1;
                Console.Write(znamenatel / Math.Pow(firstValue, secondValue));
            }
            Console.Write("Результат: ");
            Console.WriteLine(Math.Pow(firstValue, secondValue));
            break;
        case "6":
            Console.WriteLine("Введите число, из которого хотите вычислить квадратный корень - ");

            firstValue = double.Parse(Console.ReadLine());

            while (firstValue < 0)
            {
                Console.WriteLine("Число должно быть положительным");
                firstValue = double.Parse(Console.ReadLine());
            }
            Console.Write("Результат: ");
            Console.WriteLine(Math.Sqrt(firstValue));
            break;
        case "7":
            Console.WriteLine("Введите число, от которого хотите найти один процент - ");

            firstValue = double.Parse(Console.ReadLine());
            while (firstValue < 0)
            {
                Console.WriteLine("Введите положительное число - ");
                firstValue = double.Parse(Console.ReadLine());
            }
            Console.Write("Результат: ");
            Console.WriteLine(firstValue / 100);
            break;
        case "8":
            Console.WriteLine("Введите натуральное число, из которого хотите найти факториал - ");
            firstValue = Convert.ToInt32(Console.ReadLine());
            while (firstValue < 0)
            {
                Console.WriteLine("Введите натуральное число - ");
                firstValue = Convert.ToInt32(Console.ReadLine());
            }
            int factorial = 1;
            for (int i = 2; i <= firstValue; i++)
            {
                factorial *= i;
            }
            Console.Write("Результат: ");
            Console.WriteLine(factorial);
            break;
    }
    operationConvert = Convert.ToInt32(operation);
    if (operationConvert == 9)
    {
        Console.WriteLine("Программа окончена. Нажмите Enter, чтобы закрыть окно.");
        Console.ReadLine();
        break;
    }
    else if (operationConvert > 9 || operationConvert < 1)
    {
        Console.WriteLine("Соблюдайте диапазон! Нажмите Enter, чтобы попробовать ещё. ");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Нажмите Enter, чтобы использовать другое действие");
        Console.ReadLine();
    }
}    