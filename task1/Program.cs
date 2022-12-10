//Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа. Не использовать строки

Console.WriteLine("Введите трёхзначное число  ");
int value = Convert.ToInt32(Console.ReadLine());

if (value >= 100 && value <= 999);
{
    value %= 100;
    value /= 10;
}

Console.WriteLine ( "Вторая цифра  ->  " + value);
