/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int m=InputNumbers("Введите количество строк: ");
int n=InputNumbers("Введите количество столбцов: ");

int[,]array=new int[m,n];
CreateArray(array);
WriteArray(array);

int minSumLine=0;
int sumLine=sumLineElements(array,0);
for (int i = 1; i < array.GetLength(0); i++)
{
   int tempSumLine=sumLineElements(array,i);
   if (sumLine>tempSumLine)
   {
      sumLine=tempSumLine;
      minSumLine=i;
   }
   
}
Console.WriteLine($"\n{minSumLine+1} - строка с наименьшей суммой ({sumLine}) элементов");

int sumLineElements(int[,]array, int i)
{
   int sumLine=array[i,0];
   for (int j = 0; j <array.GetLength(1); j++)
   {
      sumLine+=array[i,j];
   }
   return sumLine;
}

int InputNumbers(string text)
{
   Console.Write(text);
   int output=Convert.ToInt32(Console.ReadLine());
   return output;
}

void CreateArray(int[,]array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j= 0; j < array.GetLength(1); i++)
      {
         Console.Write(array[i,j]+ " ");
      }
      Console.WriteLine();
   }
}

void WriteArray(int[,]array)
{
 for (int i = 0; i < array.GetLength(0); i++)
 {
   for (int j = 0; j < array.GetLength(1); j++)
   {
     Console.Write(array[i,j]+ " "); 
   }
   Console.WriteLine();
 }
}
