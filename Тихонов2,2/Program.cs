//Напишите программу,которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int number3 = int.Parse(Console.ReadLine());

if((number1 > number2) && (number1 > number3))
Console.WriteLine(number1);
else
    if(number2 > number3)
    Console.WriteLine(number2);
    else
    {
    Console.WriteLine(number3);
    }



