/***********************************************************************************
Задача 13:
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645--> 5
78--> третьей цифры нет
32679 -> 6
**************************************************************************************/
Console.WriteLine("Введите число для поиска 3 цифры: ");
string strnumber = Console.ReadLine();
int LenghtNumber = strnumber.Length;
int degree = LenghtNumber - 2;
int divider = Convert.ToInt32(Math.Pow(10, degree));
int number = Convert.ToInt32(strnumber);
if (number < 100)
{
    Console.WriteLine("У числа нет третьей цифры!");
}
else if (LenghtNumber == 3)
{
    int thirdnumber = number % 10;
    Console.WriteLine("Вы ввели число:" + number +". Третье число в нём : " + thirdnumber);
}
else
{
    int thirdnumber = (number % divider) / (divider/10) ;
    Console.WriteLine("Вы ввели число:" + number +". Третье число в нём : " + thirdnumber);
}