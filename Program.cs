/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int getDataFronUser(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int[,] getArray(int colLength, int rowLength, int start, int Finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, Finish + 1);
        }
    }
    return array;
}
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] SortedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {

                if (array[i, k] < array[i, k+1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k+1];
                    array[i, k+1] = temp;
                }
            }
        }
    }
    return array;
}


int n = getDataFronUser("Введите количествуо строк = ");
int m = getDataFronUser("Введите количествуо столбцов = ");
int[,] array = getArray(n, m, 0, 10);
Console.WriteLine();
printArray(array);
Console.WriteLine();
int[,] sorty = SortedArray(array);
printArray(sorty);
