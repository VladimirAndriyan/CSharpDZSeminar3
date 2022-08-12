// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.WriteLine("Введите пятизначное число:");
string number = Console.ReadLine();
if(number[0] == '-') number = number.Substring(1);
if(number.Length > 5 || number.Length < 5)
{
    Console.WriteLine("Введено некорректное число");
}
else if(number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
