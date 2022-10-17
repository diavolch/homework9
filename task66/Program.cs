/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите число M: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int endNumber = Convert.ToInt32(Console.ReadLine());
sumOfNumber(startNumber, endNumber);

void sumOfNumber(int M, int N, int sum = 0)
{
    if (M == N + 1)
    {
        Console.WriteLine(sum);
        return;
    }
    sum += M ;
    sumOfNumber( M + 1, N, sum);
}