// Напишите программу, которая задаёт массив из N элементов 
//и выводит их на экран. Вывод сделать отдельным методом

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int size = ReadInt("Введите размер массива: ");

int[] elements = new int[size];

for (int i = 0; i < size; i++)
{
    elements[i] = new Random().Next(0, 10);
}

PrintArray(elements);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}