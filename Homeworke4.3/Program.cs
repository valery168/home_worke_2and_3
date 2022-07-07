// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

int[] array = { 1,2,5,7,19,6,1,33 };
int[] array1 = {array[0], array[1],array[2], array[3],array[4]};
int[] array2 ={array[5], array[6],array[7]};
Console.WriteLine(string.Join(",", array1));
Console.WriteLine(string.Join(",", array2));