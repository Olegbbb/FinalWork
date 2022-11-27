# FinalWork
Этот вариант с созданием второстепенного массива мне понравился больше, т.к вывод правильнее

void CreateArray(string[] array)  Процедура для заполнения массива "с клавиатуры"
{
    for (int i = 0; i < array.Length; i++)
    {
        string? a = Convert.ToString(Console.ReadLine());
        array[i] = a!;
    }
}
string SecondArray(string [] array)  Функция для нахождения нужного массива
{
    int count = 0; int count2 = 0;  счетчики. count для подсчета количества элементов, count2 чтобы ставить их в новый массив по порядку
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3 ) 
        {
            count++;
        } 
    }
    string[]help = new string[count]; новый массив на количество нужных нам элементов 
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            help[count2] = array[i];
            count2 ++;
        }
    } return "[" + string.Join(", ", help) + "] "; вывод массива
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

Второй вариант отличается лишь тем, что программа сразу выводит найденные элементы на экран через процедуру

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
