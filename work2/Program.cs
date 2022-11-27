void CreateArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string? a = Convert.ToString(Console.ReadLine());
        array[i] = a!;
    }
}
void SecondArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.Write("]");
}

Console.WriteLine("Введите количество элементов в массиве");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
Console.WriteLine("Введите элемент массива");
CreateArray(array);
Console.WriteLine("Первоначальный массив: ");
Console.WriteLine("[" + string.Join(", ", array) + "] ");
Console.WriteLine("Искомый массив: ");
SecondArray(array);