// #19
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
string number1 = number.ToString();
if (number1.Length !=5)
{
    Console.WriteLine("Не правильное значение!");
}
else 
{
    if (number1[0] + number1[1] + number1[2] == number1[2] + number1[3] + number1[4])
    {
        Console.WriteLine("Является полиндромом!");
    } 
else
{
    Console.WriteLine("Не полиндром");
}
}
// #21

int q1 = ReadInt("Введите координату Q первой точки: ");
int w1 = ReadInt("Введите координату W первой точки: ");
int e1 = ReadInt("Введите координату E первой точки: ");
int q2 = ReadInt("Введите координату Q второй точки: ");
int w2 = ReadInt("Введите координату W второй точки: ");
int e2 = ReadInt("Введите координату E второй точки: ");
int S = q2 - q1;
int D = w2 - w1;
int C = e2 - e1;
double length = Math.Sqrt(S * S + D * D + C * C);
Console.WriteLine($"Длина отрезка {length}");
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
// #23
int Number = ReadInt("Введите число N: ");
for (int i = 1; i <= Number; i++)
{
    Console.Write($"{i*i*i} ");
}
int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}