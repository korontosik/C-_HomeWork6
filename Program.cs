using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

// Console.Clear();
// Задача 1: 
// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

// char[,] str_ch = new char[2, 3] {
//     {'a', 'b', 'c'},
//     {'d', 'e', 'f'},
// };


// string str = "";
// for (int i = 0; i < str_ch.GetLength(0); i++)
// {
//     for (int j = 0; j < str_ch.GetLength(1); j++)
//     {
//         str += str_ch[i,j];
//     }
// }
// Console.Write(str);

// Задача 2: 
// Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// string letters ="aBcDeFG";
// string lowerLetter = letters.ToLower();
// Console.WriteLine(lowerLetter);

// Задача 3: 
// Задайте произвольную строку. Выясните, является ли она палиндромом.



string text = "gfdsasdfg";
bool isPalindrome = IsPalindrome(text);

if (isPalindrome)
{
    Console.WriteLine("The string is a palindrome.");
}
else
{
    Console.WriteLine("The string is not a palindrome.");
}


static bool IsPalindrome(string text)
{
    int length = text.Length;
    for (int i = 0; i < length / 2; i++)
    {
        if (text[i] != text[length - i - 1])
        {
            return false;
        }
    }

    return true;
}
