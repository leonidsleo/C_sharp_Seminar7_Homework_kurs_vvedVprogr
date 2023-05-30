//Семинар 7. Курс введение в программирование. C#. Домашняя работа
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintTwoArray(double[,] array)
// метод вывода в консоль двумерного массива вещественных чисел
// задан параметр вывода количества знаков после запятой в вещ. числе 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f2} ");
        }
        Console.WriteLine();
    }
}

void CreateTwoArray()
//метод создания двумерного массива из случайных вещественных чисел
//количество срок и столбцов задает клиент
//параметры Random (поиска случайных чисел) задает клиент
// встроен метод  вывода в консоль результата
{
    Console.Write("Введите количество строк двумерного массива =  ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов двумерного массива =  ");
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, columns];
    Console.Write("Создать массив из случайных чисел [мин, макс]. Введите минимальное значение = ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Создать массив из случайных чисел [мин, макс]. Введите масимальное значение = ");
    int max = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(min, max) + new Random().NextDouble()); 
            //создание двумерного массива из вещественных чисел
        }
    }
    PrintTwoArray(array); // метод, вывод в консоль
}
CreateTwoArray();