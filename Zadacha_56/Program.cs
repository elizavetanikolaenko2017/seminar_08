/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

void NewSumMatrix(int[,]matrix)
{ 
 for (int i = 0; i < matrix.GetLength(0); i++)
 {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      int SumminString=0;
      int minSum=SumminString(matrix,0);
      for (int i = 1; i < matrix.GetLength(0); i++)
      {
        int tempSumString=SumminString(matrix,i);
        if (Summin>tempSumString)
        {
            Summin=tempSumString;
            minSum=i;
        }
      }  
    }
 }
}
Console.WriteLine($"{SumMinSring+1} - строка с наименьшей суммой элементов");

void PrintSumMinString(int[,]matrix)
{
 for (int i = 0; i < matrix.GetLength(0); i++)
 {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j]=new Random().Next(1,10);
    }
 }
 Console.WriteLine();
}

int m=ReadInt("Введите количество строк: ");
int n=ReadInt("Введите количество столбцов: ");
var myMatrix=GenerateMatrix(m,n);
NewSumMatrix(matrix);
PrintSumMinString(matrix);