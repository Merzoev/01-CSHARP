Random rnd = new Random();

int size = 1000;
int [] arr_int = new int [size];
for (int i = 0; i < arr_int.Length; i++)
{
    arr_int[i] = rnd.Next(1,1000);
}

foreach (  int e  in arr_int)
{
    Console.Write($"{e} ");
}