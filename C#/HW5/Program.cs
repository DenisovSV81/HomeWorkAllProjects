//Задача 34
/*
int[] RandomArray(int elements)
{
    int[] array = new int[elements];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int EvenNumber(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

Console.Write("Введите количество элементов массива: ");

int elem = Convert.ToInt32(Console.ReadLine());

int[] newarray = RandomArray(elem);

Console.Write("Сгенерированный массив: ");

ShowArray(newarray);

Console.WriteLine("Количество четных чисел в массиве: " + (EvenNumber(newarray)));
*/

//Задача 36
/*
int[] RandomArray(int elements)
{
    int[] array = new int[elements];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SumOddElements(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}

Console.Write("Введите количество элементов массива: ");

int elem = Convert.ToInt32(Console.ReadLine());

int[] newarray = RandomArray(elem);

Console.Write("Сгенерированный массив: ");

ShowArray(newarray);

Console.WriteLine("Сумма элементов, стоящих на нечетных позициях массива: " + (SumOddElements(newarray)));
*/

//Задача 38
/*
double[] RandomArray(int elements)
{
    double[] array = new double[elements];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (new Random().Next(1, 31)) + new Random().NextDouble();
        array[i] = Math.Round(array[i], 2);
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

double Subtraction(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    
    Console.WriteLine("Максимальное значение массива: " + max);
    Console.WriteLine("Минимальное значение массива: " + min);
   
    double subtr = max - min;
    subtr = Math.Round(subtr, 2);
    return subtr;

}

Console.Write("Введите количество элементов массива: ");

int elem = Convert.ToInt32(Console.ReadLine());

double[] newarray = RandomArray(elem);

Console.Write("Сгенерированный массив: ");

ShowArray(newarray);

Console.WriteLine("Разница между max и min значениями элементов массива: " + (Subtraction(newarray)));
*/
