//Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

void PrintArray()
{
    int[] array = new int[8];

    for (int index = 0; index < array.Length; index++)
    {
        array[index] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine(string.Join(",", array));
}

Console.WriteLine("Введите 8 чисел");
PrintArray();