//Задача 2: Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.

Console.WriteLine("Введите число");

int value = int.Parse(Console.ReadLine());
int digitsCount = (int)Math.Log10(value) + 1; 
int multiplier = (int)Math.Pow(10, digitsCount - 2); 
int result = value % multiplier + value / multiplier / 10 * multiplier; 

Console.WriteLine(result); 