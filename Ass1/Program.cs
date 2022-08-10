Console.Write("Enter a 3-digit number: ");
int Number = Convert.ToInt32(Console.ReadLine());
int twoFirst = Number / 10;
int secondDigit = twoFirst % 10;
Console.WriteLine(secondDigit);