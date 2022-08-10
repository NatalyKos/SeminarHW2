int Number = ReadInt("Введите число: ");
int Answer = 10;
int Count = 3;
while(Count != 0)
{
    if(Number == Answer)
    {
        Console.WriteLine("Correct!");
        break;
    }
    else
    {
        Count--;
        if(Answer > Number)
        {
            Number = ReadInt("Try a bigger number: ");

        }
        else
        {
            Number = ReadInt("Try a lesser number: ");
        }
    }
} 


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}