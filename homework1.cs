//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int num = int.Parse(number);

if (99 < num & num < 1000)
{
    num = num / 10;
    num = num % 10;
    Console.Write(num);
}
else
{
    Console.Write("Число не трехзначное");
}