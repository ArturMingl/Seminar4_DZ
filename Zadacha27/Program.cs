//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void digits_sum(int x)
{
    int sum = 0;
    while (x > 0)
    {

        sum = sum + x % 10;
        x = x / 10;

    }
    Console.WriteLine($"Сумма всех цифр данного числа равна {sum}");
}

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

digits_sum (a);