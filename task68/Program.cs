/*
Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Write("Введите число m: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int number = functionOfAccerman(firstNumber, secondNumber);
Console.WriteLine(number);


int functionOfAccerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    if (M > 0 && N == 0)
    {
        return functionOfAccerman(M - 1, 1);
    }
    return functionOfAccerman(M - 1, functionOfAccerman(M, N - 1));
}
