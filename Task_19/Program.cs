/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

string GetNumberAndShowPalidrome(int numberFunction)
{
    string str = Convert.ToString(numberFunction);
    string result;
    if (str.Length == 5)
    {
        if ((str[0] == str[4]) & (str[1] == str[3]))
        {
            result = "Число " + numberFunction + " является палиндоном";
        }
        else
        {
            result = "Число " + numberFunction + " не является палиндоном";
        }
    }
    else
    {
        result = "Число " + numberFunction + " не пятизначное";
    }
    return result;
}

Console.WriteLine("Введите 5-ти значное число, наприме 12345");
int number = Convert.ToInt32(Console.ReadLine());
string result = GetNumberAndShowPalidrome(number);
Console.WriteLine(result);
