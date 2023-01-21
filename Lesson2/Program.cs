// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("ВВедите пожалуйста число : ");

int num = Convert.ToInt32(Console.ReadLine());
string num3 = Convert.ToString(num);

if (num3.Length < 3)
{
  System.Console.WriteLine("Третьей цифры нет");
}
else
{
    System.Console.WriteLine(num3[2]);
}


