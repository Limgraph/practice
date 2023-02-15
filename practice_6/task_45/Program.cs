// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
Console.Clear();

int[] CopyArray(int[] inArray)
{
    int[] arr = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        arr[i] = inArray[i];
    }
    return arr;
}

int[] GetArray(int size, int min_value, int max_value)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min_value, max_value +1);
    }
    return res;
}

int[] array = GetArray(7, 0, 10);
Console.WriteLine(String.Join(", ", array));

int[] copyArray = CopyArray(array);
Console.WriteLine(String.Join(", ", copyArray));