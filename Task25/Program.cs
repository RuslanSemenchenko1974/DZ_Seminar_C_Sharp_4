// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B. Решить задачу с использованием методов.
double GetDegree(int a, int b)
{
    if (a==0) return 0;
    if (b==0) return 1;
    double ab=1;
    if (b>0)
        for (int i=1; i<=b;i++)
        {
            ab=ab*a;
        }
    else
        for (int i=-1; i>=b;i--)
        {
            ab=ab/a;
        }

           
    return ab;
}
Console.Clear();
try 
{
Console.Write("Введите число 1 :");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2 :");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write($"{a} в степени {b} равно {GetDegree(a,b)}");
}
catch(Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}