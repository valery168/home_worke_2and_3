// Напишите программу, которая выводит случайное трёхзначное число и
// удаляет вторую цифру этого числа.

  
int A = new Random().Next(99, 1000); 
Console.WriteLine(A);

int B = A%10;
int C = (A/10)%10;
int D = A/100;
     
Console.Write(D);
Console.Write(B);

