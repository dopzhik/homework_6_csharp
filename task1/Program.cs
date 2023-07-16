/*Задача 1: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int ReadInt(string msg)
{
    System.Console.Write(msg);              
    return Convert.ToInt32(Console.ReadLine());
}

int[] GenerateArray()
{
    int M = ReadInt("Введите количество чисел в массиве => ");
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        array[i] = ReadInt("Введите числа => ");
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int AmountOfNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }    
    }
    return count;
}

int[] arrayone = GenerateArray();
ShowArray(arrayone);
int count = AmountOfNumbers(arrayone);
Console.WriteLine($"Количество положительных чисел в массиве - {count}");