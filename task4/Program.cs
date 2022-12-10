//Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным. 
Console.WriteLine("Введите день недели");
int value = Convert.ToInt32(Console.ReadLine());
switch (value)
{
    case 6:
    case 7:
    Console.WriteLine("Выходной");
    break;
    default:
    Console.WriteLine("Будний день");
    break;
}