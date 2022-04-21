// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.WriteLine ("Введите число от 1 до 7");
int DayNumber = Convert.ToInt32(Console.ReadLine());

while (DayNumber < 1|| DayNumber > 7)
{
    Console.WriteLine("Введите корректное число");
    DayNumber = Convert.ToInt32(Console.ReadLine());
}

if (DayNumber == 6 || DayNumber == 7) Console.WriteLine (DayNumber + " -> Да");
else Console.WriteLine (DayNumber + " -> Нет");