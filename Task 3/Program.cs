// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. 
//Если число не кратно числу 2, то программа выводит остаток от деления/

Console.WriteLine("Введите первое двузначное число");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
while (FirstNumber<9||FirstNumber>99)
{
    Console.WriteLine("Число должно быть двузначным");
    FirstNumber = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите второе двузначное число");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
while (SecondNumber<9||SecondNumber>99)
{
    Console.WriteLine("Число должно быть двузначным");
    SecondNumber = Convert.ToInt32(Console.ReadLine());
}

if (FirstNumber%SecondNumber==0) Console.WriteLine(FirstNumber + "," + SecondNumber + " -> Кратно");
else Console.WriteLine(FirstNumber + "," + SecondNumber + " -> Не кратно, остаток " + FirstNumber%SecondNumber);
