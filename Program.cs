/*
Знакомство с языками программирования (семинары)
Урок 7. Как не нужно писать код. Часть 1
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
/*
double[,] a = new double[3, 4];

Random random = new Random();
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    { 
        a[i, j] = 10 - random.Next(21) + random.NextDouble();

        Console.Write("{0,6:F1}", a[i, j]);
    }
    Console.WriteLine();
}
*/
/*
/*
Знакомство с языками программирования (семинары)
Урок 7. Как не нужно писать код. Часть 1
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

/*
Console.Write("Input m number of rows in massive: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n number of columns in massive: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];

for(int i = 0; i < matrix.GetLength(0); i++)
{

    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();

}

Console.Write("Input m1 index position of the element in the row in massive: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n1 of the element position in the column in massive: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if (m1 < m && n1 < n)
    
    Console.WriteLine($"The value of the element in this position [{m1}, {n1}] is equal: {matrix[m1,n1]}");
    
else

    Console.WriteLine($"{m1} {n1} -> There is no such element  in the array");

    */
/*
Знакомство с языками программирования (семинары)
Урок 7. Как не нужно писать код. Часть 1
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

/*

// Получние двумерного массива размером "m" x "n" состоящего из случайных целых чисел
Console.Write("Input m number of rows in massive: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n number of columns in massive: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m,n];

for(int i = 0; i < matrix.GetLength(0); i++)
{

    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j] + " ");
    }
    Console.WriteLine();

}

// Определение среднего арифметического в каждом столбце

int sum = 0;
int count = 0;
Console.Write("Среднее арифметическое каждого столбца: ");
for(int j = 0; j < matrix.GetLength(1); j++)
{
    sum = 0;   //
    count = 0; //
    for(int i = 0; i < matrix.GetLength(0); i++)
    
    {
        sum = sum + matrix[i,j];
        if (matrix[i,j] != 0)
            count = count + 1;

    }
    Console.Write("{0,6:F2}",(double) sum / count);
    
}
Console.WriteLine();

*/

/*
// В этом варианте ниже, не учитываются элементы столбцов равные нулю при подсчете
// количества цифр в стобце. Мне кажется, что при подсчете среднего арифметического
// отдельное число 0 не учитывается. Поэтому за основу взял вариант выше.
int sum = 0;
int count = 0;
Console.Write("Среднее арифметическое каждого столбца: ");
for(int j = 0; j < matrix.GetLength(1); j++)
{
    sum = 0;   //
    count = 0; //
    for(int i = 0; i < matrix.GetLength(0); i++)
    
    {
        sum = sum + matrix[i,j];
        count = count + 1;
    }
    Console.Write("{0,6:F2}",(double) sum / count);
}
Console.WriteLine();

*/

