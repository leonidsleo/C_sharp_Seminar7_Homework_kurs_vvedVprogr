//Семинар 7. Курс введение в программирование. C#. Домашняя работа
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void NewArray(int[,] array) //Метод создания массива, значение рандома задает клиент. 
{
    Console.Write("Создать массив из случайных чисел [мин, макс]. Введите минимальное значение = ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Создать массив из случайных чисел [мин, макс]. Введите масимальное значение = ");
    int max = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
}

void SearchNumberIfTwoArray(int[,] array)
{
    Console.Write("Введите число для поиска в массиве =  ");
    int numm = Convert.ToInt32(Console.ReadLine());
    bool n = false;
    int rows = 0;
    int columns = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == numm)
            {
                n = true;
                rows = i;
                columns = j;
            }
        }

    }
    if (n)
    {
        Console.WriteLine($"Число {numm} есть в массиве");
        Console.Write($"Находится: строка {rows + 1}, столбец = {columns + 1}"); //выводит координаты последнего 
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine($"Числа {numm} нет в массиве");
    }
}
// SearchNumberIfTwoArray(array);

Console.Write("Введите количество строк двумерного массива =  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива =  ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
NewArray(array);
PrintArray(array);
SearchNumberIfTwoArray(array);