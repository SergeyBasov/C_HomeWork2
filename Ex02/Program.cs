/* Задача 13. Напищите программу, котарая выводит третью цифру 
 заданного числа или сообщает, что такой цифры нет. 
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число :");
int numA = int.Parse(Console.ReadLine());
int result = 0;
while (numA > 999)
{
    numA = numA / 10;
}
if (numA < 100)
{
    Console.WriteLine($"В введенном Вами числе {numA} нет третьей цифры!");
}
else
{
    result = numA % 10;
    Console.WriteLine($"{result} - третья цифра введеного числа");
}