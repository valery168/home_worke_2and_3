// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

int Promt(string message)
{
    Console.Write (message);
    int a = int.Parse(Console.ReadLine());
    return (a);
}
int CalcSumDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return sum;
}
int num = Promt("введите число > ");
int summ = CalcSumDigits(num);
Console.WriteLine ($" сумма чисел > {summ} ");


