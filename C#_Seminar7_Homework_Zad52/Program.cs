//Семинар 7. Курс введение в программирование. C#. Домашняя работа
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
void SearchSummColumnsTwoArray(int[,] array) 
//метод поиска среднеарифм значения каждого столбца (подходит и к сумме каждого столбца и к сумме всех чисел массива)
{
    int summ = 0;
    int j = 0;
    double Y = 0;
    while (j < array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summ = (summ + array[i, j]);
            Y = summ / Convert.ToDouble(array.GetLength(0));
        }
        Console.Write($"{Y:f2} ");
        j = j + 1;
        summ = 0;

    }
}
// SearchSummColumnsTwoArray(array);

Console.Write("Введите количество строк двумерного массива =  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов двумерного массива =  ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
NewArray(array);
PrintArray(array);
SearchSummColumnsTwoArray(array);