/*Задача 29: Напишите методы, 
который задаёт массив из 8 элементов 
и выводит их на экран.*/

using static Library;
int[] col = CreateArray(8);
Console.WriteLine(PrintGood(col));
Console.WriteLine();
Fill(col, 1, 9);
Console.WriteLine(PrintGood(col));
