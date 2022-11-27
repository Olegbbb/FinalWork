void CreateArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        string? a = Convert.ToString(Console.ReadLine());
        array[i] = a!;
    }
}
string SecondArray(string [] array)
{
    int count = 0; int count2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3 )
        {
            count++;
        } 
    }
    string[]help = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            help[count2] = array[i];
            count2 ++;
        }
    } return "[" + string.Join(", ", help) + "] ";
}

Console.WriteLine("Введите количество элементов в массиве");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
Console.WriteLine("Введите элемент массива");
CreateArray(array);
Console.WriteLine("Первоначальный массив: ");
Console.WriteLine("[" + string.Join(", ", array) + "] ");
Console.WriteLine("Искомый массив: ");
Console.WriteLine(SecondArray(array));