// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("ВВедите пожалуйста трехзначное число : ");

int num = Convert.ToInt32(Console.ReadLine());
int result = (num % 100) / 10;

System.Console.WriteLine($"Вторая цифра этого числа : {result}");
