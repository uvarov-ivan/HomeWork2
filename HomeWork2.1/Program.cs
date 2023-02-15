// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет

int Prompt(string msg)
{
    System.Console.Write($"{msg} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int num = Prompt("Введите число");
int numRef = num;

if (num < 100)
{
    System.Console.WriteLine($"В числе {num} нет третьей цифры!!!");
}
else
{
    while (num > 999)
    {
        num /= 10;
    }
    System.Console.WriteLine($"Второй цифрой числа {numRef} является {num % 10}");
}
