//Напишите программу, которая принимает на
//вход пятизначное число и проверяет, является ли оно
//палиндромом.



Console.Write("введите пятизначное число -> ");
int n = int.Parse(Console.ReadLine());
int n1 = n % 10;
int n2 = n / 10 % 10;
int n3 = n / 100 % 10;
int n4 = n / 1000 % 10;
int n5 = n / 10000;
if (n1 == n5 && n2 == n4)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("нет");
}
