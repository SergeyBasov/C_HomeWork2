// Задача 15. Напищите программу, котарая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот дент выходным. 
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру дня недели : ");
int numA = int.Parse(Console.ReadLine());
if (numA >= 8 || numA <= 0)
{
    Console.WriteLine($"Нет дня недели под цифрой {numA}");
}
else if (numA == 6 || numA == 7)
{
    Console.WriteLine($"{numA} день недели - это выходной");
}
else
{
    Console.WriteLine($"{numA} день недели - это рабочий день");
}