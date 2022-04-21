// Получить произвольной число в интервале [10,99] и вывести его большу цифру

int a = new Random().Next(10,100);

int b = a / 10;
int c = a % 10;

if (b >= c) Console.WriteLine("Для числа "+ a + " наибольшая цифра " + b);
else Console.WriteLine("Для числа "+ a + " наибольшая цифра " + c);