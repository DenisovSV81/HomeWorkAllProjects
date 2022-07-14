//Задача 41
/*
Console.WriteLine("Укажите количество чисел, которое собираетесь ввести.");
int number = Convert.ToInt32(Console.ReadLine());

// checking if "number" greater than zero.
while (number <= 0)
{
    Console.WriteLine("Ошибка ввода! введите новое число");
    number = Convert.ToInt32(Console.ReadLine());
}

// Array initialization.
int[] array = new int[number];

// Creating a new void method for to fill the array.
void FillArray(int[] collection)
{
    int a = 1;      // just a counter.
    for (int index = 0; index < number; index++)
    {
    Console.WriteLine("Введите число " + a + ": ");
    collection[index] = Convert.ToInt32(Console.ReadLine());
    a++;
    }
}

// Cheching values greater than zero.
int checkValue(int[] collection)
{
    int result = 0;

    for (int index = 0; index < number; index++)
    {
        if (collection[index] > 0) result++;
    }

    return result;
}

FillArray(array);

// Output the counter of values.
Console.WriteLine("Количество чисел, больше нуля: " + checkValue(array));
*/

//Задача 43
/*
Console.WriteLine("Программа расчитывает координаты точки пересечения на плоскости 2-х прямых через систему уравнений.");
Console.WriteLine("Укажите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Укажите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

// Finding value of "x".
double ValueX(double arg1, double arg2, double arg3, double arg4)
{
    double x = (arg3 - arg1) / (arg2 - arg4);
    return x;
}

// finding value of "y".
double ValueY(double arg1, double arg2, double arg3)
{
    double y = arg2 * arg3 + arg1;
    return y;
}

// checking if k1 equals k2, and output answer.
if (k1 == k2) Console.WriteLine("Пересечения не найдено. Прямые параллельны!");
else Console.WriteLine("Координаты точки на плоскости: (" + ValueX(b1, k1, b2, k2) + "; " + ValueY(b1, k1, ValueX(b1, k1, b2, k2)) + ")");
*/

