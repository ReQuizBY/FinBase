// Задача: Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3
// символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении 
// не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// ["Hello", "2", "world", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] → ["-2"]
// ["Russia", "Denmark", "Kazan"] → []

string[] array1 = { "Hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

string[] GetArray(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}
void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Нету значений");
    }
    else
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}

void PrintResult(string[] array)
{
    string[] shortArray = GetArray(array);
    PrintArray(shortArray);
}

Console.WriteLine("Массивы:");
PrintArray(array1);
PrintArray(array2);
PrintArray(array3);
Console.WriteLine();
Console.WriteLine($"Новые массивы ");
PrintResult(array1);
PrintResult(array2);
PrintResult(array3);