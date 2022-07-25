//Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.
/*
int NumberOfDigits(int N)
{
    if (N / 10 != 0)
        return 1 + NumberOfDigits(N / 10);

    else return 1;
}

Console.Write("Пожалуйста, введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Количетсво цифр в введенном числе: " + NumberOfDigits(m));
*/

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumOfNaturalElem(int M, int N)
{
    if (M < N)
    {
        while (M != N)
            return M + SumOfNaturalElem(M + 1, N);
    }

    if (M > N)
    {
        while (M != N)
            return M + SumOfNaturalElem(M - 1, N);
    }

    return M;
}

Console.Write("Введите 1 число (M): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число (N): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Сумма натуральных элементов в указанном промежутке: " + SumOfNaturalElem(m, n));
*/
