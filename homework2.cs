//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int num = int.Parse(number);
int lengthNumber = number.Length;
double rank = Math.Pow(10, (lengthNumber - 3));
int rankInt = (int) rank;

if (lengthNumber < 3)
{
  Console.Write("Нет третьей цифры"); 
}
else
{
    num = num / rankInt;
    num = num % 10;
    Console.Write(num);
}