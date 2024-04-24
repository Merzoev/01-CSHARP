// int[] arr = new int[5];
// arr[0] = 5;
// arr[1] = 7;
// arr[2] = 5;
// arr[3] = 4;
// arr[4] = 3;
// Console.WriteLine(arr[0]);
// Console.WriteLine(arr[1]);
// Console.WriteLine(arr[2]);
// Console.WriteLine(arr[3]);
// Console.WriteLine(arr[4]);
// // Console.WriteLine(arr[5]);

// int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };


// int[] arr3 = { 1, 2, 3, 4, 5 };

// arr = {1,2,3,4,5}

Console.WriteLine("ВВедите размер массива");

int n = Convert.ToInt32(Console.ReadLine());
int i = 0;

int[] numbers = new int [n];
while (i < n)
{
    Console.WriteLine($"ВВедите {i} число массива");
    numbers [i] = Convert.ToInt32(Console.ReadLine());
    
    i = i + 1;
}

int i1 =0;

while (i1 < n)
{
    Console.Write($"{numbers [i1] } " );
    i1 = i1 + 1;

}


