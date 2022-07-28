//Задача 1: Задайте массив строк. Напишите программу, которая считает кол-во слов в массиве, начинающихся на гласную букву.
/*
int StartsWithVowels(string[] words)
{
    char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };

    int count = 0;

    for (int i = 0; i < words.Length; i++)
        for (int j = 0; j < vowels.Length; j++)
        {
            if (words[i].ToLower()[0] == Char.ToLower(vowels[j])) count++;
        }
    return count;
}

string[] sadness = { "qwe", "wer", "ert", "rty", "tyu", ":(" };

Console.Write("Number of words that start with a vowel: " + StartsWithVowels(sadness));
*/

//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
/*
string[] PairwiseUnion(string[] words)
{

    string[] combined = new string[words.Length / 2];

    for (int j = 0, i = 0; i < words.Length; i += 2, j++)
        combined[j] = words[i] + words[i + 1];

    return combined;
}

void ShowString(string[] words)
{
    for (int i = 0; i < words.Length; i++)
        Console.Write($"{words[i]}  ");
    Console.WriteLine();
}

string[] Goodbye = { "Pav", "el,", "yo", "u", "a", "re", "rea", "ly", "go", "od", "tea", "cher!"};

ShowString((PairwiseUnion(Goodbye)));
*/

