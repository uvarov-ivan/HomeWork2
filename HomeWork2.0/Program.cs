// Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

int Prompt(string msg)
{
    System.Console.Write($"{msg} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int num = Prompt("Введите трёхзначное число  :");
int secondDigit = 0;
if (num <100 || num > 999)
{
    System.Console.WriteLine($" Число {num} не трёхзначное!!!");
}
else
{
secondDigit = (num / 10) % 10;
System.Console.WriteLine($"Второй цифрой числа {num} является {secondDigit}");
}

