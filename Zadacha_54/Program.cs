﻿/*
 Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int m=InputNumbers("Введите количество строк: ");
int n=InputNumbers("Введите количество столбцов: ");
int range= InputNumbers("Введите диапазон чисел от 1 до ");
Console.WriteLine($" Отсортированный массив: ");


int InputNumbers(string input)      /////задаем число
{
    Console.Write(input);
    int output=Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] matrix)    /////задаем каркас матрицы и осносная матрица
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
          matrix[i,j]=new Random().Next(range);  
        }
    
        
    }

    
}


void OrderArray(int[,]array)    ////отсортированный массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
              if (array[i,j]< array[i,k+1])
              {
                int temp=array[i,k +1];
                array[i,k+1]=array[i,k];
                array[i,k]=temp;
              }  
            }
        }
        
    }

}




void WriteArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write(matrix[i,j] + " "); 
        }
        Console.WriteLine();
    }
}



int[,] array=new int[m,n];
CreateArray(array);
WriteArray(array);
OrderArray(array);

