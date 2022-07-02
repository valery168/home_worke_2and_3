// Напишите программу, которая принимает на вход 
//число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

int Promt(string message)
{
    Console.Write (message);
    int a = int.Parse(Console.ReadLine());
    return (a);
}

int A = Promt ( "enter A >");

int count = 1;
while(count <= A)
{
 Console.WriteLine(count * count * count);
 count++;
}