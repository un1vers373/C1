using System;
namespace c1
{
    class Program
    {
        static void Main()
        {
        Console.WriteLine("Введите первое число: ");
string input = Console.ReadLine();
int number = int.Parse(input);

Console.WriteLine("Введите второе число: ");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);

Console.WriteLine("Сумма: " + (number + number1));
        }
    }
}