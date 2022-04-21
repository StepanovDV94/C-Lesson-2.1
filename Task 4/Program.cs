// Напишите программу, которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите целое число");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number%7==0&&Number%23==0) Console.WriteLine(Number + "-> да");
else Console.WriteLine(Number + "-> нет");
