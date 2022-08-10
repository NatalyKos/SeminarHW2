Console.WriteLine("Enter a number: ");
int Number = Convert.ToInt32(Console.ReadLine());



if(Number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
   while(Number > 999)
   {
        Number = Number / 10;
   }
   Number = Number % 10;
   Console.WriteLine(Number);
}


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.