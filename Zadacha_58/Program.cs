/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

 void int[,] FirstMatrix(int[,]matrix)
{
    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          matrix[i,j]=*matrix[i,j] 
          
        }
    }
}