/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumOfNums(int num1, int num2)
{
    if (num2 < num1) return 0;
    else return SumOfNums(num1+1, num2) + (num1);
}

Console.WriteLine(SumOfNums(1, 15));