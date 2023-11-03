string GetArr(string message)
{
    Console.Write($"{message}");
    string num = Console.ReadLine();
    return num;
}
int GetNum(string message)
{
    Console.Write($"{message}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
string[] CreateArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i += 1)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}





int Arrlenght = GetNum("Введите размер масива: ");
string[] arr = new string[Arrlenght];