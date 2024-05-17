int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3};
      int count = 0;
      for (int i=0;i<10;i++)
      {
        if (array[i] >= 10 && array[i] <= 90)
        {
          count++;
        }
      }
    

Console.WriteLine($"{count}");