// Задача 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

// int[] Arr = new int[8];
    //     Random rnd = new Random();
            
     // for (int x = 0; x < Arr.Length; x++)
     // {
      //    Arr[x] = rnd.Next(8);
      //    Console.Write(Arr [x]);

     // }

      int[] Arr = new int[8];
         Random rnd = new Random();
            
         for (int x = 0; x < Arr.Length; x++)
            {
                Arr[x] = rnd.Next(8);
                Console.WriteLine("Индекс каждого числа массива " + x + " = " + Arr[x]);
            }