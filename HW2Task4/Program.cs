//  Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.

int Promt(string message)
{
    Console.Write (message);
    int a = int.Parse(Console.ReadLine());
    return (a);
}

int A = Promt ( "enter A >");
if(A <99)

Console.WriteLine("3 digits no ");
int D = A%10;
if ( A > 99 && A<1000 )

{Console.WriteLine(D);}

if ( A > 1000 )
Console.WriteLine(" try agane,  enter digit less previous one ");

//else Console.WriteLine(" try agane ");