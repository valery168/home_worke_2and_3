// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.


int Promt(string message)
{
    Console.Write (message);
    int a = int.Parse(Console.ReadLine());
    return (a);
}

int A = Promt ( "enter A >");
int C = (A/10)%10;
//int D = A/100;
if (A < 99 & A >1000)
{
     Console.WriteLine("wrong");
}

else 
{Console.WriteLine(C);}

