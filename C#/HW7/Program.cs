//Задача 47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] Random2dArray(int a, int b)
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
    
    double[,] new2dArray = new double[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            new2dArray[i, j] = (new Random().Next(-10, 11)) + new Random().NextDouble();

    return new2dArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(array[i, j], 1);
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк двумерного массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] my2dArray = Random2dArray(m, n);

Console.WriteLine("Сгенерированный двумерный массив:");

Show2dArray(my2dArray);
*/

//Задача 50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
double[,] Random2dArray(int a, int b)
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

    double[,] new2dArray = new double[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            new2dArray[i, j] = (new Random().Next(1, 10));

    return new2dArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}  ");

        Console.WriteLine();
    }
}

void ElementValue(double[,] array, int c, int d)
{
    int row = c;
    int column = d;

    if (row >= 0 && row < array.GetLength(0))
    {
        if (column >= 0 && column < array.GetLength(1))
        {
            Console.Write("Значение указанного элемента: " + array[row, column]);
        }
        else Console.Write("Такого элемента нет (ошибка в номере столбца).");
    }
    else Console.Write("Такого элемента нет (ошибка в номере строки).");
}

int m = new Random().Next(3, 9);
int n = new Random().Next(3, 9);

double[,] my2dArray = Random2dArray(m, n);

Console.WriteLine("Сгенерированный двумерный массив:");

Show2dArray(my2dArray);

Console.Write("Введите позицию искомого элемента номер строки - ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("                                  номер столбца - ");
int c = Convert.ToInt32(Console.ReadLine());

ElementValue(my2dArray, r, c);
*/

//Задача 52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
double[,] Random2dArray(int a, int b)
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

    double[,] new2dArray = new double[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            new2dArray[i, j] = (new Random().Next(1, 10));

    return new2dArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}  ");

        Console.WriteLine();
    }
}

void Average(double[,] twodarray)
{

    for (int l = 0; l < twodarray.GetLength(1); l++)
    {
        double sum = 0;
        for (int k = 0; k < twodarray.GetLength(0); k++)
        {
            sum = sum + twodarray[k, l];
        }
        double average = sum / twodarray.GetLength(0);
        average = Math.Round(average, 1);
        Console.WriteLine("Среднее арифметическое " + $"{l+1}" + " столбца: " + average);
    }
}

int m = new Random().Next(3, 9);
int n = new Random().Next(3, 9);

double[,] my2dArray = Random2dArray(m, n);

Console.WriteLine("Сгенерированный двумерный массив:");

Show2dArray(my2dArray);

Average(my2dArray);
*/
