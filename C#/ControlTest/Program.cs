﻿string[] ArrayWords = new string[6] {"Pavel", "you", "are", "good", "Teacher", ":-)" };
string[] ArrayWords2 = new string [ArrayWords.Length];

void AskWords(string[] ArrayWords, string[] ArrayWords2)
{
    int count = 0;
    for (int i = 0; i < ArrayWords.Length; i++)
    {
        if (ArrayWords[i].Length <= 3)
        {
            ArrayWords2[count] = ArrayWords[i];
            count++;
        }
    }
}

void PrintArrayWords(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");

    }
    Console.WriteLine();

}

AskWords(ArrayWords, ArrayWords2);
PrintArrayWords(ArrayWords2);
