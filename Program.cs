﻿// 1. Создать репозиторий на ГитХаб
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части,
// если вы выделите ее в отдельный метод).
// 3.Снабдить репозиторий оформленным текстовым описанием решения (файл README.md).
// 4.Написать программу, решающую поставленную задачу.
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так,
// что все залито одним коммитом, как минимум этапы 2, 3, 4 должны быть расположены в разных коммитах).

// Задача.Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна  3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] ->["2",":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

int Сounting(string[] array)
{
   int j = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i].Length <= 3)
      {
         j++;
      }
   }
   return j;
}

void NewArray(string[] array, int size)
{

   if (size == 0)
   {
      Console.WriteLine($"[]");
   }
   else
   {
      string[] resultArray = new string[size];
      int j = 0;
      for (int i = 0; i < array.Length; i++)
      {
         if (array[i].Length <= 3)
         {
            resultArray[j] = array[i];

            Console.Write(resultArray[j] + " ");
            j++;

         }
      }
   }
}

string[] arr = { "hello", "2", "world", ":-)" };
int count = Сounting(arr);
NewArray(arr, count);
