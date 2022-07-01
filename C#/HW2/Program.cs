//Задача 10
/*
int SecondDigit()
{
    int number = new Random().Next(100, 1000);
    Console.WriteLine("Сгенерированное число: " + number);

    int twodigit = number / 10;
    int second = twodigit % 10;

    return second;
}

int result = SecondDigit();
Console.WriteLine("Вторая цифра сгенерированного числа: " + result);
*/

//Задача 13
/*
void ThirdDigit(int number)
{
    if(number<0)
    {
        number = number*-1;
    }
    if (number>=100)
    {
        while (number>1000)
        {
            number = number/10;
        }

        int third = number%10;
        Console.WriteLine("Третья цифра Вашего числа: " + third);
        
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

 Console.Write("Введите число: ");
 int num = Convert.ToInt32(Console.ReadLine());
 
ThirdDigit(num);
*/

//Задача 15
/*
void DayOfTheWeek (int day)
{
    if (day == 0)
    {
        Console.WriteLine("Ошибочка вышла, введите номер от 1 до 7");
    }
    if (day > 0 & day <= 5)
    {
        Console.WriteLine("Под этим номером день не является выходным");
    }
    if (day > 5 & day <= 7)
    {
        Console.WriteLine("Вот это выходной");
    }
    if (day > 7)
    {
        Console.WriteLine("В неделе 7 дней, введите номер еще раз");
    }
}

Console.Write("Введите порядковый номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

DayOfTheWeek (number);
*/
