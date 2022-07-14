// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

int[] GenerateArray(int lenght, int min, int max) //Создание массива и заполнение его рандомными элементами...
{
    int[] newArray = new int[lenght];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max + 1);
    }
    return newArray;
}

void PrintArray(int[] array)    //Вывод созданого массива
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int PositiveNumber(int[] array)     //Функция поиска кол-ва  чисел больше 0 в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]  >= 0) count++;
    }
    return count;
}
int[] array = GenerateArray(15, -100, 999);
PrintArray(array);
System.Console.WriteLine();
int A1 = PositiveNumber(array);
System.Console.WriteLine($"Количество четных чисел {A1}");