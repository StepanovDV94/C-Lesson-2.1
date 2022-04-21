// Напишите программу, которая принимает на вход число и выводит его 3-ю цифру, либо сообщает, что такой нет

Console.WriteLine("Введите число");
int CNumber = Convert.ToInt32(Console.ReadLine());
CNumber = Math.Abs(CNumber);

if (CNumber < 100 && CNumber > -100) Console.WriteLine (CNumber + " -> Третьей цифры нет");
else
{
String s = Convert.ToString(CNumber);
Console.WriteLine ("Третья цифра ->  " + s[2]);
}

