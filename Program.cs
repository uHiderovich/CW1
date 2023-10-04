int InputNum(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine()!);
}

void PrintArray(string[] array)
{
  Console.Write('[');
  for (int i = 0; i < array.Length - 1; i++)
  {
    Console.Write($"{array[i]}, ");
  }
  Console.Write($"{array[array.Length - 1]}");
  Console.Write(']');
}

int NumberSearchWords(string[] array)
{
  int counter = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      counter += 1;
    }
  }

  return counter;
}

string[] InputStringArray(int arraySize)
{
  string[] result = new string[arraySize];

  for (int i = 0; i < arraySize; i++)
  {
    Console.WriteLine($"Введите слово(осталось ввести {arraySize - i} из {arraySize}): ");
    string str = Console.ReadLine()!;

    result[i] = str;
  }

  return result;
}

string[] FilteredArray(string[] array)
{
  int resultArraySize = NumberSearchWords(array);
  string[] result = new string[resultArraySize];
  int currentResultIndex = 0;

  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= 3)
    {
      result[currentResultIndex] = array[i];
      currentResultIndex += 1;
    }
  }

  return result;
}

int arraySize = InputNum("Введите размер массива: ");
string[] result = FilteredArray(InputStringArray(arraySize));
Console.WriteLine();
Console.WriteLine("Массива строк, длина которых меньше, либо равна 3 символам: ");
PrintArray(result);