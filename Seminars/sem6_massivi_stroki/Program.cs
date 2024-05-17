// Задание 1. Совместная работа
// Семинар 6. Массивы и строки
// 15 мин
// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// string CharArrayToString(char [] charArray)
// {
//     string result = string.Empty;
//     for (int i = 0; i < charArray.Length; i++)
//     {
//         result += charArray[i];
//     }
//     return result;
// }

// // char [] charArray = new char [] {'a', 'b', 'c', 'd'};
// // string result = CharArrayToString(charArray);
// // Console.WriteLine(result);

// char[] InputCharArray()
// {
//     System.Console.Write("Input number of array size: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     char[] array = new char[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = Console.ReadKey() .KeyChar;
//         Console.Write("*");
//         Console.WriteLine();
//     }
//     return array;
//     }
// char[] chars = {'a', 'b', 'c', 'd'};
// string str = new string(chars);
// System.Console.WriteLine(str);
// System.Console.WriteLine(CharArrayToString(InputCharArray()));

// Задание 2. Работа в сессионных залах
// Семинар 6. Массивы и строки
// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

// char[] StringToCharArray(string str)
// {
//     char[] chars = new char[str.Length];
//     for (int i = 0; i < str.Length; i++)
//     {
//         chars[i] = str[i];
//     }
//     return chars;
// }

// void PrintCharArray(char[] chars)
// {
//     foreach (char c in chars)
//     {
//         Console.Write(c + " ");
//     }
//     Console.WriteLine();
// }

// PrintCharArray(StringToCharArray("Hello!" ));

// Задание 3. Совместная работа
// Семинар 6. Массивы и строки
// 20 мин
// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int CountVowels(string str)
{
    int count = 0;
    foreach (char c in str)
    {
        if (c == 'a'  || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        {
            count++;    

        }
    }
    return count;
}
Console.Write("Enter string: ");
string str = Console.ReadLine();
Console.WriteLine(CountVowels(str));
