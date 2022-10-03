void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");

string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
string[] result = new string[array.Length];
int size = 0;
foreach (string element in array)
{
    if (element.Length <= 3)
    {
        result[size] = element;
        size++;
    }
}

ShowArray(array);
Console.WriteLine();
ShowArray(result);