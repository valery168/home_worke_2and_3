// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

int Promt(string message)
{
    Console.Write (message);
    int a = int.Parse(Console.ReadLine());
    return (a);
}
int A = Promt("введите число А > ");
int B = Promt("введите число В > ");
int count = 0;
Console.WriteLine( Math.Pow(A, B));