//Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.

int[]array = new int [3];

for(int index = 0; index < array.Length; index++)
{
    array[index] = Convert.ToInt32(Console.ReadLine()); 
}

Console.Write(array);