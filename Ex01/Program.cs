// Задача 10. Напищите программу котарая на вход принимает трехзначное число 
// и на выходе показывает вторую цифру этого числа. 
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число : ");
int numA = int.Parse(Console.ReadLine());
if (numA < 99)
{
    Console.WriteLine($"{numA} - не трехзначное число");
}
else
{
    int result = numA / 10 % 10;
    Console.WriteLine($"{result} - вторая цифра введеного Вами числа");
}