//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int num = int.Parse(number);

if (0 < num & num < 8)
{
    if (num == 6 | num == 7)
    {
        Console.Write("Выходной");
    }
    else
    {
        Console.Write("Рабочий день");
    }

}
else
{
    Console.Write("Число не означает день недели");
}