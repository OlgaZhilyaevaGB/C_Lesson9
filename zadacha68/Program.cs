
/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9*/

Console.WriteLine("Введите первое значение функции");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе значение функции");
int n = int.Parse(Console.ReadLine());

int FunctionAkkermana(int first, int second)
{
    if (first == 0) return second + 1;

    else if (second == 0)
    {
        return FunctionAkkermana(first - 1, 1);
    }
    else
    {
        return FunctionAkkermana(first - 1, FunctionAkkermana(first, second - 1));
    }

}

FunctionAkkermana(m, n);
Console.Write($"Для A({m},{n}) = {FunctionAkkermana(m, n)}");
Console.WriteLine();