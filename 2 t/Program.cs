// See https://aka.ms/new-console-template for more information
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());


int counter = Convert.ToString(n).Length;
int advance = 0;
int result = 0;

for(int i = 0; i < counter; i++) 
{
    advance = n - n%10;
    result = result + (n - advance);
    n = n/10;
}
Console.WriteLine($"Сумма всех элементов числа равна: {result}");