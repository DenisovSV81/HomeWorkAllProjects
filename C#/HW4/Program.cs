//Задача 27
/*
int SumOfDigits(int num)
{
    int sum = 0;
    while (num != 0)
    {
        int remainder = num % 10;
        num = num / 10;
        sum = sum + remainder;
    }
    return sum;
}

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumOfDigits(number);

Console.WriteLine("Сумма всех цифр введенного числа: " + result);
*/

//Задача 29
/*
void RandomArray(int elements)
{
    int[] array = new int[elements];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Введите количество элементов массива: ");
int elem = Convert.ToInt32(Console.ReadLine());

Console.Write("Сгенерированный массив: ");

RandomArray(elem);
*/