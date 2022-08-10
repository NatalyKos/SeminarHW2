// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int Number = ReadInt("Введите число: ");


if(Number == 7 || Number == 6)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}