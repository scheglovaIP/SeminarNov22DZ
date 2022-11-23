//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int a = ReadInt("Введите основание: ");

int b = ReadInt("Введите значение степени: ");

int result = 1;
for(int i=0; i<b;i++)
{
    result*=a;
}

Console.WriteLine($"число {a} в степени {b} равно {result}");