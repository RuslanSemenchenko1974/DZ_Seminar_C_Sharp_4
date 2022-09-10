// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.
//В задании не определен тип элементов, поэтому выбрали тип массива string
string[] GetArray()
{
    string[] array=new string[8];
    for (int i=0;i<8;i++)
    { 
        Console.Write($"Введите {i+1} элемент массива :");
        array[i]=Console.ReadLine();
    }
    return array;
}
void ShowArray(string[] array)
{
    for (int i=0;i<8;i++) Console.WriteLine($"{i+1} ) {array[i]}");
}
Console.Clear();
string[] array=GetArray();
ShowArray(array);
