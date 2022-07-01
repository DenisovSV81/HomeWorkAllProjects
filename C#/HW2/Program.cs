//Задача 10 Принимает двухзначное число и выдает максимальную цифру

int number = new Random().Next(10,100);
int findBiggestNumber(int arg)
{
    Console.WriteLine("Current random number is " + number);
    int firstDigit = arg / 10;
    int secondDigit = arg % 10;
    int max;
    if (firstDigit > secondDigit) max = firstDigit;
    else max = secondDigit;
    return max;
}
int result = findBiggestNumber(number);
Console.WriteLine("Max number is " + result);