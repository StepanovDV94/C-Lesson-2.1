// Напишите программу, которая принимает на вход трехзначное число и на выход показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число");
int CNumber = Convert.ToInt32(Console.ReadLine());
CNumber = Math.Abs(CNumber);

while (CNumber<100||CNumber>999)
{
    Console.WriteLine("Число должно быть трехзначным");
    CNumber = Convert.ToInt32(Console.ReadLine());
    CNumber = Math.Abs(CNumber);
}

int a = CNumber%100/10;

Console.WriteLine(a);