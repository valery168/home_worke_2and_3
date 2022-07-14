//Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
// k1*x + b1 = k2*x + b2
//k1*x -k2*x = b2-b1
//x = b2-b1/k1-k2
// 
int Promt(string message)
{
    Console.Write (message);
    int a = int.Parse(Console.ReadLine());
    return (a);
}

int b1 = Promt ( "enter b1 >");
int k1 = Promt ( "enter k1 >");
int b2 = Promt ( "enter b2 >");
int k2 = Promt ( "enter k2 >");

int x = b2-b1/k2-k1;
int y = y = k2 * x + b2;
Console.WriteLine($"({x} , {y})");