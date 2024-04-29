/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

void PrintArr(string[] arr) // печать массива
{
  if (arr.Length == 0)
  {
    System.Console.WriteLine("[]");
  }
  else
  {
    System.Console.Write("[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
      System.Console.Write($"'{arr[i]}', ");
    }
    System.Console.Write($"'{arr[arr.Length - 1]}' ]");
    System.Console.WriteLine();
  }
}
string[] StringLengthLess3(string[] arr) //создание нового массива из строк, длина которых меньше, либо равна 3 символам.
{
  int sizenewarr = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i].Length < 4)
    {
      sizenewarr++;
    }
  }
  string[] newarr = new string[sizenewarr];
  if (sizenewarr > 0)
  {
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
      if (arr[i].Length < 4)
      {
        newarr[j] = arr[i];
        j++;
      }
    }
  }

  return newarr;

}

string[] st1 = { "1234", "1567", "-25", "funny dog", "КОТ" };
System.Console.WriteLine($"Исходный массив:");
PrintArr(st1);
string[] st2 = StringLengthLess3(st1);
System.Console.WriteLine($"Новый массив:");
PrintArr(st2);
