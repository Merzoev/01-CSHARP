
// void NumToQuad(int num)
// {
//    System.Console.WriteLine(num*num);
// }
// int NumToQuadInt(int num)
// {
   
//     return num * num;
// }
// System.Console.WriteLine("input number:");
// int a = Convert.ToInt32(Console.ReadLine());

// // NumToQuad(a);
// // int result = NumToQuadInt(a);
// // System.Console.WriteLine(result);
// System.Console.WriteLine(NumToQuadInt(a));

// // Задание 1. Совместная работа
// // Семинар 2. Простые алгоритмы на C#
// // Напишите программу, которая принимает на
// // вход трёхзначное число и удаляет вторую
// // цифру этого числа.
// // Примеры
// // a = 256 => 26
// // a = 891 => 81


// int DeleteSecondDigit(int num)
// {
//     if (num >= 100 && num <= 999 )
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     return sot* 10 + ed;
   
// }
//     else
//     {
//     System.Console.WriteLine("You input not tree-digit-number");
//     return 0;
//     }
// }

// System.Console.WriteLine("input tree digit number:");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DeleteSecondDigit(num));

// void DeleteSecondDigitvoid(int num)
// {
//     if (num >= 100 && num <= 999 )
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     System.Console.WriteLine(sot * 10 + ed);
   
// }
//     else
//     {
//     System.Console.WriteLine("You input not tree-digit-number");
//     }
// }

// // System.Console.WriteLine("input tree digit number:");
// // int num = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine(DeleteSecondDigit(num));

// DeleteSecondDigitvoid(num);

// Задание 2. Работа в сессионных залах
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// int SecondToThirdPower(int num)
// {
//     if (num >= 100 && num <= 999 )
// {
//     int ed = num % 10;
//     int dec = num / 10 % 10;
//     int result = 1;
//     for ( int i = 0; i < ed; i++)
//     {
//         result = dec * result;
//     }
//     return result;
   
// }
//     else
//     {
//     System.Console.WriteLine("You input not tree-digit-number");
//     return 0;
//     }
// }

// System.Console.WriteLine("input tree digit number:");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(SecondToThirdPower(num));

// Задание 3. Обсуждение решений
// Семинар 2. Простые алгоритмы на C#
// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// void CheckIfDevides(int num1,int num2)
// {
//     if ( num1 % num2 == 0)
//     {
//         System.Console.WriteLine($"{num1},{num2} -> yes");

//     }

// else
// {
//             System.Console.WriteLine($"{num1},{num2} -> no,{num1 % num2 }");
// }
// }

// Console.WriteLine("Введите первое число a:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число b:");
// int num2 = Convert.ToInt32(Console.ReadLine());

// CheckIfDevides(num1,num2);