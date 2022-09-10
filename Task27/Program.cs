// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int GetSumm(int number)
{
    number=Math.Abs(number);
    int summ=0;
    while (number!=0)
    {   
        summ=summ+number%10;
        number=number/10;
    }
    return summ;
}
Console.Clear();
try
{
    Console.WriteLine("Введите число");
    int number=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Сумма {GetSumm(number)}");
}
catch(Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
