// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int i = 0;
int result = 1;
while(i < b)
{
   result = result*a;
   i++;
}
Console.WriteLine($"Число А, возведенное в степень В равно: {result}");
// Console.WriteLine(Math.Pow(a, b));
