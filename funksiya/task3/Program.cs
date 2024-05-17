Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[n];
Random val1 = new Random();
// int i = 0;

for (int i = 0; i < n; i++)
{
    numbers[i] = val1.Next(0, 100);
    // Console.Write($"{numbers[i]} ");    
}
foreach (int a in numbers)
{
    Console.Write($"{a} ");
}
for (int j = 0; j < n; j++)
{
    if (numbers[j] % 2 == 0)
    {
        Console.WriteLine( $"четные {numbers[j]} ");
       
    }
}

// if (numbers[i] % 2 == 0)
//     {
//     Console.Write($"{numbers[i]} ");
//     }

// while (i < n)
// {
//     // numbers[i] = val1.Next(0, 100);
//     // Console.Write($"{numbers[i]} ");

    // i = i + 1;
// }
// return;
// int i1 = 0;
// int count = 0;

// for (int i1 = 0; i1 < n; i1 = i1 + 1)
// while (i < n)
// {
    // if (numbers[i-1] % 2 == 0)
    // {
        // int [] even = new int [count];
        // even[i1] = numbers[i];
        // Console.WriteLine($"{numbers[i-1]} ");
        // count = count+1;
        // i1 = i1 +1;
        // i = i - 1;
    // }
// }





// i = i-1;
// while (i > 0)
// {
// if (numbers[i] % 2 == 0)
// {
//     Console.WriteLine($"{numbers[i]} ");
//     i = i -1;
// }
// }