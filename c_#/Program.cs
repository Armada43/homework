


//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

//[5, 18, 123, 6, 2] -> 1

//[1, 2, 3, 6, 2] -> 0

//[10, 11, 12, 13, 14] -> 5


/*int[] arrayRealNumb = new int[123];
  int count = 0;
  for (int i = 0; i < arrayRealNumb.Length; i++ )
  {
    arrayRealNumb[i] = new Random().Next(1, 100);
    Console.Write(arrayRealNumb[i] + " ");
  }
   for (int i = 0; i < arrayRealNumb.Length; i++)
  {
    if (arrayRealNumb[i] >= 10 && arrayRealNumb[i] <= 99)
    {
     count+=1;
    }
    
  }
    

 
Console.WriteLine($"\nколичество элементов массива в отрезке от 10 до 99: {count}");*/

//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

//[1 2 3 4 5] -> 5 8 3

//[6 7 3 6] -> 36 21

using System;
Console.Write("Введите массив через пробел: ");
string elements = Console.ReadLine();
int[] baseArray = GetArrayFromString(elements);
Console.WriteLine(String.Join(" ", ResultArray(baseArray)));
int[] GetArrayFromString(string stringArray)
{
  string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
  int[] res=new int[nums.Length];
  for (int i=0; i<nums.Length; i++)
  {
    res[i]=int.Parse(nums[i]);
  }
  return res;
}
int[] ResultArray(int[] array)
{
  int size = array.Length / 2;
  if (array.Length % 2 == 1) size++;
  int [] result = new int[size];
  for ( int i = 0; i < array.Length / 2; i++)
  {
    result[i] = array[i] * array[array.Length - 1 - i];
  }
  if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];
  return result;
}    











 

 
