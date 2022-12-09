// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B

int expo (int x, int degree)
{
    int result = 1;

    for (int i = 0; i < degree; i++)
    {
        result = result * x;
    }

    return result;
}

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int B = Convert.ToInt32(Console.ReadLine());

expo(A,B);

Console.WriteLine($"{A} в степени {B} равна {expo(A,B)}");