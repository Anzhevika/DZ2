//  Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите пожалуйста цифру, обозначающую день недели");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6)
{
 System.Console.WriteLine($"{day} - выходной");
}
else if (day == 7)
{
 System.Console.WriteLine($"{day} - выходной");
}
else 
 System.Console.WriteLine($"{day} - не выходной");
