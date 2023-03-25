/*
Задача 60. ...Сформируйте трёхмерный массив двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
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
