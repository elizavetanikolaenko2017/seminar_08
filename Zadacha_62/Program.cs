/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int ReadInt(string text)       /////1-   задаем тип числа
{
 Console.Write(text);
 return Convert.ToInt32(Console.ReadLine());
}

int[,]GenerateMatrix(int m, int n)     /// 2  создаем шаблон матрицы
{ 
   int[,]matrix=new int[m,n];
   Random rand=new Random();
   for (int i = 0; i < matrix.GetLength(0); i++)
   {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       matrix[i,j]=new Random().Next(1,10); 
    }
   } 
   return matrix;
}
