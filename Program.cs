// See https://aka.ms/new-console-template for more information
// Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
    

string CharArrayToString(char[,] array)
{
   string result = string.Empty;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
         for (int j = 0; j < array.GetLength(1); j++)
            {
            result += array[i,j]; 
            }
    }
    return result;
}

        char[,] charArray = { {'q', 'w', 'e',}, {'a', 's', 'd'}, {'z', 'x', 'c'} };
        string res = CharArrayToString(charArray);
        Console.WriteLine(res);

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// Console.Write("Введите строку: ");
// string str = Console.ReadLine();
// string lowerStr = str.ToLower();
// Console.WriteLine(lowerStr);

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// string str = "zakkaz";
// string reversedStr = string.Empty;

// for (int i = str.Length - 1; i >= 0; i--)
// {
// reversedStr += str[i];
// }

// if (str == reversedStr)
// {
// Console.WriteLine("Строка является палиндромом");
// }
// else
// {
// Console.WriteLine("Строка не является палиндромом");
// }
