// int[] nums = { 1, 2, 3, 4, 5, 6 };

// int[] ProductExceptSelf(int[] nums)
// {

//     int[] nums2 = new int[nums.Length];

//     // while (2 <= nums.Length <= 100000)
//     // {


//         for (int i = 0; i < nums.Length; i++)
//         {

//             int result = 1;
//             int temp = nums[i];
//             nums[i] = 1;
//             for (int j = 0; j < nums.Length; j++)
//             {
//                 result = result * nums[j];
//             }

//             nums[i] = temp;

//             nums2[i] = result;
//         }
//         foreach (int e in nums2)
//         {
//             Console.Write($"{e} ");
//         }
//         return nums2;

//     }
// // }

// ProductExceptSelf(nums);

// Учитывая целочисленный массив nums, переместите все 0элементы в конец, сохраняя относительный порядок ненулевых элементов.

// Обратите внимание , что вы должны сделать это на месте, не копируя массив.



// Пример 1:

// Ввод: числа = [0,1,0,3,12]
//  Вывод: [1,3,12,0,0]
// Пример 2:

// Ввод: числа = [0]
//  Вывод: [0]

int[] nums = { 0,0,1 };

    for (int i = 0; i < nums.Length; i++)
    {
        
        if (nums[i] == 0)
        {
            for (int j = i; j < nums.Length-1; j++)
            {
            int temp = nums[j];
            nums[j] = nums[j+1];
            nums[j+1] = temp;
            }
            // i--;
            }
    }


    foreach (int e in nums)
    {
        Console.Write($"{e} ");
    }
