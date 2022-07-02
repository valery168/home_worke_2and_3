// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

int Promt(string message)
{
    Console.Write (message);
    int a = int.Parse(Console.ReadLine());
    return (a);
}

int A = Promt ( "enter A >");
if (1<A && A <6)
{
    Console.WriteLine(" it is working day");
    }

if (5<A && A <8)
{
    Console.WriteLine(" it is weekend");
    }
 else Console.WriteLine("enter number bigger than 0 and les than 8");


