
//// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


/*int[] numbers = new int[4];

void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ )
  {
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array)
{
    for (int i = 0; i<array.Length; i++ )
    {
    Console.Write(array[i] + " ");
  }
  Console.WriteLine();
}

int QuantityPositive(int[] array)
{
    int quantity = 0;
    for (int i = 0; i<array.Length; i++ )
    {
    if (array[i] % 2 == 1)
    {
      quantity++;
    }
  }
  return quantity;
}

FillArray(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();

int quantity = QuantityPositive(numbers);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


/*Console.Write($"Введи n+1 элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numberElements, int min, int max)
  {
  int[] randomNumbers = new int[numberElements];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 1; i<randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }

int randomNumbers =  RandomNumbers(numberElements, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {randomNumbers}");*/


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] arrayRealNumb = new double[10];
  for (int i = 0; i < arrayRealNumb.Length; i++ )
  {
    arrayRealNumb[i] = new Random().Next(1, 100);
    Console.Write(arrayRealNumb[i] + " ");
  }

double maxNumb = arrayRealNumb[0];
double minNumb = arrayRealNumb[0];

  for (int i = 1; i < arrayRealNumb.Length; i++)
  {
    if (maxNumb < arrayRealNumb[i])
    {
      maxNumb = arrayRealNumb[i];
    }
        if (minNumb > arrayRealNumb[i])
    {
      minNumb = arrayRealNumb[i];
    }
  }

  double decision = maxNumb - minNumb;

  Console.WriteLine($"\nразница между между максимальным ({maxNumb}) и минимальным({minNumb}) элементами: {decision}");
