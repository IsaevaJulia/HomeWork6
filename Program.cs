//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
/*
int [] RandomArray (int size)
{
    int [] newArrey = new int [size];
    for (int i = 0; i < size; i++)
    {
        newArrey[i] = new Random().Next(-100,100 );
        
    }
    return newArrey;
}

void PrintArray(int[] array)
{
    Console.Write("Массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void CountPosotiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        while (array[i] > 0) count += count;       
    }
    Console.WriteLine($"количество чисел больше 0 -> {count}");
}

Console.WriteLine("Введите размер массива  ");
int a = Convert.ToInt32(Console.ReadLine());

int[] myArray = RandomArray(a);
PrintArray(myArray);
CountPosotiveNumber(myArray);
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Point(double k1, double b1, double k2, double b2)
{
double x = (b1-b2)/(k2-k1);
double y = (k2*b1-k1*b2)/(k2-k1);
if(k1==k2) Console.Write("Прямые не пересекаются!");
else
Console.Write($"Точка пересечения прямых: ({x}; {y})");
}

Console.WriteLine("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Point(k1,b1,k2,b2);

