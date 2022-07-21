//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*

int[,] Random2dArray(int a, int b)
{
    while (a <= 0)
    {
        Console.Write("Невозможно построить двумерный массив с заданным количеством строк. Пожалуйста, введите новое значение: " );
        a = Convert.ToInt32(Console.ReadLine());
    }

    while (b <= 0)
    {
        Console.Write("Невозможно построить двумерный массив с заданным количеством столбцов. Пожалуйста, введите новое значение: ");
        b = Convert.ToInt32(Console.ReadLine());
    }

    int[,] new2dArray = new int[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            new2dArray[i, j] = new Random().Next(1, 11);

    return new2dArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] DescendingSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if(array[i,k] < array[i,k+1])
                {
                    int elem = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = elem;
                }
            }
        }
    }
    return array;
}


int m = new Random().Next(3, 9);
int n = new Random().Next(3, 9);

int[,] my2dArray = Random2dArray(m, n);

Console.WriteLine("Сгенерированный двумерный массив:");

Show2dArray(my2dArray);

int[,] sortsdArray = DescendingSort(my2dArray);

Console.WriteLine("Двумерный массив,отсортированный по убыванию: ");

Show2dArray(sortsdArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int[,] Random2dArray(int a, int b)
{
    while (a <= 0)
    {
        Console.Write("Невозможно построить двумерный массив с заданным количеством строк. Пожалуйста, введите новое значение: ");
        a = Convert.ToInt32(Console.ReadLine());
    }

    while (b <= 0)
    {
        Console.Write("Невозможно построить двумерный массив с заданным количеством столбцов. Пожалуйста, введите новое значение: ");
        b = Convert.ToInt32(Console.ReadLine());
    }

    int[,] new2dArray = new int[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            new2dArray[i, j] = new Random().Next(1, 10);

    return new2dArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[] LineSum(int[,] twodarray)
{
    int[] array = new int[twodarray.GetLength(0)];

    for (int k = 0, i = 0; k < twodarray.GetLength(0); k++, i++)
    {
        int sum = 0;
        for (int l = 0; l < twodarray.GetLength(1); l++)
        {
            sum = sum + twodarray[k, l];
        }
        array[i] = sum;
    }
    return array;
}

void SmallAmount(int[] array)
{
    int min = array[0];
    int minindex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minindex = i;
        }
    }
    Console.Write("Строка с минимальной суммой элементов - " + $"{minindex + 1}" + " (сумма элементов в данной строке: " + min + ").");
}

int m = new Random().Next(3, 9);

int[,] my2dArray = Random2dArray(m, m);

Console.WriteLine("Сгенерированный двумерный массив:");

Show2dArray(my2dArray);

SmallAmount(LineSum(my2dArray));
*/

//Задача 62: Заполните спирально массив
/*

int[,] Null2dArray(int a, int b)
{
    int[,] new2dArray = new int[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            new2dArray[i, j] = 0;

    return new2dArray;
}

int[,] Spirall2dArray(int[,] array)
{
    int firstNum = 1;
    int finish = array.GetLength(0) * array.GetLength(1);
    int rememberRow = 0;
    int rememberCol = 0;

    while (firstNum <= finish)
    {
        while (rememberCol < array.GetLength(1) && array[rememberRow, rememberCol] == 0)
            array[rememberRow, rememberCol++] = firstNum++;
        rememberRow++;
        rememberCol--;

        while (rememberRow < array.GetLength(0) && array[rememberRow, rememberCol] == 0)
            array[rememberRow++, rememberCol] = firstNum++;
        rememberCol--;
        rememberRow--;

        while (rememberCol >= 0 && array[rememberRow, rememberCol] == 0)
            array[rememberRow, rememberCol--] = firstNum++;
        rememberRow--;
        rememberCol++;

        while (rememberRow >= 0 && array[rememberRow, rememberCol] == 0)
            array[rememberRow--, rememberCol] = firstNum++;
        rememberRow++;
        rememberCol++;
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int m = new Random().Next(3, 9);
int n = new Random().Next(3, 9);

int[,] array2d = Spirall2dArray(Null2dArray(m, n));

Show2dArray(array2d);
*/

