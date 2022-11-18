/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int AkkermanCount(int num1, int num2)
{

    if (num1 == 0) return num2 + 1;
    if (num1 != 0 && num2 == 0) return AkkermanCount(num1 - 1, 1);
    else return AkkermanCount(num1 - 1, AkkermanCount(num1, num2 - 1));
}

Console.WriteLine(AkkermanCount(3,2));