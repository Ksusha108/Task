// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно 
// ввести с клавиатуры, либо задать на старте выполнения алгоритма.


string ReleaseArray(string [] array)
{
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            result = result + array[i];
    }
    return result;
}

Console.Clear();
string [] array = {"Hello", "World", "2", ";)"};
Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Новый массив: [{ReleaseArray(array)}]");