/*
11. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456--> 5
782--> 8
918--> 1 
*/
Console.WriteLine("Введите трёхзначное число: ");
string strnumber = Console.ReadLine();
int number = Convert.ToInt32(strnumber);
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели неверное число");
}
else
{
    int TwoPairNumber = number / 10;
    int FinalNumber = TwoPairNumber % 10;
    Console.WriteLine("Второй разряд числа: " + FinalNumber);
}