// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

string ReadInt(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

string a = ReadInt("Введите число: ");
int length = a.Length;

int[] y = new int[length];
for (int i = 0; i < length; i++)
{
    y[i] = Convert.ToInt32(a[i].ToString());
}

int result = 0;
for (int i = 0; i < length; i++)
{
    result += y[i];
}

Console.WriteLine(result);
